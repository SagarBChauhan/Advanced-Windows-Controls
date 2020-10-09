using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Practical4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new greeting());
            Application.Run(new Notepad());
          //  Application.Run(new TreeViewUniversity());
            //Application.Run(new TextEditor());
           // Application.Run(new EmployeeList());
        }
    }
}
