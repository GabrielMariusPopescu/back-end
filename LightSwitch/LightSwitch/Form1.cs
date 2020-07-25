using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LightSwitch
{
    public partial class LightSwitch : Form
    {
        private const string Path = @"C:\Users\GabyM\Documents\Visual Studio 2015\Projects\back-end-code\LightSwitch\LightSwitch\item\";
        private readonly SoundPlayer _clickSound = new SoundPlayer(Path + "shortClick.wav");

        public LightSwitch()
        {
            InitializeComponent();
        }

        private void LightSwitch_Load(object sender, EventArgs e)
        {
            pctBox.Image = Image.FromFile(Path + "light_off.jpg");
            btnOn.Enabled = true;
            btnOn.BackColor = Color.White;
            btnOff.Enabled = false;
            btnOff.BackColor = Color.Black;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            pctBox.Image = Image.FromFile(Path + "light_on.jpg");
            btnOn.Enabled = false;
            btnOn.BackColor = Color.Black;
            btnOff.Enabled = true;
            btnOff.BackColor = Color.White;
            _clickSound.Play();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            LightSwitch_Load(null, null);
            _clickSound.Play();
        }
    }
}
