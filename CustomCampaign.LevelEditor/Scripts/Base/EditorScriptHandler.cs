using System;

namespace CustomCampaign.LevelEditor.Scripts.Base
{
    public class EditorScriptHandler : AddedComponent
    {
        public override Type RemoveTool_ => throw new NotImplementedException();

        public override ComponentID ID_ => (ComponentID)4100;
    }
}
