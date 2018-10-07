using ServiceStack.Common;
using ServiceStack.Service;
using ServiceStack.ServiceClient.Web;
using System;

namespace ServiceStack.Messaging
{
    public static class ClientFactory
    {
        public static IOneWayClient Create(string endpointUrl)
        {
            if (endpointUrl.IsNullOrEmpty() || !endpointUrl.StartsWith("http"))
                return null;

            if (endpointUrl.IndexOf("format=") == -1 || endpointUrl.IndexOf("format=json") >= 0)
                return new JsonServiceClient(endpointUrl);

            if (endpointUrl.IndexOf("format=xml") >= 0)
                return new XmlServiceClient(endpointUrl);

            if (endpointUrl.IndexOf("format=jsv") >= 0)
                return new JsvServiceClient(endpointUrl);


            throw new NotImplementedException("could not find service client for " + endpointUrl);
        }
    }
}