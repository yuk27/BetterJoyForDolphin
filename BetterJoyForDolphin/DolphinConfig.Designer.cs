namespace BetterJoyForDolphin
{
    partial class DolphinConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DolphinConfig));
            this.sensibilityBar = new System.Windows.Forms.TrackBar();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.con1 = new System.Windows.Forms.Button();
            this.ProRadio = new System.Windows.Forms.RadioButton();
            this.LeftRadio = new System.Windows.Forms.RadioButton();
            this.RightRadio = new System.Windows.Forms.RadioButton();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sensibilityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sensibilityBar
            // 
            this.sensibilityBar.Location = new System.Drawing.Point(12, 133);
            this.sensibilityBar.Maximum = 15;
            this.sensibilityBar.Minimum = 1;
            this.sensibilityBar.Name = "sensibilityBar";
            this.sensibilityBar.Size = new System.Drawing.Size(260, 45);
            this.sensibilityBar.TabIndex = 0;
            this.sensibilityBar.Value = 5;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(197, 229);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensibility";
            // 
            // defaultBtn
            // 
            this.defaultBtn.Location = new System.Drawing.Point(12, 229);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(75, 23);
            this.defaultBtn.TabIndex = 4;
            this.defaultBtn.Text = "Set default";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Location = new System.Drawing.Point(16, 202);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(84, 17);
            this.checkBoxX.TabIndex = 5;
            this.checkBoxX.Text = "Invert X axis";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Axis config";
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Location = new System.Drawing.Point(100, 203);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(84, 17);
            this.checkBoxY.TabIndex = 7;
            this.checkBoxY.Text = "Invert Y axis";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.AutoSize = true;
            this.checkBoxZ.Location = new System.Drawing.Point(188, 203);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(84, 17);
            this.checkBoxZ.TabIndex = 8;
            this.checkBoxZ.Text = "Invert Z axis";
            this.checkBoxZ.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Controller type";
            // 
            // con1
            // 
            this.con1.BackgroundImage = global::BetterJoyForDolphin.Properties.Resources.pro;
            this.con1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con1.Enabled = false;
            this.con1.Location = new System.Drawing.Point(49, 31);
            this.con1.Name = "con1";
            this.con1.Size = new System.Drawing.Size(58, 59);
            this.con1.TabIndex = 10;
            this.con1.TabStop = false;
            this.con1.UseVisualStyleBackColor = true;
            // 
            // ProRadio
            // 
            this.ProRadio.AutoSize = true;
            this.ProRadio.Location = new System.Drawing.Point(150, 31);
            this.ProRadio.Name = "ProRadio";
            this.ProRadio.Size = new System.Drawing.Size(88, 17);
            this.ProRadio.TabIndex = 11;
            this.ProRadio.Text = "Pro Controller";
            this.ProRadio.UseVisualStyleBackColor = true;
            this.ProRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LeftRadio
            // 
            this.LeftRadio.AutoSize = true;
            this.LeftRadio.Location = new System.Drawing.Point(150, 55);
            this.LeftRadio.Name = "LeftRadio";
            this.LeftRadio.Size = new System.Drawing.Size(80, 17);
            this.LeftRadio.TabIndex = 12;
            this.LeftRadio.Text = "Left Joycon";
            this.LeftRadio.UseVisualStyleBackColor = true;
            this.LeftRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RightRadio
            // 
            this.RightRadio.AutoSize = true;
            this.RightRadio.Location = new System.Drawing.Point(150, 79);
            this.RightRadio.Name = "RightRadio";
            this.RightRadio.Size = new System.Drawing.Size(87, 17);
            this.RightRadio.TabIndex = 13;
            this.RightRadio.Text = "Right Joycon";
            this.RightRadio.UseVisualStyleBackColor = true;
            this.RightRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.AutoSize = true;
            this.serialNumberLabel.Location = new System.Drawing.Point(185, 9);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.serialNumberLabel.TabIndex = 14;
            this.serialNumberLabel.Text = "serialNumberLabel";
            // 
            // DolphinConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.serialNumberLabel);
            this.Controls.Add(this.RightRadio);
            this.Controls.Add(this.LeftRadio);
            this.Controls.Add(this.ProRadio);
            this.Controls.Add(this.con1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxZ);
            this.Controls.Add(this.checkBoxY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxX);
            this.Controls.Add(this.defaultBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.sensibilityBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DolphinConfig";
            this.Text = "DolphinConfig";
            this.Load += new System.EventHandler(this.DolphinConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sensibilityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sensibilityBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button defaultBtn;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button con1;
        private System.Windows.Forms.RadioButton ProRadio;
        private System.Windows.Forms.RadioButton LeftRadio;
        private System.Windows.Forms.RadioButton RightRadio;
        private System.Windows.Forms.Label serialNumberLabel;
    }
}