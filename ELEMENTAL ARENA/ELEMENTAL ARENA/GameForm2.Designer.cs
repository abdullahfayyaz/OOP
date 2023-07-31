
namespace ELEMENTAL_ARENA
{
    partial class GameForm2
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
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.Bullet = new System.Windows.Forms.Timer(this.components);
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MagicBallLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 135;
            this.Gametimer.Tick += new System.EventHandler(this.Gametimer_Tick);
            // 
            // Bullet
            // 
            this.Bullet.Enabled = true;
            this.Bullet.Interval = 70;
            this.Bullet.Tick += new System.EventHandler(this.Bullet_Tick);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.KeyLabel.Location = new System.Drawing.Point(1682, 141);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(40, 40);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(1569, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "KEY :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(1569, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "SCORE :";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ScoreLabel.Location = new System.Drawing.Point(1758, 100);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(40, 40);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell Extra Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(1569, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "MAGIC BALL :";
            // 
            // MagicBallLabel
            // 
            this.MagicBallLabel.AutoSize = true;
            this.MagicBallLabel.BackColor = System.Drawing.Color.Transparent;
            this.MagicBallLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicBallLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.MagicBallLabel.Location = new System.Drawing.Point(1872, 60);
            this.MagicBallLabel.Name = "MagicBallLabel";
            this.MagicBallLabel.Size = new System.Drawing.Size(40, 40);
            this.MagicBallLabel.TabIndex = 9;
            this.MagicBallLabel.Text = "0";
            // 
            // GameForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELEMENTAL_ARENA.Properties.Resources.Level2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 650);
            this.Controls.Add(this.MagicBallLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm2_FormClosing);
            this.Load += new System.EventHandler(this.GameForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.Timer Bullet;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MagicBallLabel;
    }
}