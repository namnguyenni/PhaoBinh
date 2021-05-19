using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cannon_Project;
namespace Cannon_Project
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
            Application.Run(new Main());

            //new AesFileData().MaHoaThuMuc(@"E:\Cannon-Project\Cannon-Project\bin\Debug\Content\Video",
            //    @"E:\Cannon-Project\Cannon-Project\bin\Debug\Content\mahoa");
        }
    }
}
