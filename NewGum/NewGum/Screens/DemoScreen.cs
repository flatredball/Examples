using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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



namespace NewGum.Screens
{
    public partial class DemoScreen
    {

        void CustomInitialize()
        {
            Forms.ResolutionBox.Items.Add("320x240");
            Forms.ResolutionBox.Items.Add("480x360");
            Forms.ResolutionBox.Items.Add("600x800");
            Forms.ResolutionBox.Items.Add("1024x768");

            Forms.DetectResolutionsButton.Click += (not, used) =>
            {
                Forms.ResolutionBox.Items.Add("Some Resolution");
            };

            Forms.ComboBoxInstance.Items.Add("Creative");
            Forms.ComboBoxInstance.Items.Add("Easy");
            Forms.ComboBoxInstance.Items.Add("Medium");
            Forms.ComboBoxInstance.Items.Add("Hard");
            Forms.ComboBoxInstance.Items.Add("Permadeath");
            Forms.ComboBoxInstance.Items.Add("Extreme");
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

    }
}
