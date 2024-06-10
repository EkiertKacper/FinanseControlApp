using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Finanse_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double income = 0;
        public double expenditure = 0;
        public double bal = 0;

        private void btnAddIncomeCommit_Click(object sender, RoutedEventArgs e)
        {
            income += Convert.ToDouble(tbAddIncome.Text);
            bal = income - expenditure;
            stackInHistory.Items.Add($"Przychód: {tbAddIncome.Text}");
            txtAccBalance.Text = bal.ToString();
            tbAsideIncome.Text = income.ToString();
            tbAsideExp.Text = expenditure.ToString();
            pup4tbBal.Text = bal.ToString();
            pup4tbIncome.Text = income.ToString();
            pupAddIncome.IsOpen = false;
        }
        private void pup2BtnCommit_Click(object sender, RoutedEventArgs e)
        {
            expenditure += Convert.ToDouble(tbAddExp.Text);
            bal = income - expenditure;
            string item = $"Wydatek: {tbAddExp.Text}, Kategoria: {pup2cb.Text}";
            stackInHistory.Items.Add(item);
            txtAccBalance.Text = bal.ToString();
            tbAsideIncome.Text = income.ToString();
            tbAsideExp.Text = expenditure.ToString();
            pup4tbBal.Text= bal.ToString();
            pup4tbExp.Text = expenditure.ToString();
            pupAddExpenditure.IsOpen = false;
        }


        private void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            pupAddIncome.IsOpen = true;
        }
        private void btnAddExpenditiure_Click(object sender, RoutedEventArgs e)
        {
            pupAddExpenditure.IsOpen = true;
        }
        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            pupHistory.IsOpen = true;
        }
        private void btnBalance_Click(object sender, RoutedEventArgs e)
        {
            pupBal.IsOpen = true;
        }
        private void pupBtnCancel_Click(object sender, RoutedEventArgs e)
        {
            pupAddIncome.IsOpen = false;
        }
        private void pup2BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            pupAddExpenditure.IsOpen = false;
        }
        private void pup3btnCancel_Click(object sender, RoutedEventArgs e)
        {
            pupHistory.IsOpen = false;
        }

        private void pup4btnCancel_Click(object sender, RoutedEventArgs e)
        {
            pupBal.IsOpen=false;
        }
    }
}