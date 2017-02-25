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

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fontDialog1.Apply += new System.EventHandler(fontDialog1_Apply);

            System.Drawing.Font oldFont = this.Font;
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fontDialog1_Apply(this.nameTextBox, new System.EventArgs());
                fontDialog1_Apply(this.nameLabel, new System.EventArgs());
                fontDialog1_Apply(this.heightTextBox, new System.EventArgs());
                fontDialog1_Apply(this.heightLabel, new System.EventArgs());
                fontDialog1_Apply(this.ageTextBox, new System.EventArgs());
                fontDialog1_Apply(this.ageLabel, new System.EventArgs());
                fontDialog1_Apply(this.weightTextBox, new System.EventArgs());
                fontDialog1_Apply(this.weightLabel, new System.EventArgs());

            }
            // If Cancel is clicked, set the font back to
            // the original font.
            else if (result == DialogResult.Cancel)
            {
                this.Font = oldFont;
                foreach (Control containedControl in this.Controls)
                {
                    containedControl.Font = oldFont;
                }
            } 
        }
        private void fontDialog1_Apply(object sender, System.EventArgs e)
        {

            this.Font = fontDialog1.Font;
            foreach (Control containedControl in this.Controls)
            {
                containedControl.Font = fontDialog1.Font;
            }
        }
       
        public void characterAbilities()
        {
            strTextBox.Text = Program.character.STR;
            dexTextBox.Text = Program.character.DEX;
            endTextBox.Text = Program.character.END;
            intTextBox.Text = Program.character.INT;
            perTextBox.Text = Program.character.PER;
            chaTextBox.Text = Program.character.CHA;
            jobTextBox.Text = Program.character.Job;
            healthPointsTextBox.Text = Program.character.Health;
            raceTextBox.Text = Program.character.Race;
        }
        //populate finalForm with character selection & picture
        private void FinalForm_Load(object sender, EventArgs e)
        {
            characterAbilities();
            
            if (raceTextBox.Text == "Human")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Human1;
            }
            else if (raceTextBox.Text == "Dwarf")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else if (raceTextBox.Text == "Elf")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if (raceTextBox.Text == "Halfling")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            }
            
        }

    }
}
