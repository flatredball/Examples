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
    public partial class KeyboardScreen
    {

        void CustomInitialize()
        {
            this.Forms.KeyboardInstance.AssociatedTextBox = this.Forms.TextBoxInstance;
            this.Forms.TextBoxInstance.IsCaretVisibleWhenNotFocused = true;
        }

        void CustomActivity(bool firstTimeCalled)
        {


        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

    }
}
