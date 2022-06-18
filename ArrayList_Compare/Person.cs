using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Compare
{
    public class Person
    {
        private string name;
        private int age;
        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public string toString()
        {
            return String.Format("Tên: {0} - Tuổi: {1}", name, age);
        }
    }
}
