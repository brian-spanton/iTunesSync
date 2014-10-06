namespace foobalator.iTunesSync
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType((short)1), Guid("A1567595-4C2F-4574-A6FA-ECEF917B9A40")]
    public interface IPortableDeviceManager
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDevices([In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1, ArraySubType = UnmanagedType.LPWStr)] string[] pPnPDeviceIDs, [In, Out] ref uint pcPnPDeviceIDs);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDeviceFriendlyName([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.U2)] ushort[] pDeviceFriendlyName, [In, Out] ref uint pcchDeviceFriendlyName);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDeviceDescription([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.U2)] char[] pDeviceDescription, [In, Out] ref uint pcchDeviceDescription);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RefreshDeviceList();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDeviceManufacturer([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, Out] ref ushort pDeviceManufacturer, [In, Out] ref uint pcchDeviceManufacturer);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDeviceProperty([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, MarshalAs(UnmanagedType.LPWStr)] string pszDevicePropertyName, [In, Out] ref byte pData, [In, Out] ref uint pcbData, [In, Out] ref uint pdwType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetPrivateDevices([In, Out, MarshalAs(UnmanagedType.LPWStr)] ref string pPnPDeviceIDs, [In, Out] ref uint pcPnPDeviceIDs);
    }

    [ComImport, Guid("A1567595-4C2F-4574-A6FA-ECEF917B9A40"), CoClass(typeof(PortableDeviceManagerClass))]
    public interface PortableDeviceManager : IPortableDeviceManager
    {
    }

    [ComImport, TypeLibType((short)2), ClassInterface((short)0), Guid("0AF10CEC-2ECD-4B92-9581-34F6AE0637F3")]
    public class PortableDeviceManagerClass
    {
        // Methods
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetDevices([In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1, ArraySubType = UnmanagedType.LPWStr)] string[] pPnPDeviceIDs, [In, Out] ref uint pcPnPDeviceIDs);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetDeviceFriendlyName([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.U2)] ushort[] pDeviceFriendlyName, [In, Out] ref uint pcchDeviceFriendlyName);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetDeviceDescription([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.U2)] char[] pDeviceDescription, [In, Out] ref uint pcchDeviceDescription);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetDeviceManufacturer([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, Out] ref ushort pDeviceManufacturer, [In, Out] ref uint pcchDeviceManufacturer);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetDeviceProperty([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, MarshalAs(UnmanagedType.LPWStr)] string pszDevicePropertyName, [In, Out] ref byte pData, [In, Out] ref uint pcbData, [In, Out] ref uint pdwType);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetPrivateDevices([In, Out, MarshalAs(UnmanagedType.LPWStr)] ref string pPnPDeviceIDs, [In, Out] ref uint pcPnPDeviceIDs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RefreshDeviceList();
    }
}
