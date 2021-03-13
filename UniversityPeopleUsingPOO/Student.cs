using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityPeopleUsingPOO
{
    class Student : Base
    {
        public Student(String name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public Student() : this("Name", 0, 0, 0)
        {

        }

    }
}
