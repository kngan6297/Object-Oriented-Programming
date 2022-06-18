using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_Compare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person("AAA", 25);
            Person p1 = new Person("QQQ", 18);
            Person p2 = new Person("DDD", 20);
            Person p3 = new Person("ZZZ", 23);
            Person p4 = new Person("III", 30);
            Person p5 = new Person("BBB", 35);
            Person p6 = new Person("MMM", 21);
            Person p7 = new Person("OOO", 24);
            Person p8 = new Person("TTT", 22);
            Person p9 = new Person("GGG", 28);
            var arr = new List<Person>();
            arr.Add(p);
            arr.Add(p1);
            arr.Add(p2);
            arr.Add(p3);
            arr.Add(p4);
            arr.Add(p5);
            arr.Add(p6);
            arr.Add(p7);
            arr.Add(p8);
            arr.Add(p9);

        }
    }
}