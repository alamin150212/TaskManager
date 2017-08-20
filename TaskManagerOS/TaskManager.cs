using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace TaskManagerOS
{
    public partial class TaskManager : MetroFramework.Forms.MetroForm
    {
        private bool isRunningXPOrLater= false;
        private int groupColumn;
        //Bunifu_classes.moveform mf = new Bunifu_classes.moveform();
        public TaskManager()
        {
            InitializeComponent();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            loadProcessList();
            
            //btnEndTask.Enabled = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTask form = new CreateNewTask();
            form.ShowDialog();
            loadProcessList();
        }

        private void loadProcessList()
        {

            listViewProcess.Items.Clear();
            Process[] processesList = Process.GetProcesses();
            foreach (Process process in processesList)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                //item.SubItems.Add();
                
                item.Tag = process;
                
                listViewProcess.Items.Add(item);
            }
            listViewProcess.Sort();

        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewProcess.SelectedItems[0];
            Process process = (Process)item.Tag;
            process.Kill();
            loadProcessList();
        }

        private void listViewProcess_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listViewProcess.Sorting == SortOrder.Descending ||
            (isRunningXPOrLater && (e.Column != groupColumn)))
            {
                listViewProcess.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewProcess.Sorting = SortOrder.Descending;
            }
            groupColumn = e.Column;

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fmemory = pMemory.NextValue();
            CPU.Value = (int)fcpu;
            CPU.Text = string.Format("{0:0.00}%", fcpu);
            Memory.Value = (int)fmemory;
            Memory.Text = string.Format("{0:0.00}%", fmemory);
            chartMemory.Series["Memory"].Points.AddY(fmemory);
            chartCPU.Series["CPU"].Points.AddY(fcpu);
            //availableMemory.Text = string.Format("{0}MB", fcpu);
            //cpuLbl.Text = string.Format("{0:0.00}%", fcpu);
            //ramLbl.Text = string.Format("{0:0.00}%", fram);
        }

        
    }
}
