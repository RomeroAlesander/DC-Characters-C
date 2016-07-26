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
    public partial class Form1 : Form
    {


        private string imageToDisplay;

        public string ImageToDisplay
        {
            get { return imageToDisplay; }
            set { imageToDisplay = value; }
        }


        public Form1()
        {

            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string dir = "../../info";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string[] charNames = Directory.GetFiles("../../info")
                                        .Select(path => Path.GetFileNameWithoutExtension(path))
                                        .ToArray();
            for (int n = 0; n < charNames.Length; n++)
            {
                if (!lstChar.Items.Contains(charNames[n]))
                {
                    lstChar.Items.Add(charNames[n]);
                }
            }


            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            try
            {
                int numberElements = lstChar.Items.Count;
                string[] lstElements = new string[numberElements];
                for (int i = 0; i < lstChar.Items.Count; i++)
                {
                    lstElements[i] = Convert.ToInt32(lstChar.Items[i]).ToString();
                }


                if (!lstChar.Items.Contains(charNames[0]))
                {
                    lstChar.Items.Add(charNames[0]);
                }
            }
            catch
            {
                MessageBox.Show("List Updated");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertData insertData;
            insertData = new InsertData();
            insertData.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string dir = @"C:\\temp\\Characters";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string[] charNames = Directory.GetFiles("../../info")
                                        .Select(path => Path.GetFileNameWithoutExtension(path))
                                        .ToArray();



            for (int i = 0; i < charNames.Length; i++)
            {

                if (!lstChar.Items.Contains(charNames[i]))
                {
                    lstChar.Items.Add(charNames[i]);
                }

            }



            if (lstChar.Items.Count > 0)
            {
                lstChar.SelectedIndex = 0;
            }

        }

        private void lstChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] charNames = System.IO.Directory.GetFiles("../../info")
                                        .Select(path => Path.GetFileNameWithoutExtension(path))
                                        .ToArray();


            int position = Array.IndexOf(charNames, lstChar.SelectedItem);
            if (position > -1)
            {


                System.IO.StreamReader file =
                    new System.IO.StreamReader("../../info/" + lstChar.SelectedItem + ".txt");
                string[] lines = System.IO.File.ReadAllLines("../../info/" + lstChar.SelectedItem + ".txt");

                lblName.Text = lines[0];
                lblAlias.Text = lines[1];
                lblDescription.Text = lines[2];
                lblRealName.Text = lines[3];
                lblOccupation.Text = lines[4];
                lblHeight.Text = lines[5];
                lblWeight.Text = lines[6];
                lblBase.Text = lines[7];
                lblAllies.Text = lines[8];
                lblFoes.Text = lines[9];

                file.Close();

                ImageToDisplay = lstChar.SelectedItem.ToString();
                picB.ImageLocation = "../../pictures/" + ImageToDisplay + ".jpg";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstChar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a character to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + lstChar.SelectedItem, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                string ItemToDelete = lstChar.SelectedItem.ToString();
                lstChar.Items.Remove(ItemToDelete);

                if (System.IO.File.Exists("../../info/" + ItemToDelete + ".txt"))
                {
                    try
                    {
                        System.IO.File.Delete("../../info/" + ItemToDelete + ".txt");
                    }
                    catch
                    {
                        MessageBox.Show("Nothing to Delete");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSear_Click(this, new EventArgs());
            }
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.ToLower();

            if (txtSearch.Text == "" | txtSearch.Text == null)
            {
                MessageBox.Show("Please type a name",
                     "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {

                bool found = false;
                int a = lstChar.SelectedIndex;
                for (int i = 0; i < lstChar.Items.Count; i++)
                {
                    lstChar.SelectedIndex = i;
                    string selected = lstChar.GetItemText(lstChar.SelectedItem).ToString().ToLower();

                    if (selected.Contains(name))
                    {
                        int Result = lstChar.SelectedIndex;
                        lstChar.SetSelected(Result, true);
                        found = true;
                        break;
                    }


                }
                if (found == false)
                {
                    lstChar.SelectedIndex = a;
                    MessageBox.Show(name.ToUpper() + " is not part of the encyclopedia (yet)",
                     "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }

            }
            txtSearch.Clear();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblRealName_Click(object sender, EventArgs e)
        {

        }

        private void lblOccupation_Click(object sender, EventArgs e)
        {

        }

        private void lblAlias_Click(object sender, EventArgs e)
        {

        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void lblAllies_Click(object sender, EventArgs e)
        {

        }

        private void lblFoes_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstAppearance FA = new firstAppearance(ImageToDisplay);
            FA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomPic RP = new RandomPic(ImageToDisplay);
            RP.Show();
        }
    }
}
