using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class PersonList
    {
        private Person[] list = null;
        private int count = 0;
        public PersonList(int size)
        {
            if(size < 10)
            {
                size = 10;
            }
            list = new Person[size];
        }
        int find(string aCode)
        {
            for(int i = 0; i < count; i++)
            {
                if(aCode.Equals(list[i].getCode()))
                {
                    return i;
                }
            }
            return -1;
        }
        public void add()
        {
            if (count == list.Length)
            {
                Console.WriteLine("List is full!");
            }
            else
            {
                string newCode;
                string newName;
                int newAge;
                //Entering new person details
                int pos;
                do
                {
                    Console.WriteLine("Enter the person's code: ");
                    newCode = Console.ReadLine().ToUpper();
                    pos = find(newCode);
                    if (pos >= 0)
                    {
                        Console.WriteLine("\tThis code existed!");
                    }
                } while (pos >= 0);
                Console.WriteLine("Enter the person's name: ");
                newName = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter the person's age: ");
                newAge = Convert.ToInt32(Console.ReadLine());
                list[count++] = new Person(newCode, newName, newAge);
                Console.WriteLine("New person has been added.");
            }
        }
        public void remove()
        {
            if(count == 0)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            string removeCode;
            //Entering new person details
            Console.WriteLine("Enter the code of removed person: ");
            removeCode = Console.ReadLine().ToUpper();
            int pos = find(removeCode);
            if(pos < 0)
            {
                Console.WriteLine("This person does not exist.");
            }
            else
            {
                for(int i = pos; i < count - 1; i++)
                {
                    list[i] = list[i + 1];
                    count--;
                }
                Console.WriteLine("The person " + removeCode + " was removed");
            }

        }
        public void update()
        {
            if (count == 0)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            string code;
            Console.WriteLine("Enter the code of updated person: ");
            code = Console.ReadLine().ToUpper();
            int pos = find(code);
            if (pos < 0)
            {
                Console.WriteLine("This person does not exist.");
            }
            else
            {
                string newName;
                int newAge;
                Console.WriteLine("Enter the person's name: ");
                newName = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter the person's age: ");
                newAge = Convert.ToInt32(Console.ReadLine());
                list[pos].setName(newName);
                list[pos].setAge(newAge);
                Console.WriteLine("The person " + code + " was updated");
            }
        }
        public void print()
        {
            if (count == 0)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            else 
            {
                Console.WriteLine("LIST OF PERSONS:");
                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine(list[i].toString());
                }
            }
        }
        public void sort()
        {
            if(count == 0)
            {
                return;
            }
            for(int i = 0; i < count-1; i++)
            {
                for(int j = count-1; j < i; j--)
                {
                    if(list[j].getAge() > list[j-1].getAge())
                    {
                        Person p = list[j];
                        list[j] = list[j-1];
                        list[j-1] = p;
                    }    
                }
            }    
        }
    }
}
