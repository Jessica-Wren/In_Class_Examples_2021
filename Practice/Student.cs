using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Student
    {
        public string FirstName { get; set; }
        public double GPA { get; set; }

       


        /// <summary>
        /// Default CTOR
        /// </summary>
        public Student()
        {
            FirstName = string.Empty;
            GPA = 0;
            
        }

        /// <summary>
        /// Overloaded ctor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="gpa"></param>
        public Student(string firstName, double gpa)
        {
            FirstName = firstName;
            GPA = gpa;
            
        }

        public string CalculateDistinction()
        {
            

            if (GPA < 3.40)
            {
                return ("No distinction");
            }
            else if (GPA >= 3.40 && GPA <= 3.59)
            {
                return ("Cum Laude");
            }
            else if (GPA >= 3.60 && GPA <= 3.79)
            {
                return ("magna cum laude");
            }
            else
            {
                return ("Summa Cum Laude");
            }
        }

        
    }
}
