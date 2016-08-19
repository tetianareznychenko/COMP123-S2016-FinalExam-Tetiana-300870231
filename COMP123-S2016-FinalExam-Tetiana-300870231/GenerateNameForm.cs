using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam_Tetiana_300870231
{
    public partial class GenerateNameForm : Form
    {

        // private Instance Object
        private Random _random;


        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           List<string> list = new List<string>();
        }

        private string GenerateNames()
        {

            //Trying to assign the FirstNameListBox to new firstName List 
            List<string> firstName = new List<string>(GenerateNameForm.FirstNameListBox());

            //Trying to assign the LastNameListBox to new lastName List 
            List<string> lastName = new List<string>(GenerateNameForm.LastNameListBox());

            //Randomly picking the first name
            Random randomFirst = new Random();
            int indexFirst = randomFirst.Next(firstName.Count);
            string randomStringFirst = firstName[indexFirst];

            //Randomly picking the last name

            Random randomLast = new Random();
            int indexLast = randomLast.Next(lastName.Count);
            string randomStringLast = lastName[indexLast];

            return (randomStringFirst);
            return (randomStringLast);

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            
            GenerateNames();
            //Set the value of the FirstName 
            FirstNameListBox.Text = randomStringFirst;

            //Set the value of the LstName
            LastNameTextBox.Text = randomStringLast;

        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //	event	handler,	call	the	Show() method	of	abilityGeneratorForm
            AbilityGeneratorForm abilities = new AbilityGeneratorForm();
            abilities.Show();
            //	Hide() method	of	the	GenerateNameForm
            GenerateNameForm name = new GenerateNameForm();
            name.Hide(); 

        }
    }
}
