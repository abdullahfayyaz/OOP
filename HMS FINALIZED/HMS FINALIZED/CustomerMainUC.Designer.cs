
namespace HMS_FINALIZED
{
    partial class CustomerMainUC
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
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Login_User_name = new System.Windows.Forms.Label();
            this.AccountButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2PictureBox1;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::HMS_FINALIZED.Properties.Resources.Hotel_booking;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(126, 126);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(633, 585);
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.label1;
            this.guna2DragControl3.TransparentWhileDrag = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(170, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 57);
            this.label1.TabIndex = 14;
            this.label1.Text = "ONLINE HOTEL BOOKING";
            // 
            // Login_User_name
            // 
            this.Login_User_name.AutoSize = true;
            this.Login_User_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_User_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(43)))));
            this.Login_User_name.Location = new System.Drawing.Point(71, 31);
            this.Login_User_name.Name = "Login_User_name";
            this.Login_User_name.Size = new System.Drawing.Size(146, 29);
            this.Login_User_name.TabIndex = 17;
            this.Login_User_name.Text = "User Name";
            // 
            // AccountButton
            // 
            this.AccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AccountButton.FillColor = System.Drawing.Color.White;
            this.AccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AccountButton.ForeColor = System.Drawing.Color.White;
            this.AccountButton.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.AccountButton.HoverState.FillColor = System.Drawing.Color.Purple;
            this.AccountButton.Image = global::HMS_FINALIZED.Properties.Resources.user_6054974;
            this.AccountButton.ImageSize = new System.Drawing.Size(50, 50);
            this.AccountButton.Location = new System.Drawing.Point(14, 17);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(51, 45);
            this.AccountButton.TabIndex = 16;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            this.AccountButton.MouseHover += new System.EventHandler(this.AccountButton_MouseHover);
            // 
            // CustomerMainUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Login_User_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.AccountButton);
            this.Name = "CustomerMainUC";
            this.Size = new System.Drawing.Size(854, 726);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        public System.Windows.Forms.Label Login_User_name;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button AccountButton;
    }
}
