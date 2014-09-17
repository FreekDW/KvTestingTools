using System;
using System.Net;

namespace Spookfiles.Testing.Common
{
    public class HttpHelper
    {
        /// <summary>
        ///     This will check the input parameters and provide the options to the webclient instance.
        ///     It supports api key and basic auth at the moment.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="o"></param>
        public static void ConfigureAuth(WebClient c, Options o)
        {
            if (!String.IsNullOrEmpty(o.ApiKey))
            {
                if (!String.IsNullOrEmpty(o.ApiKeyHeader))
                {
                    c.Headers.Add(o.ApiKeyHeader, o.ApiKey);
                }
                else
                {
                    c.Headers.Add(Options.DefaultApiKeyHeaderName, o.ApiKey);
                }
            }
            if (!String.IsNullOrEmpty(o.User))
            {
                c.Credentials = new NetworkCredential(o.User, o.Pass);
            }
        }
    }
}