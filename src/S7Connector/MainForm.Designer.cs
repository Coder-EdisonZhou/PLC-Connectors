namespace S7Connector
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.plcStatusGroup = new System.Windows.Forms.GroupBox();
			this.txtPlcIPAddress = new System.Windows.Forms.TextBox();
			this.btnWriteData = new System.Windows.Forms.Button();
			this.btnReadData = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBool01 = new System.Windows.Forms.TextBox();
			this.txtInt01 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStr01 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStr02 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.plcStatusGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// plcStatusGroup
			// 
			this.plcStatusGroup.Controls.Add(this.txtPlcIPAddress);
			this.plcStatusGroup.Controls.Add(this.btnWriteData);
			this.plcStatusGroup.Controls.Add(this.btnReadData);
			this.plcStatusGroup.Controls.Add(this.btnConnect);
			this.plcStatusGroup.Location = new System.Drawing.Point(0, 0);
			this.plcStatusGroup.Name = "plcStatusGroup";
			this.plcStatusGroup.Size = new System.Drawing.Size(613, 169);
			this.plcStatusGroup.TabIndex = 0;
			this.plcStatusGroup.TabStop = false;
			this.plcStatusGroup.Text = "Control Panel";
			// 
			// txtPlcIPAddress
			// 
			this.txtPlcIPAddress.Location = new System.Drawing.Point(126, 38);
			this.txtPlcIPAddress.Name = "txtPlcIPAddress";
			this.txtPlcIPAddress.Size = new System.Drawing.Size(209, 28);
			this.txtPlcIPAddress.TabIndex = 9;
			this.txtPlcIPAddress.Text = "192.168.10.200";
			// 
			// btnWriteData
			// 
			this.btnWriteData.Location = new System.Drawing.Point(343, 100);
			this.btnWriteData.Name = "btnWriteData";
			this.btnWriteData.Size = new System.Drawing.Size(142, 47);
			this.btnWriteData.TabIndex = 10;
			this.btnWriteData.Text = "Write Data";
			this.btnWriteData.UseVisualStyleBackColor = true;
			this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
			// 
			// btnReadData
			// 
			this.btnReadData.Location = new System.Drawing.Point(126, 100);
			this.btnReadData.Name = "btnReadData";
			this.btnReadData.Size = new System.Drawing.Size(142, 47);
			this.btnReadData.TabIndex = 9;
			this.btnReadData.Text = "Read Data";
			this.btnReadData.UseVisualStyleBackColor = true;
			this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(343, 27);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(142, 47);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(141, 197);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bool01";
			// 
			// txtBool01
			// 
			this.txtBool01.Location = new System.Drawing.Point(219, 194);
			this.txtBool01.Name = "txtBool01";
			this.txtBool01.Size = new System.Drawing.Size(209, 28);
			this.txtBool01.TabIndex = 2;
			// 
			// txtInt01
			// 
			this.txtInt01.Location = new System.Drawing.Point(219, 256);
			this.txtInt01.Name = "txtInt01";
			this.txtInt01.Size = new System.Drawing.Size(209, 28);
			this.txtInt01.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(141, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Int01";
			// 
			// txtStr01
			// 
			this.txtStr01.Location = new System.Drawing.Point(219, 312);
			this.txtStr01.Name = "txtStr01";
			this.txtStr01.Size = new System.Drawing.Size(209, 28);
			this.txtStr01.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(141, 315);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Str01";
			// 
			// txtStr02
			// 
			this.txtStr02.Location = new System.Drawing.Point(219, 372);
			this.txtStr02.Name = "txtStr02";
			this.txtStr02.Size = new System.Drawing.Size(209, 28);
			this.txtStr02.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(141, 375);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Str02";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 450);
			this.Controls.Add(this.txtStr02);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtStr01);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtInt01);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBool01);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.plcStatusGroup);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "S7 PLC Connector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.plcStatusGroup.ResumeLayout(false);
			this.plcStatusGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox plcStatusGroup;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBool01;
		private System.Windows.Forms.TextBox txtInt01;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStr01;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtStr02;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnReadData;
		private System.Windows.Forms.Button btnWriteData;
		private System.Windows.Forms.TextBox txtPlcIPAddress;
	}
}

