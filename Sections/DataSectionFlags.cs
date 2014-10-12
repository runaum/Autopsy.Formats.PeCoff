using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    [Flags]
    public enum DataSectionFlags : uint
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("TypeReg")]
        TypeReg = 0x00000000,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("TypeDsect")]
        TypeDsect = 0x00000001,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("TypeNoLoad")]
        TypeNoLoad = 0x00000002,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("TypeGroup")]
        TypeGroup = 0x00000004,

        /// <summary>
        /// The section should not be padded to the next boundary. This flag is obsolete and is replaced by IMAGE_SCN_ALIGN_1BYTES. This is valid only for object files.
        /// </summary>
        [Description("No padded")]
        TypeNoPadded = 0x00000008,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("TypeCopy")]
        TypeCopy = 0x00000010,

        /// <summary>
        /// The section contains executable code.
        /// </summary>
        [Description("Executable code")]
        ContentCode = 0x00000020,

        /// <summary>
        /// The section contains initialized data.
        /// </summary>
        [Description("Initialized data")]
        ContentInitializedData = 0x00000040,

        /// <summary>
        /// The section contains uninitialized data.
        /// </summary>
        [Description("Uninitialized data")]
        ContentUninitializedData = 0x00000080,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("LinkOther")]
        LinkOther = 0x00000100,

        /// <summary>
        /// The section contains comments or other information. The .drectve section has this type. This is valid for object files only.
        /// </summary>
        [Description("LinkInfo")]
        LinkInfo = 0x00000200,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("TypeOver")]
        TypeOver = 0x00000400,

        /// <summary>
        /// The section will not become part of the image. This is valid only for object files.
        /// </summary>
        [Description("LinkRemove")]
        LinkRemove = 0x00000800,

        /// <summary>
        /// The section contains COMDAT data. For more information, see section 5.5.6, COMDAT Sections (Object Only). This is valid only for object files.
        /// </summary>
        [Description("COMDAT data")]
        LinkComDat = 0x00001000,

        /// <summary>
        /// Reset speculative exceptions handling bits in the TLB entries for this section.
        /// </summary>
        [Description("NoDeferSpecExceptions")]
        NoDeferSpecExceptions = 0x00004000,

        /// <summary>
        /// The section contains data referenced through the global pointer (GP).
        /// </summary>
        [Description("Relative global pointer")]
        RelativeGP = 0x00008000,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("Purgeable")]
        MemPurgeable = 0x00020000,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("16-bit")]
        Memory16Bit = 0x00020000,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("Locked")]
        MemoryLocked = 0x00040000,

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [Description("Preload")]
        MemoryPreload = 0x00080000,

        /// <summary>
        /// Align data on a 1-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 1b")]
        Align1Bytes = 0x00100000,

        /// <summary>
        /// Align data on a 2-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 2b")]
        Align2Bytes = 0x00200000,

        /// <summary>
        /// Align data on a 4-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 4b")]
        Align4Bytes = 0x00300000,

        /// <summary>
        /// Align data on an 8-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 8b")]
        Align8Bytes = 0x00400000,

        /// <summary>
        /// Align data on a 16-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 16b")]
        Align16Bytes = 0x00500000,

        /// <summary>
        /// Align data on a 32-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 32b")]
        Align32Bytes = 0x00600000,

        /// <summary>
        /// Align data on a 64-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 64b")]
        Align64Bytes = 0x00700000,

        /// <summary>
        /// Align data on a 128-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 128b")]
        Align128Bytes = 0x00800000,

        /// <summary>
        /// Align data on a 256-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 256b")]
        Align256Bytes = 0x00900000,

        /// <summary>
        /// Align data on a 512-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 512b")]
        Align512Bytes = 0x00A00000,

        /// <summary>
        /// Align data on a 1024-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 1024b")]
        Align1024Bytes = 0x00B00000,

        /// <summary>
        /// Align data on a 2048-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 2048b")]
        Align2048Bytes = 0x00C00000,

        /// <summary>
        /// Align data on a 4096-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 4096b")]
        Align4096Bytes = 0x00D00000,

        /// <summary>
        /// Align data on an 8192-byte boundary. Valid only for object files.
        /// </summary>
        [Description("Align 8192b")]
        Align8192Bytes = 0x00E00000,

        /// <summary>
        /// The section contains extended relocations.
        /// </summary>
        [Description("Relocation Overflow")]
        LinkExtendedRelocationOverflow = 0x01000000,

        /// <summary>
        /// The section can be discarded as needed.
        /// </summary>
        [Description("Discardable")]
        MemoryDiscardable = 0x02000000,

        /// <summary>
        /// The section cannot be cached.
        /// </summary>
        [Description("Not cached")]
        MemoryNotCached = 0x04000000,

        /// <summary>
        /// The section is not pageable.
        /// </summary>
        [Description("Not paged")]
        MemoryNotPaged = 0x08000000,

        /// <summary>
        /// The section can be shared in memory.
        /// </summary>
        [Description("Shared")]
        MemoryShared = 0x10000000,

        /// <summary>
        /// The section can be executed as code.
        /// </summary>
        [Description("Execute")]
        MemoryExecute = 0x20000000,

        /// <summary>
        /// The section can be read.
        /// </summary>
        [Description("Read")]
        MemoryRead = 0x40000000,

        /// <summary>
        /// The section can be written to.
        /// </summary>
        [Description("Write")]
        MemoryWrite = 0x80000000
    }
}
