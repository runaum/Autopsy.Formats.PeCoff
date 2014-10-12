using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
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
