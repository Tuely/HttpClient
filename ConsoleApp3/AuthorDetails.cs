using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public class AuthorDetails
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
        public class Datum
        {
            public string title { get; set; }
            public string url { get; set; }
            public string author { get; set; }
            public int num_comments { get; set; }
            public object story_id { get; set; }
            public string? story_title { get; set; }
            public object story_url { get; set; }
            public object parent_id { get; set; }
            public int created_at { get; set; }
        }

      
           
       

    }
}
