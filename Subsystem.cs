using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public enum Subsystem: ushort
    {
        /// <summary>
        /// IMAGE_SUBSYSTEM_UNKNOWN: An unknown subsystem
        /// </summary>        
        Unknown = 0,

        /// <summary>
        /// IMAGE_SUBSYSTEM_NATIVE: Device drivers and native Windows processes
        /// </summary>        
        Native = 1,

        /// <summary>
        /// IMAGE_SUBSYSTEM_WINDOWS_GUI: The Windows graphical user interface (GUI) subsystem
        /// </summary>        
        WindowsGui = 2,

        /// <summary>
        /// IMAGE_SUBSYSTEM_WINDOWS_CUI: The Windows character subsystem
        /// </summary>        
        WindowsCui = 3,

        /// <summary>
        /// IMAGE_SUBSYSTEM_OS2_CUI: OS/2 CUI subsystem.
        /// </summary>        
        Os2Cui = 5,

        /// <summary>
        /// IMAGE_SUBSYSTEM_POSIX_CUI: The Posix character subsystem
        /// </summary>        
        PosixCui = 7,

        /// <summary>
        /// IMAGE_SUBSYSTEM_WINDOWS_CE_GUI: Windows CE
        /// </summary>        
        WindowsCEGui = 9,

        /// <summary>
        /// IMAGE_SUBSYSTEM_EFI_APPLICATION: An Extensible Firmware Interface (EFI) application
        /// </summary>        
        EfiApplication = 10,

        /// <summary>
        /// IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER: An EFI driver with boot services
        /// </summary>        
        EfiBootServiceDriver = 11,

        /// <summary>
        /// IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER: An EFI driver with run-time services
        /// </summary>        
        EfiRuntimeDriver = 12,

        /// <summary>
        /// IMAGE_SUBSYSTEM_EFI_ROM: An EFI ROM image
        /// </summary>       
        EfiRom = 13,

        /// <summary>
        /// IMAGE_SUBSYSTEM_XBOX: XBOX
        /// </summary>        
        Xbox = 14,

        /// <summary>
        /// IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION: Boot application.
        /// </summary>
        WindowsBootApplication = 16
    }
}
