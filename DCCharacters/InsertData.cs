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
    public partial class InsertData : Form
    {
        private Form1 frm = new Form1();

        public Form1 Frm
        {
            get { return frm; }
            set { frm = value; }
        }

        public InsertData()
        {
            InitializeComponent();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter at least the name of the character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string fileName = "../../info/" + txtName.Text + ".txt";

                System.IO.StreamWriter objWritter;
                objWritter = new System.IO.StreamWriter(fileName);
                objWritter.WriteLine(txtName.Text);
                objWritter.WriteLine(txtAlias.Text);
                objWritter.WriteLine(txtDescription.Text);
                objWritter.WriteLine(txtRealName.Text);
                objWritter.WriteLine(txtOccupation.Text);
                objWritter.WriteLine(txtHeight.Text);
                objWritter.WriteLine(txtWeight.Text);
                objWritter.WriteLine(txtBase.Text);
                objWritter.WriteLine(txtAllies.Text);
                objWritter.WriteLine(txtFoes.Text);
                objWritter.Close();

                this.Close();


            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Picture Files (.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string destFile = "../../pictures/" + txtName.Text + ".jpg";
                System.IO.File.Copy(sourceFile, destFile, true);
                lblLocation.Text = sourceFile;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAlias.Text = "";
            txtDescription.Text = "";
            txtRealName.Text = "";
            txtOccupation.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtBase.Text = "";
            txtAllies.Text = "";
            txtFoes.Text = "";
            lblLocation.Text = "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Picture Files (.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string destFile = "../../firstappearance/" + txtName.Text + ".jpg";
                System.IO.File.Copy(sourceFile, destFile, true);
                lblLocation.Text = sourceFile;
            }
        }

    }
}
