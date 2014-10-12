using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public interface IBinaryData
    {
        void Read(IBinaryHelper binary);
    }
}
