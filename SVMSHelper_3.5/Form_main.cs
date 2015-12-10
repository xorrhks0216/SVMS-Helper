using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace SVMSHelper_3._5
{
    public partial class Form_main : Form
    {
        // 요약:
        //     메인 UI를 구현한다.
        public Form_main()
        {
            InitializeComponent();
        }

        public void txtClear()
        {
            txtCPU.Clear();
            txtMem.Clear();
            txtGPU.Clear();
            txtHDD.Clear();
            txtOS.Clear();
            txtHostname.Clear();
        }

        private void btnGetinfo_Click(object sender, EventArgs e)
        {
            txtClear();
            btnGetinfo.Enabled = false;
            getInfo();
            btnGetinfo.Enabled = true;
        }

        private void btnGetprocess_Click(object sender, EventArgs e)
        {
            lvProcess.Items.Clear();
            btnGetprocess.Enabled = false;
            Process[] processlist = Process.GetProcesses();
            var counters = new List<PerformanceCounter>();
            foreach (Process process in processlist)
            {
                var counter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
                counter.NextValue();
                counters.Add(counter);
            }

            int i = 0;
            
            Thread.Sleep(1000);

            foreach(var counter in counters)
            {
                ListViewItem lvitem = new ListViewItem(new String[] { 
                    processlist[i].ProcessName, 
                    processlist[i].Id.ToString(), 
                    Math.Round(counter.NextValue(), 1).ToString(),
                    ""
                });
                lvProcess.Items.AddRange(new ListViewItem[] { lvitem });
                ++i;
            }



            /*foreach (Process theprocess in processlist)
            {
                ListViewItem lvitem = new ListViewItem(new String[] { theprocess.ProcessName, theprocess.Id.ToString(), "", theprocess.});
                lvProcess.Items.AddRange(new ListViewItem[] { lvitem });
            }*/
            btnGetprocess.Enabled = true;
            lvProcess.Refresh();
        }

        private void getInfo()
        {
            Info info = new Info();

            // set TextBox
            txtCPU.Text = info.getCPUInfo();
            int memcnt = 0;
            List<UInt64> memList = info.getMemInfo();
            foreach (UInt64 mem in memList)
            {
                if (memcnt != 0)
                    txtMem.Text += Environment.NewLine;
                txtMem.Text += "Memslot " + memcnt + " : " + mem + "MB";
                memcnt++;
            }
            txtGPU.Text = info.getGPUInfo();
            int hddcnt = 0;
            List<HDDInfo> hddList = info.getHDDInfo();
            foreach (HDDInfo hdd in hddList)
            {
                if (hddcnt != 0)
                    txtHDD.Text += Environment.NewLine;
                txtHDD.Text += hdd.caption + " " + hdd.Size / 1024 / 1024 / 1024 + "GB(" + hdd.DriveType + ")";
                hddcnt++;
            }
            txtOS.Text = info.getOSInfo();
            txtHostname.Text = info.getHostnameInfo();
        }

        private void lvProcess_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //ListViewItemComparer sorter = GetListViewSorter(e.Column);
        }
    }
}
