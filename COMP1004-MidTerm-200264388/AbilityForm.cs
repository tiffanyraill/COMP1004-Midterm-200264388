///@Midterm Assignmentt RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 2/20/2017
///@Description:Whenever the RollButton is clicked, the Character’s Abilities 
///(STR, DEX, END, INT, PER, CHA) will display a random number between 3 and 30.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MidTerm_200264388
{
    public partial class AbilityForm : Form
    {
        // create new Random Number object
        Random random = new Random();


        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            //generate random numbers between 3-30 for STR, DEX, END, INT, PER, CHA textboxes
            STRTextBox.Text = this.Roll3D10().ToString();
            DEXTextBox.Text = this.Roll3D10().ToString();
            ENDTextBox.Text = this.Roll3D10().ToString();
            INTTextBox.Text = this.Roll3D10().ToString();
            PERTextBox.Text = this.Roll3D10().ToString();
            CHATextBox.Text = this.Roll3D10().ToString();

            Debug.WriteLine(Roll3D10().ToString());
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;
           
            character.STR = STRTextBox.Text;
            character.DEX = DEXTextBox.Text;
            character.END = ENDTextBox.Text;
            character.INT = INTTextBox.Text;
            character.PER = PERTextBox.Text;
            character.CHA = CHATextBox.Text;

            //instantiate the next form
            RaceForm raceForm = new RaceForm();
            raceForm.previousForm = this;
            //go to next form
            raceForm.Show();
            //hide current form
             this.Hide();
        }
    }
}
