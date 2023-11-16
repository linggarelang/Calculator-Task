using System;
using System.Windows.Forms;

namespace CalculatorTask
{
    public partial class FormCalculate : Form
    {
        public delegate void CreateUpdateEventHandler(Calculator Calc);
        public event CreateUpdateEventHandler OnCreate;
        private Calculator Calc;

        public FormCalculate()
        {
            InitializeComponent();
            ListOperations.SelectedIndex = 0;
        }

        public void HandlerOperation(int operation, double isValueA, double isValueB)
        {
            switch (operation)
            {
                case 0:
                    Calc.Result = isValueA + isValueB;
                    Calc.Operations = "+";
                    Calc.Title = "Penjumlahan";
                    break;
                case 1:
                    Calc.Result = isValueA - isValueB;
                    Calc.Operations = "-";
                    Calc.Title = "Pengurangan";
                    break;
                case 2:
                    Calc.Result = isValueA * isValueB;
                    Calc.Operations = "*";
                    Calc.Title = "Perkalian";
                    break;
                case 3:
                    Calc.Result = isValueA / isValueB;
                    Calc.Operations = "/";
                    Calc.Title = "Pembagian";
                    break;
            }
        }

        private void ButtonHitung_Click(object sender, System.EventArgs e)
        {
            try
            {
                Calc = new Calculator();
                Calc.ValueA = Convert.ToDouble(TextNilaiA.Text);
                Calc.ValueB = Convert.ToDouble(TextNilaiB.Text);

                int operation = ListOperations.SelectedIndex;

                HandlerOperation(operation, Calc.ValueA, Calc.ValueB);

                OnCreate(Calc);
                TextNilaiA.Clear();
                TextNilaiB.Clear();
                TextNilaiA.Focus();
            }
            catch (System.FormatException)
            {
                DialogResult res = MessageBox.Show("NILAI HARUS BERTIPE ANGKA DAN TIDAK BOLEH NULL!!!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.No) this.Close();
            }

        }
    }
}
