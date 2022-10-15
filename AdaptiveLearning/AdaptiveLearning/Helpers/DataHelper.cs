using AdaptiveLearning.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdaptiveLearning.Helpers
{
    /// <summary>
    /// Helper class
    /// </summary>
    public class DataHelper
    {
        private static DataHelper instance = null;

        /// <summary>
        /// SingleTon class for use by both HomeController & LearningController
        /// </summary>
        public static DataHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataHelper();
                }
                return instance;
            }
        }
        DataHelper()
        {
        }

        /// <summary>
        /// Import Json file and display
        /// Return Range of 100
        /// </summary>
        /// <returns></returns>
        public List<Learning> FetchData(bool all = false)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FileLocation\Original_Json.json");
            string jsonString = System.IO.File.ReadAllText(path);
            List<Learning> LearningList = all == true? JsonConvert.DeserializeObject<List<Learning>>(jsonString) : JsonConvert.DeserializeObject<List<Learning>>(jsonString).GetRange(0, 100);

            return LearningList;
        }
    }
}
