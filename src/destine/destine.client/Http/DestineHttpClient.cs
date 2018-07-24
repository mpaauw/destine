using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;

namespace Destine.Client.Http
{
    public class DestineHttpClient : FlurlClient
    {
        private const string BaseUrl = "https://hacker-news.firebaseio.com/v0/";

        public DestineHttpClient() : base(BaseUrl)
        {
            Settings.HttpClientFactory = new DestineHttpClientFactory();

            Settings.BeforeCall = request => { };
            Settings.AfterCall = response => { };
        }

        internal class DestineHttpClientFactory : DefaultHttpClientFactory
        {
            public override HttpClient CreateHttpClient(HttpMessageHandler handler)
            {
                HttpClient httpClient = base.CreateHttpClient(handler);
                httpClient.DefaultRequestHeaders.Accept.ParseAdd("application/json");
                return httpClient;
            }
        }
    }
}
