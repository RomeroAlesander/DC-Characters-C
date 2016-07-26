using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace DCCharacters
{
    public partial class RandomPic : Form
    {
        string imageToDisplay;
        int a = 0;

        public RandomPic(string _imageToDisplay)
        {
            InitializeComponent();
            imageToDisplay = _imageToDisplay;
        }



        private void RandomPic_Load(object sender, EventArgs e)
        {
            var rand = new Random();
            var files = Directory.GetFiles("../../randpics/" + imageToDisplay + "/", "*.jpg");
            //RandPicture.ImageLocation = files[rand.Next(files.Length)];
            RandPicture.ImageLocation = files[a];
        }

        private void RandPicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            var files = Directory.GetFiles("../../randpics/" + imageToDisplay + "/", "*.jpg");
            int len = files.Length;

            if (a != len)
            {
                RandPicture.ImageLocation = files[a];
                a++;
            }
            else
            {
                a = 0;
                //RandPicture.ImageLocation = files[a];
            }
            
        }
    }
}
