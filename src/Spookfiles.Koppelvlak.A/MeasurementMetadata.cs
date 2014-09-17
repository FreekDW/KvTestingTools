using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.A
{
    public class MeasurementMetadata
    {
        /*
         *  lane_specific	boolean		V	Geeft aan of er gebruik is gemaakt van rijstrook specifieke metingen (true) of dat deze niet beschikbaar waren en de gemeten waarde is verdeeld over de beschikbare stroken (false).
            feed_id	list<integer>		V	Databron(nen). Lijst van databronnen waar de meting vandaan komt, indien dataleverancier brondata doorsturen toestaat. 
            estimation_algorithm	text		O	Methode gebruikt voor het schatten / verrijken van de data. Bijvoorbeeld:
            interpolatie, historisch.
            num_input_values	integer		O	Aantal metingen waarop de waarde is gebaseerd. Of NULL indien niet bekend.
            accuracy	float		V	Waarde tussen 0 en 1 die de betrouwbaarheid van de data weergeeft. De rekenkundige methode die is gebruikt voor de invulling van deze waarde hangt af van de bron (en of combinatie van bronnen) die zijn gebruikt.
         */
        public bool lane_specific { get; set; }

        public List<int> feed_id { get; set; }

        public string estimation_algorithm { get; set; }

        public int num_input_values { get; set; }

        public float accuracy { get; set; }
    }
}