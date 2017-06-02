namespace HMS
{
    partial class Welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.alabel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arrb3 = new Telerik.WinControls.UI.RadRepeatButton();
            this.arrb2 = new Telerik.WinControls.UI.RadRepeatButton();
            this.arrb1 = new Telerik.WinControls.UI.RadRepeatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.arrb3);
            this.panel1.Controls.Add(this.arrb2);
            this.panel1.Controls.Add(this.arrb1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.alabel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 71);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.alabel1.AutoSize = true;
            this.alabel1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alabel1.Location = new System.Drawing.Point(64, 20);
            this.alabel1.Name = "label1";
            this.alabel1.Size = new System.Drawing.Size(75, 23);
            this.alabel1.TabIndex = 2;
            this.alabel1.Text = "NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 71);
            this.panel2.TabIndex = 1;
            // 
            // rrb3
            // 
            this.arrb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.arrb3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrb3.ForeColor = System.Drawing.Color.White;
            this.arrb3.Image = global::HMS.Properties.Resources.Hopstarter_Button_Button_Close;
            this.arrb3.Location = new System.Drawing.Point(0, 143);
            this.arrb3.Name = "rrb3";
            this.arrb3.Size = new System.Drawing.Size(183, 34);
            this.arrb3.TabIndex = 3;
            this.arrb3.Text = "E&xit";
            this.arrb3.Click += new System.EventHandler(this.rrb3_Click);
            // 
            // rrb2
            // 
            this.arrb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.arrb2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrb2.ForeColor = System.Drawing.Color.White;
            this.arrb2.Image = global::HMS.Properties.Resources.Iconshow_Medical_Patients;
            this.arrb2.Location = new System.Drawing.Point(0, 110);
            this.arrb2.Name = "rrb2";
            this.arrb2.Size = new System.Drawing.Size(183, 34);
            this.arrb2.TabIndex = 3;
            this.arrb2.Text = "&Patient";
            // 
            // rrb1
            // 
            this.arrb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.arrb1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrb1.ForeColor = System.Drawing.Color.White;
            this.arrb1.Image = global::HMS.Properties.Resources.Mini_Dashboard;
            this.arrb1.Location = new System.Drawing.Point(0, 77);
            this.arrb1.Name = "rrb1";
            this.arrb1.Size = new System.Drawing.Size(183, 34);
            this.arrb1.TabIndex = 2;
            this.arrb1.Text = "&Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.health;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadRepeatButton rrb1;
        private Telerik.WinControls.UI.RadRepeatButton rrb3;
        private Telerik.WinControls.UI.RadRepeatButton rrb2;
    }
}