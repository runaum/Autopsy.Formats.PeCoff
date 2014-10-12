using System.IO;

namespace Autopsy.Formats.PeCoff.Common
{
    public interface IBinaryHelper
    {
        Stream Stream { get; }
        BinaryReader Reader { get; }

        T MarshalAt<T>(long offset = -1);
        bool CanRead(long size);
        bool TrySeekTo(long offset);
        bool IsValidOffset(long offset);
        void SeekTo(long offset);
    }
}
