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

namespace Wynagrodzenia
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal podstawowa;
        decimal dodatkii;
        decimal brutto;
        decimal spoleczne;
        decimal podatek;
        public MainWindow()
        {
            InitializeComponent();   
        }

        private void Oblicz_button_Click(object sender, RoutedEventArgs e)
        {
            
                if (placapodstText.Text == "")
                {
                    MessageBox.Show("Wprowadź płacę zasadniczą!", "Błąd wyliczenia", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    try
                    {
                        Wynagrodzenie addwynagrodzenie = new Wynagrodzenie();
                        podstawowa = decimal.Parse(placapodstText.Text);
                        if (dodatkiText.Text == "")
                        {
                            dodatkii = 0;
                            dodatkiText.Text = "0";
                        }
                        else
                        {
                            dodatkii = decimal.Parse(dodatkiText.Text);
                        }
                        if (nieskładkoweText.Text == "")
                        {
                            nieskładkoweText.Text = "0";
                        }

                        brutto = podstawowa + dodatkii;
                        spoleczne = (brutto - (brutto * 0.0976M) - (brutto * 0.015M) - (brutto * 0.0245M));
                        podatek = (((spoleczne - 111.25M) * 0.18M) - 46.33M) - ((spoleczne) * 0.0775M);

                        addwynagrodzenie.placa_podstawowa = podstawowa.ToString("c");
                        addwynagrodzenie.dodatki = dodatkii.ToString("c");
                        addwynagrodzenie.wynagr_brutto = brutto.ToString("c");
                        addwynagrodzenie.ubezp_emerytalne = (brutto * 0.0976M).ToString("c");
                        addwynagrodzenie.ubezp_rentowe = (brutto * 0.015M).ToString("c");
                        addwynagrodzenie.ubezp_chorobowe = (brutto * 0.0245M).ToString("c");
                        addwynagrodzenie.ubezp_zdrowotne = (spoleczne * 0.09M).ToString("c");
                        addwynagrodzenie.podatekUS = Math.Round(podatek, 0).ToString("c");


                        addwynagrodzenie.wynagr_netto = ((brutto - (brutto * 0.0976M) - (brutto * 0.015M) - (brutto * 0.0245M) - (spoleczne * 0.09M) - Math.Round(podatek, 0)) + decimal.Parse(nieskładkoweText.Text)).ToString("c");


                        Lista_plac.Items.Add(addwynagrodzenie);
                    }
                    catch
                    {
                        MessageBox.Show("Wprowadzono błędne dane!", "Błąd wyliczenia", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;  
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }


    }  
}
