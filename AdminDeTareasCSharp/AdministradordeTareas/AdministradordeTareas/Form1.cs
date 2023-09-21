using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace AdministradordeTareas
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int selectedRowIndex = -1;
        public Form1()
        {
            InitializeComponent();
            UpdateProcessList();
            timer1.Interval = 8000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

        }

        private void UpdateProcessList()
        {
            dgAdmin.Rows.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                int n = dgAdmin.Rows.Add();
                dgAdmin.Rows[n].Cells[0].Value = p.ProcessName;
                dgAdmin.Rows[n].Cells[1].Value = p.Id;
                dgAdmin.Rows[n].Cells[2].Value = p.WorkingSet64;
                dgAdmin.Rows[n].Cells[3].Value = p.VirtualMemorySize64;
                dgAdmin.Rows[n].Cells[4].Value = p.SessionId;
            }
            lblcount.Text= "Current processes"+dgAdmin.Rows.Count.ToString();
        }
        private void Killprocess()
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == lblprocname.Text)
                    {
                        p.Kill();
                    }
                }
            }catch (Exception x) 
            {
                MessageBox.Show("You did not select a process" + x, "End task error",MessageBoxButtons.OK);

            }
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblprocname.Text = dgAdmin.CurrentRow.Cells[0].Value.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            Killprocess();
            UpdateProcessList();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dgAdmin.SelectedRows.Count > 0)
            {
                selectedRowIndex = dgAdmin.SelectedRows[0].Index;
            }
            UpdateProcessList();
            if(selectedRowIndex >=0 && selectedRowIndex <dgAdmin.Rows.Count) 
            {
                dgAdmin.Rows[selectedRowIndex].Selected = true;
            }
        }
    }
}
