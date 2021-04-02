namespace Hospital_Management_System
{
    partial class Welcome_Page
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DctBut = new System.Windows.Forms.Button();
            this.PatBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(181, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "WELCOME TO S.S.L. HOSPITAL ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Continue as ......";
            // 
            // DctBut
            // 
            this.DctBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DctBut.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DctBut.Location = new System.Drawing.Point(201, 90);
            this.DctBut.Name = "DctBut";
            this.DctBut.Size = new System.Drawing.Size(144, 49);
            this.DctBut.TabIndex = 5;
            this.DctBut.Text = "A Doctor";
            this.DctBut.UseVisualStyleBackColor = false;
            this.DctBut.Click += new System.EventHandler(this.Click_Doctor);
            // 
            // PatBut
            // 
            this.PatBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PatBut.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PatBut.Location = new System.Drawing.Point(550, 90);
            this.PatBut.Name = "PatBut";
            this.PatBut.Size = new System.Drawing.Size(126, 49);
            this.PatBut.TabIndex = 6;
            this.PatBut.Text = "A Patient";
            this.PatBut.UseVisualStyleBackColor = false;
            this.PatBut.Click += new System.EventHandler(this.Click_Patient);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click_Exit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "About Us";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click_About);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Contact Us";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Click_cont);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources.SSL;
            this.pictureBox1.Location = new System.Drawing.Point(108, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 633);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 833);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatBut);
            this.Controls.Add(this.DctBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome_Page";
            this.Text = "Welcome Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DctBut;
        private System.Windows.Forms.Button PatBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

