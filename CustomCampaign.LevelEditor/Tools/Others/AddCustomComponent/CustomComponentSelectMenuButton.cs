namespace CustomCampaign.LevelEditor.Tools.Others
{
    public class CustomComponentSelectMenuButton : UIExButtonListButton
    {
        public UIButton labelButton_;

        public override void OnDisplayedVirtual()
        {
            labelButton_.defaultColor = (entry_ as AddCustomComponentMenuLogic.ComponentEntry)?.color_ ?? default;
        }
    }
}
