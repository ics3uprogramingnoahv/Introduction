/*
 * Created by: Noah Voroney
 * Created on: 05-feb-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays Hello World but with an exit menu
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldMenuNoahV
{
    public partial class frmHelloWorldMenu : Form
    {
        public frmHelloWorldMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progarmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
