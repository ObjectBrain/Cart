using System;
using System.Net.Http.Headers;

namespace Service.WebApi.Client
{
    public interface IHttpClientConfiguration
    {
        Uri ApiBaseUri { get; set; }
        MediaTypeWithQualityHeaderValue MediaTypeWithQualityHeaderValue { get; set; }
    }
}