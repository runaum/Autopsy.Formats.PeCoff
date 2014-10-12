using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    // TODO: Explicit?
    /// <summary>
    /// IMAGE_SECTION_HEADER
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class SectionHeader
    {
        /// <summary>
        /// An 8-byte, null-padded UTF-8 string.
        /// There is no terminating null character if the string is exactly eight characters long. 
        /// For longer names, this member contains a forward slash (/) followed by an ASCII representation of a decimal number that is an offset into the string table. 
        /// Executable images do not use a string table and do not support section names longer than eight characters.
        /// </summary>
        //[FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public char[] Name;

        /// <summary>
        /// The total size of the section when loaded into memory, in bytes. 
        /// If this value is greater than the SizeOfRawData member, the section is filled with zeroes. 
        /// This field is valid only for executable images and should be set to 0 for object files.
        /// </summary>
        //[FieldOffset(8)]
        public UInt32 VirtualSize;

        /// <summary>
        /// The address of the first byte of the section when loaded into memory, relative to the image base. 
        /// For object files, this is the address of the first byte before relocation is applied.
        /// </summary>
        //[FieldOffset(12)]
        public UInt32 VirtualAddress;

        /// <summary>
        /// The size of the initialized data on disk, in bytes. 
        /// This value must be a multiple of the FileAlignment member of the IMAGE_OPTIONAL_HEADER structure. 
        /// If this value is less than the VirtualSize member, the remainder of the section is filled with zeroes. 
        /// If the section contains only uninitialized data, the member is zero.
        /// </summary>
        //[FieldOffset(16)]
        public UInt32 SizeOfRawData;

        /// <summary>
        /// A file pointer to the first page within the COFF file. 
        /// This value must be a multiple of the FileAlignment member of the IMAGE_OPTIONAL_HEADER structure. 
        /// If a section contains only uninitialized data, set this member is zero.
        /// </summary>
        //[FieldOffset(20)]
        public UInt32 PointerToRawData;

        /// <summary>
        /// A file pointer to the beginning of the relocation entries for the section. 
        /// If there are no relocations, this value is zero.
        /// </summary>
        //[FieldOffset(24)]
        public UInt32 PointerToRelocations;

        /// <summary>
        /// A file pointer to the beginning of the line-number entries for the section. 
        /// If there are no COFF line numbers, this value is zero.
        /// </summary>
        //[FieldOffset(28)]
        public UInt32 PointerToLinenumbers;

        /// <summary>
        /// The number of relocation entries for the section. 
        /// This value is zero for executable images.
        /// </summary>
        //[FieldOffset(32)]
        public UInt16 NumberOfRelocations;

        /// <summary>
        /// The number of line-number entries for the section.
        /// </summary>
        //[FieldOffset(34)]
        public UInt16 NumberOfLinenumbers;

        /// <summary>
        /// The characteristics of the image.
        /// </summary>
        //[FieldOffset(36)]
        public DataSectionFlags Characteristics;

        public string Section
        {
            get { return new string(Name); }
        }
    }
}
