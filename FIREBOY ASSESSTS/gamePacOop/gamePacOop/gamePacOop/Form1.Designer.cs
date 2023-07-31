
namespace gamePacOop
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.scoreLbl = new System.Windows.Forms.Label();
            this.liveLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoEllipsis = true;
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Cinzel Decorative", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Location = new System.Drawing.Point(12, 4);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(61, 18);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score: ";
            // 
            // liveLbl
            // 
            this.liveLbl.AutoEllipsis = true;
            this.liveLbl.AutoSize = true;
            this.liveLbl.Font = new System.Drawing.Font("Cinzel Decorative", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveLbl.ForeColor = System.Drawing.Color.Transparent;
            this.liveLbl.Location = new System.Drawing.Point(184, 4);
            this.liveLbl.Name = "liveLbl";
            this.liveLbl.Size = new System.Drawing.Size(44, 18);
            this.liveLbl.TabIndex = 1;
            this.liveLbl.Text = "Lives";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liveLbl);
            this.Controls.Add(this.scoreLbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label liveLbl;
    }
}

