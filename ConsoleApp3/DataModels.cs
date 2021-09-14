using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DataModels
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
        public class Datum
        {
            public string title { get; set; }
            public string? about { get; set; }
            public string? story_title { get; set; }
            //public int id { get; set; }
            //public string username { get; set; }
            //public string? about { get; set; }
            //public int submitted { get; set; }
            //public DateTime updated_at { get; set; }
            //public int submission_count { get; set; }
            //public int comment_count { get; set; }
            //public int created_at { get; set; }
        }
           
        
    }
}
