using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public class BinaryHelper: IBinaryHelper
    {
        private Stream _stream;
        public Stream Stream { get { return _stream; } }

        private BinaryReader _reader;
        public BinaryReader Reader { get { return _reader; } }

        protected virtual void ReadInternal(Stream stream) {}

        protected void Read(Stream stream)
        {
            _stream = stream;
            _reader = new BinaryReader(Stream);

            ReadInternal(Stream);
        }

        public virtual void SeekTo(long offset)
        {
            Stream.Seek(offset, SeekOrigin.Begin);
        }

        public bool IsValidOffset(long offset)
        {
            return (offset >= 0 && offset < Stream.Length);
        }

        public bool TrySeekTo(long offset)
        {
            try
            {
                if (!IsValidOffset(offset))
                    return false;
                SeekTo(offset);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CanRead(long size)
        {
            return (Stream.Position + size <= Stream.Length);
        }

        public T MarshalAt<T>(long offset = -1)
        {
            if (offset >= 0)
            {
                if (!TrySeekTo(offset))
                    throw new Exception("Corrupted image?");
            }

            var size = Marshal.SizeOf(typeof(T));
            if (!CanRead(size))
                throw new Exception("Corrupted image?");

            try
            {
                var bytes = Reader.ReadBytes(size);
                GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                T result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
                handle.Free();
                return result;
            }
            catch
            {
                return default(T);
            }
        }
    }
}
