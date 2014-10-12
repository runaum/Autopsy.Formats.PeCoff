using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    /// <summary>
    /// The state of the image file.
    /// </summary>
    public enum ImageState//: ushort
    {
        /// <summary>
        /// IMAGE_NT_OPTIONAL_HDR32_MAGIC: The file is an executable image.
        /// </summary>
        [Description("PE32")]
        PE32 = 0x10b,

        /// <summary>
        /// IMAGE_NT_OPTIONAL_HDR64_MAGIC: The file is an executable image.
        /// </summary>
        [Description("PE32+")]
        PE32Plus = 0x20b,

        /// <summary>
        /// IMAGE_ROM_OPTIONAL_HDR_MAGIC: The file is a ROM image.
        /// </summary>
        [Description("ROM")]
        ROM = 0x107
    }
}
