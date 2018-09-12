using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._09_app
{
    class Program
    {
        public static DeviceManager _manager = new DeviceManager();

        static void Main(string[] args)
        {
            DeviceManager.Instance.SendData();
            //var dm1 = new DeviceManager();
            //var dm2 = new DeviceManager();
        }
    }
    public class DeviceManager
    {
        private static DeviceManager _managerInstance; // = new DeviceManager();
        private static Lazy<DeviceManager> _managerInstanceLazy;
         //_managerInstance = new DeviceManager();
        static DeviceManager()
        {
            _managerInstanceLazy = new Lazy<DeviceManager>(() =>
            {
                return new DeviceManager();
            });

        }
        public static DeviceManager Instance
        {
            get
            {
                if (_managerInstance == null) 
                {
                    _managerInstance = new DeviceManager();
                }
                {
                    return _managerInstance;
                }
            }
        }
        public DeviceManager GetInstance()
        {
            return _managerInstance;
        }
        public void SendData()
        {

        }
    }
}
