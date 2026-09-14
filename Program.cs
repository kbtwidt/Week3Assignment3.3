namespace Week3Assignment3._3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.Students.Add (new Student() { StudentID = 1, FName = "Sample", LName = "Student", Address = "123 University Blvd", MonthOfAdmission = MonthOfAdmission.August, Grade = 'A'});
            Application.Run(new Login());
        }
    }
}