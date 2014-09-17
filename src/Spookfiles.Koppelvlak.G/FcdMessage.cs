using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.G
{
    /// <summary>
    ///     Contains a collection of fcd records, which can be reported by different users.
    /// </summary>
    public class FcdMessage
    {
        public long message_time { get; set; }
        public string provider_id { get; set; }
        public List<FcdRecord> fcd_records { get; set; }
    }
}