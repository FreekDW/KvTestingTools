using System;
using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.G
{
    /// <summary>
    ///     Fcd trail is a trip.
    /// </summary>
    public class FcdTrail
    {
        /// <summary>
        ///     Tabel 1
        /// </summary>
        public DateTime generation_time { get; set; }

        public double ref_position_lon { get; set; }

        public double ref_position_lat { get; set; }

        public int speed { get; set; }

        public int heading { get; set; }

        public double accuracy { get; set; }

        /// <summary>
        ///     Free public key/value pairs
        /// </summary>
        public Dictionary<string, string> trail_free { get; set; }
    }
}