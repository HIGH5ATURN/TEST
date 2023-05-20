﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skedule_v3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
           
           new Announcement().Show();
        }

        private void quizbutton_Click(object sender, EventArgs e)
        {

            this.Hide();

            new Quiz().Show();
        }

        private void Routine_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Routine().Show();
        }
    }
}
