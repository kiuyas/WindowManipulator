using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowManipulator
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindWindow(
            string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int MoveWindow(
            IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private Process[] processes;

        public Form1()
        {
            InitializeComponent();
            GetProcessNames();
        }

        private void GetProcessNames()
        {
            List<string> list = new List<string>();
            processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!list.Contains(p.ProcessName))
                {
                    list.Add(p.ProcessName);
                }
            }
            list.Sort();
            cmbProcessName.DataSource = list;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            List<Process> list = FindProcess(cmbProcessName.Text.Trim());
            int w = int.Parse(txtW.Text);
            int h = int.Parse(txtH.Text);
            foreach (Process p in list)
            {
                MoveWindow(p.MainWindowHandle, 0, 0, w, h, true);
            }
            this.Dispose();
        }

        private List<Process> FindProcess(string processName)
        {
            List<Process> result = new List<Process>();
            foreach (Process p in processes)
            {
                if (p.ProcessName == processName)
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
