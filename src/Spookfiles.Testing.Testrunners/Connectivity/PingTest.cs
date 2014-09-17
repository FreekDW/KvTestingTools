using System;
using System.Net.NetworkInformation;
using Spookfiles.Testing.Common;

namespace Spookfiles.Testing.Testrunners.Connectivity
{
    public class PingTest : ITest
    {
        private const int NrOfPingChecks = 4;

        /// <summary>
        ///     Test ICMP/ PING Connectivity
        /// </summary>
        /// <param name="o"></param>
        public TestResultBase Test(Options o)
        {
            string domain = new Uri(o.Url).DnsSafeHost;
            var res = new GenericTestResult
            {
                ShortDescription = "Ping",
                Status = TestResult.OK
            };
            long rtt = 0;
            int nrSuccess = 0;
            try
            {
                for (int i = 0; i < NrOfPingChecks; i++)
                {
                    PingReply pingReply = new Ping().Send(domain);
                    if (pingReply.Status == IPStatus.Success)
                    {
                        long replyTimes = pingReply.RoundtripTime;
                        // successd
                        rtt += pingReply.RoundtripTime;
                        nrSuccess++;
                    }
                    else
                    {
                        // fail
                        res.Status = TestResult.FAIL;
                        res.CauseOfFailure = pingReply.Status.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                res.Status = TestResult.FAIL;
                res.CauseOfFailure = ex.Message;
            }
            res.ExtraInformation = rtt != 0 ? (rtt/nrSuccess) + " ms avg RTT" : "0";

            return res;
        }
    }
}