using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ChemiCleanWinService
{
    public partial class Service1 : ServiceBase
    {
        ISyncFiles syncFiles;
        public Service1(ISyncFiles syncFiles)
        {
            InitializeComponent();
            this.syncFiles = syncFiles;
        }

        protected override void OnStart(string[] args)
        {            
           syncFiles.SyncTheFiles();
        }

        protected override void OnStop()
        {
        }
    }
}
