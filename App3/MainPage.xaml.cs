using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace Practica_3
{
    public partial class MainPage : ContentPage
    {
        public string Cadena = "";
        public MainPage()
        {
            InitializeComponent();
        }
        bool _Alto;
        bool _Feo;
        bool _Listo;
        bool _Extrabagante;
        bool _Raro;
        bool _Grande;
        string _Nombre;


        public void Criticar(object sender, EventArgs e)
        {
            Cadena = "";
            if (!string.IsNullOrEmpty(Entry_Nombre.Text))
            {


                _Nombre = Entry_Nombre.Text;
                _Alto = Box_Alto.IsChecked;
                _Listo = Box_Listo.IsChecked;
                _Extrabagante = Box_Extravagante.IsChecked;
                _Feo = Box_Feo.IsChecked;
                _Raro = Box_Raro.IsChecked;
                _Grande = Box_Grande.IsChecked;
                if (Radio_Hombre.IsChecked)
                    GeneroHombre(_Nombre);
                else
                    GeneroMujer(_Nombre);
            }
            else
                DisplayAlert("Datos Incorrectos", "Ingrese el nombre", "Cerrar");
        }




        public void GeneroHombre(string _Nombre)
        {

            Cadena += _Nombre + " es ";

            int cont = 0;
            if (_Alto == true)
            {
                Cadena += ", alto ";
                cont++;
            }
            if (_Feo == true)
            {
                Cadena += ", feo ";
                cont++;
            }
            if (_Listo == true)
            {
                Cadena += ", listo ";
                cont++;
            }
            if (_Extrabagante == true)
            {
                Cadena += ", extrabagante ";
                cont++;
            }
            if (_Raro == true)
            {
                Cadena += ", raro ";
                cont++;
            }
            if (_Grande == true)
            {
                Cadena += ", grande ";
                cont++;
            }
            Yepunto(cont);
            Critica.Text = Cadena.ToString();
        }

        public void GeneroMujer(string _Nombre)
        {
            Cadena += _Nombre + " es ";

            int cont = 0;
            if (_Alto == true)
            {
                Cadena += ", alta";
                cont++;
            }
            if (_Feo == true)
            {
                Cadena += ", fea ";
                cont++;
            }
            if (_Listo == true)
            {
                Cadena += ", lista ";
                cont++;
            }
            if (_Extrabagante == true)
            {
                Cadena += ", extrabagante ";
                cont++;
            }
            if (_Raro == true)
            {
                Cadena += ", rara ";
                cont++;
            }
            if (_Grande == true)
            {
                Cadena += ", grande ";
                cont++;
            }
            Yepunto(cont);
            Critica.Text = Cadena.ToString();



        }

        public void Yepunto(int cont)
        {

            int contador = 0;
            for (int i = 0; i < Cadena.Length; i++)
            {
                if (Cadena[i] == ',')
                {

                    contador++;
                }

                if (Cadena[i] == ',' && contador == 1)
                {
                    Cadena = Cadena.Remove(i, 1);

                }
                    if (contador == cont && contador != 1 && contador!=0)
                    {
                        Cadena = Cadena.Substring(0, i) + 'y' + Cadena.Substring(i + 1);
                        contador++;
                    }
            }
            



        }
    }
}
