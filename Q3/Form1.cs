using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			//取得輸入日期的年份
			string input=textBox1.Text;
			int inputYear=0;
			try
			{
				inputYear= GetDateTime(input);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			//確認是否滿13
			string result=GetAge(inputYear);

			//呈現
			MessageBox.Show(result);
		}

		private string GetAge(int inputYear)
		{
			int year = Convert.ToInt32(DateTime.Today.Year);
			if (year - inputYear >= 13)
			{
				return $"您的年齡是{year - inputYear}歲,已滿13歲";
			}
			else
			{
				return $"您的年齡是{year - inputYear}歲,未滿13歲";
			}


		}

		//確認輸入日期是否正確
		private int GetDateTime(string input)
		{
			bool isDateTime = DateTime.TryParse(input, out DateTime result);
			if (isDateTime==false)
			{
				throw new Exception("請輸入正確的日期格式");
			}
			if (result>DateTime.Today)
			{
				throw new Exception("生日不能大於今天");
			}
			return result.Year;
		}
	}
}
