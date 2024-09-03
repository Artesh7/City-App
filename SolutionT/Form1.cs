using System;
using System.Windows.Forms;
using NAudio.Wave; // This namespace includes classes like WaveOut and AudioFileReader

namespace TankS
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private double count = 0.0;
        private int buttonPressCount = 0;
        private int preciseHitCount = 0;
        private bool justHitPrecise = false;
        private System.Windows.Forms.Timer timer1;
        private Timer delayTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            InitializeAudio();
        }

        private void InitializeAudio()
        {
            try
            {
                // Set the path to your M4A file
                audioFileReader = new AudioFileReader(@"C:\Users\artes\OneDrive - ViaUC\Repos\City-App\SolutionT\Stemme 022.m4a");
                waveOutDevice = new WaveOut();  // You can experiment with different output devices here
                waveOutDevice.Init(audioFileReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audio file: " + ex.Message);
            }
        }

        private void InitializeCustomComponents()
        {
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);

            delayTimer = new Timer();
            delayTimer.Interval = 333;
            delayTimer.Tick += DelayTimer_Tick;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (justHitPrecise)
            {
                ResetGame();
                justHitPrecise = false;
            }
            delayTimer.Start();
            buttonPressCount++;
            AntalTryk.Text = $"Antal Tryk: {buttonPressCount}\nPræcise hits: {preciseHitCount}";

            if (waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Stop();
            }
            audioFileReader.Position = 0;  // Reset the audio file to the beginning
            waveOutDevice.Play();
        }


        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            delayTimer.Stop();
            timer1.Stop();
            waveOutDevice.Stop();

            if (Math.Abs(count - 100.00) < 0.01)
            {
                preciseHitCount++;
                AntalTryk.Text = $"Antal Tryk: {buttonPressCount}, Præcise hits: {preciseHitCount}";
                justHitPrecise = true;
            }
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            count = 0.0;
            label1.Text = "0.00";
            timer1.Stop();
            audioFileReader.Position = 0;  // Reset audio position to the start
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 111)
            {
                count += 0.25;
                label1.Text = count.ToString("N2");
            }
            else
            {
                timer1.Stop();
                if (count > 111)
                {
                    count = 111;
                    label1.Text = count.ToString("N2");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
            }
        }

        private void AntalTryk_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
