using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    internal class ButtonManager
    {
        private bool checkButton;
        private Guna2Button[] buttons;
        private Guna2Button activeButton;

        
        public ButtonManager(Guna2Button[] gunaButtons)
        {
            buttons = gunaButtons;
            checkButton = false;
            UpdateButtonColor(); 
        }

        public void ToggleButton()
        {
            checkButton = !checkButton;
            UpdateButtonColor();
        }

        
        private void UpdateButtonColor()
        {
            foreach (var btn in buttons)  
            {
                btn.FillColor = checkButton ? Color.White : Color.Transparent;
            }
        }

        
        public void SetActiveButton(Guna2Button newButton)
        {
            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent; 
            }

            activeButton = newButton;
            activeButton.FillColor = Color.White;
        }
    }
}
