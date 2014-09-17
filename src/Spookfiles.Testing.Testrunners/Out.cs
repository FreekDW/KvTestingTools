using System;
using System.Reflection;
using log4net;

namespace Spookfiles.Testing.Testrunners
{
    public class Out
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Info(string data)
        {
            Log.Info(data);
            Console.WriteLine(data);
        }
    }
}