using System;

namespace Autopsy.Formats.PeCoff.Headers
{
    [Flags]
    public enum Characteristics: ushort
    {
        /// <summary>
        /// IMAGE_FILE_RELOCS_STRIPPED: Image only, Windows CE, and Windows NT® and later. 
        /// This indicates that the file does not contain base relocations and must therefore be loaded at its preferred base address. 
        /// If the base address is not available, the loader reports an error. 
        /// The default behavior of the linker is to strip base relocations from executable (EXE) files.
        /// </summary>
        RelocsStripped = 0x0001,

        /// <summary>
        /// IMAGE_FILE_EXECUTABLE_IMAGE: Image only. 
        /// This indicates that the image file is valid and can be run. 
        /// If this flag is not set, it indicates a linker error.
        /// </summary>
        ExecutableImage = 0x0002,

        /// <summary>
        /// IMAGE_FILE_LINE_NUMS_STRIPPED: COFF line numbers have been removed.
        /// This flag is deprecated and should be zero.
        /// </summary>        
        LineNumsStripped = 0x0004,

        /// <summary>
        /// IMAGE_FILE_LOCAL_SYMS_STRIPPED: COFF symbol table entries for local symbols have been removed. 
        /// This flag is deprecated and should be zero.
        /// </summary>        
        LocalSymsStripped = 0x0008,

        /// <summary>
        /// IMAGE_FILE_AGGRESSIVE_WS_TRIM: Obsolete. Aggressively trim working set. 
        /// This flag is deprecated for Windows 2000 and later and must be zero.
        /// </summary>        
        AggressiveWsTrim = 0x0010,

        /// <summary>
        /// IMAGE_FILE_LARGE_ADDRESS_ AWARE: Application can handle > 2 GB addresses.
        /// </summary>        
        LargeAddressAware = 0x0020,

        /// <summary>
        /// This flag is reserved for future use.
        /// </summary>        
	    ReservedFlag = 0x0040,

        /// <summary>
        /// IMAGE_FILE_BYTES_REVERSED_LO: Little endian: the least significant bit (LSB) precedes the most significant bit (MSB) in memory. 
        /// This flag is deprecated and should be zero.
        /// </summary>        
        BytesReservedLo = 0x0080,

        /// <summary>
        /// IMAGE_FILE_32BIT_MACHINE: Machine is based on a 32-bit-word architecture.
        /// </summary>        
        Machine32Bit = 0x0100,

        /// <summary>
        /// IMAGE_FILE_DEBUG_STRIPPED: Debugging information is removed from the image file.
        /// </summary>        
        DebugStripped = 0x0200,

        /// <summary>
        /// IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP: If the image is on removable media, fully load it and copy it to the swap file.
        /// </summary>        
        RemovableRunFromSwap = 0x0400,

        /// <summary>
        /// IMAGE_FILE_NET_RUN_FROM_SWAP: If the image is on network media, fully load it and copy it to the swap file.
        /// </summary>        
        NetRunFromSwap = 0x0800,

        /// <summary>
        /// IMAGE_FILE_SYSTEM: The image file is a system file, not a user program.
        /// </summary>        
        System = 0x1000,

        /// <summary>
        /// IMAGE_FILE_DLL: The image file is a dynamic-link library (DLL). 
        /// Such files are considered executable files for almost all purposes, although they cannot be directly run.
        /// </summary>        
        Dll = 0x2000,

        /// <summary>
        /// IMAGE_FILE_UP_SYSTEM_ONLY: The file should be run only on a uniprocessor machine.
        /// </summary>        
        UpSystemOnly = 0x4000,

        /// <summary>
        /// IMAGE_FILE_BYTES_REVERSED_HI: Big endian: the MSB precedes the LSB in memory. 
        /// This flag is deprecated and should be zero.
        /// </summary>        
        BytesReservedHi = 0x8000
    }
}
