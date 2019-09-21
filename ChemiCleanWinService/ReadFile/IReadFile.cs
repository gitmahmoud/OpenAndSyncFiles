using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemiCleanWinService
{
    public interface IReadFile
    {
        byte[] DownloadFile(string url);
    }
}
