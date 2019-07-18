using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomCampaign.Data
{
    public class GameModeId
    {
        // Links each available gamemode to the corresponding ID (GamemodeID from Assembly-CSharp.dll)
        public static Dictionary<string, int> ConversionTable = new Dictionary<string, int>()
        {
            { "Adventure", 9 },
            { "Nexus", 15 },
            { "Lost to Echoes", 14 }
        };

        public static int GetIndexFromId(int id)
        {
            try
            {
                return ConversionTable.Values.ToList().IndexOf(id);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int GetIdFromIndex(int index)
        {
            try
            {
                return ConversionTable.Values.ToList()[index];
            }
            catch (Exception)
            {
                return 15;
            }
        }
    }
}
