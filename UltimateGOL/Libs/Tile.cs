using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RLForm.Libs;

namespace RLForm.Libs
{
    class Tile
    {
        TileManager tileManager { get; set; }
        public Point tilePoint { get; set; }
        public Brush tileBrush { get; set; }
        public int tileSize { get; set; }
        public int tileMargin { get; set; }

        public Tile(TileManager tileManager, Brush tileBrush, int tileSize, int tileMargin)
        {
            this.tileManager = tileManager;
            this.tileBrush = tileBrush;
            this.tileSize = tileSize;
            this.tileMargin = tileMargin;
        }

        public void Draw(int tileX, int tileY)
        {
            // Set the tile location
            tilePoint = new Point(tileX, tileY);

            using (Graphics g = Graphics.FromImage(tileManager.bmp))
            {
                //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Disabled for speed boost
                g.FillRectangle(
                    tileBrush,                                  // Tile Color
                    (tileSize * tileX) + (tileMargin / 2),      // X coord
                    (tileSize * tileY) + (tileMargin / 2),      // Y coord 
                    tileSize - tileMargin,                      // X Size
                    tileSize - tileMargin);                     // Y Size
                
            }
        }
    }
}
