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
using System.IO;

namespace Wynagrodzenia
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Wynagrodzenie> wynagrodzenia = new Dictionary<int, Wynagrodzenie>();
        
        int lp = 0;
        public MainWindow()
        {
            InitializeComponent();     
        }
        private void Oblicz_button_Click(object sender, RoutedEventArgs e)
        {
            Obciazenia obc = new Obciazenia(0.0976M, 0.015M, 0.0245M, 0.09M, 0.18M, 111.25M, 0.0775M, 46.33M);

            
            if (placapodstText.Text == "")
                    MessageBox.Show("Wprowadź płacę zasadniczą!", "Błąd wyliczenia!", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    try
                    {
                    ReplaceSign();
                    wynagrodzenia.Add(++lp, new Wynagrodzenie(lp));
                    Calculator(obc);
                    Lista_plac.Items.Add(wynagrodzenia[lp]);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Błąd wyliczenia!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
        }

        private void ReplaceSign()
        {
            if (dodatkiText.Text == "")
                dodatkiText.Text = "0";
            if (nieskladkoweText.Text == "")
                nieskladkoweText.Text = "0";
            placapodstText.Text = placapodstText.Text.Replace(',', '.');
            dodatkiText.Text = dodatkiText.Text.Replace(',', '.');
            nieskladkoweText.Text = nieskladkoweText.Text.Replace(',', '.');
        }
        private void Calculator(Obciazenia obc)
        {
            decimal brutto = Math.Round(Convert.ToDecimal(placapodstText.Text) + Convert.ToDecimal(dodatkiText.Text),2);
            decimal spoleczne = (brutto - (brutto * obc.Emerytalna) - (brutto * obc.Rentowa) - (brutto * obc.Chorobowa));
            decimal podatek = (((spoleczne - obc.KUP) * obc.PD) - obc.KWOP) - ((spoleczne) * obc.Zdrowotna2);

            wynagrodzenia[lp].placa_podstawowa = Math.Round(Convert.ToDecimal(placapodstText.Text), 2);
            wynagrodzenia[lp].dodatki = Math.Round(Convert.ToDecimal(dodatkiText.Text),2);
            wynagrodzenia[lp].wynagr_brutto = brutto;
            wynagrodzenia[lp].ubezp_emerytalne = Math.Round(brutto * obc.Emerytalna,2);
            wynagrodzenia[lp].ubezp_rentowe = Math.Round(brutto * obc.Rentowa,2);
            wynagrodzenia[lp].ubezp_chorobowe = Math.Round(brutto * obc.Chorobowa,2);
            wynagrodzenia[lp].ubezp_zdrowotne = Math.Round(spoleczne * obc.Zdrowotna1,2);
            wynagrodzenia[lp].podatekUS = Math.Round(podatek, 0);

            wynagrodzenia[lp].wynagr_netto = Math.Round((brutto - (brutto * obc.Emerytalna) - (brutto * obc.Rentowa) - (brutto * obc.Chorobowa) - (spoleczne * obc.Zdrowotna1) - Math.Round(podatek, 0)) + decimal.Parse(nieskladkoweText.Text),2);
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Power_Button(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExcelExport_Button(object sender, MouseButtonEventArgs e)
        {
            if (Lista_plac.Items.IsEmpty == true)
            {
                MessageBox.Show("Nie wprowadzono żadnych danych!", "Błąd zapisu!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string path = @"C:\Wynagrodzenia";

                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                Lista_plac.SelectAllCells();
                Lista_plac.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, Lista_plac);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                Lista_plac.UnselectAllCells();
                StreamWriter sheet1 = new StreamWriter(@"C:\Wynagrodzenia\sheet1.xls", false, Encoding.GetEncoding("Windows-1252"));
                sheet1.WriteLine(result.Replace(',', ' '));
                sheet1.Close();
            }
        }

        private void DeleteAllRows_Button(object sender, MouseButtonEventArgs e)
        {
            Lista_plac.Items.Clear();
            wynagrodzenia.Clear();
            lp = 0;
        }
    }  
}
