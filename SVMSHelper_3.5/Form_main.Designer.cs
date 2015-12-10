namespace SVMSHelper_3._5
{
    partial class Form_main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetinfo = new System.Windows.Forms.Button();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.txtMem = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetprocess = new System.Windows.Forms.Button();
            this.lvProcess = new System.Windows.Forms.ListView();
            this.colProcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. 시스템 사양";
            // 
            // btnGetinfo
            // 
            this.btnGetinfo.Location = new System.Drawing.Point(15, 401);
            this.btnGetinfo.Name = "btnGetinfo";
            this.btnGetinfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetinfo.TabIndex = 38;
            this.btnGetinfo.Text = "Get Info";
            this.btnGetinfo.UseVisualStyleBackColor = true;
            this.btnGetinfo.Click += new System.EventHandler(this.btnGetinfo_Click);
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(15, 355);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Size = new System.Drawing.Size(250, 25);
            this.txtHostname.TabIndex = 32;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(15, 294);
            this.txtOS.Multiline = true;
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(250, 40);
            this.txtOS.TabIndex = 33;
            // 
            // txtHDD
            // 
            this.txtHDD.Location = new System.Drawing.Point(15, 233);
            this.txtHDD.Multiline = true;
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.ReadOnly = true;
            this.txtHDD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHDD.Size = new System.Drawing.Size(250, 40);
            this.txtHDD.TabIndex = 34;
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(15, 172);
            this.txtGPU.Multiline = true;
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.ReadOnly = true;
            this.txtGPU.Size = new System.Drawing.Size(250, 40);
            this.txtGPU.TabIndex = 35;
            // 
            // txtMem
            // 
            this.txtMem.Location = new System.Drawing.Point(15, 111);
            this.txtMem.Multiline = true;
            this.txtMem.Name = "txtMem";
            this.txtMem.ReadOnly = true;
            this.txtMem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMem.Size = new System.Drawing.Size(250, 40);
            this.txtMem.TabIndex = 36;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(15, 50);
            this.txtCPU.Multiline = true;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.ReadOnly = true;
            this.txtCPU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCPU.Size = new System.Drawing.Size(250, 40);
            this.txtCPU.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 383);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 15);
            this.label24.TabIndex = 30;
            this.label24.Text = "- IP Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "- Hostname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "- OS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "- HDD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "- GPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "- Mem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "- CPU";
            // 
            // btnGetprocess
            // 
            this.btnGetprocess.Location = new System.Drawing.Point(500, 401);
            this.btnGetprocess.Name = "btnGetprocess";
            this.btnGetprocess.Size = new System.Drawing.Size(116, 23);
            this.btnGetprocess.TabIndex = 39;
            this.btnGetprocess.Text = "Get Process";
            this.btnGetprocess.UseVisualStyleBackColor = true;
            this.btnGetprocess.Click += new System.EventHandler(this.btnGetprocess_Click);
            // 
            // lvProcess
            // 
            this.lvProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProcName,
            this.colProcID,
            this.colCPU,
            this.colMem});
            this.lvProcess.GridLines = true;
            this.lvProcess.Location = new System.Drawing.Point(15, 430);
            this.lvProcess.Name = "lvProcess";
            this.lvProcess.Size = new System.Drawing.Size(601, 259);
            this.lvProcess.TabIndex = 41;
            this.lvProcess.UseCompatibleStateImageBehavior = false;
            this.lvProcess.View = System.Windows.Forms.View.Details;
            this.lvProcess.VirtualListSize = 13;
            this.lvProcess.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvProcess_ColumnClick);
            // 
            // colProcName
            // 
            this.colProcName.Text = "Name";
            this.colProcName.Width = 112;
            // 
            // colProcID
            // 
            this.colProcID.Text = "ID";
            this.colProcID.Width = 120;
            // 
            // colCPU
            // 
            this.colCPU.Text = "CPU";
            this.colCPU.Width = 113;
            // 
            // colMem
            // 
            this.colMem.Text = "Memory";
            this.colMem.Width = 184;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 702);
            this.Controls.Add(this.lvProcess);
            this.Controls.Add(this.btnGetprocess);
            this.Controls.Add(this.btnGetinfo);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtHDD);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.txtMem);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_main";
            this.Text = "SVMS Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetinfo;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.TextBox txtMem;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetprocess;
        private System.Windows.Forms.ListView lvProcess;
        private System.Windows.Forms.ColumnHeader colProcName;
        private System.Windows.Forms.ColumnHeader colProcID;
        private System.Windows.Forms.ColumnHeader colCPU;
        private System.Windows.Forms.ColumnHeader colMem;
    }
}

