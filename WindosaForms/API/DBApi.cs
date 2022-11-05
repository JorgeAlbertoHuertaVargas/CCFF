using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindosaForms.API
{
    public class DBApi
    {
        //public dynamic Post(string url, string json, string autorizacion =  null)
        //{
        //    try
        //    {
        //        var client = new RestClient(url);
        //        var request = new RestRequest(Method.POST);
        //        request.AddHeader("Content-Type", "application/json");
        //        request.AddParameter("application/json", json, ParameterType.RequestBody);
        //        if(autorizacion != null)
        //        {
        //            request.AddHeader("Authorization", autorizacion);

        //        }
        //        IRestResponse response = client.Execute(request);

        //        dynamic datos = JsonConvert.DeserializeObject(response.Content);
        //        return datos;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}


        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";

            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);

            //string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            //dynamic data = JsonConvert.DeserializeObject(Datos);
            //return data;

            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            dynamic data = JsonConvert.DeserializeObject(Datos);
            return data;


        }

      

        //public static void GetItem(int id)
        //{
        //    //var url = $"http://localhost:8080/item/{id}";
        //    var url = $"https://joeapiccff.azurewebsites.net/api/Alumno/ListarAlumnoByID{id}";
        //    var request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "GET";
        //    request.ContentType = "application/json";
        //    request.Accept = "application/json";
        //    try
        //    {
        //        using (WebResponse response = request.GetResponse())
        //        {
        //            using (Stream strReader = response.GetResponseStream())
        //            {
        //                if (strReader == null) return;
        //                using (StreamReader objReader = new StreamReader(strReader))
        //                {
        //                    string responseBody = objReader.ReadToEnd();
        //                    // Do something with responseBody
        //                    Console.WriteLine(responseBody);

        //                }
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        // Handle error
        //    }
        //}




    }
    
}
