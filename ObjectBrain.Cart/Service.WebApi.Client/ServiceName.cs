using System;
using System.Collections.Generic;
using Domain.Entity;

namespace Service.WebApi.Client
{
    public enum ServiceName
    {
        Customer
    }

    public static class ServiceNameMapper
    {
        public static Dictionary<Type, ServiceName> Mapping = new Dictionary<Type, ServiceName>
        {
            {typeof (Customer), ServiceName.Customer}
        };
    }
}