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
           //t1.eat();             //????

            IActions action = t1; //????
            action.eat();

            Console.WriteLine("**********************");
            Console.WriteLine(t1.pushups());

        }

    }

}

