using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.ActiveDirectory;
using System.Numerics;
using System.Threading.Tasks.Sources;
using System.Web;

namespace Proyecto__calculadora
{
    public partial class Form1 : Form
    {
        static float num1, num2 = 0;
        static string valor2 = "";
        static string n = string.Empty;
        static string decima = "";
        static float total = 0;
        static bool suma,resta,coma,limpiar = false;
       
        public Form1()
        {
            InitializeComponent();
        }
       
        public static void Reset()
        {

            valor2 = "";
            num2 = 0;
            total = 0;
        }
        public void valor0()
        {
            if (Lresultado.Text == "0") { Lresultado.Text = string.Empty; }

        }
        

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

       


        private void b_1_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            FuncionBotones.funcionBotones_(ref coma, ref suma,ref valor2,ref  n,
                                   ref  decima, ref resta, Lresultado);
        }
        private void b_2_Click(object sender, EventArgs e)
        {
            n = "2";
            limpiar = true; valor0();
            FuncionBotones.funcionBotones_(ref coma, ref suma,ref valor2, ref n,
                       ref  decima,ref resta, Lresultado);
        }
        private void b_3_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "3";
            FuncionBotones.funcionBotones_(ref coma,ref  suma, ref valor2, ref  n,
                        ref decima, ref resta, Lresultado);
        }
        private void b_4_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "4";
            FuncionBotones.funcionBotones_(ref coma, ref suma, ref valor2,ref n,
                         ref decima, ref resta, Lresultado);

        }
        private void b_5_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "5";
            FuncionBotones.funcionBotones_(ref coma, ref suma,ref valor2,ref n,
                        ref decima, ref resta,Lresultado);


        }

        private void b_6_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "6";
            FuncionBotones.funcionBotones_(ref coma, ref suma, ref valor2, ref n,
                         ref decima, ref resta, Lresultado);
        }

        private void b_7_Click(object sender, EventArgs e)

        {
            limpiar = true; valor0();
            n = "7";
            FuncionBotones.funcionBotones_(ref coma,ref  suma,ref valor2, ref n,
                        ref decima,ref resta, Lresultado);
        }
        private void b_8_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "8";
            FuncionBotones.funcionBotones_(ref coma, ref suma,ref valor2, ref n,
                        ref decima,ref  resta, Lresultado);
        }
        private void b_9_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "9";
            FuncionBotones.funcionBotones_(ref coma, ref suma, ref valor2,ref  n,
                        ref decima,ref resta, Lresultado);
        }
        private void b_0_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "0";
            FuncionBotones.funcionBotones_(ref coma, ref suma,ref valor2,ref n,
                        ref decima, ref resta, Lresultado);
        }

        private void b_coma_Click(object sender, EventArgs e)

        {
            Lresultado.Text = Lresultado.Text + ",";

            decima = Lresultado.ToString();
            coma = true;

        }
        private void b_Borrar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            Lresultado.Text = "0";
            suma = false;
        }

        private void b_mas_Click(object sender, EventArgs e)
        {

            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Lresultado.Text + "+";


            suma = true;
            if (suma == true && coma == true)
            { Lresultado.Text = string.Empty; }
        }


        private void b_igual_Click(object sender, EventArgs e)
        {

            if (suma == true)
            {
                Lresultado.Text = string.Empty;
                num2 = float.Parse(valor2);
                Lresultado.Text = Lresultado.Text + "=" + SUMA.sumar(num1, num2).ToString();
                suma = false;
                coma = false;

            }
            else if (resta == true)
            {
                Lresultado.Text = string.Empty;
                num2 = float.Parse(valor2);
                Lresultado.Text = Lresultado.Text + "=" + Resta.restars(num1, num2).ToString();
                resta = false;
            }



        }

        public static void Lresultado_Click(object sender, EventArgs e)

        {


        }


        private void b_diferencial_Click_1(object sender, EventArgs e)
        {

            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Factorial.factorial(num1).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Lresultado.Text);
            Lresultado.Text = Lresultado.Text + "-";
            resta = true;
        }
    }
} 
         
