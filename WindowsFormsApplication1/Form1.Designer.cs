namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.clockCycle = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPaddleY = new System.Windows.Forms.Label();
            this.labelBallX = new System.Windows.Forms.Label();
            this.labelBallY = new System.Windows.Forms.Label();
            this.labelYV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelXV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(13, 34);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(843, 531);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paddle Y = ";
            // 
            // clockCycle
            // 
            this.clockCycle.Enabled = true;
            this.clockCycle.Interval = 33;
            this.clockCycle.Tick += new System.EventHandler(this.clockCycle_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ball X = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ball Y = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "yV = ";
            // 
            // labelPaddleY
            // 
            this.labelPaddleY.AutoSize = true;
            this.labelPaddleY.Location = new System.Drawing.Point(185, 577);
            this.labelPaddleY.Name = "labelPaddleY";
            this.labelPaddleY.Size = new System.Drawing.Size(35, 13);
            this.labelPaddleY.TabIndex = 6;
            this.labelPaddleY.Text = "label5";
            // 
            // labelBallX
            // 
            this.labelBallX.AutoSize = true;
            this.labelBallX.Location = new System.Drawing.Point(281, 577);
            this.labelBallX.Name = "labelBallX";
            this.labelBallX.Size = new System.Drawing.Size(35, 13);
            this.labelBallX.TabIndex = 7;
            this.labelBallX.Text = "label5";
            // 
            // labelBallY
            // 
            this.labelBallY.AutoSize = true;
            this.labelBallY.Location = new System.Drawing.Point(376, 577);
            this.labelBallY.Name = "labelBallY";
            this.labelBallY.Size = new System.Drawing.Size(35, 13);
            this.labelBallY.TabIndex = 8;
            this.labelBallY.Text = "label5";
            // 
            // labelYV
            // 
            this.labelYV.AutoSize = true;
            this.labelYV.Location = new System.Drawing.Point(533, 577);
            this.labelYV.Name = "labelYV";
            this.labelYV.Size = new System.Drawing.Size(35, 13);
            this.labelYV.TabIndex = 9;
            this.labelYV.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "xV = ";
            // 
            // labelXV
            // 
            this.labelXV.AutoSize = true;
            this.labelXV.Location = new System.Drawing.Point(456, 577);
            this.labelXV.Name = "labelXV";
            this.labelXV.Size = new System.Drawing.Size(35, 13);
            this.labelXV.TabIndex = 11;
            this.labelXV.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 599);
            this.Controls.Add(this.labelXV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelYV);
            this.Controls.Add(this.labelBallY);
            this.Controls.Add(this.labelBallX);
            this.Controls.Add(this.labelPaddleY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer clockCycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPaddleY;
        private System.Windows.Forms.Label labelBallX;
        private System.Windows.Forms.Label labelBallY;
        private System.Windows.Forms.Label labelYV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelXV;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

