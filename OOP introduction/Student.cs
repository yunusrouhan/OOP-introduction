using OOP_introduction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    class Student : OOP_introduction.Person
    {
        public string InsNumber;

        public Student()
        {
            InsNumber = "I1234";
        }

        public Student(string INumber, string Isal, string ftName, string ltName) : base(ltName)
        {
            InsNumber = INumber;
        }

        public string getName()
        {
            return InsNumber + " " + base.getName();
        }
    }
}
