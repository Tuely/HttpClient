using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string author = Console.ReadLine();
            List<string> result = Program.getAuthorHistory(author);
            Console.WriteLine("\n");
            Console.WriteLine(String.Join("\n"   , result));
            
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //  string author = Console.ReadLine();
            //  List<string> result = Program.getAuthorHistory(author);
            //  var result = Program.getAuthorHistory(author);
            //  textWriter.WriteLine(String.Join("\n", result));
            //  textWriter.Flush();
            //  textWriter.Close();

        }

        public static List<string> getAuthorHistory(string author)
        {
            List<string> historyArray = new List<string>();
            HttpClient _client = new HttpClient();
            Task<HttpResponseMessage> getResponse;
            var responseDataDetails = "";
            string getUrl;

            getUrl = $"https://jsonmock.hackerrank.com/api/article_users?username={author}";
            getResponse = _client.GetAsync(getUrl);
            getResponse.Status.Equals(200);
            responseDataDetails = getResponse.Result.Content.ReadAsStringAsync().Result;
            var resp = JsonConvert.DeserializeObject<DataModels>(responseDataDetails);
            if (resp.data != null)
            {
                for (int i = 0; i < resp.data.Count; i++)
                {
                    var about = resp.data[i].about;
                }
            }

            getUrl = $"https://jsonmock.hackerrank.com/api/articles?author={author}";
            getResponse = _client.GetAsync(getUrl);
            getResponse.Status.Equals(200);
            responseDataDetails = getResponse.Result.Content.ReadAsStringAsync().Result;
            var resp1 = JsonConvert.DeserializeObject<DataModels>(responseDataDetails);

            for (int i = 0; i < resp1.data.Count; i++)
            {
                if (resp1.data[i].title != null)
                {
                    historyArray.Add(resp1.data[i].title);
                    historyArray.Add(resp1.data[i].story_title);
                }
            }
            return historyArray;
        }
    }
}
