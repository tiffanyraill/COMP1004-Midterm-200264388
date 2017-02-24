///@Midterm Assignmentt RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 2/20/2017
///@Description:allow the user to choose between Soldier, Rogue, Magicker or Cultist as the Character’s Job.
///Health Points vary according to character Job and of the Abilities that were previously generated
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
    public partial class JobForm : Form
    {
        //pass a reference to the current form to the next form
        public RaceForm previousForm;

        private int _DEXHealth;
        private int _ENDHealth;
        private int _INTHealth;
        private int _CHAHealth;

        private int _soldier = 30;
        private int _rogue = 28;
        private int _magicker = 15;
        private int _cultist = 24;
        private string _race;

        public JobForm()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            //store selected race & ability
            Character character = Program.character;

            character.Health = healthTextBox.Text;
            character.Race = _race;

            //instantiate the next form
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;
            finalForm.Show();
            //hide current form
            this.Hide();
        }

        //30  pts and END ability
        private void soldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;

            healthTextBox.Text = (_soldier + _ENDHealth).ToString();
            
            this._race = race.Text;
        }

        //15 points and INT ability
        private void magickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;

            healthTextBox.Text = (_magicker + _INTHealth).ToString();

            this._race = race.Text;
        }

        //28 points and DEX ability
        private void rogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;

            healthTextBox.Text = (_rogue + _DEXHealth).ToString();

            this._race = race.Text;
        }

        //24 points and CHA abiility
        private void cultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton race = (RadioButton)sender;

            healthTextBox.Text = (_cultist + _CHAHealth).ToString();

            this._race = race.Text;
        }
      
    }
}
