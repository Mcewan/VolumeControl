using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeControl
{
    public partial class MainForm : Form
    {
        private readonly Muter _muter;
        public MainForm()
        {
            InitializeComponent();
            _muter =  new Muter(this);
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _muter.Mute();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                _muter.Mute(double.Parse(txtDelaySeconds.Text)*1000);
            }
            catch (FormatException)
            {
                MessageBox.Show("Delay not valid","GIGO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {

            _muter.Unmute();
        }
    }
}
