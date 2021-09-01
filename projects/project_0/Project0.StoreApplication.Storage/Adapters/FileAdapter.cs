using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Adapters
{
    public class FileAdapter
    {
        public void SaveData<T> (List<T> uniList) where T : class {

            var path = @"/home/zacharyhammersmith/revature/zach_code/projects/project_0/Project0.StoreApplication.Storage/Data/StoreAppData.xml";

            var type = typeof(List<T>);
            
            var open = new StreamWriter(path);

            var serialData = new XmlSerializer(type);

            serialData.Serialize(open, uniList);
        }

        public List<T> RetreiveData<T> () where T : class {

            var path = @"/home/zacharyhammersmith/revature/zach_code/projects/project_0/Project0.StoreApplication.Storage/Data/StoreAppData.xml";

            var type = typeof(List<T>);
            
            var open = new StreamReader(path);

            var deserialData = new XmlSerializer(type);

            var uploadData = deserialData.Deserialize(open) as List<T>;

            return uploadData;
        }


        
       
    }
}