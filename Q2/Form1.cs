namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			//取得
			string input=textBox1.Text;
			DateTime datetimeInput;
			try
			{
				datetimeInput = GetDate(input);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}


			//判斷
			string result=GetResult(datetimeInput);
			MessageBox.Show($"您輸入的日期為{datetimeInput:yyyy-MM-dd}，{result}");

		}

		private string  GetResult(DateTime dateTime)
		{
			if (dateTime<DateTime.Today)
			{
				return "小於今天";
			}
			else if(dateTime >DateTime.Today)
			{
				return "大於今天";
			}
			return "等於今天";
		}

		private DateTime GetDate(string input)
		{
			bool isDateTime=DateTime.TryParse(input, out DateTime dt);
			if (isDateTime == false)
			{
				throw new Exception("請輸入正確的日期格式: 年/月/日");
			}
			return dt;
		}
	}
}