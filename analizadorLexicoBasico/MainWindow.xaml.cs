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
            char[] cadena = cad.ToCharArray(0, cad.Length);
            int inicio = 0, final = 0;
            //Ciclo que nos sirve para analizar cada posición de la cadena
            for (int i = 0; i < cad.Length; i++)
            {
                if(cadena[i] == ' ')
                {
                    final = i;
                    char[] comp = cad.Substring(inicio, final-inicio).ToCharArray();
                    imprimir(comp);
                    inicio = i + 1;
                }
            }
            final = cad.Length;
            char[] compi = cad.Substring(inicio, final-inicio).ToCharArray();
            
            imprimir(compi);
        }

        private void imprimir(char[] comp)
        {
            if (esDinero(comp))
            {
                listSalidas.Items.Add("DINERO");
            }
            else if (esPalabra(comp))
            {
                listSalidas.Items.Add("PALABRA");
            } 
            else if (esEntero(comp))
            {
                listSalidas.Items.Add("ENTERO");
            }
            else if (esDecimal(comp))
            {
                listSalidas.Items.Add("DECIMAL");
            }
            else {
                listSalidas.Items.Add("EXPRESIÓN INVALIDA");
            }
        }

        private bool esDinero(char[] array)
        {
            bool condicion = true;
            //Cuenta los puntos que existen en la cadena
            int cont = 0;

            //Verifica que la cadena inicie con una Q
            if (array.Length > 1 && esQ(array[0]))
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (esPunto(array[i]))
                        cont++;
                    else if (!esNumero(array[i]))
                    {
                        condicion = false;
                    }
                    if (cont == 2)
                    {
                        condicion = false;
                    }
                }
            }
            else
            {
                condicion = false;
            }
            return condicion;
        }

        private bool esEntero(char[] array)
        {
            bool condicion = true;
            //En el caso de que exista un entero expresado de la siguiente manera 13.00, se tomará como entero
            //una expresión escrita de la forma n. se tomara como n.00 (ejemplo: 13. = 13.00)
            for(int i = 0; i < array.Length; i++)
            {
                if (i == (array.Length - 1) && esPunto(array[i])) { }
                else if (esPunto(array[i]))
                {
                    for(int j = i+1; j < array.Length; j++)
                    {
                        if (array[j] != '0')
                            condicion = false;
                    }
                }
                else if (!esNumero(array[i]))
                    condicion = false;
            }
            return condicion;
        }

        private bool esDecimal(char[] array)
        {
            bool condicion = true;
            //Cuenta la cantidad de puntos existentes en la cadena
            int cont = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (esPunto(array[i]))
                    cont++;
                else if (!esNumero(array[i]))
                    condicion = false;
                if (cont == 2)
                    condicion = false;
            }
            return condicion;
        }

        private bool esPalabra(char[] array)
        {
            bool condicion = true;
            for(int i = 0; i < array.Length; i++)
            {
                if (!esLetra(array[i]))
                    condicion = false;
            }
            return condicion;
        }

        //Los siguientes métodos sirven para identificar que los carácteres ingresados sean permitidos por el alfabeto del analizador
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
            else if (num == 'ñ' || num == 'Ñ' || num == 'á' || num == 'é' || num == 'í' || num == 'ó' || num == 'ú' || num == 'Á' || num == 'É' || num == 'Í' || num == 'Ó' || num == 'U')
                return true;
            else 
                return false;
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
