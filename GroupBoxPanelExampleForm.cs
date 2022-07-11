﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxPanelExample
{
    public partial class GroupBoxPanelExampleForm : Form
    {
        public GroupBoxPanelExampleForm()
        {
            InitializeComponent();
        }

        private void hiButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi pressed";  // Change text in messageLabel
        }

        private void byeButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Bye pressed";  // Change text in messageLabel
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Left pressed";  // Change text in messageLabel
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Right pressed";  // Change text in messageLabel
        }
    }
}
