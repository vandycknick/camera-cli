using System;

namespace CameraCli.Native
{
    [Flags]
    internal enum ClassInstallerFunctionCode : uint
    {
        DIF_SELECTDEVICE = 0x1,
        DIF_INSTALLDEVICE = 0x2,
        DIF_ASSIGNRESOURCES = 0x3,
        DIF_PROPERTIES = 0x4,
        DIF_REMOVE = 0x5,
        DIF_FIRSTTIMESETUP = 0x6,
        DIF_FOUNDDEVICE = 0x7,
        DIF_SELECTCLASSDRIVERS = 0x8,
        DIF_VALIDATECLASSDRIVERS = 0x9,
        DIF_INSTALLCLASSDRIVERS = 0xA,
        DIF_CALCDISKSPACE = 0xB,
        DIF_DESTROYPRIVATEDATA = 0xC,
        DIF_VALIDATEDRIVER = 0xD,
        DIF_DETECT = 0xF,
        DIF_INSTALLWIZARD = 0x10,
        DIF_DESTROYWIZARDDATA = 0x11,
        DIF_PROPERTYCHANGE = 0x12,
        DIF_ENABLECLASS = 0x13,
        DIF_DETECTVERIFY = 0x14,
        DIF_INSTALLDEVICEFILES = 0x15,
        DIF_UNREMOVE = 0x16,
        DIF_SELECTBESTCOMPATDRV = 0x17,
        DIF_ALLOW_INSTALL = 0x18,
        DIF_REGISTERDEVICE = 0x19,
        DIF_NEWDEVICEWIZARD_PRESELECT = 0x1A,
        DIF_NEWDEVICEWIZARD_SELECT = 0x1B,
        DIF_NEWDEVICEWIZARD_PREANALYZE = 0x1C,
        DIF_NEWDEVICEWIZARD_POSTANALYZE = 0x1D,
        DIF_NEWDEVICEWIZARD_FINISHINSTALL = 0x1E,
        DIF_UNUSED1 = 0x1F,
        DIF_INSTALLINTERFACES = 0x20,
        DIF_DETECTCANCEL = 0x21,
        DIF_REGISTER_COINSTALLERS = 0x22,
        DIF_ADDPROPERTYPAGE_ADVANCED = 0x23,
        DIF_ADDPROPERTYPAGE_BASIC = 0x24,
        DIF_RESERVED1 = 0x25,
        DIF_TROUBLESHOOTER = 0x26,
        DIF_POWERMESSAGEWAKE = 0x27,
        DIF_ADDREMOTEPROPERTYPAGE_ADVANCED = 0x28,
        DIF_UPDATEDRIVER_UI = 0x29,
        DIF_FINISHINSTALL_ACTION = 0x2A,
        DIF_RESERVED2 = 0x30
    }
}