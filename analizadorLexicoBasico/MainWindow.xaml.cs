using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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

namespace analizadorLexicoBasico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lector l1 = new Lector(txtEntrada.Text);
            respuesta.Content = l1.leer();
        }
    }
}

class Lector
{

    private String cadena;

    public Lector(String cadena)
    {
        this.cadena = cadena;
    }

    public String leer()
    {

        String resultadoF = cadena;



        return resultadoF;

    }

}
