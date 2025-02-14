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

        // Constructor to initialize buttons
        public ButtonManager(Guna2Button[] gunaButtons)
        {
            buttons = gunaButtons;
            checkButton = false; // Default state
            UpdateButtonColor(); // Set initial colors
        }

        // Method to toggle all button colors
        public void ToggleButton()
        {
            checkButton = !checkButton;
            UpdateButtonColor();
        }

        // Update all buttons based on checkButton state
        private void UpdateButtonColor()
        {
            foreach (var btn in buttons)  // ✅ Fix: Loop through all buttons
            {
                btn.FillColor = checkButton ? Color.White : Color.Transparent;
            }
        }

        // Method to set one active button and reset others
        public void SetActiveButton(Guna2Button newButton)
        {
            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent; // Reset all buttons
            }

            activeButton = newButton;
            activeButton.FillColor = Color.White;  // Set active button color
        }
    }
}
