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
			//���o
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


			//�P�_
			string result=GetResult(datetimeInput);
			MessageBox.Show($"�z��J�������{datetimeInput:yyyy-MM-dd}�A{result}");

		}

		private string  GetResult(DateTime dateTime)
		{
			if (dateTime<DateTime.Today)
			{
				return "�p�󤵤�";
			}
			else if(dateTime >DateTime.Today)
			{
				return "�j�󤵤�";
			}
			return "���󤵤�";
		}

		private DateTime GetDate(string input)
		{
			bool isDateTime=DateTime.TryParse(input, out DateTime dt);
			if (isDateTime == false)
			{
				throw new Exception("�п�J���T������榡: �~/��/��");
			}
			return dt;
		}
	}
}