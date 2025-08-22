using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace ProjetoCalculadora
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSoma_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);

            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            TxtResultado.Text = calc.Somar().ToString();
        }

        private void BtnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);
            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            TxtResultado.Text = calc.Subtrair().ToString();
           
        }

        private void BtnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);
            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            TxtResultado.Text = calc.Multiplicar().ToString();
        }

        private void BtnDivisao_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);
            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            try
            {
                TxtResultado.Text = calc.Dividir().ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnPotencia_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);
            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            TxtResultado.Text = calc.Potencia().ToString();
        }

        private void BtnRaiz_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);
            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            TxtResultado.Text = calc.RaizQuadrada().ToString();
        }

        private void BtnModulo_Click(object sender, RoutedEventArgs e)
        {
            if (!AddNumero()) return;
            double n1 = double.Parse(TxtNumero1.Text);
            double n2 = double.Parse(TxtNumero2.Text);
            Calculadora.Calculadora calc = new Calculadora.Calculadora(n1, n2);
            TxtResultado.Text = calc.Modulo().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtResultado.Clear();
            TxtNumero1.Clear();
            TxtNumero2.Clear();
        }

        private bool AddNumero()
        {
            if (string.IsNullOrWhiteSpace(TxtNumero1.Text) || TxtNumero1.Text == "Digite o primeiro número" ||
                string.IsNullOrWhiteSpace(TxtNumero2.Text) || TxtNumero2.Text == "Digite o segundo número")
            {
                Funcao.MsgErro("Por favor, preencha ambos os campos com números válidos.");
                return false;
            }
            return true;
        }

        private void TxtNumero1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtNumero1.Text == "Digite o primeiro número")
            {
                TxtNumero1.Text = "";
                TxtNumero1.Foreground = Brushes.White;
            }
        }

        private void TxtNumero1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumero1.Text))
            {
                TxtNumero1.Text = "Digite o primeiro número";
                TxtNumero1.Foreground = new SolidColorBrush(Color.FromRgb(130, 130, 130)); // #FF828282
            }
        }

        private void TxtNumero2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtNumero2.Text == "Digite o segundo número")
            {
                TxtNumero2.Text = "";
                TxtNumero2.Foreground = Brushes.White;
            }
        }

        private void TxtNumero2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumero2.Text))
            {
                TxtNumero2.Text = "Digite o segundo número";
                TxtNumero2.Foreground = new SolidColorBrush(Color.FromRgb(130, 130, 130));
            }
        }

        private void TxtNumero_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            char c = e.Text[0];
            if (!char.IsDigit(c) && c != ',' && c != '.')
            {
                e.Handled = true;
            }
        }
    }
}
