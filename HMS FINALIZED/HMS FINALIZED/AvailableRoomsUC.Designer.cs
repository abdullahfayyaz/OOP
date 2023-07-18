
namespace HMS_FINALIZED
{
    partial class AvailableRoomsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalRoomsLabel = new System.Windows.Forms.Label();
            this.AvailableRoomsLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(218, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 57);
            this.label1.TabIndex = 35;
            this.label1.Text = "AVAILABLE ROOMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(54, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 40);
            this.label2.TabIndex = 46;
            this.label2.Text = "Total Rooms :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(396, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 40);
            this.label3.TabIndex = 47;
            this.label3.Text = "Available Rooms :";
            // 
            // TotalRoomsLabel
            // 
            this.TotalRoomsLabel.AutoSize = true;
            this.TotalRoomsLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRoomsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(43)))));
            this.TotalRoomsLabel.Location = new System.Drawing.Point(263, 166);
            this.TotalRoomsLabel.Name = "TotalRoomsLabel";
            this.TotalRoomsLabel.Size = new System.Drawing.Size(36, 40);
            this.TotalRoomsLabel.TabIndex = 48;
            this.TotalRoomsLabel.Text = "0";
            // 
            // AvailableRoomsLabel
            // 
            this.AvailableRoomsLabel.AutoSize = true;
            this.AvailableRoomsLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableRoomsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(43)))));
            this.AvailableRoomsLabel.Location = new System.Drawing.Point(660, 166);
            this.AvailableRoomsLabel.Name = "AvailableRoomsLabel";
            this.AvailableRoomsLabel.Size = new System.Drawing.Size(36, 40);
            this.AvailableRoomsLabel.TabIndex = 49;
            this.AvailableRoomsLabel.Text = "0";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::HMS_FINALIZED.Properties.Resources.Futuristic_Style_Bedroom_Designs;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 268);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(744, 393);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 50;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // AvailableRoomsUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.AvailableRoomsLabel);
            this.Controls.Add(this.TotalRoomsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvailableRoomsUC";
            this.Size = new System.Drawing.Size(854, 725);
            this.Load += new System.EventHandler(this.AvailableRoomsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalRoomsLabel;
        private System.Windows.Forms.Label AvailableRoomsLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
