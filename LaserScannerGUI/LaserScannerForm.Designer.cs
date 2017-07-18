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
            this.buttonOnEmail = new System.Windows.Forms.Button();
            this.labelMessagebox = new System.Windows.Forms.Label();
            this.labelEmailAlert = new System.Windows.Forms.Label();
            this.buttonMotorOff = new System.Windows.Forms.Button();
            this.buttonMotorOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOffEmail = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(265, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(722, 574);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 574);
            this.panel1.TabIndex = 1;
            // 
            // buttonOnEmail
            // 
            this.buttonOnEmail.Location = new System.Drawing.Point(31, 304);
            this.buttonOnEmail.Name = "buttonOnEmail";
            this.buttonOnEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonOnEmail.TabIndex = 5;
            this.buttonOnEmail.Text = "On";
            this.buttonOnEmail.UseVisualStyleBackColor = true;
            this.buttonOnEmail.Click += new System.EventHandler(this.buttonEmailOn);
            // 
            // labelMessagebox
            // 
            this.labelMessagebox.AutoSize = true;
            this.labelMessagebox.Location = new System.Drawing.Point(28, 442);
            this.labelMessagebox.Name = "labelMessagebox";
            this.labelMessagebox.Size = new System.Drawing.Size(95, 13);
            this.labelMessagebox.TabIndex = 4;
            this.labelMessagebox.Text = "Message Box Alert";
            // 
            // labelEmailAlert
            // 
            this.labelEmailAlert.AutoSize = true;
            this.labelEmailAlert.Location = new System.Drawing.Point(28, 242);
            this.labelEmailAlert.Name = "labelEmailAlert";
            this.labelEmailAlert.Size = new System.Drawing.Size(59, 13);
            this.labelEmailAlert.TabIndex = 3;
            this.labelEmailAlert.Text = "Email Alert:";
            // 
            // buttonMotorOff
            // 
            this.buttonMotorOff.Location = new System.Drawing.Point(146, 103);
            this.buttonMotorOff.Name = "buttonMotorOff";
            this.buttonMotorOff.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorOff.TabIndex = 2;
            this.buttonMotorOff.Text = "Off";
            this.buttonMotorOff.UseVisualStyleBackColor = true;
            this.buttonMotorOff.Click += new System.EventHandler(this.buttonMotorOff_Click);
            // 
            // buttonMotorOn
            // 
            this.buttonMotorOn.Location = new System.Drawing.Point(31, 103);
            this.buttonMotorOn.Name = "buttonMotorOn";
            this.buttonMotorOn.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorOn.TabIndex = 1;
            this.buttonMotorOn.Text = "On";
            this.buttonMotorOn.UseVisualStyleBackColor = true;
            this.buttonMotorOn.Click += new System.EventHandler(this.buttonMotorOn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motor:";
            // 
            // buttonOffEmail
            // 
            this.buttonOffEmail.Location = new System.Drawing.Point(146, 304);
            this.buttonOffEmail.Name = "buttonOffEmail";
            this.buttonOffEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonOffEmail.TabIndex = 6;
            this.buttonOffEmail.Text = "Off";
            this.buttonOffEmail.UseVisualStyleBackColor = true;
            this.buttonOffEmail.Click += new System.EventHandler(this.buttonEmailOff);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "On";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonMessageOn);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 498);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Off";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonMessageOff);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(861, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonUpdate);
            // 
            // LaserScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 574);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.panel1);
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

