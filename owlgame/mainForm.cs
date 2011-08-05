using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace owlgame
{
    public partial class mainForm : Form
    {
        private gameController controller;
        public mainForm()
        {            
            InitializeComponent();
            buttonback.Enabled = false;
        }

        private void myweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.myweb.Tag != null)
            {
                string url = this.myweb.Tag.ToString();
                System.Diagnostics.Process.Start(url);
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (buttonstart.Text == "ø™ º(&E)")
            {
                gaizi.Hide();
                controller = new gameController(gamewiew);
                buttonback.Enabled = true; 
                gametimer.Enabled = true;
                gamewiew.Invalidate();
                proimg.Invalidate();
                buttonstart.Text = "Õ£÷π(&P)";
                gamewiew.Focus();
            }
            else
            {
                buttonback.Enabled = false;
                gametimer.Enabled = false;
                gaizi.Show();
                buttonstart.Text = "ø™ º(&E)";
                welcomelabel.Text = "ª∂”≠≥¢ ‘”Œœ∑";
                proimg.Invalidate();
                gaizi.Focus();

            }
            
        }

        private void gamewiew_Paint(object sender, PaintEventArgs e)
        {
            if (gametimer.Enabled)
                controller.draw(e);
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            if (controller.down(0) == false)
            {
                controller.putblock();
                controller.clearLine();
                controller.startnext();
                if (controller.fall())
                {
                    gametimer.Enabled = false;
                    gaizi.Show();
                    welcomelabel.Text = "ƒ„ ß∞‹¡À°≠";
                    buttonstart.Enabled = false; ;
                    gaizi.Focus();
                }
                else
                {
                    proimg.Invalidate();
                    gamewiew.Invalidate();
                }
            }                    
            
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            gaizi.Hide();
            controller = new gameController(gamewiew);
            buttonstart.Enabled = true;
            gametimer.Enabled = true;
            gamewiew.Invalidate();
            proimg.Invalidate();
            buttonstart.Text = "Õ£÷π(&P)";
            gamewiew.Focus();
        }

        private void gamewiew_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {           
            switch (e.KeyCode)
            {
                case Keys.Up:
                    controller.transpose();
                    break;
                case Keys.Left:
                    controller.move(false);
                    break;
                case Keys.Right:
                    controller.move(true);
                    break;
                case Keys.Down:
                    controller.down(2);
                    break;
            }           
        }

        private void proimg_Paint(object sender, PaintEventArgs e)
        {
            if(gametimer.Enabled)
                controller.drawwait(proimg, e);
        }

        private void buttonset_Click(object sender, EventArgs e)
        {
            if (gametimer.Enabled)
            {
                gametimer.Enabled = false;
                if ((new gamehelp()).ShowDialog() == DialogResult.OK)
                    gametimer.Enabled = true;
                gamewiew.Focus();
            }
            else
            {
                (new gamehelp()).ShowDialog();
                gaizi.Focus();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            gaizi.Focus();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}