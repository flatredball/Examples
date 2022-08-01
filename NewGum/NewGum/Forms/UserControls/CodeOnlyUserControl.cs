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

            var stackPanel = new StackPanel();
            stackPanel.X = 8;
            stackPanel.Y = 8;
            stackPanel.Width = -16;
            stackPanel.Visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            this.AddChild(stackPanel);

            var label = new Label();
            label.Text = "This is a form made purely in code";
            label.Width = 0;
            label.Visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
            stackPanel.AddChild(label);

            AddTextBoxWithLabel("Name");
            AddTextBoxWithLabel("Age");
            AddTextBoxWithLabel("Address");
            AddTextBoxWithLabel("Something Else");

            AddCheckBox("Checkbox Option 1");
            AddCheckBox("Checkbox Option 2");
            AddCheckBox("Checkbox Option 3");
            AddCheckBox("Checkbox Option 4");

            var groupBox = new StackPanel();
            stackPanel.AddChild(groupBox);

            AddRadioButton("Radio Button Option 1");
            AddRadioButton("Radio Button Option 2");
            AddRadioButton("Radio Button Option 3");
            AddRadioButton("Radio Button Option 4");
            AddRadioButton("Radio Button Option 5");

            for (int i = 0; i < 5; i++)
            {
                var button = new Button();
                button.Text = "Button " + i;
                stackPanel.AddChild(button);

            }

            void AddTextBoxWithLabel(string labelText)
            {
                var nameLabel = new Label();
                nameLabel.Y = 5;
                nameLabel.Text = labelText;
                stackPanel.AddChild(nameLabel);

                var textBox = new TextBox();
                //textBox.Placeholder = "Name";
                stackPanel.AddChild(textBox);
            }

            void AddCheckBox(string text)
            {
                var checkBox = new CheckBox();
                checkBox.Text = text;
                stackPanel.AddChild(checkBox);
            }

            void AddRadioButton(string text)
            {
                var radioButton = new RadioButton();
                radioButton.Text = text;
                radioButton.Width = 200;
                stackPanel.AddChild(radioButton);
            }
        }

    }
}
