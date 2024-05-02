using DiascanTestTask.HashCalculator;

namespace DiascanTestTask
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SHA256HashCalculator sHA256HashCalculator = new SHA256HashCalculator();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(sHA256HashCalculator));
        }
    }
}