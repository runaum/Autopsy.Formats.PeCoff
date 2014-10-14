using System;
using System.Runtime.InteropServices;

namespace Autopsy.Formats.PeCoff.Headers
{
    /// <summary>
    /// IMAGE_DOS_HEADER
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class DosHeader
    {
        /// <summary>
        /// e_magic: Magic number
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public char[] InternalMagic;      

        /// <summary>
        /// e_cblp: Bytes on last page of file
        /// </summary>
        public UInt16 UsedBytesInTheLastPage;   

        /// <summary>
        /// e_cp: Pages in file
        /// </summary>
        public UInt16 FileSizeInPages;      

        /// <summary>
        /// e_crlc: Relocations
        /// </summary>
        public UInt16 NumberOfRelocationItems;    

        /// <summary>
        /// e_cparhdr: Size of header in paragraphs
        /// </summary>
        public UInt16 HeaderSizeInParagraphs;    

        /// <summary>
        /// e_minalloc: Minimum extra paragraphs needed
        /// </summary>
        public UInt16 MinimumExtraParagraphs;   

        /// <summary>
        /// e_maxalloc: Maximum extra paragraphs needed
        /// </summary>
        public UInt16 MaximumExtraParagraphs;   

        /// <summary>
        /// e_ss: Initial (relative) SS value
        /// </summary>
        public UInt16 InitialRelativeSS;      

        /// <summary>
        /// e_sp: Initial SP value
        /// </summary>
        public UInt16 InitialSP;      

        /// <summary>
        /// e_csum: Checksum
        /// </summary>
        public UInt16 Checksum;    

        /// <summary>
        /// e_ip: Initial IP value
        /// </summary>
        public UInt16 InitialIP;      

        /// <summary>
        /// e_cs: Initial (relative) CS value
        /// </summary>
        public UInt16 InitialRelativeCS;      

        /// <summary>
        /// e_lfarlc: File address of relocation table
        /// </summary>
        public UInt16 AddressOfRelocationTable;      

        /// <summary>
        /// e_ovno: Overlay number
        /// </summary>
        public UInt16 OverlayNumber;    

        /// <summary>
        /// e_res1: Reserved words
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public UInt16[] Reserved;    

        /// <summary>
        /// e_oemid: OEM identifier (for e_oeminfo)
        /// </summary>
        public UInt16 OemId;      

        /// <summary>
        /// e_oeminfo: OEM information; e_oemid specific
        /// </summary>
        public UInt16 OemInfo;    

        /// <summary>
        /// e_res2: Reserved words
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public UInt16[] Reserved2;

        /// <summary>
        /// e_lfanew: File address of new exe header
        /// </summary>
        public Int32 AddressOfNewExeHeader;

        public string Magic
        {
            get { return new string(InternalMagic); }
        }

        public bool IsValid
        {
            get { return Magic == "MZ" || Magic == "ZM"; }
        }
    }
}
