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
    public partial class SplashForm : Form
    {
        public SplashForm splashForm { get; set; }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            //To make the GenerateNameForm come after timer is on 
            timerSplashScreen.Start();           
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            // Instantiate an object of the generateName form. 
            GenerateNameForm generateNameForm = new GenerateNameForm();
            
            //To show the GenerateNameForm
            generateNameForm.Show();

            //To make the timer stop
            timerSplashScreen.Stop();

            //To hide SplashScreen Form
            this.Hide(); 
        }
    }
}
