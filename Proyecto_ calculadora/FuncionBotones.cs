using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__calculadora
{
    internal class FuncionBotones
    {

        public static void funcionBotones_(ref bool coma, ref bool suma, ref  string valor2, ref string n,
            ref string decima, ref bool resta, Label resultado)
        {
            if (coma == true && suma == true)
            {

                valor2 = resultado.Text + n;
                decima = valor2;
            }
            else if (suma == true)
            {
                Form1.Reset();
                resultado.Text = string.Empty;
                valor2 = resultado.Text + n;
                decima = valor2;
            }
            else if (resta == true)
            {
                Form1.Reset();
                resultado.Text = string.Empty;
                valor2 = resultado.Text + n;
                decima = valor2;

            }
            resultado.Text = resultado.Text + n;



        }
    }
}
