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
            //Plugin.Log.Info("OnEnable");

            //Plugin.Log.Info("headerHierarchy");
            //buttonList_ = GetComponentInChildren<UIExButtonList>();
            //const string headerHierarchy = "Panel/Window Content/Header/Label";
            //headerLabel_ = transform.Find(headerHierarchy).GetComponent<UILabel>();

            //Plugin.Log.Info("inputHierarchy");
            //const string inputHierarchy = "Panel/InputField";
            //levelPathInput_ = transform.Find(inputHierarchy).GetComponent<UIExInput>();

            //Plugin.Log.Info("GenerateComponentNameList");
            GenerateComponentNameList();
        }

        internal void Init(LevelEditorLevelNameSelectMenuLogic menuLogic)
        {
            levelPathInput_ = menuLogic.levelPathInput_;
            headerLabel_ = menuLogic.headerLabel_;
            buttonList_ = menuLogic.buttonList_;
        }

        public void Show(string headerText, Action<HierarchyComponentData> pathCallback)
        {
            headerLabel_.text = headerText;
            entryCallback_ = pathCallback;
        }

        private void GenerateComponentNameList()
        {
            buttonList_.Clear();

            for (int i = 0; i < 10; i++)
            {
                HierarchyComponentFile file = new HierarchyComponentFile($"File #{i}", $"component#{i}", null);
                ComponentEntry entry = ComponentEntry.CreateEntry(file, (_) => { }, (_) => { }, true, Color.cyan);
                buttonList_.Add(entry);
            }

            buttonList_.SortAndUpdateVisibleButtons();
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
