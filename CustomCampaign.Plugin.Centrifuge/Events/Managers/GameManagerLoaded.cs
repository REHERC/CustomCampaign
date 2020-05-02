#pragma warning disable CA1034, CA1815

namespace Events.Managers
{
    public class GameManagerLoaded : StaticEvent<GameManagerLoaded.Data>
    {
        public struct Data
        {
            public GameManager manager;

            public Data(GameManager gm)
            {
                manager = gm;
            }
        }
    }
}