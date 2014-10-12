using System;
using System.Runtime.InteropServices;

namespace Autopsy.Formats.PeCoff.Directories.Export
{
    /// <summary>
    /// IMAGE_EXPORT_DIRECTORY
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class ExportDirectory: IDirectory
    {
        public UInt32 Characteristics;
        public UInt32 TimeDateStamp;
        public UInt16 MajorVersion;
        public UInt16 MinorVersion;
        public UInt32 Name;
        public UInt32 Base;
        public UInt32 NumberOfFunctions;
        public UInt32 NumberOfNames;
        public UInt32 AddressOfFunctions;     // RVA from base of image
        public UInt32 AddressOfNames;     // RVA from base of image
        public UInt32 AddressOfNameOrdinals;  // RVA from base of image
    }
}
