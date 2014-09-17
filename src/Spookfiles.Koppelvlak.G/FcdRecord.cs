using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.G
{
    /// <summary>
    ///     Fcd record is a collection of trails
    /// </summary>
    public class FcdRecord
    {
        public long user_id_anonymous { get; set; }
        public Dictionary<string, string> rec_free { get; set; }
        public List<FcdTrail> trail { get; set; }
    }
}