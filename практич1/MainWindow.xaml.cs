using Lib3;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практ_1
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

        private void btnMenuInfoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Генерировать случайные числа Х, распределенные в диапазоне от -4 до 7 \r\n и вычислять для чисел > 0 корень из X , а для чисел < 0 функцию x^2. \r\n Вычисления прекратить, когда подряд появится два одинаковых случайных числа. \r\n На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках");
        }

        private void btnCalc(object sender, RoutedEventArgs e)
        {
            double rez;
            int col;
            int chisla;

            CalcNumbers.CalcFunction(out chisla, out rez, out col);
            tbGenerate.Text = Convert.ToString(chisla);
            tbSqrt.Text = Convert.ToString(rez);
            tbSquare.Text = Convert.ToString(col);
        }


        private void btnClear(object sender, RoutedEventArgs e)
        {
            tbGenerate.Clear();
            tbSqrt.Clear();
            tbSquare.Clear();
        }

        private void btnExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}