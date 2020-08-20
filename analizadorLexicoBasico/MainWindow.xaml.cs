using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //Limpiamos el listBox y leemos la entrada del usuario
            listSalidas.Items.Clear();
            leer(txtEntrada.Text);
        }

        public void leer(String cad)
        {
            //Convertimos la entrada del usuario en un array tipo char
            char[] cadena = cad.ToCharArray();

            //Ciclo que nos sirve para analizar cada posición de la cadena
            for (int i = 0; i < cad.Length; i++)
            {
                if ( esQ(cadena[i]) )
                {
                    listSalidas.Items.Add("SIUUUUU");
                }
            }
        }

        private bool esNumero(char num)
        {
            if(num >= 48 && num <= 57)
            {
                return true;
            }
            else
                return false;
        }

        private bool esLetra(char num)
        {
            if (num >= 65 && num <= 90)
                return true;
            else if (num >= 97 && num <= 122)
                return true;
            else if (num == 164 || num == 165)
                return true;
            else return false;
        }

        private bool esPunto(char num)
        {
            if (num == 46)
                return true;
            else
                return false;
        }

        private bool esQ(char num)
        {
            if (num == 81)
                return true;
            else
                return false;
        }
    }
}
