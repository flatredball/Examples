using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Gui;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Microsoft.Xna.Framework;
using System.Reflection;
using FlatRedBall.Forms.Controls;
using FlatRedBall.Forms.Controls.Popups;

namespace NewGum.Screens
{
    public partial class DemoScreen
    {

        void CustomInitialize()
        {
            PopulateListBox();
            PopulateComboBox();
            PopulateTreeView();
            InitializeDialogBoxUi();
            InitializeToastUi();
        }

        private void InitializeToastUi()
        {
            Forms.ShowToastButton.Click += (not, used) =>
            {
                ToastManager.Show($"It is now: {DateTime.Now}", durationInSeconds:2);
            };
        }

        private void InitializeDialogBoxUi()
        {
            Forms.DialogBoxInstance.IsVisible = false;

            List<string> pages = new List<string>
            {
                "This is a dialog box. It's built in to FRB because this is a common control in lots of games",
                "This is the second page of the dialog box. This only shows after the first page.",
                "What?!? A third page? Can you believe it?"
            };


            Forms.ShowDialogButton.Click += (not, used) =>
                Forms.DialogBoxInstance.Show(pages);

        }

        void CustomActivity(bool firstTimeCalled)
        {
            //FlatRedBall.Debugging.Debugger.Write(GuiManager.Cursor.WindowOver);

        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        void PopulateListBox()
        {
            Forms.ResolutionBox.Items.Add("320x240");
            Forms.ResolutionBox.Items.Add("480x360");
            Forms.ResolutionBox.Items.Add("600x800");
            Forms.ResolutionBox.Items.Add("1024x768");

            Forms.DetectResolutionsButton.Click += (not, used) =>
            {
                Forms.ResolutionBox.Items.Add("Some Resolution");
            };
        }

        void PopulateComboBox()
        {
            Forms.ComboBoxInstance.Items.Add("Creative");
            Forms.ComboBoxInstance.Items.Add("Easy");
            Forms.ComboBoxInstance.Items.Add("Medium");
            Forms.ComboBoxInstance.Items.Add("Hard");
            Forms.ComboBoxInstance.Items.Add("Permadeath");
            Forms.ComboBoxInstance.Items.Add("Extreme");
        }

        void PopulateTreeView()
        {
            PopulateTreeViewRecursively(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        void PopulateTreeViewRecursively(string path)
        {
            var treeViewItem = new TreeViewItem();
            treeViewItem.UpdateToObject(Path.GetFileName(path));

            // get dirs
            foreach (var dir in Directory.GetDirectories(path))
            {
                PopulateTreeViewRecursively(dir);
            }

            // get files
            foreach (var file in Directory.GetFiles(path))
            {
                var name = Path.GetFileName(file);
                treeViewItem.Items.Add(name);
            }

            Forms.TreeViewInstance.Items.Add(treeViewItem);
        }
    }
}
