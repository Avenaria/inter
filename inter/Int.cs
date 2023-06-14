using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace inter
{
    internal class StudentCard
    {
        public int Number { get; set; }
        public string Serias { get; set; }
        public override string ToString()
        {
            return $"Студенчиский билет {Serias}{Number}";

        }

    }
    class Student : ICloneable
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BR { get; set; }
        public StudentCard studentCard { get; set; }

        public object Clone()//доклонирование обьекта другого класса 
        {
            Student card =(Student)this.MemberwiseClone();
           card.studentCard = new StudentCard
           {
               Serias = studentCard.Serias,
               Number = studentCard.Number,
           };
            return card;
        }

        public override string ToString()
        {
            return $"Студент {LName}{LName} {BR}\n" +
                $" Карта студента  {studentCard}";
        }
    }
    //Current -получить текущий обьект коллекции
    //MuveNext - перемещает перечислитель по коллекции
    /// <summary>
    ///  Reset -устанавливает перечислительт в начало колекции 
    /// </summary>
    //class Auditore : IEnumerable,// Позволяет при помощи перечслителя  осуществить 
    //                             //перебор всех эелементов не обопщенной коллекции 
    //    IComparable// для сравнения двух обьектов между собой, = 0 если равный и >0 если больше 

    //{
    //    Student[] st =
    //    {
    //        new Student
    //        {FName = " Ivan ",
    //            LName = "Ivano",
    //            BR= new DateTime( 1999, 4,12),
    //            studentCard = new StudentCard
    //            { Number = 546573,
    //                Serias = "TDY"

    //            }

    //        },
    //        new Student
    //        {FName = " max ",
    //            LName = "Ivano",
    //            BR= new DateTime( 1998, 14,12),
    //            studentCard = new StudentCard
    //            { Number = 546587,
    //                Serias = "TDY"

    //            }

    //        },
    //        new Student
    //        {FName = " Den ",
    //            LName = "Ivano",
    //            BR= new DateTime( 1997, 4,2),
    //            studentCard = new StudentCard
    //            { Number = 554573,
    //                Serias = "TDY"

    //            }

    //        }

    //    };
    //   //
    //    public IEnumerator GetEnumerator()
    //    {
    //        return st.GetEnumerator();
    //    }

    //}
    class Child : ICloneable//интерфейс для клонирования
    {
        public int age { get; set; }
         public string Name { get; set; }

        public object Clone()// метод клонирования
        {
            return this.MemberwiseClone();// уже готовая реализация
        }

        public override string ToString()
        {
            return String.Format("Имя{1} возраст{0} ", age, Name);
        }
    }

}








