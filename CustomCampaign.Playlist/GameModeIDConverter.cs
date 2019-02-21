using System.Collections.Generic;
using System.Linq;

#pragma warning disable RCS1110
public static class GameMode {
    public static Dictionary<int, GameModeID> Values = new Dictionary<int, GameModeID>()
    {
        {0, GameModeID.Nexus},
        {1, GameModeID.LostToEchoes}
    };

    public static GameModeID GetMode(int value)
    {
        if (Values.ContainsKey(value))
            return Values[value];
        return GameModeID.Nexus;
    }

    public static int GetIndex(GameModeID value)
    {
        foreach (var item in from element in Values where element.Value == value select element)
            return item.Key;
        return 0;
    }
}