namespace Simple_Punch_Out_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            boxerHealthBar = new ProgressBar();
            playerHealthBar = new ProgressBar();
            player = new PictureBox();
            boxer = new PictureBox();
            boxerAttackTimer = new System.Windows.Forms.Timer(components);
            BoxerMoveTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxer).BeginInit();
            SuspendLayout();
            // 
            // boxerHealthBar
            // 
            boxerHealthBar.Location = new Point(37, 41);
            boxerHealthBar.Name = "boxerHealthBar";
            boxerHealthBar.Size = new Size(219, 29);
            boxerHealthBar.TabIndex = 0;
            // 
            // playerHealthBar
            // 
            playerHealthBar.Location = new Point(436, 41);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(234, 29);
            playerHealthBar.TabIndex = 1;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.boxer_stand;
            player.Location = new Point(379, 400);
            player.Name = "player";
            player.Size = new Size(61, 153);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // boxer
            // 
            boxer.BackColor = Color.Transparent;
            boxer.Image = Properties.Resources.enemy_stand;
            boxer.Location = new Point(405, 292);
            boxer.Name = "boxer";
            boxer.Size = new Size(77, 185);
            boxer.SizeMode = PictureBoxSizeMode.AutoSize;
            boxer.TabIndex = 3;
            boxer.TabStop = false;
            // 
            // boxerAttackTimer
            // 
            boxerAttackTimer.Enabled = true;
            boxerAttackTimer.Interval = 500;
            boxerAttackTimer.Tick += BoxerAttackTimerEvent;
            // 
            // BoxerMoveTimer
            // 
            BoxerMoveTimer.Enabled = true;
            BoxerMoveTimer.Interval = 20;
            BoxerMoveTimer.Tick += BoxerMoveTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 553);
            Controls.Add(player);
            Controls.Add(playerHealthBar);
            Controls.Add(boxerHealthBar);
            Controls.Add(boxer);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Simple Punch Out Game";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar boxerHealthBar;
        private ProgressBar playerHealthBar;
        private PictureBox player;
        private PictureBox boxer;
        private System.Windows.Forms.Timer boxerAttackTimer;
        private System.Windows.Forms.Timer BoxerMoveTimer;
    }
}