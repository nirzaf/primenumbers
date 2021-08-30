using System;

namespace app2
{
    class Program
    {
        class People
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int age = 0;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                        age = value;
                    else
                        age = 0;
                }
            }
        }
        class BankAccount
        {
            private double balance = 0;
            public void Deposit(double n)
            {
                balance += n;
            }
            public void Withdraw(double n)
            {
                balance -= n;
            }
            public double GetBalance()
            {
                return balance;
            }
            public BankAccount()
            {
                Console.WriteLine("Bank Account Balance");
            }
        }
        class Person
        {
            private string name;
            public int age;
            public void SayHi()
            {
                Console.WriteLine("Hi");
            }
            public Person (string nm)
            {
                name = nm;
            }
            public string GetName()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person("Bobby");
           // p1.name = "Bobby";
            p1.age = 3;
            p1.SayHi();
            Console.WriteLine(p1.GetName() + "\n" + p1.age);

            BankAccount b1 = new BankAccount();
            b1.Deposit(199);
            b1.Withdraw(42);
            Console.WriteLine(b1.GetBalance());
            b1.Deposit(100);
            b1.Withdraw(50);
            Console.WriteLine(b1.GetBalance());

            People pl1 = new People();
            pl1.Name = "Bob";
            Console.WriteLine(pl1.Name);
            pl1.Age = 10;
            Console.WriteLine(pl1.Age);


        }  
    }
}
