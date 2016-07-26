using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCCharacters
{
    public partial class firstAppearance : Form
    {
        string imageToDisplay;

        public firstAppearance(string _imageToDisplay)
        {
            InitializeComponent();
            imageToDisplay = _imageToDisplay;
        }

        private void firstAppearance_Load(object sender, EventArgs e)
        {
            
            pcbFirst.ImageLocation = "../../firstappearance/" + imageToDisplay + ".jpg";
        }

        private void firstAppearance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbFirst_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
