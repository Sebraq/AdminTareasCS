namespace AdministradordeTareas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgAdmin = new MetroFramework.Controls.MetroGrid();
            this.dgProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnend = new MetroFramework.Controls.MetroButton();
            this.btnexit = new MetroFramework.Controls.MetroButton();
            this.lblcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprocname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAdmin
            // 
            this.dgAdmin.AllowUserToResizeRows = false;
            this.dgAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgProcess,
            this.dgId,
            this.dgMemory,
            this.dgVirtual,
            this.dgCPU});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAdmin.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgAdmin.EnableHeadersVisualStyles = false;
            this.dgAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgAdmin.Location = new System.Drawing.Point(23, 63);
            this.dgAdmin.Name = "dgAdmin";
            this.dgAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAdmin.Size = new System.Drawing.Size(777, 301);
            this.dgAdmin.TabIndex = 0;
            this.dgAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // dgProcess
            // 
            this.dgProcess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgProcess.HeaderText = "Process";
            this.dgProcess.Name = "dgProcess";
            // 
            // dgId
            // 
            this.dgId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgId.HeaderText = "ID";
            this.dgId.Name = "dgId";
            // 
            // dgMemory
            // 
            this.dgMemory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgMemory.HeaderText = "Physical Memory";
            this.dgMemory.Name = "dgMemory";
            // 
            // dgVirtual
            // 
            this.dgVirtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgVirtual.HeaderText = "Virtual Memory";
            this.dgVirtual.Name = "dgVirtual";
            // 
            // dgCPU
            // 
            this.dgCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCPU.HeaderText = "CPU";
            this.dgCPU.Name = "dgCPU";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(23, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 54);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(150, 370);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(119, 54);
            this.btnend.TabIndex = 2;
            this.btnend.Text = "End task";
            this.btnend.UseSelectable = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(681, 370);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 54);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseSelectable = true;
            this.btnexit.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(24, 431);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(29, 13);
            this.lblcount.TabIndex = 4;
            this.lblcount.Text = "label";
            this.lblcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Process name:";
            // 
            // lblprocname
            // 
            this.lblprocname.AutoSize = true;
            this.lblprocname.Location = new System.Drawing.Point(700, 437);
            this.lblprocname.Name = "lblprocname";
            this.lblprocname.Size = new System.Drawing.Size(0, 13);
            this.lblprocname.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 473);
            this.Controls.Add(this.lblprocname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgAdmin);
            this.Name = "Form1";
            this.Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVirtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCPU;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnend;
        private MetroFramework.Controls.MetroButton btnexit;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprocname;
        private System.Windows.Forms.Timer timer1;
    }
}

