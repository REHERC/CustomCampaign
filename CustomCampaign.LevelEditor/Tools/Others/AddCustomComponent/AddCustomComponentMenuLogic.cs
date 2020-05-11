#pragma warning disable RCS1213, RCS1225, CA1034, IDE0051, CA1822
using CustomCampaign.LevelEditor.Data;
using System;
using System.Linq;
using System.Collections.Generic;
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
        public static HierarchyComponentFolder Root = new HierarchyComponentFolder("//Root", null)
        {
            Entries = new List<HierarchyComponentData>()
            {
                new HierarchyComponentFolder("Secret Folder", null),
                new HierarchyComponentFolder("Default Components", null),
                new HierarchyComponentFile("Lamp", "component.generic.lamp"),
                new HierarchyComponentFile("Chair", "component.generic.chair"),
                new HierarchyComponentFile("Sloth", "component.epic.speed"),
                new HierarchyComponentFile("Crab", "component.skuttling.crustacean"),
                new HierarchyComponentFile("H", "h.h.h")
            }
        };

        private void OnEnable()
        {
            GenerateComponentNameList();
        }

        public void CloseWindow()
        {
            G.Sys.MenuPanelManager_.Pop(true);
        }

        public void ConfirmInput()
        {
            // BRUH
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
            okButton.onClick = (_) => ConfirmInput();
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

            CreateButtons(Root);

            buttonList_.SortAndUpdateVisibleButtons();
        }

        private void CreateButtons(HierarchyComponentFolder folder)
        {
            int sortIndex = 1;
            int sortLength = (folder.Entries.Count + sortIndex).ToString().Length;

            var subfolders = (from entry in folder.Entries where entry is HierarchyComponentFolder select entry).ToList();
            var files = (from entry in folder.Entries where entry is HierarchyComponentFile select entry).ToList();

            subfolders.Sort((x, y) => string.Compare(x.Name, y.Name));
            files.Sort((x, y) => string.Compare(x.Name, y.Name));

            CreateEntries(subfolders, Colors.GreenColors.lime);
            CreateEntries(files, Colors.white);

            void CreateEntries(List<HierarchyComponentData> entries, Color color)
            {
                foreach (var entry in entries)
                {
                    string sort = sortIndex.ToString();
                    while (sort.Length < sortLength)
                    {
                        sort = $"0{sort}";
                    }

                    ComponentEntry componentEntry = ComponentEntry.CreateEntry(entry, ClickOnEntry, DoubleClickOnEntry, true, color);
                    componentEntry.sortString_ = sort;
                    buttonList_.Add(componentEntry);

                    ++sortIndex;
                }
            }
        }

        public void SetLevelPathInput(string name)
        {
            levelPathInput_.Value_ = name;
        }

        public void ClickOnEntry(UIExButtonContainer.Entry e)
        {
            ComponentEntry entry = e as ComponentEntry;
            SetLevelPathInput(entry.item_.Path);
        }

        public void DoubleClickOnEntry(UIExButtonContainer.Entry e)
        {
            ClickOnEntry(e);
            ConfirmInput();
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
                string name = item.Name;
                if (item is HierarchyComponentFolder)
                {
                    name = $"/{name}";
                }
                return new ComponentEntry(string.Empty, name, onClick, onDoubleClick, buttonIsClickable, item, color);
            }
        }
    }
}
