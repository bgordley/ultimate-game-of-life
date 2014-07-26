using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using RLForm.Libs;

namespace RLForm
{
    public partial class Form1 : Form
    {
        TileManager tileManager;
        Graphics g;
        Thread drawThread;
        bool exitThread;
        int FPS;

        public Form1()
        {
            InitializeComponent();

            // Create the drawThread
            drawThread = new Thread(DrawBmp);

            // Initialize graphics
            g = GamePanel.CreateGraphics();

            // Initialize bool switches
            exitThread = false;

            // Initialize tile manager
            tileManager = new TileManager(GamePanel);

            // Initialize FPS and Margin
            FPS = 1000 / trackBarFPS.Value;
            trackBarMargin.Maximum = tileManager.tileSize / 2;
            tileManager.tileMargin = trackBarMargin.Value;

            // Initialize color panels and 
            panelAliveColor.BackColor = tileManager.tileAliveBrush.Color;
            panelDeadColor.BackColor = tileManager.tileDeadBrush.Color;
            panelGridColor.BackColor = tileManager.gridPen.Color;
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GamePanel_Click(object sender, EventArgs e)
        {
            if (drawThread.IsAlive)
            {
                tileManager.LoadStatusGrid();
            }
        }

        private void DrawBmp()
        {
            bool drawGrid;

            tileManager = new TileManager(GamePanel);
            tileManager.LoadStatusGrid();

            while (!exitThread)
            {
                if (showGridBox.CheckState == CheckState.Checked)
                    drawGrid = true;
                else
                    drawGrid = false;

                tileManager.ConwayGOL(drawGrid);
                g.DrawImage(tileManager.bmp, new Point(0, 0));
                Thread.Sleep(FPS);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If thread is paused, unpause to exit properly
            if (drawThread.ThreadState == ThreadState.Suspended)
                drawThread.Resume();
            // Kill the while loop in the thread method to join properly
            exitThread = true;
            // Join the thread
            if (drawThread.IsAlive)
                drawThread.Join();
        }

        private void showGridBox_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!drawThread.IsAlive)
                drawThread.Start();
            else if (drawThread.ThreadState == ThreadState.Suspended)
                drawThread.Resume();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (drawThread.IsAlive)
                drawThread.Suspend();
        }

        private void panelAliveColor_Click(object sender, EventArgs e)
        {
            if (drawThread.IsAlive)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    tileManager.tileAliveBrush.Color = colorDialog.Color;
                    panelAliveColor.BackColor = tileManager.tileAliveBrush.Color;
                }
            }
        }

        private void panelDeadColor_Click(object sender, EventArgs e)
        {
            if (drawThread.IsAlive)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    tileManager.tileDeadBrush.Color = colorDialog.Color;
                    panelDeadColor.BackColor = tileManager.tileDeadBrush.Color;
                }
            }
        }

        private void panelGridColor_Click(object sender, EventArgs e)
        {
            if (drawThread.IsAlive)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    tileManager.gridPen.Color = colorDialog.Color;
                    panelGridColor.BackColor = tileManager.gridPen.Color;
                }
            }
        }

        private void trackBarFPS_ValueChanged(object sender, EventArgs e)
        {
            FPS = 1000 / trackBarFPS.Value;
        }

        private void trackBarMargin_ValueChanged(object sender, EventArgs e)
        {
            tileManager.tileMargin = trackBarMargin.Value;
        }
    }
}
