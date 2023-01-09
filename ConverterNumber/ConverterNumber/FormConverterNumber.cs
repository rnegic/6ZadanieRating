using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterNumber
{
    public partial class FormConverter : System.Windows.Forms.Form
    {
        public FormConverter()
        {
            //comboBoxConvertStart.Items.Add("Milimeter");

            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double value = Convert.ToInt32(textBoxEnterData.Text);
            int index1 = comboBoxConvertStart.SelectedIndex;
            int index2 = comboBoxConvertFinal.SelectedIndex;

            if (index1 == index2 && index2 == index1)
            {
                //выводим то же самое значение в текстбоксрезалт
                labelResult.Text = (textBoxEnterData.Text);
            }

            if (index1 == 0 && index2 == 1)//милиметры в сантиметры
            {
                labelResult.Text = Convert.ToString(value * 0.1);
            }
            if (index1 == 0 && index2 == 2)//милиметры в метры
            {
                labelResult.Text = Convert.ToString(value * 0.001);
            }
            if (index1 == 0 && index2 == 3)//милиметры в километры
            {
                labelResult.Text = Convert.ToString(value / 1e+6);
            }

            //сантиметры в миллиметры
            if(index1 == 1 && index2 == 0)
            {
                labelResult.Text = Convert.ToString(value * 10);
            }
            if (index1 == 1 && index2 == 2)//сантиметры в метры
            {
                labelResult.Text = Convert.ToString(value / 100);
            }
            if (index1 == 1 && index2 == 3)//сантиметры в километры
            {
                labelResult.Text = Convert.ToString(value / 100000);
            }


            if (index1 == 2 && index2 == 0)//метры в миллиметры
            {
                labelResult.Text = Convert.ToString(value * 1000);
            }
            if (index1 == 2 && index2 == 1)//метры в сантиметры
            {
                labelResult.Text = Convert.ToString(value * 100);
            }
            if (index1 == 2 && index2 == 3)//метры в километры
            {
                labelResult.Text = Convert.ToString(value / 100);
            }

            if (index1 == 3 && index2 == 0)//километры в миллиметры
            {
                labelResult.Text = Convert.ToString(value * 1e+6);
            }
            if (index1 == 3 && index2 == 1)//километры в сантиметры
            {
                labelResult.Text = Convert.ToString(value * 100000);
            }
            if (index1 == 3 && index2 == 2)//километры в метры
            {
                labelResult.Text = Convert.ToString(value * 1000);
            }

        }


    }
}
