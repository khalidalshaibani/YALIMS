using System.Data;
using Newtonsoft.Json;

namespace YALIMS.Controller
{
    public abstract class Database
    {
        /// <summary>
        /// Get the Type of API
        /// </summary>
        /// <returns>API type</returns>
        protected string TYPE;
        /// <summary>
        /// Fields 
        /// </summary>
        /// <returns></returns>
        protected string[,] Fields;
        public void Add(string[,] parameters) {
            Connector.Operate("insert", Connector.ArrayToString(parameters), TYPE);
        }
        public void Remove(string key, string column = "")
        {
            if (column == "") column = "username";
            string query = $"&{column}={key}";
            Connector.Operate("delete", query, TYPE);
        }
        public void Update(string[,] parameters)
        {
            Connector.Operate("update", Connector.ArrayToString(parameters), TYPE);
        }
        public void Activate(string username)
        {
            Connector.Operate("activate", $"&username={username}", TYPE);
        }
        public DataTable? Find(string key, string column = "")
        {
            if (column == "") column = "username";
            string query = $"&{column}={key}";
            string data = Connector.Operate("select", query, TYPE);
            if (data != "Error")
            {
                return JsonConvert.DeserializeObject<DataTable>(data);
            }
            else
            {
                return null;
            }
        }
        public DataTable? All()
        {
            string data = Connector.Operate("select", "", TYPE);
            if (data != "Error")
            {
                return JsonConvert.DeserializeObject<DataTable>(data);
            }
            else
            {
                return null;
            }
        }
        public void Save()
        {
            Connector.Operate("insert", Connector.ArrayToString(Fields), TYPE);
        }
    }
}
