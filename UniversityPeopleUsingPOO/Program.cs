using System;

namespace UniversityPeopleUsingPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();

            s1.displayStudent();

            Console.WriteLine("**********************");
            Teacher t1 = new Teacher();
            t1.sleep();
           //t1.eat();             //de ce nu merge? din moment ce nu merge de ce nu primesc eroare ca nu ii implementata
                                   //metoda in clasa Teacher din moment ce implementeaza IAction                                         
                
            IActions action = t1; // ce obiect este action? teacher?
            action.eat();

            Console.WriteLine("**********************");
            Console.WriteLine(t1.pushups());

        }

    }

}

