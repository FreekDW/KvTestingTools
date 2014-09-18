using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.A
{
    public class MaxSpeedMetadata
    {
        /*
         *  lane_specific	boolean		V	Geeft aan of er gebruik is gemaakt van rijstrook specifieke maximum snelheid (true) of dat deze niet aanwezig is op beschikbare stroken (false).
            feed_id	list<integer>		V	Databron(nen). Lijst van databronnen waar de maximum snelheid vandaan komt. 
            accuracy	float		V	Getal dat aangeeft hoe betrouwbaar de maximum snelheid bepaald kon worden.

         */

        public bool lane_specific { get; set; }

        public List<int> feed_id { get; set; }

        public float accuracy { get; set; }
    }
}