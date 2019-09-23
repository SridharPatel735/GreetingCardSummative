using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
/// <summary>
/// Created By Sridhar
/// September 2019
/// Summative birthday card with display of skills which include draw audio and animation
/// </summary>

namespace GreetingCardSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Song
            SoundPlayer happySound = new SoundPlayer(Properties.Resources.Happy);
            happySound.Play();

            //Draw tools
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Lucida Handwriting", 50);
            Pen ribbonPen = new Pen(Color.Red, 5);
            Pen balloonPen = new Pen(Color.Black, 5);
            SolidBrush titleBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            SolidBrush balloonBrush = new SolidBrush(Color.LightSkyBlue);

            //Title and background
            g.Clear(Color.LightYellow);
            g.DrawString("Happy Birthday", titleFont, titleBrush, 20, 50);

            //Present
            g.FillRectangle(goldBrush, 250, 300, 200, 200);
            g.FillRectangle(redBrush, 250, 380, 200, 20);
            g.FillRectangle(redBrush, 340, 300, 20, 200);
            g.RotateTransform(20);
            g.DrawEllipse(ribbonPen, 420, 99, 30, 60);
            g.ResetTransform();
            g.RotateTransform(340);
            g.DrawEllipse(ribbonPen, 210, 340, 30, 60);
            g.ResetTransform();

            //Balloons animation
            for (int i = 470; i >= -410; i = i - 15)
            {
                g.Clear(Color.LightYellow);
                g.DrawString("Happy Birthday", titleFont, titleBrush, 20, 50);

                g.FillRectangle(goldBrush, 250, 300, 200, 200);
                g.FillRectangle(redBrush, 250, 380, 200, 20);
                g.FillRectangle(redBrush, 340, 300, 20, 200);
                g.RotateTransform(20);
                g.DrawEllipse(ribbonPen, 420, 99, 30, 60);
                g.ResetTransform();
                g.RotateTransform(340);
                g.DrawEllipse(ribbonPen, 210, 340, 30, 60);
                g.ResetTransform();

                g.FillEllipse(balloonBrush, 130, i, 90, 130);
                g.FillEllipse(balloonBrush, 475, i, 90, 130);

                g.DrawLine(balloonPen, 175, (i + 130), 175, (i + 330));
                g.DrawLine(balloonPen, 525, (i + 130), 525, (i + 330));
                Thread.Sleep(100);
            }
            happySound.Stop();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Draw tools
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Liberty BT", 50);
            SolidBrush titleBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            SolidBrush cakeBrush = new SolidBrush(Color.Brown);

            g.Clear(Color.LightBlue);

            //Title
            g.DrawString("Hope You Have A", titleFont, titleBrush, 20, 20);
            Thread.Sleep(750);
            g.DrawString("Joyous Year", titleFont, titleBrush, 20, 70);
            Thread.Sleep(750);

            //Present
            g.FillRectangle(goldBrush, 250, 300, 200, 200);
            g.FillRectangle(redBrush, 250, 380, 200, 20);
            g.FillRectangle(redBrush, 340, 300, 20, 200);

            //Cake
            g.FillRectangle(cakeBrush, 275, 205, 150, 75);
        }
    }
}
