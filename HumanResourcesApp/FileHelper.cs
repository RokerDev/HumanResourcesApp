using Newtonsoft.Json;
using System.IO;

namespace HumanResourcesApp
{
    class FileHelper<T>
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
            T Something =
                JsonConvert.DeserializeObject<T>(File.ReadAllText(_filePath));

            return Something;
        }
    }
}
