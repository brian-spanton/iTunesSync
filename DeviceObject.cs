namespace foobalator.iTunesSync
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DeviceObject
    {
        private static readonly PortableDeviceKeyCollection SearchKeys = new PortableDeviceKeyCollection();

        static DeviceObject()
        {
            SearchKeys.Add(Constants.WPD_OBJECT_NAME);
            SearchKeys.Add(Constants.WPD_OBJECT_ORIGINAL_FILE_NAME);
        }

        private Device device;

        internal string id;
        private string name;
        private string originalFilename;

        private bool childrenIndexed = false;
        private Dictionary<string, DeviceObject> childrenByName = new Dictionary<string, DeviceObject>();
        private Dictionary<string, DeviceObject> childrenByOriginalFilename = new Dictionary<string, DeviceObject>();

        public DeviceObject(Device device, string id)
        {
            this.device = device;
            this.id = id;

            IPortableDeviceValues values;
            device.properties.GetValues(id, SearchKeys, out values);

            try
            {
                values.GetStringValue(Constants.WPD_OBJECT_NAME, out name);
            }
            catch
            {
            }

            try
            {
                values.GetStringValue(Constants.WPD_OBJECT_ORIGINAL_FILE_NAME, out originalFilename);
            }
            catch
            {
            }
        }

        public DeviceObject GetChildByName(string name, bool reindex = false)
        {
            IndexChildren(reindex);

            DeviceObject child = null;
            childrenByName.TryGetValue(name, out child);
            return child;
        }

        public DeviceObject GetChildByOriginalFilename(string originalFilename, bool reindex = false)
        {
            IndexChildren(reindex);

            DeviceObject child = null;
            childrenByOriginalFilename.TryGetValue(originalFilename, out child);
            return child;
        }

        private void IndexChildren(bool reindex)
        {
            if (!childrenIndexed || reindex)
            {
                childrenByName.Clear();
                childrenByOriginalFilename.Clear();

                IEnumPortableDeviceObjectIDs childrenEnum;
                device.content.EnumObjects(0, id, null, out childrenEnum);

                try
                {
                    string[] ids = new string[0x1000];

                    while (true)
                    {
                        uint count = (uint)ids.Length;
                        childrenEnum.Next((uint)ids.Length, ids, ref count);
                        if (count == 0)
                            break;

                        for (int i = 0; i < count; i++)
                        {
                            DeviceObject child = device.GetObject(ids[i]);

                            childrenByName.Add(child.name, child);

                            if (child.originalFilename != null)
                                childrenByOriginalFilename.Add(child.originalFilename, child);
                        }
                    }
                }
                catch
                {
                    childrenEnum.Cancel();
                    device.content.Cancel();

                    throw;
                }

                childrenIndexed = true;
            }
        }
    }
}
