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
            Pen candlePen = new Pen(Color.Red, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            SolidBrush cakeBrush = new SolidBrush(Color.Brown);
            SolidBrush cakeBrush2 = new SolidBrush(Color.LightBlue);

            g.Clear(Color.White);
            g.DrawImage(Properties.Resources.polkadots, 0, 0);

            //Title
            g.DrawString("Hope You Have A", titleFont, redBrush, 20, 20);
            Thread.Sleep(750);
            g.DrawString("Joyous Year", titleFont, redBrush, 20, 70);
            Thread.Sleep(750);

            //Present
            g.FillRectangle(goldBrush, 250, 300, 200, 200);
            g.FillRectangle(redBrush, 250, 380, 200, 20);
            g.FillRectangle(redBrush, 340, 300, 20, 200);

            //Sound
            SoundPlayer yaySound = new SoundPlayer(Properties.Resources.Yay);
            yaySound.Play();

            //Candle
            g.FillEllipse(goldBrush, 340, 165, 5, 15);
            g.FillRectangle(redBrush, 340, 175, 5, 40);
            g.FillEllipse(goldBrush, 360, 165, 5, 10);
            g.DrawLine(candlePen, 350, 175, 370, 175);
            g.DrawLine(candlePen, 370, 175, 350, 205);

            //Cake
            g.FillRectangle(cakeBrush, 275, 205, 150, 75);
            g.FillRectangle(cakeBrush2, 275, 205, 150, 25);
            g.FillEllipse(cakeBrush, 270, 225, 10, 55);
            g.FillEllipse(cakeBrush, 420, 225, 10, 55);
            g.FillEllipse(cakeBrush2, 275, 195, 150, 20);
            g.FillEllipse(cakeBrush2, 275, 195, 150, 20);
            g.FillEllipse(cakeBrush2, 270, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 280, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 290, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 300, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 310, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 320, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 330, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 340, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 350, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 360, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 370, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 380, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 390, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 400, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 410, 205, 10, 30);
            g.FillEllipse(cakeBrush2, 420, 205, 10, 30);
        }
    }
}
