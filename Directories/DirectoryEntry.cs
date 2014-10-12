using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public static class DirectoryEntry
    {
        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_EXPORT
        /// </summary>
        public const uint Export = 0;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_IMPORT
        /// </summary>
        public const uint Import = 1;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_RESOURCE
        /// </summary>
        public const uint Resource = 2;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_EXCEPTION
        /// </summary>
        public const uint Exception = 3;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_SECURITY
        /// </summary>
        public const uint Security = 4;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_BASERELOC
        /// </summary>
        public const uint BaseReloc = 5;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_DEBUG
        /// </summary>
        public const uint Debug = 6;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_ARCHITECTURE
        /// </summary>
        public const uint Architecture = 7;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_GLOBALPTR
        /// </summary>
        public const uint GlobalPtr = 8;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_TLS
        /// </summary>
        public const uint TLS = 9;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG
        /// </summary>
        public const uint LoadConfig = 10;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT
        /// </summary>
        public const uint BoundImport = 11;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_IAT
        /// </summary>
        public const uint IAT = 12;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT
        /// </summary>
        public const uint DelayImport = 13;

        /// <summary>
        /// IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR
        /// </summary>
        public const uint ComDescriptor = 14;

        /// <summary>
        /// Reserved
        /// </summary>
        public const uint Reserved = 15;
    }
}
