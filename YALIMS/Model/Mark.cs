using System.Data;
using Newtonsoft.Json;
using YALIMS.Controller;

namespace YALIMS.Model
{
    public class Mark : Database
    {
        public int Student;
        /// <summary>
        /// The Level
        /// </summary>
        public int Level;
        private int grade;
        /// <summary>
        /// The grade of the level in numbers
        /// </summary>
        /// <value>
        /// Value should be between 0 and 100
        /// </value>
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    throw new ArgumentException("Mark should be between 0 and 100");
                }
            }
        }
        public string Course = "";
        private readonly string TYPE = "Mark";
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Mark()
        {
            base.TYPE = this.TYPE;
            base.Fields = new string[,]
            {
                { "Student_ID", Student.ToString() },
                { "CourseLevel", Level.ToString() },
                { "CourseName", Course },
                { "Mark", Grade.ToString() }
            };
        }
    }
}