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

namespace TaskManagerOS
{
    public partial class CreateNewTask : MetroFramework.Forms.MetroForm
    {
        public CreateNewTask()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void CreateNewTask_Load(object sender, EventArgs e)
        {
            showMessage.Text = "Type the name of a program, folder, document and \nWindows will open it for you.";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openTextbox.Text = ofd.FileName;

            }
        }
        private void openProcess()
        {

            string text = openTextbox.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
            this.Close();


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openProcess();
        }

        private void openTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openProcess();
            }
        }
    }
}
