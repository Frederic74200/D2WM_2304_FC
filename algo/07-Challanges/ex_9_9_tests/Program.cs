using System.Data;
using System.Net;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace ex_9_9_tests
{
    internal class Program
    {
        static void Main(string[] args)


        {
            DataTable JsonDataTable = new DataTable();


            var json = new WebClient().DownloadString("https://api.devoldere.net/polls/yoghurts/");


            Console.WriteLine(json);


            JsonDataTable = (DataTable)JsonConvert.DeserializeObject(JsonSting, (typeof(DataTable)));





        }
    }
}