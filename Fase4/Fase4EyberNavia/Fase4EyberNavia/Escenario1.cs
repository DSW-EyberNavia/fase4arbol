using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4EyberNavia
{
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)

        // llamar Formulario de menú para selcionar otra escena
        {
            MenúEscenarios form = new MenúEscenarios();
            form.Show();

            this.Close();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo para mostrar en pantalla el proceso
            
            
                Graphics InOrden;
                InOrden = CreateGraphics();
                InOrden.DrawString("InOrden :", Font, Brushes.Red, 10, 400);


                InOrden.DrawString("2", Font, Brushes.Black, 105, 400);

                InOrden.DrawString("10", Font, Brushes.Black, 125, 400);

                InOrden.DrawString("15", Font, Brushes.Black, 145, 400);

                InOrden.DrawString("20", Font, Brushes.Black, 165, 400);

                InOrden.DrawString("29", Font, Brushes.Black, 185, 400);

                InOrden.DrawString("59", Font, Brushes.Black, 205, 400);

                InOrden.DrawString("69", Font, Brushes.Black, 225, 400);

                InOrden.DrawString("70", Font, Brushes.Black, 245, 400);

                InOrden.DrawString("75", Font, Brushes.Black, 270, 400);

                InOrden.DrawString("77", Font, Brushes.Black, 295, 400);

                InOrden.DrawString("98", Font, Brushes.Black, 320, 400);

                InOrden.DrawString("86", Font, Brushes.Black, 345, 400);

                InOrden.DrawString("78", Font, Brushes.Black, 365, 400);

                InOrden.DrawString("91", Font, Brushes.Black, 385, 400);
            
            

        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Incio del Arbol
            Graphics nodo;
            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 410, 50, 40, 40);
            nodo.DrawString("70", Font, Brushes.White, 420, 60);


            // # Circulo 20

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 210, 100, 40, 40);
            nodo.DrawString("20", Font, Brushes.White, 220, 110);

            // lineas4 conectar nodo principal vs nodo 98
            Pen myline4 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline4, 700, 110, 450, 75);


            // lineas1 conectar nodo principal vs nodo 20
            Pen myline1 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline1, 248, 110, 410, 75);


            // lineas2 conectar izquierdo 20 vs 15
            Pen myline2 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline2, 153, 200, 216, 135);


            // lineas3 conectar derecho 20 vs 59
            Pen myline3 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline3, 300, 200, 240, 135);



            // # Circulo 15

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 140, 180, 40, 40);
            nodo.DrawString("15", Font, Brushes.White, 150, 188);

            // lineas5 conectar izquierdo 15 vs 10
            Pen myline5 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline5, 150, 215, 100, 280);

            // # Circulo 10

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 95, 250, 40, 40);
            nodo.DrawString("10", Font, Brushes.White, 105, 260);

            // lineas6 conectar izquierdo 10 vs 2
            Pen myline6 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline6, 69, 340, 105, 287);

            // # Circulo 2

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 50, 330, 40, 40);
            nodo.DrawString("2", Font, Brushes.White, 65, 340);


            // # Circulo 59

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 270, 180, 40, 40);
            nodo.DrawString("59", Font, Brushes.White, 280, 188);



            // lineas7 conectar izquierdo 59 vs 29
            Pen myline7 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline7, 278, 215, 250, 255);


            // # Circulo 29

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 220, 250, 40, 40);
            nodo.DrawString("29", Font, Brushes.White, 230, 260);


            // lineas8 conectar derecha 59 vs 69
            Pen myline8 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline8, 300, 215, 330, 255);


            // # Circulo 29

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 320, 250, 40, 40);
            nodo.DrawString("69", Font, Brushes.White, 330, 260);




            // # Circulo 98

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 700, 100, 40, 40);
            nodo.DrawString("98", Font, Brushes.White, 710, 110);



            // lineas9 conectar izquierda 98 vs 77
            Pen myline9 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline9, 500, 190, 702, 130);


            // # Circulo 77

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 480, 180, 40, 40);
            nodo.DrawString("77", Font, Brushes.White, 491, 192);


            // lineas10 conectar izquierda 77 vs 75
            Pen myline10 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline10, 489, 215, 469, 255);


            // # Circulo 75

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 440, 250, 40, 40);
            nodo.DrawString("75", Font, Brushes.White, 450, 260);


            // lineas11 conectar derecha 77 vs 91
            Pen myline11 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline11, 510, 215, 660, 255);


            // # Circulo 91

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 650, 250, 40, 40);
            nodo.DrawString("91", Font, Brushes.White, 660, 260);


            // lineas11 conectar derecha 91 vs 78
            Pen myline12 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline12, 655, 280, 587, 340);


            // # Circulo 78

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 550, 330, 40, 40);
            nodo.DrawString("78", Font, Brushes.White, 560, 340);


            // lineas13 conectar derecha 78 vs 86
            Pen myline13 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline13, 580, 365, 620, 400);


            // # Circulo 86

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Blue, 600, 400, 40, 40);
            nodo.DrawString("86", Font, Brushes.White, 610, 410);

        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo para mostrar en pantalla el proceso

            Graphics PreOrden;
            PreOrden = CreateGraphics();
            PreOrden.DrawString("PreOrden :", Font, Brushes.Red, 10, 380);


            PreOrden.DrawString("70", Font, Brushes.Black, 105, 380);

            PreOrden.DrawString("20", Font, Brushes.Black, 125, 380);

            PreOrden.DrawString("15", Font, Brushes.Black, 145, 380);

            PreOrden.DrawString("10", Font, Brushes.Black, 165, 380);

            PreOrden.DrawString("2", Font, Brushes.Black, 185, 380);

            PreOrden.DrawString("59", Font, Brushes.Black, 200, 380);

            PreOrden.DrawString("29", Font, Brushes.Black, 225, 380);

            PreOrden.DrawString("69", Font, Brushes.Black, 245, 380);

            PreOrden.DrawString("98", Font, Brushes.Black, 270, 380);

            PreOrden.DrawString("77", Font, Brushes.Black, 295, 380);

            PreOrden.DrawString("75", Font, Brushes.Black, 320, 380);

            PreOrden.DrawString("91", Font, Brushes.Black, 345, 380);

            PreOrden.DrawString("78", Font, Brushes.Black, 365, 380);

            PreOrden.DrawString("86", Font, Brushes.Black, 385, 380);




        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo para mostrar en pantalla el proceso

            Graphics PostOrden;
            PostOrden = CreateGraphics();
            PostOrden.DrawString("PostOrden :", Font, Brushes.Red, 10, 420);


            PostOrden.DrawString("2", Font, Brushes.Black, 105, 420);

            PostOrden.DrawString("10", Font, Brushes.Black, 125, 420);

            PostOrden.DrawString("15", Font, Brushes.Black, 145, 420);

            PostOrden.DrawString("20", Font, Brushes.Black, 165, 420);

            PostOrden.DrawString("29", Font, Brushes.Black, 185, 420);

            PostOrden.DrawString("59", Font, Brushes.Black, 205, 420);

            PostOrden.DrawString("69", Font, Brushes.Black, 225, 420);

            PostOrden.DrawString("75", Font, Brushes.Black, 245, 420);

            PostOrden.DrawString("77", Font, Brushes.Black, 270, 420);

            PostOrden.DrawString("98", Font, Brushes.Black, 295, 420);

            PostOrden.DrawString("86", Font, Brushes.Black, 320, 420);

            PostOrden.DrawString("78", Font, Brushes.Black, 345, 420);

            PostOrden.DrawString("91", Font, Brushes.Black, 365, 420);

            PostOrden.DrawString("70", Font, Brushes.Black, 385, 420);

        }
    }
}
