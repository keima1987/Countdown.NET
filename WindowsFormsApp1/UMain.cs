using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class frmCountdown : Form
    {
        //Global Variable
        int Mode = 0;
        DateTime NewDate;
        List<string> FontFileNames = new List<string>();



        public frmCountdown()
        {
            InitializeComponent();
            
        }

        void UseCustomFont(string name, int size, Label label)
        {

            PrivateFontCollection modernFont = new PrivateFontCollection();

            modernFont.AddFontFile(name);

            label.Font = new Font(modernFont.Families[0], size);


        }

        private void Wait(int time)
        {
            long Start = DateTime.Now.Ticks;
            while (DateTime.Now.Ticks - Start <= time)
            {
                Application.DoEvents();    
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime selected;
            TimeSpan difference; 
            switch (Mode)
            {
                case 0:
                {
                    if (btnStart.Text == "&Start")
                    {
                        selected = bdDateTime.Value;
                        difference = selected - DateTime.Now;
                        if (difference.TotalMilliseconds < 0)
                        {
                            lblCountdown.Text = "Invalid Input";
                            Wait(2000);
                            lblCountdown.Text = "--.--:--:--.---";
                        }
                        else
                        {
                            tmCountdown.Enabled = true;
                            btnStart.Text = "&Stop";
                            bdDateTime.Enabled = false;
                            gbMode.Enabled = false;
                            btnReset.Enabled = false;
                        }

                    }
                    else
                    {
                        btnStart.Text = "&Start";
                        btnReset.Enabled = true;
                        bdDateTime.Enabled = true;
                        tmCountdown.Enabled = false;
                        gbMode.Enabled = true;
                    }
                    break;
                }
                case 1:
                {
                    if (btnStart.Text == "&Start")
                    {
                        selected = DateTime.Now;
                        selected=selected.AddHours((double)speHours.Value);
                        selected=selected.AddMinutes((double)speMin.Value);
                        selected=selected.AddSeconds((double)speSec.Value+1);
                        NewDate = selected;
                        difference = selected - DateTime.Now;
                        if (difference.TotalMilliseconds < 0)
                        {
                            lblCountdown.Text = "Invalid Input";
                            Wait(2000);
                            lblCountdown.Text = "--.--:--:--.---";
                        }
                        else
                        {
                            tmCountdown.Enabled = true;
                            btnStart.Text = "&Stop";
                            speHours.Enabled = false;
                            speMin.Enabled = false;
                            speSec.Enabled = false;
                            gbMode.Enabled = false;
                            btnReset.Enabled = false;
                        }
                    }
                    else
                    {
                        tmCountdown.Enabled = false;
                        btnStart.Text = "&Start";
                        speHours.Enabled = true;
                        speMin.Enabled = true;
                        speSec.Enabled = true;
                        gbMode.Enabled = true;
                        btnReset.Enabled = true;
                    }
                    break;
                }
                case 2:
                {
                        if (btnStart.Text == "&Start")
                        {
                            tmCountdown.Enabled = true;
                            btnStart.Text = "&Stop";
                            gbMode.Enabled = false;
                            btnReset.Enabled = false;
                            bdDateTime.Value = DateTime.Now;
                        }
                        else
                        {
                            tmCountdown.Enabled = false;
                            btnStart.Text = "&Start";
                            gbMode.Enabled = true;
                            btnReset.Enabled = true;
                        }
                        break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCountdown.Text = "--.--:--:--.---";
            bdDateTime.Value = DateTime.Now;
        }

        private void tmCountdown_Tick(object sender, EventArgs e)
        {
            //https://www.dotnetperls.com/timespan
            DateTime selected;
            TimeSpan Countdown;
            int Days = 0;
            int Hours = 0;
            int Min = 0;
            int Sec = 0;
            int Ms = 0;
            string SDays = Days.ToString();
            string SHours = Hours.ToString();
            string SMin = Min.ToString();
            string SSec = Sec.ToString();
            string SMs = Ms.ToString();
            switch (Mode)
            {
                case 0: {
                    selected = bdDateTime.Value;
                    Countdown = selected - DateTime.Now;
                    Days = Countdown.Days;
                    Hours = Countdown.Hours;
                    Min = Countdown.Minutes;
                    Sec = Countdown.Seconds;
                    Ms = Countdown.Milliseconds;
                    SDays = Days.ToString();
                    SHours = Hours.ToString();
                    SMin = Min.ToString();
                    SSec = Sec.ToString();
                    SMs = Ms.ToString();
                    lblCountdown.Text = SDays.PadLeft(2, '0') + "." + SHours.PadLeft(2, '0') + ":" + SMin.PadLeft(2, '0') + ":" + SSec.PadLeft(2, '0') + "." + SMs.PadLeft(3, '0');
                    if (Countdown.TotalSeconds <= 0)
                    {
                        tmCountdown.Enabled = false;
                        lblCountdown.Text = "Time up";
                        btnStart.Text = "&Start";
                        btnReset.Enabled = true;
                        bdDateTime.Enabled = true;
                        gbMode.Enabled = true;
                    }
                    break;
                 }
                case 1: {
                    selected = NewDate;
                    Countdown =  selected - DateTime.Now;
                    Days = Countdown.Days;
                    Hours = Countdown.Hours;
                    Min = Countdown.Minutes;
                    Sec = Countdown.Seconds;
                    Ms = Countdown.Milliseconds;
                    SDays = Days.ToString();
                    SHours = Hours.ToString();
                    SMin = Min.ToString();
                    SSec = Sec.ToString();
                    SMs = Ms.ToString();
                    lblCountdown.Text = SDays.PadLeft(2, '0') + "." + SHours.PadLeft(2, '0') + ":" + SMin.PadLeft(2, '0') + ":" + SSec.PadLeft(2, '0') + "." + SMs.PadLeft(3, '0');
                    if (Countdown.TotalSeconds <= 0)
                    {
                        tmCountdown.Enabled = false;
                        lblCountdown.Text = "Time up";
                        btnStart.Text = "&Start";
                        btnReset.Enabled = true;
                        speHours.Enabled = true;
                        speMin.Enabled = true;
                        speSec.Enabled = true;
                        gbMode.Enabled = true;
                    }
                    break;
                }
                case 2: {
                    selected = bdDateTime.Value;
                    Countdown = selected - DateTime.Now;
                    Days = Countdown.Days * -1;
                    Hours = Countdown.Hours * -1;
                    Min = Countdown.Minutes * -1;
                    Sec = Countdown.Seconds * -1;
                    Ms = Countdown.Milliseconds * -1;
                        SDays = Days.ToString();
                        SHours = Hours.ToString();
                        SMin = Min.ToString();
                        SSec = Sec.ToString();
                        SMs = Ms.ToString();
                        lblCountdown.Text = SDays.PadLeft(2, '0') + "." + SHours.PadLeft(2, '0') + ":" + SMin.PadLeft(2, '0') + ":" + SSec.PadLeft(2, '0') + "." + SMs.PadLeft(3, '0');
                        break;
                }
            }
        }

        private void rbCountdownD_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 0;
            speHours.Enabled = false;
            speMin.Enabled = false;
            speSec.Enabled = false;
            bdDateTime.Enabled = true;
            lblCountdown.Text = "--.--:--:--.---";
        }

        private void rbCountdownT_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 1;
            speHours.Enabled = true;
            speMin.Enabled = true;
            speSec.Enabled = true;
            bdDateTime.Enabled = false;
            lblCountdown.Text = "--.--:--:--.---";
        }

        private void rbCounter_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 2;
            speHours.Enabled = false;
            speMin.Enabled = false;
            speSec.Enabled = false;
            bdDateTime.Enabled = false;
            lblCountdown.Text = "--.--:--:--.---";
        }

        private void speMin_ValueChanged(object sender, EventArgs e)
        {
            if (speMin.Value > 59)
            {
                speHours.Value++;
                speMin.Value = 0;
            }
        }

        private void speSec_ValueChanged(object sender, EventArgs e)
        {
            if (speSec.Value > 59)
            {
                speMin.Value++;
                speSec.Value = 0;
            }
        }

        private void frmCountdown_Load(object sender, EventArgs e)
        {
            bdDateTime.Value = DateTime.Now;
            LoadFonts();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FontFileName = "fonts\\" + FontFileNames[cbFonts.SelectedIndex];
            // "fonts\\"+cbFonts.SelectedItem.ToString()
            UseCustomFont(FontFileName, 35, lblCountdown);
        }

        public void LoadFonts()
        {
            DirectoryInfo d = new DirectoryInfo("fonts\\");//Assuming Test is your Folder
            //TTF Font Files
            FileInfo[] Files = d.GetFiles("*.ttf"); //Getting Text files
            string str = "";
            int I = 0;
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                FontFileNames.Add(str);
                PrivateFontCollection modernFont = new PrivateFontCollection();

                modernFont.AddFontFile("fonts\\"+str);
                cbFonts.Items.Add(modernFont.Families[0].Name);
                I++;
            }
        }
    }
}
