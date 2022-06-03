using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string code = "";
        private string name = "";
        private int age = 0;
        //constructor
        public Person()
        {

        }
        public Person(string code, string name, int age)
        {
            this.code = code;
            this.name = name;
            if(age > 0)
            {
                this.age = age;
            }
            else
            {
                this.age = 0;
            }    
        }
        //getter
        public string getCode()
        {
            return code;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        //setter
        public void setCode(string code)
        {
            this.code = code;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        //Input details of the person
        public void input()
        {      
            Console.WriteLine("Enter the person's code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter the person's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the person's age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        //Method for output
        public string toString()
        {
            return this.code + ", " + this.name + ", " + this.age;
        }
    }
}
