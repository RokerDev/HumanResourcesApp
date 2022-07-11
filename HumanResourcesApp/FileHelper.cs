using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesApp
{
    class FileHelper
    {
        public static void SerializeToJsonFile(List<Employee> employees)
        {
            File.WriteAllText(Program.FilePath, JsonConvert.SerializeObject(employees));
        }

        public static List<Employee> DeserializeFromFile()
        {
            List<Employee> employees = 
                JsonConvert.DeserializeObject<List<Employee>>
                (File.ReadAllText(Program.FilePath));
            
            return employees;
        }
    }
}
