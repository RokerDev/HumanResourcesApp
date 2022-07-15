using Newtonsoft.Json;
using System.IO;

namespace HumanResourcesApp
{
    class FileHelper<T> where T : new()
    {
        private string _filePath;

        public FileHelper(string FilePath)
        {
            _filePath = FilePath;
        }

        public void SerializeToJsonFile(T Something)
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(Something));
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(_filePath));

            //czy moze lepiej 

            //try
            //{
            //   return JsonConvert.DeserializeObject<T>(File.ReadAllText(_filePath));
            //}
            //catch (System.Exception)
            //{
            //    return new T();
            //}

        }
    }
}
