﻿using System;
using System.Net;
using Spookfiles.Testing.Common;

namespace Spookfiles.Testing.Testrunners.Functionality
{
    public class HttpResponseValidTests : ITest
    {
        public string RelativeUrl { get; set; }
        public Func<dynamic, bool> ValidatorFunction { get; set; }

        public TestResultBase Test(Options o)
        {
            var res = new GenericTestResult
            {
                ShortDescription = "HTTP response valid",
                Status = TestResult.INCONCLUSIVE
            };

            try
            {
                var c = new WebClient();
                byte[] data = c.DownloadData(o.Url + RelativeUrl);
                if (c.ResponseHeaders["Content-Type"].ToLowerInvariant().Contains("application/json"))
                {
                    if (c.ResponseHeaders["Charset"].ToLowerInvariant().Contains("utf-8"))
                    {
                        res.Status = TestResult.OK;
                    }
                }
                else
                {
                    res.Status = TestResult.FAIL;
                    res.ExtraInformation = "No response header Content-Type. Invalid HTTP";
                }
            }
            catch (Exception ex)
            {
                res.Status = TestResult.FAIL;
                res.CauseOfFailure = ex.Message;
            }
            finally
            {
                res.ExtraInformation += " Url: " + RelativeUrl;
            }

            return res;
        }
    }
}