﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EatingMonster
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            this.Height = 32 * 22;
            this.Width = 32 * 21;

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            HomeForm.ActiveForm.Hide();

            FrmMain frm = new FrmMain();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
