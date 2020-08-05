using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using STUN;
using STUN.Attributes;

namespace Kukushka_Talk.Network
{
    class STUNSupport
    {
        public static void Get()
        {
            /*
            if (!STUNUtils.TryParseHostAndPort("stun.schlund.de:3478", out IPEndPoint stunEndPoint))
                throw new Exception("Failed to resolve STUN server address");

            UdpClient client = new UdpClient();
            STUNClient.ReceiveTimeout = 500;
            var queryResult = STUNClient.Query(client.Client, stunEndPoint, STUNQueryType.ExactNAT, NATTypeDetectionRFC.Rfc5780);
            
            if (queryResult.QueryError != STUNQueryError.Success)
                throw new Exception("Query Error: " + queryResult.QueryError.ToString());

            System.Diagnostics.Debug.WriteLine("PublicEndPoint: {0}", queryResult.PublicEndPoint);
            System.Diagnostics.Debug.WriteLine("LocalEndPoint: {0}", queryResult.LocalEndPoint);
            System.Diagnostics.Debug.WriteLine("NAT Type: {0}", queryResult.NATType);
            Socket socket = queryResult.Socket;*/
        }
    }
}
