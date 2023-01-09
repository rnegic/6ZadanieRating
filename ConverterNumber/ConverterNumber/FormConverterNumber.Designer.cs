namespace ConverterNumber
{
    partial class FormConverter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxConvertStart = new System.Windows.Forms.ComboBox();
            this.comboBoxConvertFinal = new System.Windows.Forms.ComboBox();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.textBoxEnterData = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(232, 309);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(122, 28);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Перевести";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxConvertStart
            // 
            this.comboBoxConvertStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxConvertStart.FormattingEnabled = true;
            this.comboBoxConvertStart.Items.AddRange(new object[] {
            "Milimeter",
            "Centimeter",
            "Meter",
            "Kilometer"});
            this.comboBoxConvertStart.Location = new System.Drawing.Point(265, 121);
            this.comboBoxConvertStart.Name = "comboBoxConvertStart";
            this.comboBoxConvertStart.Size = new System.Drawing.Size(121, 23);
            this.comboBoxConvertStart.TabIndex = 2;
            this.comboBoxConvertStart.SelectedIndexChanged += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxConvertFinal
            // 
            this.comboBoxConvertFinal.FormattingEnabled = true;
            this.comboBoxConvertFinal.Items.AddRange(new object[] {
            "Milimeter",
            "Centimeter",
            "Meter",
            "Kilometer"});
            this.comboBoxConvertFinal.Location = new System.Drawing.Point(505, 123);
            this.comboBoxConvertFinal.Name = "comboBoxConvertFinal";
            this.comboBoxConvertFinal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConvertFinal.TabIndex = 3;
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(99, 126);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(81, 13);
            this.labelOne.TabIndex = 4;
            this.labelOne.Text = "Введите длину";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(428, 126);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(71, 13);
            this.labelTwo.TabIndex = 5;
            this.labelTwo.Text = "Перевести в";
            // 
            // textBoxEnterData
            // 
            this.textBoxEnterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterData.Location = new System.Drawing.Point(195, 121);
            this.textBoxEnterData.Name = "textBoxEnterData";
            this.textBoxEnterData.Size = new System.Drawing.Size(64, 22);
            this.textBoxEnterData.TabIndex = 6;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(428, 317);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 7;
            // 
            // FormConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxEnterData);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.comboBoxConvertFinal);
            this.Controls.Add(this.comboBoxConvertStart);
            this.Controls.Add(this.buttonConvert);
            this.Name = "FormConverter";
            this.Text = "Конвертер длин";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxConvertStart;
        private System.Windows.Forms.ComboBox comboBoxConvertFinal;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.TextBox textBoxEnterData;
        private System.Windows.Forms.Label labelResult;
    }
}

