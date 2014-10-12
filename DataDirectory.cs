using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    /// <summary>
    /// IMAGE_DATA_DIRECTORY
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class DataDirectory
    {
        public UInt32 VirtualAddress;

        public UInt32 Size;
    }
}
