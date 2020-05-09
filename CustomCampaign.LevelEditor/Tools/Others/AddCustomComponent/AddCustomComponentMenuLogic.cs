#pragma warning disable RCS1213, RCS1225, CA1034, IDE0051
using CustomCampaign.LevelEditor.Data;
using System;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Tools.Others
{
    public class AddCustomComponentMenuLogic : MonoBehaviour
    {
        public UIExInput levelPathInput_;
        public UILabel headerLabel_;
        public UIExButtonList buttonList_;
        // Generic value type of action being returned when clicking ok
        private Action<HierarchyComponentData> entryCallback_;
        //private HierarchyComponentData root_;

        private void OnEnable()
        {
            GenerateComponentNameList();
        }

        public void CloseWindow()
        {
            G.Sys.MenuPanelManager_.Pop(true);
        }

        internal void Init(LevelEditorLevelNameSelectMenuLogic menuLogic)
        {
            levelPathInput_ = menuLogic.levelPathInput_;
            headerLabel_ = menuLogic.headerLabel_;
            buttonList_ = menuLogic.buttonList_;

            const string okButtonHierarchy = "Panel/OK Button/Sprite";
            UIEventListener okButton = transform.Find(okButtonHierarchy).GetComponent<UIEventListener>();

            const string cancelButtonHierarchy = "Panel/Cancel Button/Sprite";
            UIEventListener cancelButton = transform.Find(cancelButtonHierarchy).GetComponent<UIEventListener>();

            const string closeButtonHierarchy = "Panel/Window Content/Corner X";
            UIButton closeButton = transform.Find(closeButtonHierarchy).GetComponent<UIButton>();

            closeButton.onClick.Add(new EventDelegate(CloseWindow));
            cancelButton.onClick = (_) => CloseWindow();
        }

        public void Show(string headerText, Action<HierarchyComponentData> pathCallback)
        {
            headerLabel_.text = headerText;
            entryCallback_ = pathCallback;

            levelPathInput_.defaultText = "Enter Component Name";
            SetLevelPathInput(string.Empty);
        }

        private void GenerateComponentNameList()
        {
            buttonList_.Clear();

            for (int i = 0; i < 100; i++)
            {
                HierarchyComponentFile file = new HierarchyComponentFile($"File #{i}", $"component#{i}", null);
                ComponentEntry entry = ComponentEntry.CreateEntry(file, ClickOnEntry, (_) => { }, true, Color.cyan);
                entry.sortString_ = $"component#{i}";
                buttonList_.Add(entry);
            }

            buttonList_.SortAndUpdateVisibleButtons();
        }

        public void SetLevelPathInput(string name)
        {
            levelPathInput_.Value_ = name;
        }

        public void ClickOnEntry(UIExButtonContainer.Entry e)
        {
            ComponentEntry entry = e as ComponentEntry;
            SetLevelPathInput(entry.item_.Name);
        }

        public class ComponentEntry : UIExButtonContainer.Entry
        {
            public HierarchyComponentData item_;
            public Color color_;

            private ComponentEntry(
                string objectName,
                string labelText,
                OnClickCallback onClick,
                OnClickCallback onDoubleClick,
                bool buttonIsClickable,
                HierarchyComponentData item,
                Color color)
            : base(objectName, labelText, onClick, onDoubleClick, buttonIsClickable)
            {
                item_ = item;
                color_ = color;
            }

            public override string ToString()
            {
                return labelText_;
            }

            public static ComponentEntry CreateEntry(HierarchyComponentData item, OnClickCallback onClick, OnClickCallback onDoubleClick, bool buttonIsClickable, Color color)
            {
                return new ComponentEntry(string.Empty, item.Name, onClick, onDoubleClick, buttonIsClickable, item, color);
            }
        }
    }
}
