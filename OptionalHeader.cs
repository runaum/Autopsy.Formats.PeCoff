using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public class OptionalHeader
    {

#region Standart fields

        /// <summary>
        /// The state of the image file.
        /// </summary>
        public ImageState Magic;

        /// <summary>
        /// The major version number of the linker.
        /// </summary>
        public byte MajorLinkerVersion;

        /// <summary>
        /// The minor version number of the linker.
        /// </summary>
        public byte MinorLinkerVersion;

        /// <summary>
        /// The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.
        /// </summary>
        public UInt32 SizeOfCode;

        /// <summary>
        /// The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.
        /// </summary>
        public UInt32 SizeOfInitializedData;

        /// <summary>
        /// The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.
        /// </summary>
        public UInt32 SizeOfUninitializedData;

        /// <summary>
        /// A pointer to the entry point function, relative to the image base address. 
        /// For executable files, this is the starting address. 
        /// For device drivers, this is the address of the initialization function. 
        /// The entry point function is optional for DLLs. When no entry point is present, this member is zero.
        /// </summary>
        public UInt32 AddressOfEntryPoint;

        /// <summary>
        /// A pointer to the beginning of the code section, relative to the image base.
        /// </summary>
        public UInt32 BaseOfCode;

        /// <summary>
        /// A pointer to the beginning of the data section, relative to the image base.
        /// </summary>
        public UInt32 BaseOfData;

#endregion
        
#region Windows-Specific fields

        /// <summary>
        /// The preferred address of the first byte of the image when it is loaded in memory. 
        /// This value is a multiple of 64K bytes. The default value for DLLs is 0x10000000. 
        /// The default value for applications is 0x00400000, except on Windows CE where it is 0x00010000.
        /// </summary>
        public UInt32 ImageBase;

        /// <summary>
        /// The alignment of sections loaded in memory, in bytes. 
        /// This value must be greater than or equal to the FileAlignment member. 
        /// The default value is the page size for the system.
        /// </summary>
        public UInt32 SectionAlignment;

        /// <summary>
        /// The alignment of the raw data of sections in the image file, in bytes. 
        /// The value should be a power of 2 between 512 and 64K (inclusive).
        /// The default is 512. 
        /// If the SectionAlignment member is less than the system page size, this member must be the same as SectionAlignment.
        /// </summary>
        public UInt32 FileAlignment;

        /// <summary>
        /// The major version number of the required operating system.
        /// </summary>
        public UInt16 MajorOperatingSystemVersion;

        /// <summary>
        /// The minor version number of the required operating system.
        /// </summary>
        public UInt16 MinorOperatingSystemVersion;

        /// <summary>
        /// The major version number of the image.
        /// </summary>
        public UInt16 MajorImageVersion;

        /// <summary>
        /// The minor version number of the image.
        /// </summary>
        public UInt16 MinorImageVersion;

        /// <summary>
        /// The major version number of the subsystem.
        /// </summary>
        public UInt16 MajorSubsystemVersion;

        /// <summary>
        /// The minor version number of the subsystem.
        /// </summary>
        public UInt16 MinorSubsystemVersion;

        /// <summary>
        /// This member is reserved and must be 0.
        /// </summary>
        public UInt32 Win32VersionValue;

        /// <summary>
        /// The size of the image, in bytes, including all headers. Must be a multiple of SectionAlignment.
        /// </summary>
        public UInt32 SizeOfImage;

        /// <summary>
        /// The combined size of the following items, rounded to a multiple of the value specified in the FileAlignment member.
        /// * e_lfanew member of IMAGE_DOS_HEADER
        /// * 4 byte signature
        /// * size of IMAGE_FILE_HEADER
        /// * size of optional header
        /// * size of all section headers
        /// </summary>
        public UInt32 SizeOfHeaders;

        /// <summary>
        /// The image file checksum. 
        /// The following files are validated at load time: all drivers, any DLL loaded at boot time, and any DLL loaded into a critical system process.
        /// </summary>
        public UInt32 CheckSum;

        /// <summary>
        /// The subsystem required to run this image.
        /// </summary>
        public Subsystem Subsystem;

        /// <summary>
        /// The DLL characteristics of the image.
        /// </summary>
        public DllCharacteristics DllCharacteristics;

        /// <summary>
        /// The number of bytes to reserve for the stack. 
        /// Only the memory specified by the SizeOfStackCommit member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public UInt32 SizeOfStackReserve;

        /// <summary>
        /// The number of bytes to commit for the stack.
        /// </summary>
        public UInt32 SizeOfStackCommit;

        /// <summary>
        /// The number of bytes to reserve for the local heap. 
        /// Only the memory specified by the SizeOfHeapCommit member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public UInt32 SizeOfHeapReserve;

        /// <summary>
        /// The number of bytes to commit for the local heap.
        /// </summary>
        public UInt32 SizeOfHeapCommit;

        /// <summary>
        /// This member is obsolete.
        /// </summary>
        public UInt32 LoaderFlags;

        /// <summary>
        /// The number of directory entries in the remainder of the optional header. Each entry describes a location and size.
        /// </summary>
        public UInt32 NumberOfRvaAndSizes;

#endregion

        public DataDirectory[] DataDirectories;

        public OptionalHeader() { }

        public OptionalHeader(IBinaryHelper binary)
        {
            // TODO: Data contract, attributes, good mapping

            Magic = (ImageState)binary.Reader.ReadUInt16();

            MajorLinkerVersion = binary.Reader.ReadByte();
            MinorLinkerVersion = binary.Reader.ReadByte();
            SizeOfCode = binary.Reader.ReadUInt32();
            SizeOfInitializedData = binary.Reader.ReadUInt32();
            SizeOfUninitializedData = binary.Reader.ReadUInt32();
            AddressOfEntryPoint = binary.Reader.ReadUInt32();
            BaseOfCode = binary.Reader.ReadUInt32();

            if (Magic == ImageState.PE32)
                BaseOfData = binary.Reader.ReadUInt32();

            ImageBase = binary.Reader.ReadUInt32();
            SectionAlignment = binary.Reader.ReadUInt32();
            FileAlignment = binary.Reader.ReadUInt32();
            MajorOperatingSystemVersion = binary.Reader.ReadUInt16();
            MinorOperatingSystemVersion = binary.Reader.ReadUInt16();
            MajorImageVersion = binary.Reader.ReadUInt16();
            MinorImageVersion = binary.Reader.ReadUInt16();
            MajorSubsystemVersion = binary.Reader.ReadUInt16();
            MinorSubsystemVersion = binary.Reader.ReadUInt16();
            Win32VersionValue = binary.Reader.ReadUInt32();
            SizeOfImage = binary.Reader.ReadUInt32();
            SizeOfHeaders = binary.Reader.ReadUInt32();
            CheckSum = binary.Reader.ReadUInt32();
            Subsystem = (Subsystem)binary.Reader.ReadUInt16();
            DllCharacteristics = (DllCharacteristics)binary.Reader.ReadUInt16();
            SizeOfStackReserve = binary.Reader.ReadUInt32();
            SizeOfStackCommit = binary.Reader.ReadUInt32();
            SizeOfHeapReserve = binary.Reader.ReadUInt32();
            SizeOfHeapCommit = binary.Reader.ReadUInt32();
            LoaderFlags = binary.Reader.ReadUInt32();
            NumberOfRvaAndSizes = binary.Reader.ReadUInt32();

            DataDirectories = new DataDirectory[DirectoryEntry.Count];
            for (int i = 0; i < DirectoryEntry.Count; i++)
                DataDirectories[i] = binary.MarshalAt<DataDirectory>();
        }

        ///// <summary>
        ///// Export table address and size
        ///// </summary>
        //public DataDirectory ExportTable;

        ///// <summary>
        ///// Import table address and size
        ///// </summary>
        //public DataDirectory ImportTable;

        ///// <summary>
        ///// Resource table address and size
        ///// </summary>
        //public DataDirectory ResourceTable;

        ///// <summary>
        ///// Exception table address and size
        ///// </summary>
        //public DataDirectory ExceptionTable;

        ///// <summary>
        ///// Certificate table address and size
        ///// </summary>
        //public DataDirectory CertificateTable;

        ///// <summary>
        ///// Base relocation table address and size
        ///// </summary>
        //public DataDirectory BaseRelocationTable;

        ///// <summary>
        ///// Debugging information starting address and size
        ///// </summary>
        //public DataDirectory Debug;

        ///// <summary>
        ///// Architecture-specific data address and size
        ///// </summary>
        //public DataDirectory Architecture;

        ///// <summary>
        ///// Global pointer register relative virtual address
        ///// </summary>
        //public DataDirectory GlobalPtr;

        ///// <summary>
        ///// Thread local storage (TLS) table address and size
        ///// </summary>
        //public DataDirectory TLSTable;

        ///// <summary>
        ///// Load configuration table address and size
        ///// </summary>
        //public DataDirectory LoadConfigTable;

        ///// <summary>
        ///// Bound import table address and size
        ///// </summary>
        //public DataDirectory BoundImport;

        ///// <summary>
        ///// Import address table address and size
        ///// </summary>
        //public DataDirectory IAT;

        ///// <summary>
        ///// Delay import descriptor address and size
        ///// </summary>
        //public DataDirectory DelayImportDescriptor;

        ///// <summary>
        ///// The CLR header address and size
        ///// </summary>
        //public DataDirectory CLRRuntimeHeader;

        ///// <summary>
        ///// Reserved
        ///// </summary>
        //public DataDirectory Reserved;
    }
}
