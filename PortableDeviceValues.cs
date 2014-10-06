namespace foobalator.iTunesSync
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct __MIDL___MIDL_itf_PortableDeviceTypes_0003_0015_0001
    {
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct tag_inner_PROPVARIANT
    {
        public ushort vt;
        public byte wReserved1;
        public byte wReserved2;
        public uint wReserved3;
        public __MIDL___MIDL_itf_PortableDeviceTypes_0003_0015_0001 __MIDL____MIDL_itf_PortableDeviceTypes_0003_00150001;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PropVariant
    {
        [FieldOffset(0)]
        public short variantType;
        [FieldOffset(8)]
        public IntPtr pointerValue;
        [FieldOffset(8)]
        public byte byteValue;
        [FieldOffset(8)]
        public long longValue;
    } 

    [ComImport, InterfaceType((short)1), Guid("89B2E422-4F1B-4316-BCEF-A44AFEA83EB3")]
    public interface IPortableDevicePropVariantCollection
    {
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void GetCount([In] ref uint pcElems);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount([In, Out] ref uint pcElems);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAt([In] uint dwIndex, [In] ref tag_inner_PROPVARIANT pValue);

        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void Add([In] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Add([In] System.Runtime.InteropServices.VariantWrapper pValue);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetType(out ushort pvt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ChangeType([In] ushort vt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveAt([In] uint dwIndex);
    }

    [ComImport, Guid("89B2E422-4F1B-4316-BCEF-A44AFEA83EB3"), CoClass(typeof(PortableDevicePropVariantCollectionClass))]
    public interface PortableDevicePropVariantCollection : IPortableDevicePropVariantCollection
    {
    }

    [ComImport, TypeLibType((short)2), ClassInterface((short)0), Guid("08A99E2F-6D6D-4B80-AF5A-BAF2BCBE4CB9")]
    public class PortableDevicePropVariantCollectionClass : IPortableDevicePropVariantCollection, PortableDevicePropVariantCollection
    {
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //public virtual extern void Add([In] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Add([In] System.Runtime.InteropServices.VariantWrapper pValue);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ChangeType([In] ushort vt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetAt([In] uint dwIndex, [In] ref tag_inner_PROPVARIANT pValue);

        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //public virtual extern void GetCount([In] ref uint pcElems);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCount([In, Out] ref uint pcElems);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetType(out ushort pvt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RemoveAt([In] uint dwIndex);
    }

    [ComImport, InterfaceType((short)1), Guid("DADA2357-E0AD-492E-98DB-DD61C53BA353")]
    public interface IPortableDeviceKeyCollection
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount([In] ref uint pcElems);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAt([In] uint dwIndex, [In] ref _tagpropertykey pKey);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Add([In] ref _tagpropertykey key);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveAt([In] uint dwIndex);
    }

    [ComImport, CoClass(typeof(PortableDeviceKeyCollectionClass)), Guid("DADA2357-E0AD-492E-98DB-DD61C53BA353")]
    public interface PortableDeviceKeyCollection : IPortableDeviceKeyCollection
    {
    }

    [ComImport, ClassInterface((short)0), Guid("DE2D022D-2480-43BE-97F0-D1FA2CF98F4F"), TypeLibType((short)2)]
    public class PortableDeviceKeyCollectionClass : IPortableDeviceKeyCollection, PortableDeviceKeyCollection
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Add([In] ref _tagpropertykey key);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetAt([In] uint dwIndex, [In] ref _tagpropertykey pKey);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCount([In] ref uint pcElems);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RemoveAt([In] uint dwIndex);
    }

    [ComImport, Guid("6E3F2D79-4E07-48C4-8208-D8C2E5AF4A99"), InterfaceType((short)1)]
    public interface IPortableDeviceValuesCollection
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount([In] ref uint pcElems);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAt([In] uint dwIndex, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceValues ppValues);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Add([In, MarshalAs(UnmanagedType.Interface)] PortableDeviceValues pValues);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveAt([In] uint dwIndex);
    }

    [ComImport, Guid("6E3F2D79-4E07-48C4-8208-D8C2E5AF4A99"), CoClass(typeof(PortableDeviceValuesCollectionClass))]
    public interface PortableDeviceValuesCollection : IPortableDeviceValuesCollection
    {
    }

    [ComImport, Guid("3882134D-14CF-4220-9CB4-435F86D83F60"), TypeLibType((short)2), ClassInterface((short)0)]
    public class PortableDeviceValuesCollectionClass : IPortableDeviceValuesCollection, PortableDeviceValuesCollection
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Add([In, MarshalAs(UnmanagedType.Interface)] PortableDeviceValues pValues);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetAt([In] uint dwIndex, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceValues ppValues);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCount([In] ref uint pcElems);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RemoveAt([In] uint dwIndex);
    }

    [ComImport, InterfaceType((short)1), ComConversionLoss, Guid("6848F6F2-3155-4F86-B6F5-263EEEAB3143")]
    public interface IPortableDeviceValues
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetCount([In] ref uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetAt([In] uint index, [In, Out] ref _tagpropertykey pKey, [In, Out] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetValue([In] ref _tagpropertykey key, [In] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValue([In] ref _tagpropertykey key, out tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetStringValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.LPWStr)] string Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetStringValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.LPWStr)] out string pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetUnsignedIntegerValue([In] ref _tagpropertykey key, [In] uint Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetUnsignedIntegerValue([In] ref _tagpropertykey key, out uint pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetSignedIntegerValue([In] ref _tagpropertykey key, [In] int Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSignedIntegerValue([In] ref _tagpropertykey key, out int pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetUnsignedLargeIntegerValue([In] ref _tagpropertykey key, [In] ulong Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetUnsignedLargeIntegerValue([In] ref _tagpropertykey key, out ulong pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetSignedLargeIntegerValue([In] ref _tagpropertykey key, [In] long Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetSignedLargeIntegerValue([In] ref _tagpropertykey key, out long pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetFloatValue([In] ref _tagpropertykey key, [In] float Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetFloatValue([In] ref _tagpropertykey key, out float pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetErrorValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Error)] int Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetErrorValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Error)] out int pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetKeyValue([In] ref _tagpropertykey key, [In] ref _tagpropertykey Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetKeyValue([In] ref _tagpropertykey key, out _tagpropertykey pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetBoolValue([In] ref _tagpropertykey key, [In] int Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetBoolValue([In] ref _tagpropertykey key, out int pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIUnknownValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.IUnknown)] object pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIUnknownValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.IUnknown)] out object ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetGuidValue([In] ref _tagpropertykey key, [In] ref Guid Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetGuidValue([In] ref _tagpropertykey key, out Guid pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetBufferValue([In] ref _tagpropertykey key, [In] ref byte pValue, [In] uint cbValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetBufferValue([In] ref _tagpropertykey key, [Out] IntPtr ppValue, out uint pcbValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIPortableDeviceValuesValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDeviceValues pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIPortableDeviceValuesValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceValues ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIPortableDevicePropVariantCollectionValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDevicePropVariantCollection pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIPortableDevicePropVariantCollectionValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDevicePropVariantCollection ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIPortableDeviceKeyCollectionValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDeviceKeyCollection pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIPortableDeviceKeyCollectionValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceKeyCollection ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetIPortableDeviceValuesCollectionValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDeviceValuesCollection pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetIPortableDeviceValuesCollectionValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceValuesCollection ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveValue([In] ref _tagpropertykey key);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CopyValuesFromPropertyStore([In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pStore);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CopyValuesToPropertyStore([In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pStore);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Clear();
    }

    [ComImport, Guid("6848F6F2-3155-4F86-B6F5-263EEEAB3143"), CoClass(typeof(PortableDeviceValuesClass))]
    public interface PortableDeviceValues : IPortableDeviceValues
    {
    }
   
    [ComImport, ComConversionLoss, Guid("0C15D503-D017-47CE-9016-7B3F978721CC"), TypeLibType((short)2), ClassInterface((short)0)]
    public class PortableDeviceValuesClass : IPortableDeviceValues, PortableDeviceValues
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void Clear();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void CopyValuesFromPropertyStore([In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pStore);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void CopyValuesToPropertyStore([In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pStore);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetAt([In] uint index, [In, Out] ref _tagpropertykey pKey, [In, Out] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetBoolValue([In] ref _tagpropertykey key, out int pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetBufferValue([In] ref _tagpropertykey key, [Out] IntPtr ppValue, out uint pcbValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCount([In] ref uint pcelt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetErrorValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Error)] out int pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetFloatValue([In] ref _tagpropertykey key, out float pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetGuidValue([In] ref _tagpropertykey key, out Guid pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetIPortableDeviceKeyCollectionValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceKeyCollection ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetIPortableDevicePropVariantCollectionValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDevicePropVariantCollection ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetIPortableDeviceValuesCollectionValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceValuesCollection ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetIPortableDeviceValuesValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.Interface)] out PortableDeviceValues ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetIUnknownValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.IUnknown)] out object ppValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetKeyValue([In] ref _tagpropertykey key, out _tagpropertykey pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetSignedIntegerValue([In] ref _tagpropertykey key, out int pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetSignedLargeIntegerValue([In] ref _tagpropertykey key, out long pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetStringValue([In] ref _tagpropertykey key, [MarshalAs(UnmanagedType.LPWStr)] out string pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetUnsignedIntegerValue([In] ref _tagpropertykey key, out uint pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetUnsignedLargeIntegerValue([In] ref _tagpropertykey key, out ulong pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetValue([In] ref _tagpropertykey key, out tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RemoveValue([In] ref _tagpropertykey key);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetBoolValue([In] ref _tagpropertykey key, [In] int Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetBufferValue([In] ref _tagpropertykey key, [In] ref byte pValue, [In] uint cbValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetErrorValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Error)] int Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetFloatValue([In] ref _tagpropertykey key, [In] float Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetGuidValue([In] ref _tagpropertykey key, [In] ref Guid Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetIPortableDeviceKeyCollectionValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDeviceKeyCollection pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetIPortableDevicePropVariantCollectionValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDevicePropVariantCollection pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetIPortableDeviceValuesCollectionValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDeviceValuesCollection pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetIPortableDeviceValuesValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.Interface)] PortableDeviceValues pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetIUnknownValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.IUnknown)] object pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetKeyValue([In] ref _tagpropertykey key, [In] ref _tagpropertykey Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetSignedIntegerValue([In] ref _tagpropertykey key, [In] int Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetSignedLargeIntegerValue([In] ref _tagpropertykey key, [In] long Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetStringValue([In] ref _tagpropertykey key, [In, MarshalAs(UnmanagedType.LPWStr)] string Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetUnsignedIntegerValue([In] ref _tagpropertykey key, [In] uint Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetUnsignedLargeIntegerValue([In] ref _tagpropertykey key, [In] ulong Value);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetValue([In] ref _tagpropertykey key, [In] ref tag_inner_PROPVARIANT pValue);
    }

    public static class Constants
    {
        public static readonly Guid WPD_CONTENT_TYPE_FOLDER = new Guid(0x27E2E392, 0xA111, 0x48E0, 0xAB, 0x0C, 0xE1, 0x77, 0x05, 0xA0, 0x5F, 0x85);
        public static readonly Guid WPD_CONTENT_TYPE_AUDIO = new Guid(0x4AD2C85E, 0x5E2D, 0x45E5, 0x88, 0x64, 0x4F, 0x22, 0x9E, 0x3C, 0x6C, 0xF0);
        public static readonly Guid WPD_CONTENT_TYPE_PLAYLIST = new Guid(0x1A33F7E4, 0xAF13, 0x48F5, 0x99, 0x4E, 0x77, 0x36, 0x9D, 0xFE, 0x04, 0xA3);
        public static readonly Guid WPD_CONTENT_TYPE_AUDIO_ALBUM = new Guid(0xAA18737E, 0x5009, 0x48FA, 0xAE, 0x21, 0x85, 0xF2, 0x43, 0x83, 0xB4, 0xE6);
        public static readonly Guid WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT = new Guid(0x99ED0160, 0x17FF, 0x4C44, 0x9D, 0x98, 0x1D, 0x7A, 0x6F, 0x94, 0x19, 0x21);
        public static readonly Guid WPD_OBJECT_FORMAT_M4A = new Guid(0x30ABA7AC, 0x6FFD, 0x4C23, 0xA3, 0x59, 0x3E, 0x9B, 0x52, 0xF3, 0xF1, 0xC8);
        public static readonly Guid WPD_OBJECT_FORMAT_PROPERTIES_ONLY = new Guid(0x30010000, 0xAE6C, 0x4804, 0x98, 0xBA, 0xC5, 0x7B, 0x46, 0x96, 0x5F, 0xE7);
        public static readonly Guid WPD_OBJECT_FORMAT_MP3 = new Guid(0x30090000, 0xAE6C, 0x4804, 0x98, 0xBA, 0xC5, 0x7B, 0x46, 0x96, 0x5F, 0xE7);
        public static readonly Guid WPD_OBJECT_FORMAT_WPLPLAYLIST = new Guid(0xBA100000, 0xAE6C, 0x4804, 0x98, 0xBA, 0xC5, 0x7B, 0x46, 0x96, 0x5F, 0xE7);

        public static readonly _tagpropertykey WPD_CLIENT_DESIRED_ACCESS = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_PARENT_ID = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_NAME = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_CONTENT_TYPE = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_FORMAT = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_ORIGINAL_FILE_NAME = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_SIZE = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_REFERENCES = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_FOLDER_CONTENT_TYPES_ALLOWED = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_MEDIA_ALBUM_ARTIST = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_MEDIA_ARTIST = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_MUSIC_TRACK = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_MUSIC_ALBUM = new _tagpropertykey();
        public static readonly _tagpropertykey WPD_OBJECT_ID = new _tagpropertykey();

        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;

        static Constants()
        {
            WPD_CLIENT_DESIRED_ACCESS.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_DESIRED_ACCESS.pid = 9;

            WPD_OBJECT_PARENT_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_PARENT_ID.pid = 3;

            WPD_OBJECT_NAME.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_NAME.pid = 4;

            WPD_OBJECT_CONTENT_TYPE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_CONTENT_TYPE.pid = 7;

            WPD_OBJECT_FORMAT.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_FORMAT.pid = 6;

            WPD_OBJECT_ORIGINAL_FILE_NAME.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_ORIGINAL_FILE_NAME.pid = 12;

            WPD_OBJECT_SIZE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_SIZE.pid = 11;

            WPD_OBJECT_REFERENCES.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_REFERENCES.pid = 14;

            WPD_FOLDER_CONTENT_TYPES_ALLOWED.fmtid = new Guid(0x7E9A7ABF, 0xE568, 0x4B34, 0xAA, 0x2F, 0x13, 0xBB, 0x12, 0xAB, 0x17, 0x7D);
            WPD_FOLDER_CONTENT_TYPES_ALLOWED.pid = 2;

            WPD_MEDIA_ALBUM_ARTIST.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_ALBUM_ARTIST.pid = 25;

            WPD_MEDIA_ARTIST.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_ARTIST.pid = 24;

            WPD_MUSIC_TRACK.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_MUSIC_TRACK.pid = 4;

            WPD_MUSIC_ALBUM.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_MUSIC_ALBUM.pid = 3;

            WPD_OBJECT_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_ID.pid = 2;
        }

        public static tag_inner_PROPVARIANT ToPropVariant(string value)
        {
            PortableDeviceValues values = new PortableDeviceValues();
            values.SetStringValue(Constants.WPD_OBJECT_ID, value);

            tag_inner_PROPVARIANT result;
            values.GetValue(Constants.WPD_OBJECT_ID, out result);
            return result;
        }
    }
}
