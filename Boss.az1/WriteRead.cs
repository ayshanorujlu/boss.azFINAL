using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az1
{
    public static class WriteRead
    {

        #region Json
        public static void WriteWorker(List<Worker> workers)
        {
            var item = System.Text.Json.JsonSerializer.Serialize(workers);

            File.WriteAllText("workers.json", item);
        }
        public static List<Worker>? ReadWorker()
        {
            var context = File.ReadAllText("workers.json");
            var workers = JsonConvert.DeserializeObject<List<Worker>>(context);
            return workers;
        }

        public static void WriteEmployer(List<Employer> employers)
        {
            var item = System.Text.Json.JsonSerializer.Serialize(employers);

            File.WriteAllText("employers.json", item);

        }

        public static List<Employer>? ReadEmployer()
        {
            var context = File.ReadAllText("employers.json");
            var employers = JsonConvert.DeserializeObject<List<Employer>>(context);
            return employers;
        }

        #endregion

    }
}
