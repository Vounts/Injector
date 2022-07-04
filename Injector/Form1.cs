using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Injector.Imports;

namespace Injector
{


    public partial class Form1 : Form
    {
       
        List<ListViewItem> allItems = new List<ListViewItem>();
        public Form1()
        {
            InitializeComponent();
            initProcesses();
        }


        public void initProcesses()
        {
            Process[] process = Process.GetProcesses();

            ProcessList.View = View.Details;
            ProcessList.Columns.Add("PID", 80, HorizontalAlignment.Left);
            ProcessList.Columns.Add("Process Name", 270, HorizontalAlignment.Left);
            ProcessList.FullRowSelect = true;



            foreach (Process p in process)
            {
                String[] row = { p.Id.ToString(), p.ProcessName.ToString()+".exe"};
                ListViewItem item = new ListViewItem(row);
                ProcessList.Items.Add(item);
            }


            allItems.Clear();
            allItems.AddRange(ProcessList.Items.Cast<ListViewItem>());

        }

        private void ProcessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcessList.SelectedItems.Count > 0)
            {
                ListViewItem item = ProcessList.SelectedItems[0];
                txtTargetPID.Text = item.SubItems[0].Text;
                txtTargetName.Text = item.SubItems[1].Text;
            }
            else
            {
                txtTargetPID.Text = string.Empty;
                txtTargetName.Text = string.Empty;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ProcessList.Items.Clear();   // clear all items we have atm
            if (txtSearch.Text == "")
            {
                ProcessList.Items.AddRange(allItems.ToArray());  // no filter: add all items
                return;
            }
            // now we find all items that have a suitable text in any subitem/field/column
            var list = allItems.Cast<ListViewItem>()
                               .Where(x => x.SubItems
                                            .Cast<ListViewItem.ListViewSubItem>()
                                            .Any(y => y.Text.Contains(txtSearch.Text)))
                               .ToArray();
            ProcessList.Items.AddRange(list);  // now we add the result
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dllPath = txtFile.Text;
   
            uint procid = Convert.ToUInt32(txtTargetPID.Text);
            IntPtr hProc = OpenProcess(PROCESS_ALL_ACCESS, 0, procid);

            
            if(hProc != IntPtr.Zero)
            {
                IntPtr max_path = new IntPtr(MAX_PATH);

                IntPtr loc = VirtualAllocEx(hProc, IntPtr.Zero, max_path, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
                int bytesRead = 0;
                byte[] byteArray = Encoding.GetEncoding("UTF-8").GetBytes(dllPath.ToCharArray());
                if (loc != IntPtr.Zero)
                {
                    int result = WriteProcessMemory(hProc, loc, byteArray, Convert.ToUInt32(dllPath.Length), bytesRead);
                    if(result == 0 || bytesRead.Equals(0))
                    {
                        MessageBox.Show("Failed to Inject!");
                        CloseHandle(hProc);
                        return;
                    }

                    IntPtr loadlibAddy = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                    IntPtr hThread = CreateRemoteThread(hProc, IntPtr.Zero, IntPtr.Zero, loadlibAddy, loc, 0, IntPtr.Zero);

                    if (!hThread.Equals(0))
                    {
                        MessageBox.Show("Injected Successfully!");
                        CloseHandle(hThread);
                        CloseHandle(hProc);
                        return;
                    }


                    MessageBox.Show("Failed to Create Thread");
                }
            }
            CloseHandle(hProc);
            return;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            if(v1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = Path.GetFullPath(v1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            if (v1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = Path.GetFullPath(v1.FileName);
            }
        }

        private void bitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessList.Items.Clear();
            Process[] process = Process.GetProcesses();
            bool procHandle = false;
            foreach (Process p in process)
            {
                IntPtr hProc = OpenProcess(PROCESS_ALL_ACCESS, 0, Convert.ToUInt32(p.Id));
                if (hProc != IntPtr.Zero)
                {
                    IsWow64Process(hProc, out procHandle);
                    if (procHandle == false)
                    {
                        String[] row = { p.Id.ToString(), p.ProcessName.ToString() + ".exe" };
                        ListViewItem item = new ListViewItem(row);
                        ProcessList.Items.Add(item);
                    }
                }


            }
        }

        private void bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessList.Items.Clear();
            Process[] process = Process.GetProcesses();
            bool procHandle = false;
            foreach (Process p in process)
            {
                IntPtr hProc = OpenProcess(PROCESS_ALL_ACCESS, 0, Convert.ToUInt32(p.Id));
                    if (hProc != IntPtr.Zero)
                    {
                        IsWow64Process(hProc, out procHandle);
                        if (procHandle == true)
                        {
                            String[] row = { p.Id.ToString(), p.ProcessName.ToString() + ".exe" };
                            ListViewItem item = new ListViewItem(row);
                            ProcessList.Items.Add(item);
                        }
                    }
            

            }
        }
    }

    
    

}
