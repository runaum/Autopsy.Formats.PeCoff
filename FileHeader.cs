using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    /// <summary>
    /// IMAGE_FILE_HEADER
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class FileHeader
    {
        /// <summary>
        /// The architecture type of the computer. 
        /// An image file can only be run on the specified computer or a system that emulates the specified computer.
        /// </summary>
        public MachineType Machine;

        /// <summary>
        /// The number of sections. 
        /// This indicates the size of the section table, which immediately follows the headers. 
        /// Note that the Windows loader limits the number of sections to 96.
        /// </summary>
        public UInt16 NumberOfSections;

        /// <summary>
        /// The low 32 bits of the time stamp of the image. 
        /// This represents the date and time the image was created by the linker. 
        /// The value is represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.
        /// </summary>
        public UInt32 TimeDateStamp;

        /// <summary>
        /// The offset of the symbol table, in bytes, or zero if no COFF symbol table exists.
        /// </summary>
        public UInt32 PointerToSymbolTable;

        /// <summary>
        /// The number of symbols in the symbol table.
        /// </summary>
        public UInt32 NumberOfSymbols;

        /// <summary>
        /// The size of the optional header, in bytes. 
        /// This value should be 0 for object files.
        /// </summary>
        public UInt16 SizeOfOptionalHeader;
    }
}
