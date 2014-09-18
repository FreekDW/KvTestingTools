using System;
using System.Net.Sockets;
using Spookfiles.Testing.Common;

namespace Spookfiles.Testing.Testrunners.Connectivity
{
    public class TcpConnectionTest : ITest
    {
        public TestResultBase Test(Options o)
        {
            var p = new Uri(o.Url);

            var res = new GenericTestResult
            {
                ShortDescription = "TCP connection port " + p.Port,
                Status = TestResult.OK
            };

            try
            {
                var client = new TcpClient();
                client.Connect(p.DnsSafeHost, p.Port);
                res.Status = TestResult.OK;
                client.Close();
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