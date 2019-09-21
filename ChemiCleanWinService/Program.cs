using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ChemiCleanWinService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            ISyncFiles syncFiles = new SyncFiles(new ReadFile(), new HandleData());
            syncFiles.SyncTheFiles();
#endif


            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1(new SyncFiles(new ReadFile(), new HandleData() ))
            };            

            ServiceBase.Run(ServicesToRun);
        }
    }
}
