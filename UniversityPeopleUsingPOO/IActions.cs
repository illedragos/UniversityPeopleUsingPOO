using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityPeopleUsingPOO
{
    interface IActions
    {
        void eat()
        {
            Console.WriteLine("Eating");
        }
        void sleep();
        int pushup() {
            return 10;
        }
        int situps();
    }
}
