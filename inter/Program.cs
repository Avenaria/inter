using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Child ch = new Child
            { Name = " Chail1", age = 1 };

            Child ch2 = (Child)ch.Clone();// копирование, всегда необходимо делать приведение типов
            Student st = new Student
            {
                FName = " FHSKHF",
                LName = " JHSKAH",
                BR = new DateTime(1999, 5, 6)
            };


        }
    }
}
