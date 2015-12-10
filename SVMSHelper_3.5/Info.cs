using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace SVMSHelper_3._5
{
    public struct HDDInfo
    {
        public HDDInfo(String type, String cap, UInt64 size)
        {
            this.DriveType = type;
            this.caption = cap;
            this.Size = size;
        }
        public String DriveType;
        public String caption;
        public UInt64 Size;
    }

    class Info
    {
        private String[] HDDType = new String[7] { "Unknown", "No Root Directory", "Removable Disk",
                                                    "Local Disk", "Network Drive", "Compact Disc", "RAM Disk"};
        
        private String CPUInfo = "";
        private List<UInt64> MemS = null;
        private String GPUInfo = "";
        private List<HDDInfo> HDDS = null;
        private String OSInfo = "";
        private String HostnameInfo = "";
        private String IPAddrInfo = "";

        public Info()
        {
            this.setCPUInfo();
            this.setMemInfo();
            this.setGPUInfo();
            this.setHDDInfo();
            this.setOSInfo();
            this.setHostnameInfo();
        }

        // set CPU Information
        private void setCPUInfo()
        {
            var cpu = new ManagementObjectSearcher("select * from Win32_Processor")
            .Get()
            .Cast<ManagementObject>()
            .First();
            this.CPUInfo = (string)cpu["Name"];
        }

        public String getCPUInfo()
        {
            return this.CPUInfo;
        }

        // set Memory Information
        private void setMemInfo()
        {
            this.MemS = new List<UInt64>();
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            foreach (ManagementObject obj in Searcher.Get())
            {
                this.MemS.Add(Convert.ToUInt64(obj["Capacity"]) / 1024 / 1024);
            }
        }

        public List<UInt64> getMemInfo()
        {
            return this.MemS;
        }

        // set GPU Information
        private void setGPUInfo()
        {
            var gpu = new ManagementObjectSearcher("select * from Win32_VideoController")
            .Get()
            .Cast<ManagementObject>()
            .First();
            this.GPUInfo = (string)gpu["Name"];
        }

        public String getGPUInfo()
        {
            return this.GPUInfo;
        }

        // set HDD Information
        private void setHDDInfo()
        {
            this.HDDS = new List<HDDInfo>();
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
            foreach (ManagementObject obj in Searcher.Get())
            {
                HDDInfo hdd = new HDDInfo(HDDType[Convert.ToUInt32(obj["DriveType"])], (string)obj["Caption"], Convert.ToUInt64(obj["Size"]));
                this.HDDS.Add(hdd);
            }
        }

        public List<HDDInfo> getHDDInfo()
        {
            return HDDS;
        }

        // set OS Information
        private void setOSInfo()
        {
            var os = new ManagementObjectSearcher("select * from Win32_OperatingSystem")
            .Get()
            .Cast<ManagementObject>()
            .First();
            this.OSInfo = (string)os["Caption"] + " " + (string)os["OSArchitecture"];
        }

        public String getOSInfo()
        {
            return OSInfo;
        }

        private void setHostnameInfo()
        {
            this.HostnameInfo = Environment.MachineName;
        }

        public String getHostnameInfo()
        {
            return this.HostnameInfo;
        }
    }
}
