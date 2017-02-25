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
        private string _race;
        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //store selected race & ability
            Character character = Program.character;
          
            character.STR = _STR.ToString();
            character.DEX = _DEX.ToString();
            character.END = _END.ToString();
            character.INT = _INT.ToString();
            character.PER = _PER.ToString();
            character.CHA = _CHA.ToString();
            character.Race = _race;

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
            RadioButton race = (RadioButton)sender;

            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            RacialBonusTextBox.Text = "All Abilities have Increased by 5";
 
            _STR = _STR + 5;
            if (_STR > 50)
            {
                _STR = 50;
            }
            else if (_STR < 3)
            {
                _STR = 3;
            }
            else _STR = _STR + 5;

            _DEX = _DEX + 5;
            _END = _END + 5;
            _INT = _INT + 5;
            _PER = _PER + 5;
            _CHA = _CHA + 5;

            this._race = race.Text;
           
        }

        //If the user selects the Dwarf Race option, 
        //increase the Character’s STR and PER by 20 points each and decrease the Character’s CHA by 10 points. 
        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;

            RacialBonusTextBox.Text = "Strength +20, Perseverence +20, Charisma -10";

            _STR = _STR + 20;
            _PER = _PER + 20;
            _CHA = _CHA - 10;

            this._race = race.Text;
        }

        //If the user selects the Elf Race option, increase the Character’s DEX and CHA by 15
        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;

            RacialBonusTextBox.Text = "Dexterity +15, Charisma +15";

            _DEX = _DEX + 15;
            _CHA = _CHA + 15;

            this._race = race.Text;
        }

        //If the user selects the Halfling Race option, 
        //increase the Character’s DEX and INT by 20 and decrease the Character’s STR by 10 points. 
        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;

            RacialBonusTextBox.Text = "Dexterity +20, Intelligence +20, Strength -10";

            _DEX = _DEX + 20;
            _INT = _INT + 20;
            _STR = _STR - 10;

            this._race = race.Text;
        }

        //if no radio button is selected, default to Human
        private void RaceForm_Load(object sender, EventArgs e)
        {
 
            if (Program.character.Race == "")
            {
                humanRadioButton.AutoCheck = true;
            }

        }
    }
}
