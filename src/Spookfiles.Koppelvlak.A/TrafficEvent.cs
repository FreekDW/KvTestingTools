using System;
using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.A
{
    //public class Eventsrequest
    //{
    //    /// <summary>
    //    ///     Wegsegment(en) gescheiden door een komma.
    //    /// </summary>
    //    public List<long> segment_id { get; set; }

    //    /// <summary>
    //    ///     Databron(nen), gescheiden door een komma.
    //    /// </summary>
    //    public List<int> feed_id { get; set; }

    //    /// <summary>
    //    ///     Maximale leeftijd van een meting in seconden.
    //    /// </summary>
    //    public int? max_age { get; set; }
    //}


    //public class Eventshistoricrequest
    //{
    //    /// <summary>
    //    ///     Wegsegment(en) gescheiden door een komma.
    //    /// </summary>
    //    public List<long> segment_id { get; set; }

    //    /// <summary>
    //    ///     Databron(nen), gescheiden door een komma.
    //    /// </summary>
    //    public List<int> feed_id { get; set; }

    //    /// <summary>
    //    ///     Vanaf moment (inclusief)
    //    /// </summary>
    //    public DateTime? start_time { get; set; }

    //    /// <summary>
    //    ///     Tot moment (inclusief)
    //    /// </summary>
    //    public DateTime? end_time { get; set; }
    //}


    //public class Eventsrealtimerequest
    //{
    //    /// <summary>
    //    ///     Wegsegment(en) gescheiden door een komma.
    //    /// </summary>
    //    public List<long> segment_id { get; set; }

    //    /// <summary>
    //    ///     Databron(nen), gescheiden door een komma.
    //    /// </summary>
    //    public List<int> feed_id { get; set; }
    //}

    public class TrafficEvent
    {
        /*
            event_id	integer		V	O	Unieke ID van event. Deze blijft voor de gehele levensduur van het event gelijk.
            Version	integer		V	O	Event versie. Wijzigt per update.
            event_code	list<integer>		V	O	TPEG TEC causeCode
            start_time	timestamp		V	O	
            update_time 	timestamp		V	O	Van deze versie
            expected_end_time	timestamp		V	O	
            segment_id	list<long>		V	O	Lijst van id’s van getroffen segmenten
            feed_id 	integer		O	O	ID van de feed waarvan dit record afkomstig is.
         */

        public int event_id { get; set; }
        public int Version { get; set; }
        public List<int> event_code { get; set; }
        public DateTime? start_time { get; set; }
        public DateTime? update_time { get; set; }

        public DateTime? expected_end_time
        {
            get { return DateTime.Now.AddHours(4); }
            set { DateTime.Now.AddHours(4); }
        }

        public List<long> segment_id { get; set; }
        public List<int> feed_id { get; set; }
    }
}