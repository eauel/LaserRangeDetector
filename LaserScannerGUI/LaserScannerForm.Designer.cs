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
            this.boxStartAngle = new System.Windows.Forms.Label();
            this.boxEndAngle = new System.Windows.Forms.Label();
            this.textStartAngle = new System.Windows.Forms.NumericUpDown();
            this.textEndAngle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textDistnace = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textStartAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEndAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDistnace)).BeginInit();
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
            this.panel1.Controls.Add(this.textDistnace);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textEndAngle);
            this.panel1.Controls.Add(this.textStartAngle);
            this.panel1.Controls.Add(this.boxEndAngle);
            this.panel1.Controls.Add(this.boxStartAngle);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Off";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonMessageOff);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "On";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonMessageOn);
            // 
            // buttonOffEmail
            // 
            this.buttonOffEmail.Location = new System.Drawing.Point(146, 182);
            this.buttonOffEmail.Name = "buttonOffEmail";
            this.buttonOffEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonOffEmail.TabIndex = 6;
            this.buttonOffEmail.Text = "Off";
            this.buttonOffEmail.UseVisualStyleBackColor = true;
            this.buttonOffEmail.Click += new System.EventHandler(this.buttonEmailOff);
            // 
            // buttonOnEmail
            // 
            this.buttonOnEmail.Location = new System.Drawing.Point(31, 182);
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
            this.labelMessagebox.Location = new System.Drawing.Point(28, 251);
            this.labelMessagebox.Name = "labelMessagebox";
            this.labelMessagebox.Size = new System.Drawing.Size(95, 13);
            this.labelMessagebox.TabIndex = 4;
            this.labelMessagebox.Text = "Message Box Alert";
            // 
            // labelEmailAlert
            // 
            this.labelEmailAlert.AutoSize = true;
            this.labelEmailAlert.Location = new System.Drawing.Point(28, 142);
            this.labelEmailAlert.Name = "labelEmailAlert";
            this.labelEmailAlert.Size = new System.Drawing.Size(59, 13);
            this.labelEmailAlert.TabIndex = 3;
            this.labelEmailAlert.Text = "Email Alert:";
            // 
            // buttonMotorOff
            // 
            this.buttonMotorOff.Location = new System.Drawing.Point(146, 67);
            this.buttonMotorOff.Name = "buttonMotorOff";
            this.buttonMotorOff.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorOff.TabIndex = 2;
            this.buttonMotorOff.Text = "Off";
            this.buttonMotorOff.UseVisualStyleBackColor = true;
            this.buttonMotorOff.Click += new System.EventHandler(this.buttonMotorOff_Click);
            // 
            // buttonMotorOn
            // 
            this.buttonMotorOn.Location = new System.Drawing.Point(31, 67);
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
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(903, 542);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonUpdate);
            // 
            // boxStartAngle
            // 
            this.boxStartAngle.AutoSize = true;
            this.boxStartAngle.Location = new System.Drawing.Point(31, 319);
            this.boxStartAngle.Name = "boxStartAngle";
            this.boxStartAngle.Size = new System.Drawing.Size(59, 13);
            this.boxStartAngle.TabIndex = 11;
            this.boxStartAngle.Text = "Start Angle";
            // 
            // boxEndAngle
            // 
            this.boxEndAngle.AutoSize = true;
            this.boxEndAngle.Location = new System.Drawing.Point(31, 388);
            this.boxEndAngle.Name = "boxEndAngle";
            this.boxEndAngle.Size = new System.Drawing.Size(56, 13);
            this.boxEndAngle.TabIndex = 12;
            this.boxEndAngle.Text = "End Angle";
            // 
            // textStartAngle
            // 
            this.textStartAngle.Location = new System.Drawing.Point(31, 345);
            this.textStartAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.textStartAngle.Name = "textStartAngle";
            this.textStartAngle.Size = new System.Drawing.Size(120, 20);
            this.textStartAngle.TabIndex = 13;
            this.textStartAngle.Value = new decimal(new int[] {
            61,
            0,
            0,
            0});
            // 
            // textEndAngle
            // 
            this.textEndAngle.Location = new System.Drawing.Point(31, 426);
            this.textEndAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.textEndAngle.Name = "textEndAngle";
            this.textEndAngle.Size = new System.Drawing.Size(120, 20);
            this.textEndAngle.TabIndex = 14;
            this.textEndAngle.Value = new decimal(new int[] {
            91,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Distance";
            // 
            // textDistnace
            // 
            this.textDistnace.Location = new System.Drawing.Point(31, 504);
            this.textDistnace.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.textDistnace.Name = "textDistnace";
            this.textDistnace.Size = new System.Drawing.Size(120, 20);
            this.textDistnace.TabIndex = 16;
            this.textDistnace.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
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
            ((System.ComponentModel.ISupportInitialize)(this.textStartAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEndAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDistnace)).EndInit();
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
        private System.Windows.Forms.Label boxEndAngle;
        private System.Windows.Forms.Label boxStartAngle;
        private System.Windows.Forms.NumericUpDown textEndAngle;
        private System.Windows.Forms.NumericUpDown textStartAngle;
        private System.Windows.Forms.NumericUpDown textDistnace;
        private System.Windows.Forms.Label label2;
    }
}

