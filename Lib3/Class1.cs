using System.Windows;

namespace Lib3
{
    public class CalcNumbers
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="x">������������ �����</param>
    /// <param name="sqrx">������ �� �����</param>
    /// <param name="step2">������� �����</param>
        public static void CalcFunction(out int x, out double sqrx, out int step2)
        {
            int proverka = 0;
            sqrx = 0;
            step2 = 0;
            Random random = new Random();
            int prevX = 0;

            do
            {
                x = random.Next(-4, 8);

                if (x == prevX)
                {
                    MessageBox.Show("������������� 2 ���������� ����� ������. ���������� �����������");
                }

                if (x < 0)
                {
                    step2 = x * x;
                }
                if (x > 0)
                {
                    sqrx = Math.Sqrt(x);
                }
                proverka = x;

            }while (x != proverka);
        }
    }
}