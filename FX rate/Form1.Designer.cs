namespace FX_rate
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
            this.FromCurrency = new System.Windows.Forms.ComboBox();
            this.InputCurrency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToCurrency = new System.Windows.Forms.ComboBox();
            this.OutputCurrency = new System.Windows.Forms.TextBox();
            this.CurrencyExchangeBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(63, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "我想要將";
            // 
            // FromCurrency
            // 
            this.FromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromCurrency.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FromCurrency.FormattingEnabled = true;
            this.FromCurrency.Items.AddRange(new object[] {
            "新台幣 TWD",
            "美元 USD",
            "人民幣 CNY",
            "港幣 HKD",
            "日圓 JPY"});
            this.FromCurrency.Location = new System.Drawing.Point(155, 110);
            this.FromCurrency.Name = "FromCurrency";
            this.FromCurrency.Size = new System.Drawing.Size(121, 32);
            this.FromCurrency.TabIndex = 1;
            // 
            // InputCurrency
            // 
            this.InputCurrency.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputCurrency.Location = new System.Drawing.Point(299, 109);
            this.InputCurrency.Name = "InputCurrency";
            this.InputCurrency.Size = new System.Drawing.Size(182, 33);
            this.InputCurrency.TabIndex = 2;
            this.InputCurrency.Text = "輸入金額";
            this.InputCurrency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputCurrency_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(82, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "兌換為";
            // 
            // ToCurrency
            // 
            this.ToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToCurrency.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToCurrency.FormattingEnabled = true;
            this.ToCurrency.Items.AddRange(new object[] {
            "新台幣 TWD",
            "美元 USD",
            "人民幣 CNY",
            "港幣 HKD",
            "日圓 JPY"});
            this.ToCurrency.Location = new System.Drawing.Point(155, 191);
            this.ToCurrency.Name = "ToCurrency";
            this.ToCurrency.Size = new System.Drawing.Size(121, 32);
            this.ToCurrency.TabIndex = 5;
            // 
            // OutputCurrency
            // 
            this.OutputCurrency.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputCurrency.Location = new System.Drawing.Point(299, 191);
            this.OutputCurrency.Name = "OutputCurrency";
            this.OutputCurrency.Size = new System.Drawing.Size(182, 33);
            this.OutputCurrency.TabIndex = 6;
            this.OutputCurrency.Text = "輸入金額";
            this.OutputCurrency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OutputCurrency_MouseDown);
            // 
            // CurrencyExchangeBottom
            // 
            this.CurrencyExchangeBottom.Font = new System.Drawing.Font("微軟正黑體", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CurrencyExchangeBottom.Location = new System.Drawing.Point(203, 269);
            this.CurrencyExchangeBottom.Name = "CurrencyExchangeBottom";
            this.CurrencyExchangeBottom.Size = new System.Drawing.Size(194, 53);
            this.CurrencyExchangeBottom.TabIndex = 8;
            this.CurrencyExchangeBottom.Text = "兌換";
            this.CurrencyExchangeBottom.UseVisualStyleBackColor = true;
            this.CurrencyExchangeBottom.Click += new System.EventHandler(this.CurrencyExchangeBottom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 379);
            this.Controls.Add(this.CurrencyExchangeBottom);
            this.Controls.Add(this.OutputCurrency);
            this.Controls.Add(this.ToCurrency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputCurrency);
            this.Controls.Add(this.FromCurrency);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "外匯計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FromCurrency;
        private System.Windows.Forms.TextBox InputCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ToCurrency;
        private System.Windows.Forms.TextBox OutputCurrency;
        private System.Windows.Forms.Button CurrencyExchangeBottom;
    }
}

