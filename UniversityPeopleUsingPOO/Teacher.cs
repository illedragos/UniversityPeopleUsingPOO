using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityPeopleUsingPOO
{
    class Teacher : IActions
    {
        public int pushups()
        {
            return 1;
        }
        public int situps()
        {
            return 2;
        }

        public void sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
