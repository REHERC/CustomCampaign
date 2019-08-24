namespace CustomCampaign.Api
{
    public abstract class Addon
    {
        public bool Enabled { get; private set; } = false;

        public virtual void OnInit()
        {
            return;
        }

        public void Enable()
        {
            Enabled = true;
            OnEnable();
        }

        public virtual void OnEnable()
        {
            return;
        }

        public void Disable()
        {
            Enabled = false;
            OnDisable();
        }

        public virtual void OnDisable()
        {
            return;
        }
    }
}
