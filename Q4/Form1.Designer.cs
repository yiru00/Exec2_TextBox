namespace Q4
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxpeople = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCar = new System.Windows.Forms.TextBox();
			this.buttonResult = new System.Windows.Forms.Button();
			this.labelRestult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(184, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數";
			// 
			// textBoxpeople
			// 
			this.textBoxpeople.Location = new System.Drawing.Point(219, 132);
			this.textBoxpeople.Name = "textBoxpeople";
			this.textBoxpeople.Size = new System.Drawing.Size(100, 22);
			this.textBoxpeople.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(367, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "車數";
			// 
			// textBoxCar
			// 
			this.textBoxCar.Location = new System.Drawing.Point(402, 132);
			this.textBoxCar.Name = "textBoxCar";
			this.textBoxCar.Size = new System.Drawing.Size(100, 22);
			this.textBoxCar.TabIndex = 3;
			// 
			// buttonResult
			// 
			this.buttonResult.Location = new System.Drawing.Point(542, 132);
			this.buttonResult.Name = "buttonResult";
			this.buttonResult.Size = new System.Drawing.Size(75, 22);
			this.buttonResult.TabIndex = 4;
			this.buttonResult.Text = "計算";
			this.buttonResult.UseVisualStyleBackColor = true;
			this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
			// 
			// labelRestult
			// 
			this.labelRestult.AutoSize = true;
			this.labelRestult.Location = new System.Drawing.Point(184, 234);
			this.labelRestult.Name = "labelRestult";
			this.labelRestult.Size = new System.Drawing.Size(33, 12);
			this.labelRestult.TabIndex = 5;
			this.labelRestult.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelRestult);
			this.Controls.Add(this.buttonResult);
			this.Controls.Add(this.textBoxCar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxpeople);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxpeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelRestult;
    }
}

