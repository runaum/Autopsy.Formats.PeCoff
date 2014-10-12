using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public class NtHeader: IBinaryData
    {
        public uint Signature;

        public FileHeader FileHeader;

        public OptionalHeader OptionalHeader;

        public NtHeader() { }

        public NtHeader(IBinaryHelper binary)
        {
            Read(binary);
        }

        public void Read(IBinaryHelper binary)
        {
            Signature = binary.Reader.ReadUInt32();
            FileHeader = binary.MarshalAt<FileHeader>();
            OptionalHeader = new OptionalHeader(binary);
        }

        public const uint PeSignature = 0x00004550;

        public bool IsValid
        {
            get { return (Signature == PeSignature); }
        }

        #region Default static constructors

        public static NtHeader Empty
        {
            get
            {
                return new NtHeader
                {
                    Signature = 0, 
                    FileHeader = null,
                    OptionalHeader = null
                };
            }
        }

        public static NtHeader Default
        {
            get 
            {
                return new NtHeader
                {
                    Signature = 0x00004550, // 'PE\0\0',
                    FileHeader = null,
                    OptionalHeader = null
                };
            }
        }

        #endregion
    }
}
