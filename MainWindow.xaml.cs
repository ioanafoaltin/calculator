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

namespace Calculator_Nou
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float _a;
        private OperatorEnum _operatorEnum;
        float _rezultat = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        //usyntaxa regiune: 
        // #region numeregiune
        // #endregion numeregiune
        //click pe butoanele cu cifre
        // sau rg + tabtab

        #region ClickPeButoaneCuCifre

        private void butonZero_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + "0").ToString();
        }

        private void butonUnu_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + "1").ToString();
        }

        private void butonDoi_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 2).ToString();
        }

        private void butonTrei_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 3).ToString();
        }

        private void butonPatru_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 4).ToString();
        }

        private void butonCinci_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 5).ToString();
        }

        private void butonSase_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 6).ToString();
        }

        private void butonSapte_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 7).ToString();
        }

        private void butonOpt_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 8).ToString();
        }

        private void butonNoua_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = float.Parse(rezultat.Text + 9).ToString();
        }

        private void butonPunct_Click(object sender, RoutedEventArgs e)
        {
            rezultat.Text = rezultat.Text + "." ;
        }

        private void butonClear_Click(object sender, RoutedEventArgs e)
        {
            _rezultat = 0;
            rezultat.Text = float.Parse("0").ToString();
        }

        #endregion ClickPeButoaneCuCifre

        //egal
        private void butonEgal_Click(object sender, RoutedEventArgs e)
        {
            float b = float.Parse(rezultat.Text);

            switch (_operatorEnum)
            {
                case OperatorEnum.Plus:
                    _rezultat = _a + b;
                    break;
                case OperatorEnum.Minus:
                    _rezultat = _a - b;
                    break;
                case OperatorEnum.Inmultit:
                    _rezultat = _a * b;
                    break;
                case OperatorEnum.Impartit:
                    _rezultat = _a / b;
                    break;
            }
            rezultat.Text = _rezultat.ToString();
        }

        //operatori pe butoane
        private void butonPlus_Click(object sender, RoutedEventArgs e)
        {
            _operatorEnum = OperatorEnum.Plus;
            if (rezultat.Text != "")
            {
                _a = float.Parse(rezultat.Text);
                rezultat.Text = ""; //nu prea inteleg care e faza aici
            }
        }

        private void butonMinus_Click(object sender, RoutedEventArgs e)
        {
            _operatorEnum = OperatorEnum.Minus;
            if (rezultat.Text != "")
            {
                _a = float.Parse(rezultat.Text);
                rezultat.Text = "";
            }
        }

        private void butonInmultit_Click(object sender, RoutedEventArgs e)
        {
            _operatorEnum = OperatorEnum.Inmultit;
            if (rezultat.Text != "")
            {
                _a = float.Parse(rezultat.Text);
                rezultat.Text = "";
            }
        }

        private void butonImpartit_Click(object sender, RoutedEventArgs e)
        {
            _operatorEnum = OperatorEnum.Impartit;
            if (rezultat.Text != "")
            {
                _a = float.Parse(rezultat.Text);
                rezultat.Text = "";
            }
        }

        //butoanele merg si de la tastatura
        public void Window_KeyDowe(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemPlus)
            {
                butonPlus_Click(null, null);
            }

            if (e.Key == Key.OemMinus)
            {
                butonMinus_Click(null, null);
            }

            if (e.Key == Key.Multiply)
            {
                butonInmultit_Click(null, null);
            }
            
            if (e.Key == Key.Divide)
            {
                butonImpartit_Click(null, null);
            }

            if (e.Key == Key.NumPad0)
            {
                butonZero_Click(null, null);
            }

            if (e.Key == Key.NumPad1)
            {
                butonUnu_Click(null, null);
            }

            if (e.Key == Key.NumPad2)
            {
                butonDoi_Click(null, null);
            }

            if (e.Key == Key.NumPad3)
            {
                butonTrei_Click(null, null);
            }

            if (e.Key == Key.NumPad4)
            {
                butonPatru_Click(null, null);
            }

            if (e.Key == Key.NumPad5)
            {
                butonCinci_Click(null, null);
            }

            if (e.Key == Key.NumPad6)
            {
                butonSase_Click(null, null);
            }

            if (e.Key == Key.NumPad7)
            {
                butonSapte_Click(null, null);
            }

            if (e.Key == Key.NumPad8)
            {
                butonOpt_Click(null, null);
            }

            if (e.Key == Key.NumPad9)
            {
                butonNoua_Click(null, null);
            }
        }

    }
}
