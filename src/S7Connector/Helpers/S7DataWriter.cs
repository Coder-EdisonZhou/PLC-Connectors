using System.Linq;
using System.Text;
using System;

namespace PlcConnector.Helpers
{
	public static class S7DataWriter
	{
		/// <summary>
		/// 获取西门子PLC字符串数组--String类型
		/// </summary>
		public static byte[] GetPlcStringByteArray(string str)
		{
			byte[] value = Encoding.Default.GetBytes(str);
			byte[] head = new byte[2];
			head[0] = Convert.ToByte(254);
			head[1] = Convert.ToByte(str.Length);
			value = head.Concat(value).ToArray();
			return value;
		}

		/// <summary>
		/// 获取西门子PLC字符串数组--WString类型
		/// </summary>
		public static byte[] GetPlcWStringByteArray(string str)
		{
			byte[] value = Encoding.BigEndianUnicode.GetBytes(str);
			byte[] head = BitConverter.GetBytes((short)508);
			byte[] length = BitConverter.GetBytes((short)str.Length);
			Array.Reverse(head);
			Array.Reverse(length);
			head = head.Concat(length).ToArray();
			value = head.Concat(value).ToArray();
			return value;
		}
	}
}
