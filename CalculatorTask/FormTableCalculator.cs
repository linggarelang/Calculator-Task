using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorTask
{
    public partial class FormTableCalculator : Form
    {
        private IList<Calculator> listDataCalculate = new List<Calculator>();

        public FormTableCalculator()
        {
            InitializeComponent();
            InitView();
        }

        private void InitView()
        {
            tablesCalculator.View = View.Details;
            tablesCalculator.FullRowSelect = true;
            tablesCalculator.GridLines = false;
            tablesCalculator.HeaderStyle = ColumnHeaderStyle.None;
            tablesCalculator.Columns.Add(null, 350, HorizontalAlignment.Center);
        }

        private void OnCreateData(Calculator Calc)
        {
            listDataCalculate.Add(Calc);

            string isValueA = Calc.ValueA.ToString();
            string isValueB = Calc.ValueB.ToString();
            string Result = Calc.Result.ToString();

            ListViewItem isList = new ListViewItem(
                $"Hasil {Calc.Title} {isValueA} {Calc.Operations} {isValueB} = {Result}"
            );

            tablesCalculator.Items.Add(isList);
        }

        private void ButtonHitung_Click(object sender, System.EventArgs e)
        {
            FormCalculate FormCalc = new FormCalculate();
            FormCalc.OnCreate += OnCreateData;
            FormCalc.ShowDialog();
        }
    }
}
