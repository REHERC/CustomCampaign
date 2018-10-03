using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCampaign
{
    class PiecesOfThePastMode : AdventureMode
    {
        public new static GameModeID ModeID_
        {
            get
            {
                return GameModeID.Adventure;
            }
        }
    }
}
