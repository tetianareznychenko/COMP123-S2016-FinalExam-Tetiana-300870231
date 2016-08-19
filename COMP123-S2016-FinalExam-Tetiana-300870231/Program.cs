using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam_Tetiana_300870231
{
    public static class Program
    {
        /**
         * Author: Tetiana Reznychenko
         * Student Number: 300870231
         * Date: 19 August, 2016 
         * Description: This is the project	that generates the first few pages of a RolePlaying
         * Game Character
         */
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //To start the SplashForm first
            Application.Run(new SplashForm());





            //Application.Run(new AbilityGeneratorForm());
        }
    }
}
