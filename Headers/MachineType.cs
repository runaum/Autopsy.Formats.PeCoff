namespace Autopsy.Formats.PeCoff.Headers
{
    /// <summary>
    /// IMAGE_FILE_MACHINE: The Machine field has one of the following values that specifies its CPU type. 
    /// An image file can be run only on the specified machine or on a system that emulates the specified machine.
    /// </summary>
    public enum MachineType: ushort
    {
        /// <summary>
        /// IMAGE_FILE_MACHINE_UNKNOWN: The contents of this field are assumed to be applicable to any machine type
        /// </summary>
        Unknown = 0x00,

        /// <summary>
        /// IMAGE_FILE_MACHINE_AM33: Matsushita AM33
        /// </summary>
        AM33 = 0x1d3,

        /// <summary>
        /// IMAGE_FILE_MACHINE_AMD64: x64
        /// </summary>
        AMD64 = 0x8664,

        /// <summary>
        /// IMAGE_FILE_MACHINE_ARM: ARM little endian
        /// </summary>
        ARM = 0x1c0,

        /// <summary>
        /// IMAGE_FILE_MACHINE_ARMNT: ARMv7 (or higher) Thumb mode only
        /// </summary>
        ARMNT = 0x1c4,

        /// <summary>
        /// IMAGE_FILE_MACHINE_ARM64: ARMv8 in 64-bit mode
        /// </summary>
        ARM64 = 0xaa64,

        /// <summary>
        /// IMAGE_FILE_MACHINE_EBC: EFI byte code
        /// </summary>
        EBC = 0xebc,

        /// <summary>
        /// IMAGE_FILE_MACHINE_I386: Intel 386 or later processors and compatible processors
        /// </summary>
        i386 = 0x14c,

        /// <summary>
        /// IMAGE_FILE_MACHINE_IA64: Intel Itanium processor family
        /// </summary>
        IA64 = 0x200,

        /// <summary>
        /// IMAGE_FILE_MACHINE_M32R: Mitsubishi M32R little endian
        /// </summary>
        M32R = 0x9041,

        /// <summary>
        /// IMAGE_FILE_MACHINE_MIPS16: MIPS16
        /// </summary>
        MIPS16 = 0x266,

        /// <summary>
        /// IMAGE_FILE_MACHINE_MIPSFPU: MIPS with FPU
        /// </summary>
        MIPSFPU = 0x366,

        /// <summary>
        /// IMAGE_FILE_MACHINE_MIPSFPU16: MIPS16 with FPU
        /// </summary>
        MIPSFPU16 = 0x466,

        /// <summary>
        /// IMAGE_FILE_MACHINE_POWERPC: Power PC little endian
        /// </summary>
        PowerPC = 0x1f0,

        /// <summary>
        /// IMAGE_FILE_MACHINE_POWERPCFP: Power PC with floating point support
        /// </summary>
        PowerPCFloatingPoint = 0x1f1,

        /// <summary>
        /// IMAGE_FILE_MACHINE_R4000: MIPS little endian
        /// </summary>
        R4000 = 0x166,

        /// <summary>
        /// IMAGE_FILE_MACHINE_SH3: Hitachi SH3
        /// </summary>
        SH3 = 0x1a2,

        /// <summary>
        /// IMAGE_FILE_MACHINE_SH3DSP: Hitachi SH3 DSP
        /// </summary>
        SH3DSP = 0x1a3,

        /// <summary>
        /// IMAGE_FILE_MACHINE_SH4: Hitachi SH4
        /// </summary>
        SH4 = 0x1a6,

        /// <summary>
        /// IMAGE_FILE_MACHINE_SH5: Hitachi SH5
        /// </summary>
        SH5 = 0x1a8,

        /// <summary>
        /// IMAGE_FILE_MACHINE_THUMB: ARM or Thumb (“interworking”)
        /// </summary>
        Thumb = 0x1c2,

        /// <summary>
        /// IMAGE_FILE_MACHINE_WCEMIPSV2: MIPS little-endian WCE v2
        /// </summary>
        WCEMIPSv2 = 0x169
    }
}
