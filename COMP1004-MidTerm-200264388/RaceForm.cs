///@Midterm Assignmentt RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 2/20/2017
///@Description:When the user selects a Race, the portrait in the CharacterPictureBox control changes to reflect his choice
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
    public partial class RaceForm : Form
    {
        //pass a reference from the current form to the next form
        public AbilityForm previousForm { get; set; }

        //Private Variables
        private int _STR;
        private int _DEX;
        private int _END;
        private int _INT;
        private int _PER;
        private int _CHA;
        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //instantiate the next form
            JobForm jobForm = new JobForm();

            jobForm.previousForm = this;
            jobForm.Show();
            //hide current form
            this.Hide();
        }
        //If the user selects the Human Race option, 
        // increase all of the Character’s Abilities randomly generated from the AbilityForm by 5 points. 
        private void humanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
        }

        //If the user selects the Dwarf Race option, 
        //increase the Character’s STR and PER by 20 points each and decrease the Character’s CHA by 10 points. 
        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
        }

        //If the user selects the Elf Race option, increase the Character’s DEX and CHA by 15
        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
        }

        //If the user selects the Halfling Race option, 
        //increase the Character’s DEX and INT by 20 and decrease the Character’s STR by 10 points. 
        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
        }
    }
}
