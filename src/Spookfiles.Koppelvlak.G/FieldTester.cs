using System.Collections.Generic;

namespace Spookfiles.Koppelvlak.G
{
    public class FieldTester
    {
        public static List<string> FieldsThatShouldBePresentInFCD()
        {
            var list = new List<string>();
            list.AddRange(new[]
            {
                "generation_time", "ref_position_lon", "ref_position_lat", "speed", "heading", "provider_id",
                "user_id_anonymous"
            });
            return list;
        }
    }
}