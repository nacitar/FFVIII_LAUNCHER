using System.Reflection;
using System.Diagnostics;

string fullBinaryPath = Path.Combine(
    Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location) ?? Directory.GetCurrentDirectory(),
    "FFVIII.exe"
);
using (Process myProcess = new Process())
{
    myProcess.StartInfo = new() {
        UseShellExecute = false,
        FileName = fullBinaryPath,
        CreateNoWindow = true
    };
    Console.WriteLine($"Starting {Path.GetFileName(fullBinaryPath)}: {fullBinaryPath}");
    myProcess.Start();
}