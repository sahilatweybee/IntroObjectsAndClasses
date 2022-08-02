using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroObjectsAndClasses
{
    public class Account
    {
        public int Acc_No;
        public String name = "";
        public static Double InterestRate = 5.2;

        static Account()
        {
            InterestRate = 9.3;
        }
        public Account()
        {
            Console.WriteLine("Account constructed");
        }
        ~Account()
        {
            Console.WriteLine("Account Deatroyed!!");
            Console.ReadLine();
        }
        public Account(int num, string str)
        {

            this.Acc_No = num;
            this.name = str;
        }
        public void display()
        {
            Console.WriteLine(Acc_No + " " + name + " " + InterestRate + "\n");
        }
    }
    public static class MathClass
    {
        public static float PI = 3.14f;
        public static int cube(int n) 
        { 
            return n * n * n; 
        }
    }

    public struct Cuboid
    {
        public int width, height, length;

        public Cuboid(int w, int l, int h)
        {
            this.width = w;
            this.length = l;
            this.height = h;
        }
        public void area()
        {
            Console.WriteLine("Area of Cuboid is: " + (width * length));
        }
        public void volume()
        {
            Console.WriteLine("Volume of Cuboid is: "+ (width * length * height));
        }

    }
    public enum Season { WINTER=100, SPRING, SUMMER, FALL }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI = " + MathClass.PI);
            Console.WriteLine("9^3 = " + MathClass.cube(9));

            // Account.InterestRate = 7.5;
            Account ac1 = new Account(1234, "abc");
            ac1.display();
            Cuboid cb = new Cuboid(5, 7, 3);
            cb.area();
            cb.volume();

            int summer = (int)Season.SUMMER;
            int spring = (int)Season.SPRING;

            Console.WriteLine($"SUMMER = {summer}\nSPRING = {spring}\n");
            foreach (Season s in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine(s);
            }

            Account ac2 = new Account();
            
            Console.ReadLine();
        }
    }
}
