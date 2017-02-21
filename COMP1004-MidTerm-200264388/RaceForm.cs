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
        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //instantiate the next form
            JobForm jobForm = new JobForm();

            jobForm.Show();
            //hide current form
            this.Hide();
        }
    }
}
