using JSONFw.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONFw
{
    public class DataManager
    {
        private readonly object lockForClientUserFile = new object();
        public string RootFolder
        {
            get
            {
                return @"C:\Users\nipesh.shah\source\repos\testprojjsonframework\testprojjsonframework\DATAFOLDER";
            }
        }
        public List<IdolMaster> LoadTirthMaster(string searchedstring = "")
        {
            string settingsFile = Path.Combine(RootFolder, "ttkmaster.json");

            if (!File.Exists(settingsFile))
            {
                File.WriteAllText(settingsFile, "[]");
            }

            if(searchedstring.Length == 0)
                return OpenJsonFileData<List<IdolMaster>>(settingsFile);
            else
                return OpenJsonFileData<List<IdolMaster>>(settingsFile).Where(t => t.title.Contains(searchedstring)).ToList();
        }

        public List<TrustMaster> LoadTrustMaster(string searchedstring = "")
        {
            string settingsFile = Path.Combine(RootFolder, "trusmaster.json");

            if (!File.Exists(settingsFile))
            {
                File.WriteAllText(settingsFile, "[]");
            }

            if (searchedstring.Length == 0)
                return OpenJsonFileData<List<TrustMaster>>(settingsFile);
            else
                return OpenJsonFileData<List<TrustMaster>>(settingsFile).Where(t => t.title.Contains(searchedstring)).ToList();
        }


        public List<CityMaster> LoadCityMaster(string searchedstring = "")
        {
            string settingsFile = Path.Combine(RootFolder, "ctymaster.json");

            if (!File.Exists(settingsFile))
            {
                File.WriteAllText(settingsFile, "[]");
            }

            if (searchedstring.Length == 0)
                return OpenJsonFileData<List<CityMaster>>(settingsFile);
            else
                return OpenJsonFileData<List<CityMaster>>(settingsFile).Where(t => t.name.Contains(searchedstring)).ToList();
        }

        private T OpenJsonFileData<T>(string fileName)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
        }

        public bool AddTirthMaster(List<IdolMaster> entity)
        {
            bool result = false;
            lock (lockForClientUserFile)
            {
                string dataFile = Path.Combine(RootFolder, "ttkmaster.json");
                result = SaveJsonFileData<List<IdolMaster>>(dataFile, entity);
            }
            return result;
        }        

        public List<Temple> GetSearchedTemples(string searchString)
        {
            MockData mockData = new MockData();
            List<Temple> temples = mockData.GetSearchedTemples();
            return temples;
        }

        private bool SaveJsonFileData<T>(string fileName, T entity)
        {
            try
            {
                File.WriteAllText(Path.Combine(RootFolder, fileName), JsonConvert.SerializeObject(entity, Formatting.Indented));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SubmitNewEntity(SubmitNewEntity newEntity)
        {
            string settingsFile = Path.Combine(RootFolder, "requests.json");

            if (!File.Exists(settingsFile))
            {
                File.WriteAllText(settingsFile, "[]");
            }

            List<SubmitNewEntity> requests = OpenJsonFileData<List<SubmitNewEntity>> (settingsFile);
            newEntity.requestdate = DateTime.UtcNow;
            newEntity.status = "Pending";
            requests.Add(newEntity);
            bool result = false;
            lock (lockForClientUserFile)
            {
                string dataFile = Path.Combine(RootFolder, "requests.json");
                result = SaveJsonFileData<List<SubmitNewEntity>>(dataFile, requests);
            }
            return result;
        }
    }
}
