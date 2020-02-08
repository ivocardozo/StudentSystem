using System;
using StudentSystem.Utils;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemApp app = new StudentSystemApp(args);
            app.Run();            
        }
    }
}
