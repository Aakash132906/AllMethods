using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Utils
{
    public class ApiCallMethod
    {
        public string Get(string url, string AccessToken)
        {
            var client = new RestClient(url);
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-Auth-Token", AccessToken);
            RestResponse response = client.Execute(request);
            return response.Content;
        }
        public string Post(string url, string AccessToken, string body)
        {
            var client = new RestClient(url);
            var request = new RestRequest("",Method.Post);
            request.AddHeader("X-Auth-Token", AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            return response.Content;
        }
        public string GetAll(string Url, string AccessToken)
        {
            var client = new RestClient(Url);
            var request = new RestRequest("",Method.Get);
            request.AddHeader("X-Auth-Token", AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
