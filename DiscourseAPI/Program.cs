using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscourseAPI
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //Create a StreamWriter for our CSV file
            using (StreamWriter sw = new StreamWriter(@"C:\Users\jose\AppData\Local\Temp\posts.csv"))
            {
                StringWriter sww = new StringWriter();
                //Write headers
                sw.WriteLine("ID,TITLE,VOTES,LIKES,POSTS,VIEWS,DESCRIPTION,URL");
                int i = 0;
                //Get 30 topics in the selected category
                var catTopics = Newtonsoft.Json.JsonConvert.DeserializeObject<CategoryTopics>(GetRequests(i));
                do
                {
                    //Loop through each topic and extract specifics
                    foreach (var x in catTopics.topic_list.topics)
                    {
                        //Get topic details from the API
                        var topicResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<TopicResponse>(GetTopic(x.id.Value));
                        //Write to a String Writer
                        sww.WriteLine($"{x.id},\"{x.title}\",{x.vote_count},{x.like_count},{x.posts_count},{x.views}, \"{topicResponse.post_stream.posts[0].cooked.Replace("<p>", "").Replace("</p>", "").Replace("\r", "").Replace("\n", "").Replace("\"","'").Replace(",","<comma>")}\",\"{topicResponse.post_stream.posts[0].username}\" , https://e10help.com/t/{topicResponse.slug}/{topicResponse.id}");
                    }
                    //Get the next 30 topics
                    catTopics = Newtonsoft.Json.JsonConvert.DeserializeObject<CategoryTopics>(GetRequests(++i));
                }
                while (catTopics.topic_list.topics.Count() > 0);

                //Write to File
                sw.Write(sww.ToString());
            }
        }

        private static string GetRequests(int page)
        {
            var client = new RestClient($"https://e10help.com/c/16.json?page={page}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "45526d76-9b20-6e4e-0a33-1a5884ba43c0");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string GetTopic(int topicID)
        {
            var client = new RestClient($"https://e10help.com/t/{topicID}.json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "3f5dc0b7-3385-1cc0-f7da-4a38b3b0c45c");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
