using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D201_Practical_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.TextLength >= 8 )
            {
                this.Validate();
                this.scoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.membersScoresDataSet);
            }
            else if (passwordTextBox.TextLength <= 7)
            {
                MessageBox.Show("Your password is not enough characters", "Warning");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membersScoresDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.membersScoresDataSet.members);
            // TODO: This line of code loads data into the 'membersScoresDataSet.scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.membersScoresDataSet.scores);

        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked == false)
            {
                passwordTextBox.PasswordChar = '*';
            }
            else if (ckbShow.Checked == true)
            {
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void noviceToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.Novice(this.membersScoresDataSet.scores);
                //AVG.Text = this.scoresTableAdapter.ScalarQuery(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.open(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.scoresTableAdapter.Open5(this.membersScoresDataSet.scores);
        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.open(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mastersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.Masters(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.scoresTableAdapter.Masters(this.membersScoresDataSet.scores);
        }

        private void scoreAbove50ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.ScoreAbove50(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.scoresTableAdapter.ScoreAbove50(this.membersScoresDataSet.scores);
        }

        private void scorebelow50ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.Scorebelow50(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.scoresTableAdapter.Scorebelow50(this.membersScoresDataSet.scores);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void _yearToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter._year(this.membersScoresDataSet.scores, new System.Nullable<int>(((int)(System.Convert.ChangeType(event_yearToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _yearToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter._year(this.membersScoresDataSet.scores, new System.Nullable<int>(((int)(System.Convert.ChangeType(event_yearToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _yearToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter._year(this.membersScoresDataSet.scores, new System.Nullable<int>(((int)(System.Convert.ChangeType(event_yearToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _yearToolStripButton_Click_2(object sender, EventArgs e)
        {
            if (event_yearToolStripTextBox.Text == "2015")
            {
                this.scoresTableAdapter._year(this.membersScoresDataSet.scores, new System.Nullable<int>(((int)(System.Convert.ChangeType(event_yearToolStripTextBox.Text, typeof(int))))));
            }
           else if (event_yearToolStripTextBox.Text == "2016")
            {
                this.scoresTableAdapter._year(this.membersScoresDataSet.scores, new System.Nullable<int>(((int)(System.Convert.ChangeType(event_yearToolStripTextBox.Text, typeof(int))))));
            }
            else if (event_yearToolStripTextBox.Text != null)
            {
                MessageBox.Show("Please enter 4 Digit year into search textbox", "You forgot");
            }
        }
        

        private void allToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.All(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            this.scoresTableAdapter.All(this.membersScoresDataSet.scores);
        }

        private void open5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.Open5(this.membersScoresDataSet.scores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void membersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
   
}
