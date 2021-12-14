using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Text.RegularExpressions;

namespace DZ5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        class Fraction
        {
            public Fraction(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            public int Numerator { get; private set; }
            public int Denominator { get; private set; }

            public Fraction Sum(Fraction fraction)
            {
                return new Fraction(this.Numerator * fraction.Denominator + fraction.Numerator * this.Denominator, this.Denominator * fraction.Denominator);
            }

            public Fraction Sub(Fraction fraction)
            {
                return new Fraction(this.Numerator * fraction.Denominator - fraction.Numerator * this.Denominator, this.Denominator * fraction.Denominator);
            }

            public Fraction Mul(Fraction fraction)
            {
                return new Fraction(this.Numerator * fraction.Numerator, this.Denominator * fraction.Denominator);
            }

            public Fraction Div(Fraction fraction)
            {
                return new Fraction(this.Numerator * fraction.Denominator, this.Denominator * fraction.Numerator);
            }
        }



        public MainWindow()
        {
            InitializeComponent();
        }



    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = new Fraction(int.Parse(a_1.Text), int.Parse(a_2.Text));
            var b = new Fraction(int.Parse(b_1.Text), int.Parse(b_2.Text));

            resoult.Text = ($"{a.Sum(b).Numerator}/{a.Sum(b).Denominator}").ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var a = new Fraction(int.Parse(a_1.Text), int.Parse(a_2.Text));
            var b = new Fraction(int.Parse(b_1.Text), int.Parse(b_2.Text));

            resoult.Text = ($"{a.Sub(b).Numerator}/{a.Sub(b).Denominator}").ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var a = new Fraction(int.Parse(a_1.Text), int.Parse(a_2.Text));
            var b = new Fraction(int.Parse(b_1.Text), int.Parse(b_2.Text));

            resoult.Text = ($"{a.Mul(b).Numerator}/{a.Mul(b).Denominator}").ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var a = new Fraction(int.Parse(a_1.Text), int.Parse(a_2.Text));
            var b = new Fraction(int.Parse(b_1.Text), int.Parse(b_2.Text));

            resoult.Text = ($"{a.Div(b).Numerator}/{a.Div(b).Denominator}").ToString();
        }
    }
}
