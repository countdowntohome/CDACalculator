namespace CDACalculator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GroundSpeedInput = new System.Windows.Forms.TextBox();
            this.TrackMileageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroundSpeedLabel = new System.Windows.Forms.Label();
            this.AltitudeLabel = new System.Windows.Forms.Label();
            this.TrackMileageInput = new System.Windows.Forms.TextBox();
            this.AltitudeInput = new System.Windows.Forms.TextBox();
            this.ElevationInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.RequiredRateLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroundSpeedInput
            // 
            this.GroundSpeedInput.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroundSpeedInput.Location = new System.Drawing.Point(360, 48);
            this.GroundSpeedInput.Name = "GroundSpeedInput";
            this.GroundSpeedInput.ShortcutsEnabled = false;
            this.GroundSpeedInput.Size = new System.Drawing.Size(176, 32);
            this.GroundSpeedInput.TabIndex = 1;
            this.GroundSpeedInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly);
            // 
            // TrackMileageLabel
            // 
            this.TrackMileageLabel.AutoSize = true;
            this.TrackMileageLabel.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackMileageLabel.Location = new System.Drawing.Point(92, 16);
            this.TrackMileageLabel.Name = "TrackMileageLabel";
            this.TrackMileageLabel.Size = new System.Drawing.Size(257, 24);
            this.TrackMileageLabel.TabIndex = 1;
            this.TrackMileageLabel.Text = "Track Mileage (nm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threshold Elevation (ft):";
            // 
            // GroundSpeedLabel
            // 
            this.GroundSpeedLabel.AutoSize = true;
            this.GroundSpeedLabel.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroundSpeedLabel.Location = new System.Drawing.Point(105, 56);
            this.GroundSpeedLabel.Name = "GroundSpeedLabel";
            this.GroundSpeedLabel.Size = new System.Drawing.Size(244, 24);
            this.GroundSpeedLabel.TabIndex = 3;
            this.GroundSpeedLabel.Text = "Groundspeed (kts):";
            // 
            // AltitudeLabel
            // 
            this.AltitudeLabel.AutoSize = true;
            this.AltitudeLabel.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeLabel.Location = new System.Drawing.Point(157, 96);
            this.AltitudeLabel.Name = "AltitudeLabel";
            this.AltitudeLabel.Size = new System.Drawing.Size(192, 24);
            this.AltitudeLabel.TabIndex = 4;
            this.AltitudeLabel.Text = "Altitude (ft):";
            // 
            // TrackMileageInput
            // 
            this.TrackMileageInput.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackMileageInput.Location = new System.Drawing.Point(360, 8);
            this.TrackMileageInput.Name = "TrackMileageInput";
            this.TrackMileageInput.ShortcutsEnabled = false;
            this.TrackMileageInput.Size = new System.Drawing.Size(176, 32);
            this.TrackMileageInput.TabIndex = 0;
            this.TrackMileageInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly);
            // 
            // AltitudeInput
            // 
            this.AltitudeInput.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeInput.Location = new System.Drawing.Point(360, 88);
            this.AltitudeInput.Name = "AltitudeInput";
            this.AltitudeInput.ShortcutsEnabled = false;
            this.AltitudeInput.Size = new System.Drawing.Size(176, 32);
            this.AltitudeInput.TabIndex = 2;
            this.AltitudeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly);
            // 
            // ElevationInput
            // 
            this.ElevationInput.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevationInput.Location = new System.Drawing.Point(360, 128);
            this.ElevationInput.Name = "ElevationInput";
            this.ElevationInput.ShortcutsEnabled = false;
            this.ElevationInput.Size = new System.Drawing.Size(176, 32);
            this.ElevationInput.TabIndex = 3;
            this.ElevationInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(360, 168);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(176, 32);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // RequiredRateLabel
            // 
            this.RequiredRateLabel.AutoSize = true;
            this.RequiredRateLabel.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiredRateLabel.Location = new System.Drawing.Point(16, 172);
            this.RequiredRateLabel.Name = "RequiredRateLabel";
            this.RequiredRateLabel.Size = new System.Drawing.Size(257, 24);
            this.RequiredRateLabel.TabIndex = 9;
            this.RequiredRateLabel.Text = "Descent Rate (fpm):";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.Red;
            this.OutputLabel.Location = new System.Drawing.Point(288, 172);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 24);
            this.OutputLabel.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(546, 210);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.RequiredRateLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ElevationInput);
            this.Controls.Add(this.AltitudeInput);
            this.Controls.Add(this.TrackMileageInput);
            this.Controls.Add(this.AltitudeLabel);
            this.Controls.Add(this.GroundSpeedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackMileageLabel);
            this.Controls.Add(this.GroundSpeedInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Continuous Descent Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GroundSpeedInput;
        private System.Windows.Forms.Label TrackMileageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GroundSpeedLabel;
        private System.Windows.Forms.Label AltitudeLabel;
        private System.Windows.Forms.TextBox TrackMileageInput;
        private System.Windows.Forms.TextBox AltitudeInput;
        private System.Windows.Forms.TextBox ElevationInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label RequiredRateLabel;
        private System.Windows.Forms.Label OutputLabel;
    }
}

