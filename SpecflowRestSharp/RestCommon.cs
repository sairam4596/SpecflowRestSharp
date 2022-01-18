using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpecflowRestSharp
{
    internal class RestCommon
    {
        static RestClient client;
        static RestRequest request;
        static IRestResponse response;
        internal static void InitialiseClient(string BaseURL, string endpoint)
        {
            string uri = Path.Combine(BaseURL+endpoint);
            client = new RestClient(uri);
        }

        internal static void CreateRequest(Method methodName)
        {
            request = new RestRequest(methodName);
        }

        internal static void AddRequestBody(string reqJsonBody)
        {
            request.AddJsonBody(reqJsonBody);
        }

        internal static void Execute()
        {
            response = client.Execute(request);
        }

        internal static void ValidateResponseCode(string expectedstatusDescription)
        {
            string actualstatus = response.StatusCode.ToString();
            Assert.AreEqual(expectedstatusDescription, actualstatus, "The statuscode is mismatch");
        }

        internal static void AddUrlParameter(int n)
        {
            request.AddUrlSegment("id",234455);
        }
    }
}
