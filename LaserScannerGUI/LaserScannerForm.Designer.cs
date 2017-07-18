namespace LaserScannerGUI
{
    partial class LaserScannerForm
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonOffEmail = new System.Windows.Forms.Button();
            this.buttonOnEmail = new System.Windows.Forms.Button();
            this.labelMessagebox = new System.Windows.Forms.Label();
            this.labelEmailAlert = new System.Windows.Forms.Label();
            this.buttonMotorOff = new System.Windows.Forms.Button();
            this.buttonMotorOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(398, 0);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(1082, 883);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonOffEmail);
            this.panel1.Controls.Add(this.buttonOnEmail);
            this.panel1.Controls.Add(this.labelMessagebox);
            this.panel1.Controls.Add(this.labelEmailAlert);
            this.panel1.Controls.Add(this.buttonMotorOff);
            this.panel1.Controls.Add(this.buttonMotorOn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 883);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 766);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Off";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonMessageOff);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 766);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "On";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonMessageOn);
            // 
            // buttonOffEmail
            // 
            this.buttonOffEmail.Location = new System.Drawing.Point(219, 468);
            this.buttonOffEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOffEmail.Name = "buttonOffEmail";
            this.buttonOffEmail.Size = new System.Drawing.Size(112, 35);
            this.buttonOffEmail.TabIndex = 6;
            this.buttonOffEmail.Text = "Off";
            this.buttonOffEmail.UseVisualStyleBackColor = true;
            this.buttonOffEmail.Click += new System.EventHandler(this.buttonEmailOff);
            // 
            // buttonOnEmail
            // 
            this.buttonOnEmail.Location = new System.Drawing.Point(46, 468);
            this.buttonOnEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOnEmail.Name = "buttonOnEmail";
            this.buttonOnEmail.Size = new System.Drawing.Size(112, 35);
            this.buttonOnEmail.TabIndex = 5;
            this.buttonOnEmail.Text = "On";
            this.buttonOnEmail.UseVisualStyleBackColor = true;
            this.buttonOnEmail.Click += new System.EventHandler(this.buttonEmailOn);
            // 
            // labelMessagebox
            // 
            this.labelMessagebox.AutoSize = true;
            this.labelMessagebox.Location = new System.Drawing.Point(42, 680);
            this.labelMessagebox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessagebox.Name = "labelMessagebox";
            this.labelMessagebox.Size = new System.Drawing.Size(142, 20);
            this.labelMessagebox.TabIndex = 4;
            this.labelMessagebox.Text = "Message Box Alert";
            // 
            // labelEmailAlert
            // 
            this.labelEmailAlert.AutoSize = true;
            this.labelEmailAlert.Location = new System.Drawing.Point(42, 372);
            this.labelEmailAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailAlert.Name = "labelEmailAlert";
            this.labelEmailAlert.Size = new System.Drawing.Size(89, 20);
            this.labelEmailAlert.TabIndex = 3;
            this.labelEmailAlert.Text = "Email Alert:";
            // 
            // buttonMotorOff
            // 
            this.buttonMotorOff.Location = new System.Drawing.Point(219, 158);
            this.buttonMotorOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMotorOff.Name = "buttonMotorOff";
            this.buttonMotorOff.Size = new System.Drawing.Size(112, 35);
            this.buttonMotorOff.TabIndex = 2;
            this.buttonMotorOff.Text = "Off";
            this.buttonMotorOff.UseVisualStyleBackColor = true;
            this.buttonMotorOff.Click += new System.EventHandler(this.buttonMotorOff_Click);
            // 
            // buttonMotorOn
            // 
            this.buttonMotorOn.Location = new System.Drawing.Point(46, 158);
            this.buttonMotorOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMotorOn.Name = "buttonMotorOn";
            this.buttonMotorOn.Size = new System.Drawing.Size(112, 35);
            this.buttonMotorOn.TabIndex = 1;
            this.buttonMotorOn.Text = "On";
            this.buttonMotorOn.UseVisualStyleBackColor = true;
            this.buttonMotorOn.Click += new System.EventHandler(this.buttonMotorOn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motor:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(1355, 834);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 2;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonUpdate);
            // 
            // LaserScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 883);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LaserScannerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LaserScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMotorOff;
        private System.Windows.Forms.Button buttonMotorOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmailAlert;
        private System.Windows.Forms.Button buttonOnEmail;
        private System.Windows.Forms.Label labelMessagebox;
        private System.Windows.Forms.Button buttonOffEmail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

