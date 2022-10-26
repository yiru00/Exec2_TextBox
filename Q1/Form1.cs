using System.Configuration;
using System.Runtime.CompilerServices;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{

			//取值
			int input;
			try
			{
				input=GetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			//判斷
			string result=string.Empty;
			try
			{
				result=GetResult(input);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ;
			}
			
			MessageBox.Show($"您輸入{result}，介於1~99");

		}

		private string GetResult(int input)
		{
			return (input < 1 || input > 99) ? throw new Exception("數值需介於1~99"):input.ToString();

		}

		private int GetNumber()
		{

			bool isInt = int.TryParse(textBox1.Text,out int input);
			return(isInt==false) ?throw new Exception("請輸入數字"):input;
			
		}
	}
}