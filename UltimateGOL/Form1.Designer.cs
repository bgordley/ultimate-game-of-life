namespace RLForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GamePanel = new System.Windows.Forms.Panel();
            this.showGridBox = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAliveColor = new System.Windows.Forms.Panel();
            this.panelDeadColor = new System.Windows.Forms.Panel();
            this.panelGridColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarFPS = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarMargin = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMargin)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Black;
            this.GamePanel.Location = new System.Drawing.Point(12, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(500, 500);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Click += new System.EventHandler(this.GamePanel_Click);
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // showGridBox
            // 
            this.showGridBox.AutoSize = true;
            this.showGridBox.Location = new System.Drawing.Point(519, 13);
            this.showGridBox.Name = "showGridBox";
            this.showGridBox.Size = new System.Drawing.Size(75, 17);
            this.showGridBox.TabIndex = 1;
            this.showGridBox.Text = "Show Grid";
            this.showGridBox.UseVisualStyleBackColor = false;
            this.showGridBox.CheckStateChanged += new System.EventHandler(this.showGridBox_CheckStateChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(519, 36);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(71, 19);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(519, 59);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(71, 19);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(522, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dead Cells";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(522, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Live Cells";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAliveColor
            // 
            this.panelAliveColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAliveColor.Location = new System.Drawing.Point(522, 118);
            this.panelAliveColor.Name = "panelAliveColor";
            this.panelAliveColor.Size = new System.Drawing.Size(64, 19);
            this.panelAliveColor.TabIndex = 4;
            this.panelAliveColor.Click += new System.EventHandler(this.panelAliveColor_Click);
            // 
            // panelDeadColor
            // 
            this.panelDeadColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeadColor.Location = new System.Drawing.Point(522, 160);
            this.panelDeadColor.Name = "panelDeadColor";
            this.panelDeadColor.Size = new System.Drawing.Size(64, 19);
            this.panelDeadColor.TabIndex = 5;
            this.panelDeadColor.Click += new System.EventHandler(this.panelDeadColor_Click);
            // 
            // panelGridColor
            // 
            this.panelGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridColor.Location = new System.Drawing.Point(522, 202);
            this.panelGridColor.Name = "panelGridColor";
            this.panelGridColor.Size = new System.Drawing.Size(64, 19);
            this.panelGridColor.TabIndex = 6;
            this.panelGridColor.Click += new System.EventHandler(this.panelGridColor_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(522, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grid";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarFPS
            // 
            this.trackBarFPS.Location = new System.Drawing.Point(522, 261);
            this.trackBarFPS.Maximum = 15;
            this.trackBarFPS.Minimum = 1;
            this.trackBarFPS.Name = "trackBarFPS";
            this.trackBarFPS.Size = new System.Drawing.Size(64, 45);
            this.trackBarFPS.TabIndex = 7;
            this.trackBarFPS.TickFrequency = 5;
            this.trackBarFPS.Value = 15;
            this.trackBarFPS.ValueChanged += new System.EventHandler(this.trackBarFPS_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(522, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "FPS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(522, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tile Margin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarMargin
            // 
            this.trackBarMargin.Location = new System.Drawing.Point(522, 329);
            this.trackBarMargin.Name = "trackBarMargin";
            this.trackBarMargin.Size = new System.Drawing.Size(64, 45);
            this.trackBarMargin.TabIndex = 8;
            this.trackBarMargin.TickFrequency = 5;
            this.trackBarMargin.Value = 4;
            this.trackBarMargin.ValueChanged += new System.EventHandler(this.trackBarMargin_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 531);
            this.Controls.Add(this.trackBarMargin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarFPS);
            this.Controls.Add(this.panelGridColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelDeadColor);
            this.Controls.Add(this.panelAliveColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.showGridBox);
            this.Controls.Add(this.GamePanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 570);
            this.MinimumSize = new System.Drawing.Size(614, 570);
            this.Name = "Form1";
            this.Text = "UltimateGOL - Bryan Gordley";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMargin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.CheckBox showGridBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAliveColor;
        private System.Windows.Forms.Panel panelDeadColor;
        private System.Windows.Forms.Panel panelGridColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarFPS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarMargin;
    }
}

