using FlatRedBall.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGum.Forms.UserControls
{
    public class CodeOnlyUserControl : UserControl
    {
        public CodeOnlyUserControl() : base()
        {
            this.Width = 300;
            this.Height = 400;

            this.Visual.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;

            var stackLayout = new StackPanel();
            stackLayout.X = 8;
            stackLayout.Y = 8;
            stackLayout.Width = -16;
            stackLayout.Visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.AddChild(stackLayout);

            var label = new Label();
            label.Text = "This is a form made purely in code";
            label.Width = 0;
            label.Visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            stackLayout.AddChild(label);

            var nameLabel = new Label();
            nameLabel.Y = 5;
            nameLabel.Text = "Enter name:";
            stackLayout.AddChild(nameLabel);

            var textBox = new TextBox();
            textBox.Placeholder = "Name";
            stackLayout.AddChild(textBox);




            var button = new Button();
            button.Text = "OK";
            stackLayout.AddChild(button);
        }
    }
}
