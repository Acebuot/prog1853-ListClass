using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassList
{
    public partial class FrmListCollection : Form
    {
        public FrmListCollection()
        {
            InitializeComponent();
        }

        List<string> values = new List<string>();


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                MessageBox.Show("ur pp smol", "kys psa");
            }

            else
            {
                // values.Add(input); = txtValue.Text;
                string input = txtValue.Text;
                values.Add(input);

                //txtValue.Text = "";
                txtValue.Clear();

                MessageBox.Show(input + " added to index " + (values.Count - 1), "indexes start at 0");
                txtValue.Focus();
            }
           
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //values[int.Parse(txtIndex.Text)] = txtValue.Text;
                string inputStr = txtValue.Text;
                int inputInd = int.Parse(txtIndex.Text);
                values.Insert(inputInd, inputStr);

                // txtValue.Text = "";
                // txtIndex.Text = "";
                txtValue.Clear();
                txtIndex.Clear();

                //unnecessary bs
                MessageBox.Show("Value " + values[inputInd] + " has been added to index " + inputInd, "indexes start at 0");
                txtValue.Focus();
            }

            catch
            {
                MessageBox.Show("Please input valid value and index");
                txtValue.Focus();
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            StringBuilder damnSexy = new StringBuilder();
            for(int i = 0; i < values.Count; i++)
            {
                damnSexy.Append("[" + i + "] " + values[i] + " ");
            }
            MessageBox.Show(damnSexy.ToString());

            //foreach (string temp in values)
            //{
            //    damnSexy.Append(temp + "\n");
            //}
            //MessageBox.Show(damnSexy.ToString());

            txtValue.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string input = txtValue.Text;
            if (values.Remove(input))
            {
                MessageBox.Show("Value Removed", "Success", MessageBoxButtons.OK);
                txtValue.Clear();
                txtValue.Focus();
            }
            else
            {
                MessageBox.Show("What is Oklahoma's state abbreviation?", "We Trippin", MessageBoxButtons.OK);
            }

            

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            values.Clear();
            MessageBox.Show("values cleared");
            txtValue.Focus();
        }

        private void BtnRemoveAt_Click(object sender, EventArgs e)
        {
            try
            {
            //values.RemoveAt(int.Parse(txtIndex.Text));
            //messagebox
            int index = int.Parse(txtIndex.Text);
            MessageBox.Show("value of " + values[index] + " at index " + index + " will be removed", "indexes start at 0", MessageBoxButtons.OK);
            values.RemoveAt(index);

            txtIndex.Clear();

            }

            catch
            {
                MessageBox.Show("Error 404: Your brain not found", "Bless your Soul");
            }
        }

        private void BtnIndexOf_Click(object sender, EventArgs e)
        {
            try
            {
                txtIndex.Text = values.IndexOf(txtValue.Text).ToString();
            }
            catch
            {
                MessageBox.Show("ok");
            }
            
        }
    }
}
