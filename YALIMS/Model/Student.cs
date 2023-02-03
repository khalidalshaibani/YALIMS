using System.Data;
using Newtonsoft.Json;

namespace YALIMS.Model
{
    public class Student : IPerson
    {
        private DateTime birthDate;
        /// <summary>
        /// Student Birth date
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    this.birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Birth Date should be in a time before today");
                }
            }
        }
        /// <summary>
        /// Student Picture
        /// </summary>
        public string Image;
        /// <summary>
        /// Student Course Level
        /// </summary>
        public int Level;
        /// <summary>
        /// Study Time
        /// </summary>
        public TimeOnly Time;
        /// <summary>
        /// Student marks
        /// </summary>
        public Mark[] Marks;

        private readonly string TYPE = "Student";
        /// <summary>
        /// Unset all properties
        /// </summary>
        public override void Unset()
        {
            this.Name = "";
            this.Username = "";
            this.Password = "";
            this.PhoneNumber = 0;
            this.Level = 0;
            this.Email = "";
            this.BirthDate = new DateTime(2000, 1, 1);
            this.Image = "";
            this.Time = new TimeOnly(08, 00);
            this.Marks = Array.Empty<Mark>();
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Student() : base()
        {
            this.BirthDate = new DateTime(2000, 1, 1);
            this.Image = "Not Set";
            this.Level = 1;
            this.Time = new TimeOnly(08, 00);
            this.Marks = Array.Empty<Mark>();
            base.TYPE = this.TYPE;
            base.Fields = new string[,] {
                    { "name", Name },
                    { "email", Email },
                    { "username", Username},
                    { "password", Password},
                    { "phone", PhoneNumber.ToString() },
                    { "birthdate", BirthDate.ToString() },
                    { "coursetype", Level.ToString() },
                    { "time", Time.ToString() }
                };
        }
    }
}
