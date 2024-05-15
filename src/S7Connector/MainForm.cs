using PlcConnector.Helpers;
using S7.Net;
using System;
using System.Text;
using System.Windows.Forms;

namespace S7Connector
{
	public partial class MainForm : Form
	{
		private static Plc s7Instance;

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			if (btnConnect.Text == "Connect")
			{
				if (s7Instance == null)
				{
					s7Instance = new Plc(CpuType.S71500, txtPlcIPAddress.Text.Trim(), 0, 1);
				}

				s7Instance.Open();
				btnConnect.Text = "Disconnect";
			}
			else
			{
				s7Instance.Close();
				btnConnect.Text = "Connect";
				txtBool01.Clear();
				txtInt01.Clear();
				txtStr01.Clear();
				txtStr02.Clear();
			}
		}

		private void btnReadData_Click(object sender, System.EventArgs e)
		{
			if (s7Instance == null || !s7Instance.IsConnected)
			{
				MessageBox.Show("Your PLC is not connected now!", "Error", MessageBoxButtons.OK);
				return;
			}

			// bool
			var boolData = (bool)s7Instance.Read(DataType.DataBlock, 1, 0, VarType.Bit, 1);
			txtBool01.Text = boolData ? "1" : "0";
			// int
			var intData = (short)s7Instance.Read(DataType.DataBlock, 1, 2, VarType.Int, 1);
			txtInt01.Text = intData.ToString();
			// string
			var count = (byte)s7Instance.Read(DataType.DataBlock, 1, 4 + 1, VarType.Byte, 1); // +1表示读取偏移值的长度
			var str01Data = Encoding.Default.GetString(s7Instance.ReadBytes(DataType.DataBlock, 1, 4 + 2, count)); // +2表示读取偏移值（跳过）的字符
			txtStr01.Text = str01Data;
			// wstring
			var str02Data = (string)s7Instance.Read(DataType.DataBlock, 1, 260, VarType.S7WString, 254);
			txtStr02.Text = str02Data;
		}

		private void btnWriteData_Click(object sender, System.EventArgs e)
		{
			if (s7Instance == null || !s7Instance.IsConnected)
			{
				MessageBox.Show("Your PLC is not connected now!", "Error", MessageBoxButtons.OK);
				return;
			}

			// bool
			var boolValue = txtBool01.Text.Trim() == "1" ? true : false;
			s7Instance.Write(DataType.DataBlock, 1, 0, boolValue);
			// int
			var intValue = Convert.ToInt16(txtInt01.Text);
			s7Instance.Write(DataType.DataBlock, 1, 2, intValue);
			// string
			s7Instance.Write(DataType.DataBlock, 1, 4, S7DataWriter.GetPlcStringByteArray(txtStr01.Text.Trim()));
			// wstring
			s7Instance.Write(DataType.DataBlock, 1, 260, S7DataWriter.GetPlcWStringByteArray(txtStr02.Text.Trim()));

			MessageBox.Show("Write data successfully!", "Info", MessageBoxButtons.OK);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (s7Instance.IsConnected)
			{
				s7Instance.Close();
			}
		}
	}
}
