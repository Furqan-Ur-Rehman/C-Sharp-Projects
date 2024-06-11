using System.Diagnostics;

namespace run_exefiles_with_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("C:\\Windows\\notepad.exe");
            //Process.Start("C:\\Windows\\write.exe"); //open wordpad
            Process.Start("C:\\Windows\\System32\\mspaint.exe");
            System.Console.ReadLine();
            
        }
    }
}
