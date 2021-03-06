﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDACalculator
{
    public partial class MainWindow : Form
    {
        public int trackMileage, groundspeed, altitude, elevation;
        public TextBox[] inputs;
        public string descentRateString;
        public double timeToTouchdown, descentRate;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            inputs = new TextBox[] { TrackMileageInput, GroundSpeedInput, AltitudeInput, ElevationInput};

            try
            {

                foreach (TextBox input in inputs)
                {
                    if (IsEmpty(input))
                    {
                        throw new IndexOutOfRangeException();
                    }
                }

                trackMileage = Convert.ToInt32(TrackMileageInput.Text);
                groundspeed = Convert.ToInt32(GroundSpeedInput.Text);
                altitude = Convert.ToInt32(AltitudeInput.Text);
                elevation = Convert.ToInt32(ElevationInput.Text);

                descentRateString =  CalculateDescentRate(trackMileage, groundspeed, altitude, elevation);

                if(descentRateString.Length < 1 || descentRateString.Length > 4)
                {
                    throw new IndexOutOfRangeException();
                }

                OutputLabel.Text = descentRateString;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, please check your values and try again", "Error!", MessageBoxButtons.OK);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsEmpty(TextBox box)
        {
            return box.Text.Length == 0;
        }

        private void DigitsOnly(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }

        }

        private string CalculateDescentRate(int _trackMileage, int _groundSpeed, int _altitude, int _elevation)
        {
            timeToTouchdown = ((double)_trackMileage / (double)_groundSpeed) * 60.0;
            descentRate = (_altitude - _elevation) / timeToTouchdown;
            return Math.Round(descentRate).ToString();
        }
    }
}
