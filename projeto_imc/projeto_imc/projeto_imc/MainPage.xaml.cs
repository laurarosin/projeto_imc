using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projeto_imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double peso=Convert.ToDouble(Peso.Text);
            Double altura=Convert.ToDouble(Altura.Text);
            Double imc;

            imc = peso / (altura * altura);
            string r = "";
            if (imc < 18.5) 
            {
                r = "ABAIXO DO PESO";
            } else if (imc >18.5)
            {
                r = "PESO NORMAL";
            } else if (imc < 29.9)
            {
                r = "SOBREPESO";
                
            }   else if (imc < 34.9)
            {
                r = "Obesidade grau 1";
            }   else if(imc < 39.9)
            {
                r = "Obesidade grau 2";
            }   else if (imc >= 40)
            {
                r = "Obesidade grau 3 ou Mórbida";
            }
            DisplayAlert("Cálculo", "O imc é:" + imc.ToString("0.00"), "ok");
            DisplayAlert("Resolução", r, "ok");
        }
    } 
}
