using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelRestult.Text=String.Empty;
		}

        private void buttonResult_Click(object sender, EventArgs e)
        {
			//取得人數(int)
			string inputPeople=textBoxpeople.Text;
			int people=0;
			try
			{
				people =GetPeople(inputPeople);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			
			//計算人頭價格(int)
			int pricePerPeople = 200;
			int peoplePrice=GetPeoplePrice(people,pricePerPeople);

			//取得車數
			string inputCars = textBoxCar.Text;
			int cars = 0;
			try
			{
				cars=GetCars(inputCars);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			

			//取得車輛價格
			int pricePerCars = 60;
			int carsPrice = GetCarsPrice(cars, pricePerCars);

			//呈現
			Display(peoplePrice, carsPrice);
		}

		private void Display(int peoplePrice, int carsPrice)
		{
			string result = $"人:${peoplePrice}  車:${carsPrice}  共:${peoplePrice+carsPrice}";
			labelRestult.Text = result;
		}

		private int GetCarsPrice(int cars, int pricePerCars)
		{
			return cars * pricePerCars;
		}

		private int GetPeoplePrice(int people,int pricePerPeople)
		{
			return people * pricePerPeople;
		}

		private int GetCars(string inputCars)
		{
			bool isInt = int.TryParse(inputCars, out int cars);
			if (isInt==false)
			{
				throw new Exception("請輸入車數");
			}
			else if (cars < 0)
			{
				throw new Exception("車數不能小於0");
			}

			return cars;
		}

		private int GetPeople(string inputPeople)
		{
			bool isInt=int.TryParse(inputPeople, out int people);
			if (isInt==false)
			{
				throw new Exception("請輸入人數");
			}
			else if (people<0)
			{
				throw new Exception("人數不能小於0");
			}
			
			return people;
		}
	}
}
