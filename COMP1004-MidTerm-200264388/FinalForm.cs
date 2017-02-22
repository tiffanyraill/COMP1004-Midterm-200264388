///@Midterm Assignmentt RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 2/20/2017
///@Description:display the character’s Abilities, his Race, his Job, and his health score
///that are a result of randomly generated Abilities and selections made in the AbilityForm, RaceForm, and JobForm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MidTerm_200264388
{
   
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }
        public FinalForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Getting Ready To Print...");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // STEP 1: Create a new form
            AboutForm aboutForm = new AboutForm();
            //STEP 2: Show the about form with ShowDialogue (a modal method that displays the form)
            aboutForm.ShowDialog();
        }
    }
}
