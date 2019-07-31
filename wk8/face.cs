using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;

namespace CSHttpClientSample
{
   class c1 
   {
        static void Main()
        {
            MakeRequest();
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }
        
        static async void MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "{96718efc7e974d14a05bee97f46e8937}");

            // Request parameters
            queryString["returnFaceId"] = "true";
            queryString["returnFaceLandmarks"] = "false";
            queryString["returnFaceAttributes"] = "{string}";
            var uri = "https://api.projectoxford.ai/face/v1.0/detect?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("{body}");

            using (var content = new ByteArrayContent(byteData))
            {
               content.Headers.ContentType = new MediaTypeHeaderValue("< your content type, i.e. application/json >");
               response = await client.PostAsync(uri, content);
            }

        }
    }
}	
