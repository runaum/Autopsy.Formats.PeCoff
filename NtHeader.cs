using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public class NtHeader
    {
        public char[] Signature;

        public FileHeader FileHeader;

        public OptionalHeader OptionalHeader;

        public NtHeader()
        {
            // TODO
        }

        public static NtHeader Default
        {
            get 
            {
                return new NtHeader
                {
                    Signature = new [] { 'P', 'E', (char)0, (char)0 },
                    FileHeader = null,
                    OptionalHeader = null
                };
            }
        }
    }
}
