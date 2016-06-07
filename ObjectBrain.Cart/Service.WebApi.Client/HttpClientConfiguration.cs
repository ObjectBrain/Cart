using System;
using System.Net.Http.Headers;

namespace Service.WebApi.Client
{
    public class HttpClientConfiguration : IHttpClientConfiguration
    {
        public HttpClientConfiguration(Uri apiBaseUri, MediaTypeWithQualityHeaderValue mediaTypeWithQualityHeaderValue)
        {
            ApiBaseUri = apiBaseUri;
            MediaTypeWithQualityHeaderValue = mediaTypeWithQualityHeaderValue;
        }

        public Uri ApiBaseUri { get; set; }
        public MediaTypeWithQualityHeaderValue MediaTypeWithQualityHeaderValue { get; set; }
    }
}