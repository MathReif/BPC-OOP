using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;  // Potrebuješ balík Newtonsoft.Json (nainštaluj cez NuGet)

namespace CalcWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal op1, op2;
            if (decimal.TryParse(txtOperand1.Text, out op1) &&
                decimal.TryParse(txtOperand2.Text, out op2))
            {
                var selectedOp = (cmbOperation.SelectedItem as ComboBoxItem)?.Content.ToString();

                string operation = "";
                if (selectedOp == "+") operation = "plus";
                else if (selectedOp == "-") operation = "minus";
                else if (selectedOp == "*") operation = "krat";
                else if (selectedOp == "/") operation = "deleno";

                var calcDto = new CalcDTO
                {
                    Operand1 = op1,
                    Operand2 = op2,
                    Operation = operation
                };

                var json = JsonConvert.SerializeObject(calcDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    try
                    {
                        var response = await client.PostAsync("https://localhost:7069/api/calc", content);

                        if (response.IsSuccessStatusCode)
                        {
                            var result = await response.Content.ReadAsStringAsync();
                            txtResult.Text = result;
                        }
                        else
                        {
                            txtResult.Text = "Chyba API";
                        }
                    }
                    catch (Exception ex)
                    {
                        txtResult.Text = "Chyba: " + ex.Message;
                    }
                }
            }
            else
            {
                txtResult.Text = "Zlé čísla";
            }
        }
    }

    public class CalcDTO
    {
        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }
        public string Operation { get; set; }
    }
}