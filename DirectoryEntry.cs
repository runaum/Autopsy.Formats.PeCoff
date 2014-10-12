using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public static class DirectoryEntry
    {
        public const uint IMAGE_DIRECTORY_ENTRY_EXPORT = 0;
        public const uint IMAGE_DIRECTORY_ENTRY_IMPORT = 1;
        public const uint IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;
        public const uint IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;
        public const uint IMAGE_DIRECTORY_ENTRY_SECURITY = 4;
        public const uint IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;
        public const uint IMAGE_DIRECTORY_ENTRY_DEBUG = 6;
        public const uint IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;
        public const uint IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;
        public const uint IMAGE_DIRECTORY_ENTRY_TLS = 9;
        public const uint IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;
        public const uint IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;
        public const uint IMAGE_DIRECTORY_ENTRY_IAT = 12;
        public const uint IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;
        public const uint IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;
    }
}
