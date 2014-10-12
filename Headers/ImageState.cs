using System.ComponentModel;

namespace Autopsy.Formats.PeCoff.Headers
{
    /// <summary>
    /// The state of the image file.
    /// </summary>
    public enum ImageState: ushort
    {
        /// <summary>
        /// IMAGE_NT_OPTIONAL_HDR32_MAGIC: The file is an executable image.
        /// </summary>
        [Description("PE32")]
        Pe32 = 0x10b,

        /// <summary>
        /// IMAGE_NT_OPTIONAL_HDR64_MAGIC: The file is an executable image.
        /// </summary>
        [Description("PE32+")]
        Pe32Plus = 0x20b,

        /// <summary>
        /// IMAGE_ROM_OPTIONAL_HDR_MAGIC: The file is a ROM image.
        /// </summary>
        [Description("ROM")]
        Rom = 0x107
    }
}
