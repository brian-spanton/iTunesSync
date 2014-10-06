namespace foobalator.iTunesSync
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct _tagpropertykey
    {
        public Guid fmtid;
        public uint pid;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct __MIDL___MIDL_itf_PortableDeviceApi_0001_0000_0001
    {
    }

    [ComImport, Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99"), InterfaceType((short)1)]
    public interface IPropertyStore
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount(out uint cProps);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAt([In] uint iProp, out _tagpropertykey pKey);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValue([In] ref _tagpropertykey key, out System.Runtime.InteropServices.VariantWrapper pv);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetValue([In] ref _tagpropertykey key, [In] ref System.Runtime.InteropServices.VariantWrapper propvar);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Commit();
    }

    [ComImport, InterfaceType((short)1), Guid("7F6D695C-03DF-4439-A809-59266BEEE3A6")]
    public interface IPortableDeviceProperties
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedProperties([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetPropertyAttributes([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValues([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppValues);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetValues([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResults);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Delete([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Cancel();
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct _LARGE_INTEGER
    {
        public long QuadPart;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct _ULARGE_INTEGER
    {
        public ulong QuadPart;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct _FILETIME
    {
        public uint dwLowDateTime;
        public uint dwHighDateTime;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct tagSTATSTG
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsName;
        public uint type;
        public _ULARGE_INTEGER cbSize;
        public _FILETIME mtime;
        public _FILETIME ctime;
        public _FILETIME atime;
        public uint grfMode;
        public uint grfLocksSupported;
        public Guid clsid;
        public uint grfStateBits;
        public uint reserved;
    }

    [ComImport, Guid("FD8878AC-D841-4D17-891C-E6829CDB6934"), InterfaceType((short)1)]
    public interface IPortableDeviceResources
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedResources([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetResourceAttributes([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResourceAttributes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStream([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In] ref _tagpropertykey key, [In] uint dwMode, [In, Out] ref uint pdwOptimalBufferSize, [MarshalAs(UnmanagedType.Interface)] out System.Runtime.InteropServices.ComTypes.IStream ppStream);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Delete([In, MarshalAs(UnmanagedType.LPWStr)] string pszObjectID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Cancel();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateResource([In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pResourceAttributes, [MarshalAs(UnmanagedType.Interface)] out System.Runtime.InteropServices.ComTypes.IStream ppData, [In, Out] ref uint pdwOptimalWriteBufferSize, [In, Out, MarshalAs(UnmanagedType.LPWStr)] ref string ppszCookie);
    }

    [ComImport, InterfaceType((short)1), Guid("10ECE955-CF41-4728-BFA0-41EEDF1BBF19")]
    public interface IEnumPortableDeviceObjectIDs
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Next([In] uint cObjects, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.LPWStr)] string[] pObjIDs, [In, Out] ref uint pcFetched);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Skip([In] uint cObjects);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumPortableDeviceObjectIDs ppenum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Cancel();
    }

    [ComImport, Guid("6A96ED84-7C73-4480-9938-BF5AF477D426"), InterfaceType((short)1)]
    public interface IPortableDeviceContent
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumObjects([In] uint dwFlags, [In, MarshalAs(UnmanagedType.LPWStr)] string pszParentObjectID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pFilter, [MarshalAs(UnmanagedType.Interface)] out IEnumPortableDeviceObjectIDs ppenum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Properties([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceProperties ppProperties);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Transfer([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceResources ppResources);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateObjectWithPropertiesOnly([In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues, [In, Out, MarshalAs(UnmanagedType.LPWStr)] ref string ppszObjectID);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CreateObjectWithPropertiesAndData([In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pValues, [MarshalAs(UnmanagedType.Interface)] out System.Runtime.InteropServices.ComTypes.IStream ppData, [In, Out] ref uint pdwOptimalWriteBufferSize, [In, Out, MarshalAs(UnmanagedType.LPWStr)] ref string ppszCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Delete([In] uint dwOptions, [In, MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pObjectIDs, [In, Out, MarshalAs(UnmanagedType.Interface)] ref IPortableDevicePropVariantCollection ppResults);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetObjectIDsFromPersistentUniqueIDs([In, MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pPersistentUniqueIDs, [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppObjectIDs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Cancel();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Move([In, MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pObjectIDs, [In, MarshalAs(UnmanagedType.LPWStr)] string pszDestinationFolderObjectID, [In, Out, MarshalAs(UnmanagedType.Interface)] ref IPortableDevicePropVariantCollection ppResults);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Copy([In, MarshalAs(UnmanagedType.Interface)] IPortableDevicePropVariantCollection pObjectIDs, [In, MarshalAs(UnmanagedType.LPWStr)] string pszDestinationFolderObjectID, [In, Out, MarshalAs(UnmanagedType.Interface)] ref IPortableDevicePropVariantCollection ppResults);
    }

    [ComImport, InterfaceType((short)1), Guid("2C8C6DBF-E3DC-4061-BECC-8542E810D126")]
    public interface IPortableDeviceCapabilities
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedCommands([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppCommands);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCommandOptions([In] ref _tagpropertykey Command, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppOptions);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunctionalCategories([MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppCategories);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFunctionalObjects([In] ref Guid Category, [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppObjectIDs);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedContentTypes([In] ref Guid Category, [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppContentTypes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedFormats([In] ref Guid ContentType, [MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppFormats);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedFormatProperties([In] ref Guid Format, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceKeyCollection ppKeys);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFixedPropertyAttributes([In] ref Guid Format, [In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppAttributes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Cancel();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSupportedEvents([MarshalAs(UnmanagedType.Interface)] out IPortableDevicePropVariantCollection ppEvents);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetEventOptions([In] ref Guid Event, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppOptions);
    }

    [ComImport, Guid("A8792A31-F385-493C-A893-40F64EB45F6E"), InterfaceType((short)1)]
    public interface IPortableDeviceEventCallback
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OnEvent([In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pEventParameters);
    }

    [ComImport, Guid("625E2DF8-6392-4CF0-9AD1-3CFA5F17775C"), InterfaceType((short)1)]
    public interface IPortableDevice
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Open([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pClientInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SendCommand([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResults);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Content([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceContent ppContent);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Capabilities([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceCapabilities ppCapabilities);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Cancel();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Close();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Advise([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceEventCallback pCallback, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters, [MarshalAs(UnmanagedType.LPWStr)] out string ppszCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Unadvise([In, MarshalAs(UnmanagedType.LPWStr)] string pszCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetPnPDeviceID([MarshalAs(UnmanagedType.LPWStr)] out string ppszPnPDeviceID);
    }

    [ComImport, Guid("625E2DF8-6392-4CF0-9AD1-3CFA5F17775C"), CoClass(typeof(PortableDeviceClass))]
    public interface PortableDevice : IPortableDevice
    {
    }

    [ComImport, ClassInterface((short)0), TypeLibType((short)2), Guid("728A21C5-3D9E-48D7-9810-864848F0F404")]
    public class PortableDeviceClass : IPortableDevice, PortableDevice
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Advise([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceEventCallback pCallback, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters, [MarshalAs(UnmanagedType.LPWStr)] out string ppszCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Cancel();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Capabilities([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceCapabilities ppCapabilities);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Close();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Content([MarshalAs(UnmanagedType.Interface)] out IPortableDeviceContent ppContent);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetPnPDeviceID([MarshalAs(UnmanagedType.LPWStr)] out string ppszPnPDeviceID);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Open([In, MarshalAs(UnmanagedType.LPWStr)] string pszPnPDeviceID, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pClientInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SendCommand([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceValues pParameters, [MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues ppResults);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Unadvise([In, MarshalAs(UnmanagedType.LPWStr)] string pszCookie);
    }
}
