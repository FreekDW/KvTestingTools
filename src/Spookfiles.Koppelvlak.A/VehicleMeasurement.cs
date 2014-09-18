using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.A
{
    public class VehicleMeasurement
    {
        /*
         * 
            relative_time	integer	Msec	V	V	Relatieve tijd, t.o.v. measurement_time, in milliseconden. 
            segment_id	long		V	O	Segment ID waarop het voertuig zich bevindt.
            relative_position	integer	M	V	O	Positie van het voertuig t.o.v. het begin van het segment.
            coordinate	coordinate		O	V	Coordinaat van het voertuig op dit tijdstip.
            speed	integer	km/h	O	V	Punt snelheid.
            headway	integer	m	O	O	Volgafstand.
            lane	lane_enum		O	O	Rijstrook waarop het voertuig zich bevindt.
 
         */
        public int relative_time { get; set; }
        public List<long> segment_id { get; set; }
        public int relative_position { get; set; }
        public Coordinate coordinate { get; set; }
        public int speed { get; set; }
        public int headway { get; set; }
        public LaneEnum lane { get; set; }
    }
}