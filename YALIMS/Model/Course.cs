using System.Data;
using Newtonsoft.Json;

using YALIMS.Controller;

namespace YALIMS.Model
{
    public class Course : Database
    {
        private readonly string TYPE = "Course";
        public string CourseName = "";
        public Course()
        {
            base.TYPE = this.TYPE;
            base.Fields = new string[,] {
                { "Course_Name", CourseName }
            };
        }
    }
}
