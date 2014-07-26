using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLForm.Libs
{
    // Conway enum for life status
    public enum Status
    {
        Alive,
        Dead
    }

    class TileManager
    {
        // Panel properties
        public Panel gamePanel { get; private set; }
        public Bitmap bmp { get; private set; }

        // Grid properties
        public Tile[,] tileGrid { get; set; }
        public bool gridActive { get; set; }
        public int gridHeight { get; set; }
        public int gridWidth { get; set; }

        // Tile Properties
        public int tileSize { get; set; }
        public int tileMargin { get; set; }
        public SolidBrush tileAliveBrush { get; set; }
        public SolidBrush tileDeadBrush { get; set; }
        public Pen gridPen { get; set; }

        // Conway Properties
        private Status[,] statusGrid { get; set; }
        private int nCount;

        public TileManager(Panel gamePanel)
        {
            // Initialize Panel properties
            this.gamePanel = gamePanel;

            // Initialize tile properties
            tileSize = 25;
            tileMargin = 6;
            tileAliveBrush = new SolidBrush(Color.Orange);
            tileDeadBrush = new SolidBrush(Color.DarkMagenta);
            gridPen = new Pen(Color.Red);

            // Initialize tilemanager properties
            bmp = new Bitmap(gamePanel.Width, gamePanel.Height);
            gridHeight = gamePanel.Height / tileSize;
            gridWidth = gamePanel.Width / tileSize;

            // Initialize grid properties
            tileGrid = new Tile[gridHeight, gridWidth];
            DrawGrid();
        }

        public void DrawGrid()
        {
            if (gridActive == true)
            {
                for (int x = 0; x < tileGrid.GetLength(1); x++)
                {
                    for (int y = 0; y < (tileGrid.GetLength(0)); y++)
                    {
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            Point pt1 = new Point(tileSize * x, 0);
                            Point pt2 = new Point(tileSize * x, bmp.Width);
                            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Disabled for speed boost
                            g.DrawLine(gridPen, pt1, pt2);
                            pt1 = new Point(0, tileSize * y);
                            pt2 = new Point(bmp.Height, tileSize * y);
                            g.DrawLine(gridPen, pt1, pt2);
                        }
                    }
                }
            }
        }

        public void ConwayGOL(bool gridActive)
        {
            // Set tile properties
            Tile aliveTile = new Tile(this, tileAliveBrush, tileSize, tileMargin);
            Tile deadTile = new Tile(this, tileDeadBrush, tileSize, tileMargin * (int)1.5f);

            //if (gridActive != true) // Removed due to visual artifacts left behind while grid is active and tile margin is changed
            //    using (Graphics g = Graphics.FromImage(bmp))
            //    {
            //        g.Clear(Color.Black);
            //    }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
            }


            // Draw grid if called on
            this.gridActive = gridActive;
            DrawGrid();

            // Run Processor
            ProcessStatusGrid();

            // Draw using pregrid
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    switch(statusGrid[x, y])
                    {
                        case Status.Alive:
                            aliveTile.Draw(x, y);
                            break;
                        case Status.Dead:
                            deadTile.Draw(x, y);
                            break;
                    }
                }
            }
        }
            
        public void LoadStatusGrid()
        {
            // Set statusGrid properties
            statusGrid = new Status[gridWidth, gridHeight];

            //Build statusGrid
            Random rand = new Random();
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    statusGrid[x, y] = (Status)rand.Next(0, 2);
                }
            }
        }

        public void ProcessStatusGrid()
        {
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    nCount = 0;

                    try
                    {
                        if (x + 1 < gridWidth)
                            if (statusGrid[x + 1, y] == Status.Alive)
                                nCount++;
                        if (x > 0)
                            if (statusGrid[x - 1, y] == Status.Alive)
                                nCount++;
                        if (y + 1 < gridHeight)
                            if (statusGrid[x, y + 1] == Status.Alive)
                                nCount++;
                        if (y > 0)
                            if (statusGrid[x, y - 1] == Status.Alive)
                                nCount++;
                        if (x + 1 < gridWidth && y > 0)
                            if (statusGrid[x + 1, y - 1] == Status.Alive)
                                nCount++;
                        if (x > 0 && y + 1 < gridHeight)
                            if (statusGrid[x - 1, y + 1] == Status.Alive)
                                nCount++;
                        if (x + 1 < gridWidth && y + 1 < gridHeight)
                            if (statusGrid[x + 1, y + 1] == Status.Alive)
                                nCount++;
                        if (x > 0 && y > 0)
                            if (statusGrid[x - 1, y - 1] == Status.Alive)
                                nCount++;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                    if (nCount < 2 && statusGrid[x, y] == Status.Alive)
                        statusGrid[x, y] = Status.Dead;
                    else if (nCount > 3 && statusGrid[x, y] == Status.Alive)
                        statusGrid[x, y] = Status.Dead;
                    else if (nCount == 3 && statusGrid[x, y] == Status.Dead)
                        statusGrid[x, y] = Status.Alive;
                }

            }
        }
    }
}
