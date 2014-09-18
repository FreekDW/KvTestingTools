using System;

namespace Spookfiles.Koppelvlak.A
{
    public class Segmentstate
    {
        /*
         *  segment_id	long		V	O	Wegsegment
            update_time	timestamp		V	O	Tijdstip van de laatste update
            type 	segment_state_type_enum		V	O	Type omgevingsvariabele
            Value	integer		V	O	Waarde die hoort bij het segment_state_type.
            feed_id	integer		V	O	Bron waar de waarde vandaan komt

         */

        public long segment_id { get; set; }

        public DateTime update_time { get; set; }

        public segment_state_type type { get; set; }

        public int value { get; set; }

        public int feed_id { get; set; }
    }

    public enum segment_state_type
    {
        MaxSpeed,
        WindWarning,
        IceWarning,
        MistWarning,
        Holiday,
        LaneClosed,
        VMSStatus
    }
}