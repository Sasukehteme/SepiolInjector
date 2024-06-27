using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SepiolInjector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateProcessList();
        }

        private void updateProcessList()
        {
            processList.Items.Clear();
            foreach (Process process in GetProcessesByName(processSearch.Text))
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                processList.Items.Add(item);
            }
        }

        private Process[] GetProcessesByName(string name)
        {
            if (name == null) { return Process.GetProcesses(); }
            List<Process> processList = new List<Process>();

            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    processList.Add(process);
                }
            }

            return processList.ToArray();
        }

        private void selectDllButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "dll";
            ofd.Filter = "dll files (*.dll)|*.dll";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ListViewItem newFile = new ListViewItem(ofd.SafeFileName);
                newFile.SubItems.Add(ofd.FileName);
                fileList.Items.Add(newFile);
            }
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            if (processList.SelectedItems.Count == 0) { return; }

            Process selectedProcess = Process.GetProcessById(Int32.Parse(processList.SelectedItems[0].SubItems[1].Text));
            string filePath = fileList.Items[0].SubItems[1].Text;

            using (var p = selectedProcess)
            {
                var ptr = p.LoadLibrary(filePath);
            }
        }

        private void processSearch_TextChanged(object sender, EventArgs e)
        {
            updateProcessList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            updateProcessList();
        }
    }
}
