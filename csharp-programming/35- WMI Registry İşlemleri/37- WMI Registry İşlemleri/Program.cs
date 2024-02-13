using Microsoft.Win32;
using System;
using System.Management;

namespace _37__WMI_Registry_İşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projemize add referance ile assemblies kısmından System.management projeye dahil edilir.

            string Surucu = "C";
            ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + Surucu + ":\"");
            Disk.Get();
            RegistryKey Key = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);
            Key.SetValue("LogicalDiskSN", Disk["VolumeSerialNumber"].ToString());


            // Bilgisayarımızın mac adresini öğrenmek içinse;
            ManagementClass M = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection RV = M.GetInstances();
            foreach (ManagementObject item in RV)
            {
                if ((bool)item["IPEnabled"])
                {
                    RegistryKey KEY = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);
                    KEY.SetValue("MACAddress", item["MacAddress"].ToString());
                }
            }
        }
    }
}
