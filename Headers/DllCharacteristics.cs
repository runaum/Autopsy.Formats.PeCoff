using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    [Flags]
    public enum DllCharacteristics: ushort
    {
        /// <summary>
        /// Reserved, must be zero.
        /// </summary>        
        Reserved1 = 0x0001,	

        /// <summary>
        /// Reserved, must be zero.
        /// </summary>        
	    Reserved2 = 0x0002,	

        /// <summary>
        /// Reserved, must be zero.
        /// </summary>        
	    Reserved4 = 0x0004,	

        /// <summary>
        /// Reserved, must be zero.
        /// </summary>        
	    Reserved8 = 0x0008,	

        /// <summary>
        /// IMAGE_DLL_CHARACTERISTICS_DYNAMIC_BASE: DLL can be relocated at load time.
        /// </summary>        
        DynamicBase = 0x0040,

        /// <summary>
        /// IMAGE_DLL_CHARACTERISTICS_FORCE_INTEGRITY: Code Integrity checks are enforced.
        /// </summary>        
        ForceIntegrity = 0x0080,

        /// <summary>
        /// IMAGE_DLL_CHARACTERISTICS_NX_COMPAT: Image is NX compatible.
        /// </summary>        
        NxCompat = 0x0100,

        /// <summary>
        /// IMAGE_DLLCHARACTERISTICS_NO_ISOLATION: Isolation aware, but do not isolate the image.
        /// </summary>        
        NoIsolation = 0x0200,

        /// <summary>
        /// IMAGE_DLLCHARACTERISTICS_NO_SEH: Does not use structured exception (SE) handling. No SE handler may be called in this image.
        /// </summary>        
        NoSEH = 0x0400,

        /// <summary>
        /// IMAGE_DLLCHARACTERISTICS_NO_BIND: Do not bind the image.
        /// </summary>        
        NoBind = 0x0800,

        /// <summary>
        /// Reserved, must be zero.
        /// </summary>        
	    Reserved1000 = 0x1000,	

        /// <summary>
        /// IMAGE_DLLCHARACTERISTICS_WDM_DRIVER: A WDM driver.
        /// </summary>        
        WdmDriver = 0x2000,

        /// <summary>
        /// Reserved, must be zero.
        /// </summary> 
        Reserved4000 = 0x4000,

        /// <summary>
        /// IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE: Terminal Server aware.
        /// </summary>        
        TerminalServerAware = 0x8000
    }
}
