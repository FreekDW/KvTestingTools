namespace Spookfiles.Testing.Testrunners.Performance
{
    //public class PerformanceTest : HttpTestBase, ITest
    //{
    //public string RelativeUrl { get; set; }
    //public Func<dynamic, bool> ValidatorFunction { get; set; }

    //public TestResultBase Test(Options o)
    //{
    //    var res = new GenericTestResult()
    //    {
    //        ShortDescription = "Performance (uptime) " + RelativeUrl,
    //        Status = TestResult.INCONCLUSIVE
    //    };

    //    try
    //    {
    //        WebClient c = SetupWebClient(o);
    //        var data = c.DownloadData(o.Url + RelativeUrl);
    //        if (c.ResponseHeaders["Content-Type"].ToLowerInvariant().Contains("application/json"))
    //        {
    //            if (c.ResponseHeaders["Charset"].ToLowerInvariant().Contains("utf-8"))
    //            {
    //                res.Status = TestResult.OK;
    //            }
    //            else
    //            {

    //            }

    //        }
    //        else
    //        {
    //            res.Status = TestResult.FAIL;
    //            res.ExtraInformation = "No response header Content-Type. Invalid HTTP";
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        res.Status = TestResult.FAIL;
    //        res.CauseOfFailure = ex.Message;
    //    }

    //    return res;
    //}
    //}
}