using System;

namespace CustomCampaign.LevelEditor.Tools.Others
{
    public class CustomComponentSelectMenuButton : UIExButtonListButton
    {
        public UIButton labelButton_;

        public void Awake()
        {
            LevelEditorMusicTrackSelectMenuButton musicButton = GetComponent<LevelEditorMusicTrackSelectMenuButton>();
            labelButton_ = musicButton.labelButton_;
            gameObject.RemoveComponent<LevelEditorMusicTrackSelectMenuButton>();
        }

        public override void OnDisplayedVirtual()
        {
            labelButton_.defaultColor = (entry_ as AddCustomComponentMenuLogic.ComponentEntry)?.color_ ?? default;
        }

        internal void Init(LevelEditorLevelNameSelectMenuButton trackButton)
        {
            labelButton_ = trackButton.labelButton_;
        }
    }
}
