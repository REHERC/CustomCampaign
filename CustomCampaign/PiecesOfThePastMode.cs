using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CustomCampaign
{
    class PiecesOfThePastMode : AdventureMode
    {
        public new static GameModeID ModeID_ => GameModeID.LostToEchoes;

        public override GameModeID GameModeID_ => PiecesOfThePastMode.ModeID_;

        public new static string ModeName_ => "Pieces of the Past";

        public override string Name_ => PiecesOfThePastMode.ModeName_;

        public override GameModeSortValue SortValue_ => GameModeSortValue.LostToEchoes;

        public override string Description_ => "Add description here";

        public override int PlayerCountMax_ => 1;

        public override int PlayerCountMin_ => 1;

        public override CheckModeRequirements CheckModeRequirements_ => new CheckModeRequirements(AdventureMode.CheckModeRequirements);

        public override bool UsesWrongWay_ => true;

        public override bool ShowInMenu_ => false;

        public override bool ShowInLevelEditor_ => true;

        public new static ComponentID GetID()
        {
            return ComponentID.LostToEchoesMode;
        }

        public override ComponentID ID_ => PiecesOfThePastMode.GetID();

        public override double GetDisplayTime(int playerIndex)
        {
            return base.GetDisplayTimeCountUp();
        }

        public override void UpdateMode()
        {
            base.UpdateRaceModeDistanceToFinish();
        }

        public override Color GetDisplayTimeColor(int playerIndex, double warningTimeThreshold = 30.0)
        {
            return Color.cyan;
        }

        protected override void PostLoadLevel()
        {
            Level level_ = G.Sys.GameManager_.Level_;
            RaceStartCarSpawner raceStartCarSpawner = level_.FindFirstComponentOfType<RaceStartCarSpawner>();
            if (raceStartCarSpawner != null)
            {
                this.startZoneSpawnerXform_ = raceStartCarSpawner.transform.GetGlobalXform();
            }
            else
            {
                Debug.Log("A RaceStartLogic wasn't found in " + LostToEchoesMode.ModeName_ + ", did someone forget to add a StartZone to the level!?");
            }
            if (this.levelIntroPrefab_ != null && !VRManager.VREnabled)
            {
                UnityEngine.Object.Instantiate<GameObject>(this.levelIntroFinalPrefab_);
            }
        }
    }
}