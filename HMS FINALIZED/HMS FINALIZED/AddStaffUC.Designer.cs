
namespace HMS_FINALIZED
{
    partial class AddStaffUC
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
            this.label3 = new System.Windows.Forms.Label();
            this.TextCityComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextCNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextOccupationComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddStaffGradientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(186, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 57);
            this.label3.TabIndex = 45;
            this.label3.Text = "ADD STAFF MEMBER";
            // 
            // TextCityComboBox1
            // 
            this.TextCityComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextCityComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TextCityComboBox1.BorderRadius = 8;
            this.TextCityComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TextCityComboBox1.DropDownHeight = 100;
            this.TextCityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextCityComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.TextCityComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCityComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCityComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextCityComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.TextCityComboBox1.IntegralHeight = false;
            this.TextCityComboBox1.ItemHeight = 30;
            this.TextCityComboBox1.Items.AddRange(new object[] {
            "Select City",
            "Lahore",
            "Karachi",
            "Islamabad",
            "Peshawar",
            "Multan",
            "Faisalabad",
            "Gujranwala",
            "Rawalpindi",
            "Quetta",
            "Bahawalpur",
            "Hyderabad",
            "Sialkot",
            "Sargodha",
            "Larkana",
            "Sahiwal",
            "Sheikhupura",
            "Okara",
            "Kasur",
            "Dera Ghazi Khan",
            "Jhelum",
            "Hafizabad",
            "Sukkur",
            "Bahawalnagar",
            "Nawabshah"});
            this.TextCityComboBox1.Location = new System.Drawing.Point(458, 352);
            this.TextCityComboBox1.MaxDropDownItems = 5;
            this.TextCityComboBox1.Name = "TextCityComboBox1";
            this.TextCityComboBox1.Size = new System.Drawing.Size(312, 36);
            this.TextCityComboBox1.StartIndex = 0;
            this.TextCityComboBox1.TabIndex = 69;
            this.TextCityComboBox1.SelectedIndexChanged += new System.EventHandler(this.TextCityComboBox1_SelectedIndexChanged);
            // 
            // TextContact
            // 
            this.TextContact.Animated = true;
            this.TextContact.BorderRadius = 8;
            this.TextContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextContact.DefaultText = "";
            this.TextContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.TextContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextContact.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TextContact.ForeColor = System.Drawing.Color.DimGray;
            this.TextContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextContact.Location = new System.Drawing.Point(50, 352);
            this.TextContact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextContact.Name = "TextContact";
            this.TextContact.PasswordChar = '\0';
            this.TextContact.PlaceholderText = "+92";
            this.TextContact.SelectedText = "";
            this.TextContact.Size = new System.Drawing.Size(312, 42);
            this.TextContact.TabIndex = 68;
            this.TextContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextContact_KeyPress);
            this.TextContact.MouseLeave += new System.EventHandler(this.TextContact_MouseLeave);
            // 
            // TextCNIC
            // 
            this.TextCNIC.Animated = true;
            this.TextCNIC.BorderRadius = 8;
            this.TextCNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCNIC.DefaultText = "";
            this.TextCNIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextCNIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextCNIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCNIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCNIC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.TextCNIC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCNIC.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TextCNIC.ForeColor = System.Drawing.Color.DimGray;
            this.TextCNIC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCNIC.Location = new System.Drawing.Point(458, 196);
            this.TextCNIC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextCNIC.Name = "TextCNIC";
            this.TextCNIC.PasswordChar = '\0';
            this.TextCNIC.PlaceholderText = "xxxxx-xxxxxxx-x";
            this.TextCNIC.SelectedText = "";
            this.TextCNIC.Size = new System.Drawing.Size(312, 42);
            this.TextCNIC.TabIndex = 67;
            this.TextCNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCNIC_KeyPress);
            this.TextCNIC.MouseLeave += new System.EventHandler(this.TextCNIC_MouseLeave);
            // 
            // TextName
            // 
            this.TextName.Animated = true;
            this.TextName.BorderRadius = 8;
            this.TextName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextName.DefaultText = "";
            this.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TextName.ForeColor = System.Drawing.Color.DimGray;
            this.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.Location = new System.Drawing.Point(50, 196);
            this.TextName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PlaceholderText = "John";
            this.TextName.SelectedText = "";
            this.TextName.Size = new System.Drawing.Size(312, 42);
            this.TextName.TabIndex = 66;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            this.TextName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextName_KeyPress);
            this.TextName.MouseLeave += new System.EventHandler(this.TextName_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label8.Location = new System.Drawing.Point(453, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 65;
            this.label8.Text = "CNIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label7.Location = new System.Drawing.Point(45, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 64;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label6.Location = new System.Drawing.Point(453, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(45, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "Occupation";
            // 
            // TextOccupationComboBox1
            // 
            this.TextOccupationComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextOccupationComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TextOccupationComboBox1.BorderRadius = 8;
            this.TextOccupationComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TextOccupationComboBox1.DropDownHeight = 100;
            this.TextOccupationComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextOccupationComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.TextOccupationComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextOccupationComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextOccupationComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextOccupationComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.TextOccupationComboBox1.IntegralHeight = false;
            this.TextOccupationComboBox1.ItemHeight = 30;
            this.TextOccupationComboBox1.Items.AddRange(new object[] {
            "Select an option",
            "Hotel Receptionist",
            "Operation Manager",
            "Security Manager",
            "Hotel Porter",
            "Room Attendant"});
            this.TextOccupationComboBox1.Location = new System.Drawing.Point(50, 493);
            this.TextOccupationComboBox1.MaxDropDownItems = 5;
            this.TextOccupationComboBox1.Name = "TextOccupationComboBox1";
            this.TextOccupationComboBox1.Size = new System.Drawing.Size(312, 36);
            this.TextOccupationComboBox1.StartIndex = 0;
            this.TextOccupationComboBox1.TabIndex = 71;
            this.TextOccupationComboBox1.SelectedIndexChanged += new System.EventHandler(this.TextOccupationComboBox1_SelectedIndexChanged);
            // 
            // AddStaffGradientButton
            // 
            this.AddStaffGradientButton.Animated = true;
            this.AddStaffGradientButton.AutoRoundedCorners = true;
            this.AddStaffGradientButton.BorderRadius = 24;
            this.AddStaffGradientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStaffGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddStaffGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddStaffGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddStaffGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddStaffGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddStaffGradientButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(142)))));
            this.AddStaffGradientButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(43)))));
            this.AddStaffGradientButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStaffGradientButton.ForeColor = System.Drawing.Color.White;
            this.AddStaffGradientButton.Location = new System.Drawing.Point(506, 597);
            this.AddStaffGradientButton.Name = "AddStaffGradientButton";
            this.AddStaffGradientButton.Size = new System.Drawing.Size(244, 50);
            this.AddStaffGradientButton.TabIndex = 72;
            this.AddStaffGradientButton.Text = "ADD";
            this.AddStaffGradientButton.Click += new System.EventHandler(this.AddStaffGradientButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // AddStaffUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddStaffGradientButton);
            this.Controls.Add(this.TextOccupationComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextCityComboBox1);
            this.Controls.Add(this.TextContact);
            this.Controls.Add(this.TextCNIC);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "AddStaffUC";
            this.Size = new System.Drawing.Size(854, 725);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox TextCityComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextContact;
        private Guna.UI2.WinForms.Guna2TextBox TextCNIC;
        private Guna.UI2.WinForms.Guna2TextBox TextName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox TextOccupationComboBox1;
        private Guna.UI2.WinForms.Guna2GradientButton AddStaffGradientButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
