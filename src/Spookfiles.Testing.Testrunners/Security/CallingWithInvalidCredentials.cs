using System;
using System.Net;
using System.Text;
using Spookfiles.Testing.Common;

namespace Spookfiles.Testing.Testrunners.Security
{
    public class CallingWithInvalidCredentials : HttpTestBase, ITest
    {
        public string RelativeUrl { get; set; }
        public Type TypeToDeserialize { get; set; }
        public AuthenticationMode UseCredentials { get; set; }

        public TestResultBase Test(Options o)
        {
            var res = new GenericTestResult
            {
                ShortDescription =
                    string.Format("Calling {0} with {1} credentials", RelativeUrl,
                        UseCredentials == AuthenticationMode.UseInvalidCredentials ? "invalid" : "no"),
                Status = TestResult.INCONCLUSIVE
            };
            try
            {
                WebClient c = SetupWebClient(o, UseCredentials);

                string data = Encoding.UTF8.GetString(c.DownloadData(o.Url + RelativeUrl));
                res.Status = TestResult.FAIL;
                res.CauseOfFailure = "HTTP OK where it should be 401.";
            }
            catch (WebException wex)
            {
                var response = (HttpWebResponse) wex.Response;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    res.Status = TestResult.OK;
                    res.ExtraInformation = "Ok - received " + response.StatusCode + " (expected behaviour)";
                }
            }
            catch (Exception ex)
            {
                res.Status = TestResult.FAIL;
                res.CauseOfFailure = ex.Message;
            }

            return res;
        }
    }
}