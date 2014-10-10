using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public class PeFile
    {
        public DosHeader DosHeader;

        public byte[] DosStubProgram;

        public NtHeader NtHeader;

        public FileHeader FileHeader
        { 
            get 
            { 
                return NtHeader != null ? NtHeader.FileHeader : null; 
            }
            set
            {
                if (NtHeader == null)
                    NtHeader = NtHeader.Default;

                NtHeader.FileHeader = value;
            }
        }

        public OptionalHeader OptionalHeader
        {
            get
            {
                return NtHeader != null ? NtHeader.OptionalHeader : null;
            }
            set
            {
                if (NtHeader == null)
                    NtHeader = NtHeader.Default;

                NtHeader.OptionalHeader = value;
            }
        }

        private void Read(Stream stream)
        {
            // TODO
        }

        public PeFile(string fileName)
        {
            using (var stream = File.OpenRead(fileName))
            {
                Read(stream);
            }
        }

        public PeFile(Stream stream)
        {
            Read(stream);
        }

        public static PeFile Load(string fileName)
        {
            return new PeFile(fileName);
        }

        public static PeFile Load(Stream stream)
        {
            return new PeFile(stream);
        }
    }
}
