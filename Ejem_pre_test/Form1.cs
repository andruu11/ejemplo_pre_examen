using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem_pre_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador_click = 0; //inicializamos nuestra variable contadora de clicks en 0
        List<int> Lista_res = new List<int>(); //creamos una list de tipo entera
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text.Trim());//almacenamos en una variable el textbox1
            int num2 = Convert.ToInt32(textBox2.Text.Trim());//alamacenmos en una variable el textbox2
            contador_click++; // cada vez que damos click nuestra variable incrementa en uno
            if(contador_click == 1){//primer click
                Lista_res.Add(metodos.Multiplicar(num1, num2, contador_click));//invocamos nuestro metodo enviandole solo tres parametros y llenandolo en la lista 
                listBox1.Items.Add(metodos.Multiplicar(num1, num2, contador_click));//invocamos nuestro metodo enviandole solo tres parametros y llenandolo en el LISTBOX
                
            }
            else if (contador_click > 1)
            {//cuando sea mayor a un click
                var ultimo_reg = Lista_res.Last();//obtenemos el ultimo registro de la lista
                Lista_res.Add(metodos.Multiplicar(num1, num2, contador_click,ultimo_reg));//invocamos nuestro metodo y le enviamos cuatro paramentros, llenando la lista
                listBox1.Items.Add(metodos.Multiplicar(num1, num2, contador_click, ultimo_reg));//invocamos nuestro metodo enviandole cuatro parametros, llenando el LISTBOX
              }
       }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista_res.Clear();
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            contador_click = 0;


        }
    }
}
