using System;
using System.Runtime.InteropServices;

namespace Autopsy.Formats.PeCoff.Directories
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
