using MeetingInfoDatabase;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace MeetingInfoWinForms
{
    static class Program
    {

        private static bool doNotExit = true;
        private static MeetingForm programForm;
        public static Repository Repository { get; private set; }
        private static readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Repository = new Repository(cs, MeetingInfoDatabase.DAO.DatabaseType.Ado);

            while (doNotExit)
            {
                doNotExit = false;
                programForm = new MeetingForm();
                programForm.StartPosition = FormStartPosition.CenterScreen;
                programForm.LanguageChanged += new EventHandler(main_LanugageChangedEvent);
                Application.Run(programForm);
            }
        }

        static void main_LanugageChangedEvent(object sender, EventArgs e)
        {
            doNotExit = true;
            programForm.Close();
        }
    }
}
