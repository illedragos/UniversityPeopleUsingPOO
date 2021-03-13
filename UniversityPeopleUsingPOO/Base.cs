using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityPeopleUsingPOO
{
    class Base
    {
        public String name;

        public int weight;

        public int height;
        public int age
        {
            get;
            set;
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }

        }

        public int getWeight()
        {
            return weight;
        }

        public void setWeight(int data)
        {
            this.weight = data;
        }

        public void displayStudent()
        {
            Console.WriteLine("Nume :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Height :" + height);
            Console.WriteLine("Weight :" + weight);
        }


    }

}
