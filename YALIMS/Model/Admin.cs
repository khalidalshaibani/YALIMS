using System.Data;
using Newtonsoft.Json;

namespace YALIMS.Model
{
    public class Admin : IPerson
    {
        private readonly string TYPE = "Admin";
        public Admin()
        {
            base.TYPE = this.TYPE;
            base.Fields = new string[,] {
                    { "name", Name },
                    { "email", Email },
                    { "username", Username},
                    { "password", Password},
                    { "mobile", PhoneNumber.ToString() }
                };
        }
    }
}
