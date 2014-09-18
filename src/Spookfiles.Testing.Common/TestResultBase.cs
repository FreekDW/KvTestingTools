using System;

namespace Spookfiles.Testing.Common
{
    public abstract class TestResultBase
    {
        public string ShortDescription { get; set; }
        public TestResult Status { get; set; }
        public string CauseOfFailure { get; set; }
        public string ExtraInformation { get; set; }

        /// <summary>
        ///     Doesnt perse belong here, but it's useful this way.
        /// </summary>
        public string SubTest { get; set; }

        public int StepNr { get; set; }

        public static string WriteHeader()
        {
            return "Name_subtest, Step_in_subtest, Short_description, Status, Cause_of_failure, Extra_info," +
                   DateTime.UtcNow;
        }

        public override string ToString()
        {
            if (!String.IsNullOrEmpty(ExtraInformation))
            {
                ExtraInformation = ExtraInformation.Replace(',', '.');
                // replace comma's to prevent mixing with records.
            }
            return
                string.Format(String.Join(",", Nvl(SubTest), StepNr, Nvl(ShortDescription), Status, Nvl(CauseOfFailure),
                    Nvl(ExtraInformation)));
        }

        public string Nvl(string data)
        {
            if (String.IsNullOrEmpty(data))
                return "";
            return data;
        }
    }
}