using DiascanTestTask.HashCalculator;

namespace DiascanTestTask
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            SHA256HashCalculator sHA256HashCalculator = new SHA256HashCalculator();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(sHA256HashCalculator));
        }
    }
}