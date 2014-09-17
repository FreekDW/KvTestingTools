using System;

namespace Spookfiles.Koppelvlak.A
{
    public class Trafficstate
    {
        /*
         * 
        publication_time	timestamp		V	O	Tijdstip waarop een P1 partij de waarde heeft toegekend voor publicatie.
        measurement_time	timestamp		O	O	Indien een P1 partij het doorsturen van brondata toestaat wordt in dit veld de publication time overgenomen uit de brondata zoals deze toegekend is door de dataleverancier
        segment_id	Long		V	O	ID van het wegsegment
        vehicle_type	vehicle_type_enum		O	O	Voertuigklasse.
        speed	Float	km/h	V	O	Ruimtelijk gemeten snelheid
        speed_metadata	MeasurementMetadata		V	O	Metadata voor het veld snelheid
        max_speed	Integer	km/h	V	O	Wettelijke maximum snelheid
        max_speed_metadata	MaxSpeedMetadata		V	O	Metadata betreffende maximum snelheid.

        freeflow_speed	float	km/h	V	O	Freeflow snelheid
        Flow	integer	vtg/h	V	O	Intensiteit
        flow_metadata	MeasurementMetadata		V	O	Metadata voor het veld intensiteit
        Density	float	vtg/km	V	O	Dichtheid: Intensiteit / snelheid
        traveltime	float	sec	V	O	Reistijd. Inverse snelheid
        feed_id 	integer		O	O	ID van de feed waarvan dit record afkomstig is.

        */

        public DateTime publication_time { get; set; }
        public DateTime measurement_time { get; set; }
        public long segment_id { get; set; }
        public VehicleType vehicle_type { get; set; }

        /// <summary>
        ///     speed in km/h
        /// </summary>
        public float speed { get; set; }

        public MeasurementMetadata speed_metadata { get; set; }

        /// <summary>
        ///     Max speed in km/h
        /// </summary>
        public int max_speed { get; set; }

        public MaxSpeedMetadata max_speed_metadata { get; set; }

        public float freeflow_speed { get; set; }

        /// <summary>
        ///     Note: spec dictates Flow with capital letter. We chose consistency here.
        ///     Flow intensity in vtg/h
        /// </summary>
        public int flow { get; set; }

        public MeasurementMetadata flow_metadata { get; set; }

        /// <summary>
        ///     Note: spec dictates Flow with capital letter. We chose consistency here.
        ///     Density in vtg/km: Intensity / speed
        /// </summary>
        public float density { get; set; }

        /// <summary>
        ///     value in seconds. Spec dictates float, but i think double will be better.
        /// </summary>
        public double traveltime { get; set; }

        /// <summary>
        ///     Optional id for the source of this feed.
        /// </summary>
        public int feed_id { get; set; }
    }
}