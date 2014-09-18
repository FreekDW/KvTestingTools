namespace Spookfiles.Koppelvlak.A
{
    public class Roadsegments
    {
        /*
         *  Id	long		Verplicht	Uniek ID van het segment binnen de configuratieversie. 
            lane	lane_enum		Verplicht	Rijstrook.
            max_speed	integer	km/h	Verplicht	Wettelijke maximum snelheid.
            Length	integer	m	Verplicht	Lengte van het segment.
            location	locationreference		Verplicht	Locatiereferentie. Dit hangt af van de locationreferencetype parameter die wordt opgegeven aan de GET request.

         */

        public long id { get; set; }

        public LaneEnum lane { get; set; }

        public int max_speed { get; set; }

        public int length { get; set; }

        public Locationreference location { get; set; }
    }
}