using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewCalculadora.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private String number1;
        private String operation;
        private List<String> operationsList = new List<string>();
        public Page1()
        {
            InitializeComponent();
        }

        private void Button0_clicked(object sender, EventArgs e)
        {
            String number = "0";          

        }

        private void Button1_clicked(object sender, EventArgs e)
        {
            String number = "1";

        }
        private void Button2_clicked(object sender, EventArgs e)
        {
            String number = "2";

        }
        private void Button3_clicked(object sender, EventArgs e)
        {
            String number = "3";

        }
        private void ButtonSum_clicked(object sender, EventArgs e)
        {
            String number = "+";

        }
        private void Button4_clicked(object sender, EventArgs e)
        {
            String number = "4";

        }
        private void Button5_clicked(object sender, EventArgs e)
        {
            String number = "5";

        }
        private void Button6_clicked(object sender, EventArgs e)
        {
            String number = "6";

        }
        private void ButtonRes_clicked(object sender, EventArgs e)
        {
            String number = "-";

        }
        private void Button7_clicked(object sender, EventArgs e)
        {
            String number = "7";

        }
        private void Button8_clicked(object sender, EventArgs e)
        {
            String number = "8";

        }
        private void Button9_clicked(object sender, EventArgs e)
        {
            String number = "9";

        }
        private void ButtonPor_clicked(object sender, EventArgs e)
        {
            String number = "x";

        }
        private void ButtonC_clicked(object sender, EventArgs e)
        {
            String number = "c";

        }
        private void ButtonPare_clicked(object sender, EventArgs e)
        {
            String number = "()";

        }
        private void ButtonPorc_clicked(object sender, EventArgs e)
        {
            String number = "%";

        }
        private void ButtonDiv_clicked(object sender, EventArgs e)
        {
            String number = "/";

        }
        private void ButtonSDR_clicked(object sender, EventArgs e)
        {
            String number = "+/-";

        }

        private void ButtonSDR_Clicked(object sender, EventArgs e)
        {
            int stringNumber = Convert.ToInt32(lblNumber.Text) * -1;
            lblNumber.Text = stringNumber.ToString();
        }
        private void ButtonPorc_Clicked(object sender, EventArgs e)
        {
            number1 = lblNumber.Text;
            operation = "porcentaje";
            lblOperations.Text += String.Format("{0:00}", number1) + "%";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblNumber.Text = "0";

        }

        private void ButtonDiv_Clicked(object sender, EventArgs e)
        {
            number1 = lblNumber.Text;
            operation = "division";
            lblOperations.Text += String.Format("{0:00}", number1) + "/";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblNumber.Text = "0";
        }

        private void ButtonPor_Clicked(object sender, EventArgs e)
        {
            number1 = lblNumber.Text;
            operation = "multiplicacion";
            lblOperations.Text += String.Format("{0:00}", number1) + "*";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblNumber.Text = "0";
        }

        private void ButtonRes_Clicked(object sender, EventArgs e)
        {
            number1 = lblNumber.Text;
            operation = "resta";
            lblOperations.Text += String.Format("{0:00}", number1) + "-";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblNumber.Text = "0";
        }

        private void ButtonSum_Clicked(object sender, EventArgs e)
        {
            number1 = lblNumber.Text;
            operation = "suma";
            lblOperations.Text += String.Format("{0:00}", number1) + "+";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblNumber.Text = "0";
        }

        private void ButtonResul_Clicked(object sender, EventArgs e)
        {
            number1 = lblNumber.Text;
            lblOperations.Text += number1;
            operationsList.Add(number1);
            lblNumber.Text = calculate(operationsList);
        }

        private String calculate(List<String> operationsList)
        {
            double actualNumber = 0;
            for (int i = 0; i < operationsList.Count; i++)
            {

                switch (operationsList[i])
                {
                    case "porcentaje":
                        i++;
                        actualNumber = actualNumber * Convert.ToInt32(operationsList[i]) / 100;
                        
                        break;
                    case "division":
                        i++;
                        actualNumber = actualNumber / Convert.ToInt32(operationsList[i]);
                        break;
                    case "multiplicacion":
                        i++;
                        actualNumber = actualNumber * Convert.ToInt32(operationsList[i]);
                        break;
                    case "resta":
                        i++;
                        actualNumber = actualNumber - Convert.ToInt32(operationsList[i]);
                        break;
                    case "suma":
                        i++;
                        actualNumber = actualNumber + Convert.ToInt32(operationsList[i]);
                        break;
                    default:
                        actualNumber = Convert.ToInt32(operationsList[i]);
                        break;
                }
            }

            return actualNumber.ToString();
        }


    }
}
