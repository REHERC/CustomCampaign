using CustomCampaign.Data;

namespace CustomCampaign.Api
{
    public abstract class Addon
    {
        public bool Enabled { get; private set; } = false;
        public CampaignInfo Info { get; internal set; } = null;
        public bool Initialized { get; internal set; } = false;

        public virtual void OnInit(CampaignInfo info)
        {
            return;
        }

        internal void Enable()
        {
            Enabled = true;
            OnEnable();
        }

        public virtual void OnEnable()
        {
            return;
        }

        internal void Disable()
        {
            Enabled = false;
            OnDisable();
        }

        public virtual void OnDisable()
        {
            return;
        }

        public virtual void OnLevelStart(Models.Level level, bool arcade)
        {
            return;
        }
    }
}
