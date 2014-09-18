namespace Spookfiles.Koppelvlak.A
{
    public enum Locationreference
    {
        /*
         *  WGS84	Beschrijft een locatie in WGS84 coördinaten in WKT  formaat.

            AlertC		Een AlertC linear of point locatie volgens de NDW interface specificatie. De gebruikte TMC of VILD tabel wordt meegestuurd met de locatie. Via de configuratie API kan een afnemer zien welke tabel versie gebruikt is (bijv TMC of een VILD tabel)

            OpenLR	Een OpenLR Line of PointAlongLine locatie.
 
        */

        WGS84,
        AlertC,
        OpenLR

    }
}