﻿using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using ClientTajmi.ViewModel;

namespace ClientTajmi.Services
{

    public class RequestService
    {
        //private ViewModel.ConfigModel Cn;
        public RequestService()
        {
            //دریافت تنظیمات از فایل کانفیگ
            //string root = Application.StartupPath + @"\ConfigWebservice.txt";
            //Cn = JsonConvert.DeserializeObject<ViewModel.ConfigModel>(File.ReadAllText(root));
        }


        private void CreateRequest(string UrlApi, string Obj)
        {

            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create(UrlApi);
            // Set the Method property of the request to POST.  
            request.Method = "POST";

            // Create POST data and convert it to a byte array.  
            string postData = Obj;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application / json";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;

            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.  
            // The using block ensures the stream is automatically closed.
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                //Console.WriteLine(responseFromServer);
            }

            // Close the response.  
            response.Close();

        }
        private string CreateRequestGet(string UrlApi)
        {
            var RetData = new WebClient().DownloadString(UrlApi);
            return RetData;
        }

        public List<GetDataViewModel> GetNewDate(string UrlService,string Cnn,string TBname,string PrimaryKey)
        {
            string Turl = UrlService + "/" + Cnn + ",'" + TBname + "'," + PrimaryKey;

            var data = JsonConvert.DeserializeObject<List<GetDataViewModel>>(CreateRequestGet(Turl));
            return data;
        }
    }
}