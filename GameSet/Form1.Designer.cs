namespace GameSet
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureReload = new System.Windows.Forms.PictureBox();
            this.pictureSpin = new System.Windows.Forms.PictureBox();
            this.pictureShoot = new System.Windows.Forms.PictureBox();
            this.pictureAway = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(42, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Shoot Away Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(605, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Shoot Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(599, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Spin Your Gun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reload Gun";
            // 
            // pictureReload
            // 
            this.pictureReload.Image = global::GameSet.Properties.Resources.ReloadButton;
            this.pictureReload.Location = new System.Drawing.Point(45, 259);
            this.pictureReload.Margin = new System.Windows.Forms.Padding(2);
            this.pictureReload.Name = "pictureReload";
            this.pictureReload.Size = new System.Drawing.Size(67, 53);
            this.pictureReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureReload.TabIndex = 11;
            this.pictureReload.TabStop = false;
            this.pictureReload.Click += new System.EventHandler(this.pictureReload_Click_1);
            // 
            // pictureSpin
            // 
            this.pictureSpin.Image = global::GameSet.Properties.Resources.SpinButton;
            this.pictureSpin.Location = new System.Drawing.Point(607, 70);
            this.pictureSpin.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSpin.Name = "pictureSpin";
            this.pictureSpin.Size = new System.Drawing.Size(67, 53);
            this.pictureSpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpin.TabIndex = 10;
            this.pictureSpin.TabStop = false;
            this.pictureSpin.Click += new System.EventHandler(this.pictureSpin_Click_1);
            // 
            // pictureShoot
            // 
            this.pictureShoot.Image = global::GameSet.Properties.Resources.FireButton;
            this.pictureShoot.Location = new System.Drawing.Point(608, 259);
            this.pictureShoot.Margin = new System.Windows.Forms.Padding(2);
            this.pictureShoot.Name = "pictureShoot";
            this.pictureShoot.Size = new System.Drawing.Size(67, 53);
            this.pictureShoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShoot.TabIndex = 9;
            this.pictureShoot.TabStop = false;
            this.pictureShoot.Click += new System.EventHandler(this.pictureShoot_Click_1);
            // 
            // pictureAway
            // 
            this.pictureAway.Image = global::GameSet.Properties.Resources.Away;
            this.pictureAway.Location = new System.Drawing.Point(60, 84);
            this.pictureAway.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAway.Name = "pictureAway";
            this.pictureAway.Size = new System.Drawing.Size(54, 39);
            this.pictureAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAway.TabIndex = 8;
            this.pictureAway.TabStop = false;
            this.pictureAway.Click += new System.EventHandler(this.pictureAway_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameSet.Properties.Resources.BGGame;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureReload);
            this.Controls.Add(this.pictureSpin);
            this.Controls.Add(this.pictureShoot);
            this.Controls.Add(this.pictureAway);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureReload;
        private System.Windows.Forms.PictureBox pictureSpin;
        private System.Windows.Forms.PictureBox pictureShoot;
        private System.Windows.Forms.PictureBox pictureAway;
    }
}

