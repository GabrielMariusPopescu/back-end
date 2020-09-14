using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LightSwitch
{
    public partial class LightSwitch : Form
    {
        private const string PATH = @"../../item\";
        private readonly SoundPlayer clickSound = new SoundPlayer(PATH + "shortClick.wav");

        public LightSwitch()
        {
            InitializeComponent();
        }

        private void LightSwitch_Load(object sender, EventArgs e)
        {
            pctBox.Image = Image.FromFile(PATH + "light_off.jpg");
            btnOn.Enabled = true;
            btnOn.BackColor = Color.White;
            btnOff.Enabled = false;
            btnOff.BackColor = Color.Black;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            pctBox.Image = Image.FromFile(PATH + "light_on.jpg");
            btnOn.Enabled = false;
            btnOn.BackColor = Color.Black;
            btnOff.Enabled = true;
            btnOff.BackColor = Color.White;
            clickSound.Play();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            LightSwitch_Load(null, null);
            clickSound.Play();
        }
    }
}
