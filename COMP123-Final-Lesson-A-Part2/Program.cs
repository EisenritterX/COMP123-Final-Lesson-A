using COMP123_Final_Lesson_A_Part2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Final_Lesson_A_Part2
{
    static class Program
    {
        public static MDIParent1 parentForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            parentForm = new MDIParent1();
            Application.Run(parentForm);
        }
    }
}
