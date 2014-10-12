using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Autopsy.Formats.PeCoff.Common
{
    public class BinaryHelper: IBinaryHelper
    {
        public Stream Stream { get; private set; }
        public BinaryReader Reader { get; private set; }

        protected virtual void ReadInternal(Stream stream) {}

        protected void Read(Stream stream)
        {
            Stream = stream;
            Reader = new BinaryReader(Stream);

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
                var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                var result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
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
