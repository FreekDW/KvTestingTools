using System;
using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.A
{
    public class Weatherforecast
    {
        /*
         *  segment_id	long		V	O	Lijst van id’s van getroffen segmenten
            measurement_time	timestamp		V	O	Tijdstip van de meting
            weather_type 	weather_type_enum		V	O	Type weer/neerslag
            Value	float	* 	V	O	Voorspelde waarde
            Certainty	float		V	O	Zekerheid van de voorspelling
            feed_id	integer		V	O	Bron waar de waarde vandaan komt
         */

        public List<long> segment_id { get; set; }

        public DateTime measurement_time { get; set; }

        public Weathertype weather_type { get; set; }

        public float value { get; set; }

        public float certainty { get; set; }

        public int feed_id { get; set; }
    }
}