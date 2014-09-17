using System;

namespace Spookfiles.Testing.Common
{
    public abstract class RunTesterBase
    {
        /// <summary>
        ///     Run these tests for the category 'subTest', given Options o.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="subTest"></param>
        /// <param name="tests"></param>
        protected static void RunTests(Options o, string subTest, Action<string> logger, params ITest[] tests)
        {
            for (int i = 1; i <= tests.Length; i++)
            {
                TestResultBase result = tests[i - 1].Test(o);
                result.StepNr = i;
                result.SubTest = subTest;
                if (logger != null)
                    logger(result.ToString());
            }
        }
    }
}