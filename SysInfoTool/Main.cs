using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Linq;

namespace SysInfo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
                        
            RefreshProcesses();        
        }

        private void killProcess_Click(object sender, EventArgs e)
        {  
            try
            {                
                var selectedProcess = (KeyValuePair<int, string>)processes.SelectedItem;            
                Process process = Process.GetProcessById(selectedProcess.Key);
                
                if (MessageBox.Show("Are you sure you want to close " + process.ProcessName.ToString() + "?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { 
                    process.CloseMainWindow();
                    process.WaitForExit();
                    process.Dispose();
                                   
                    RefreshProcesses(); 
                }                       
            }
            catch (Win32Exception ea)
            {
                MessageBox.Show(ea.Message);             
            }                
        }

        private void RefreshProcesses()
        {            
            var processList = new Dictionary<int, string>();
           
            foreach(Process process in Process.GetProcesses())
            {
                processList.Add(process.Id, process.ProcessName);                
            }

            processes.DataSource = new BindingSource(processList, null);
            processes.DisplayMember = "Value";
            processes.ValueMember = "Key";                
        }
    }
}