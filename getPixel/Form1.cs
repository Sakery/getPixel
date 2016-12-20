using getPixel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getPixel
{
    public partial class Form1 : Form
    {
        #region Mouseclick
            // mouseclick
            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

            private const int MOUSEEVENTF_LEFTDOWN = 0x02;
            private const int MOUSEEVENTF_LEFTUP = 0x04;
            private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
            private const int MOUSEEVENTF_RIGHTUP = 0x10;

            public void DoMouseClick()
            {
                //Call the imported function with the cursor's current position
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        #endregion



        static int halfWidth = Screen.PrimaryScreen.Bounds.Width / 2;
        static int halfHeight = Screen.PrimaryScreen.Bounds.Height / 2;
        Bitmap bitmap = new Bitmap(1, 1);
        Point centerPoint = new Point(halfWidth, halfHeight);
        Point centerPointLeft = new Point(halfWidth-1, halfHeight);
        Point centerPointRight = new Point(halfWidth+1, halfHeight);
        Point centerPointTop = new Point(halfWidth, halfHeight-1);
        Point centerPointBottom = new Point(halfWidth, halfHeight+1);
        Point defaultCoordinates = new Point(0, 0);
        Size sizePixel = new Size(1, 1);
        Size sizeWindowDefault = new Size(440, 100);
        Size sizeWindowOptions = new Size(720, 220);
        bool active = false;
        bool option = false;
        int countFps = 0;
        int nbTry = 0;
        int nbTryMax = 3;
        Color pixel;

        // occurs pixel color
        private Color GetCenterPixel(Point from)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(from, defaultCoordinates, sizePixel);
            }
            return bitmap.GetPixel(0, 0);
        }

        private bool ColorInRange(byte c, char type)
        {
            if (type == 'r')
                return (c >= nupdo_redmin.Value && c <= nupdo_redmax.Value);
            else if (type == 'g')
                return (c >= nupdo_greenmin.Value && c <= nupdo_greenmax.Value);
            else
                return (c >= nupdo_bluemin.Value && c <= nupdo_bluemax.Value);
        }

        public Form1()
        {
            InitializeComponent();
        }

        // enable cheat
        private void btn_activer_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active)
            {
                this.Text = "Cheat: ON";
                btn_activer.Text = "Disable";
                btn_activer.BackColor = Color.DarkSalmon;
            }
            else
            {
                this.Text = "Cheat: OFF";
                btn_activer.Text = "Activate";
                btn_activer.BackColor = Color.PaleGreen;
            }
        }

        // expect cheat
        private void timer1_Tick(object sender, EventArgs e)
        {
            nbTry = 0;
            
            while (nbTry < nbTryMax)
            {
                switch (nbTry)
                {
                    case 1: pixel = GetCenterPixel(centerPointLeft); break;
                    case 2: pixel = GetCenterPixel(centerPointRight); break;
                    case 3: pixel = GetCenterPixel(centerPointTop); break;
                    case 4: pixel = GetCenterPixel(centerPointBottom); break;
                    default: //case 0
                        pixel = GetCenterPixel(centerPoint);
                        lbl_couleur.Text = "R=" + pixel.R.ToString() + " G=" + pixel.G.ToString() + " B=" + pixel.B.ToString();
                        break;
                }

                if (active && ColorInRange(pixel.R, 'r') && ColorInRange(pixel.G, 'g') && ColorInRange(pixel.B, 'b'))
                {
                    DoMouseClick();
                    break;
                }

                nbTry++;
            }
            
            countFps++;

            /* old method
            uint rouge = centerPixel.R;
            uint vert = centerPixel.G;
            uint bleu = centerPixel.B;

            bool red = rouge >= nupdo_redmin.Value && rouge <= nupdo_redmax.Value;
            bool green = vert >= nupdo_greenmin.Value && vert <= nupdo_greenmax.Value;
            bool blue = bleu >= nupdo_bluemin.Value && bleu <= nupdo_bluemax.Value;


            if (active && red && green && blue)
            {
                DoMouseClick();
                //this.BackColor = new Color
            }*/
        }

        // Control Opacity
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {   
            //lbl_trackbar.Text = trackBar1.Value + "%";
            this.Opacity = (double)trackBar1.Value * 0.01;
            if (this.Opacity < 0.10)
            {
                this.Opacity = 0.10;
                trackBar1.Value = 10;
            }
        }

        // open close Setting
        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (!option) 
            {
                this.MinimumSize = sizeWindowOptions;
                this.MaximumSize = sizeWindowOptions;
                //btn_setting.Text = "Options <<";
                option = true;
            }
            else
            {
                this.MinimumSize = sizeWindowDefault;
                this.MaximumSize = sizeWindowDefault;
                //btn_setting.Text = "Options >>";
                option = false;
            }
        }

        // Load Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = sizeWindowDefault;
            this.MaximumSize = sizeWindowDefault;

            //fill combobox
            cbx_mode.DisplayMember = "Text";
            cbx_mode.ValueMember = "Value";
            var items = new[] {
                new { Text = "1 Pixel", Value = "1p" },
                new { Text = "3 Pixels", Value = "3p" },
                new { Text = "5 Pixels", Value = "5p" }
            };
            cbx_mode.DataSource = items;
            cbx_mode.SelectedValue = "3p";

            //load resource image
            img_preset.Image = (Bitmap)Resources.ResourceManager.GetObject("preset_blue"); ;
        }

        // Calc FPS
        private void nupdo_fps_ValueChanged(object sender, EventArgs e)
        {
            //timer1.Interval = 1000 / (int)nupdo_fps.Value;
        }

        private void timer_fpscount_Tick(object sender, EventArgs e)
        {
            lb_count.Text = countFps.ToString();
            countFps = 0;
        }

        private void cbx_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_mode.SelectedValue.ToString() == "5p")
                nbTryMax = 5;
            else if (cbx_mode.SelectedValue.ToString() == "3p")
                nbTryMax = 3;
            else
                nbTryMax = 1;
        }
    }
}
