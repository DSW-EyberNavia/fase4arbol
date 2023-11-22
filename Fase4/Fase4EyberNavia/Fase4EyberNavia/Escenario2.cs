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
    public partial class Escenario2 : Form
    {
        public Escenario2()
        {
            InitializeComponent();
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenúEscenarios form = new MenúEscenarios();
            form.Show();

            this.Close();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Incio del Arbol
            // Circulo #50
            Graphics nodo;
            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 410, 50, 40, 40);
            nodo.DrawString("50", Font, Brushes.White, 420, 60);


            // # Circulo 17

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 210, 100, 40, 40);
            nodo.DrawString("17", Font, Brushes.White, 220, 110);

            // lineas4 conectar nodo principal vs nodo 98
            Pen myline4 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline4, 700, 110, 450, 75);


            // lineas1 conectar nodo principal vs nodo 20
            Pen myline1 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline1, 248, 110, 410, 75);


            // lineas2 conectar izquierdo 20 vs 15
            Pen myline2 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline2, 153, 200, 216, 135);


            // lineas3 conectar derecho 12 vs 14
            Pen myline3 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline3, 300, 200, 160, 200);



            // # Circulo 12

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 140, 180, 40, 40);
            nodo.DrawString("12", Font, Brushes.White, 150, 188);

            // lineas5 conectar izquierdo 15 vs 10
            Pen myline5 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline5, 150, 215, 100, 280);

            // # Circulo 9

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 95, 250, 40, 40);
            nodo.DrawString("9", Font, Brushes.White, 105, 260);


            // # Circulo 14

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 270, 180, 40, 40);
            nodo.DrawString("14", Font, Brushes.White, 280, 188);





            // lineas8 conectar derecha 14 vs 17
            Pen myline8 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline8, 300, 184, 330, 145);


            // # Circulo 23

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 320, 123, 40, 40);
            nodo.DrawString("23", Font, Brushes.White, 330, 135);




            // # Circulo 19

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 700, 100, 40, 40);
            nodo.DrawString("19", Font, Brushes.White, 710, 110);



            // lineas9 conectar izquierda 19 vs 77
            Pen myline9 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline9, 500, 190, 702, 130);


            // # Circulo 72

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 480, 180, 40, 40);
            nodo.DrawString("72", Font, Brushes.White, 491, 192);


            // lineas10 conectar izquierda 77 vs 75
            Pen myline10 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline10, 489, 215, 469, 255);


            // # Circulo 54

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 440, 250, 40, 40);
            nodo.DrawString("54", Font, Brushes.White, 450, 260);


            // lineas11 conectar derecha 19 vs 91
            Pen myline11 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline11, 720, 139, 682, 255);


            // # Circulo 67

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 650, 250, 40, 40);
            nodo.DrawString("67", Font, Brushes.White, 660, 260);


            // lineas11 conectar derecha 91 vs 78
            Pen myline12 = new Pen(Color.Black, 2);
            nodo.DrawLine(myline12, 655, 280, 587, 340);


            // # Circulo 76

            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Green, 550, 330, 40, 40);
            nodo.DrawString("76", Font, Brushes.White, 560, 340);


         
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo para mostrar en pantalla el proceso


            Graphics InOrden;
            InOrden = CreateGraphics();
            InOrden.DrawString("InOrden :", Font, Brushes.Red, 10, 400);


            InOrden.DrawString("9", Font, Brushes.Black, 105, 400);

            InOrden.DrawString("12", Font, Brushes.Black, 125, 400);

            InOrden.DrawString("14", Font, Brushes.Black, 145, 400);

            InOrden.DrawString("17", Font, Brushes.Black, 165, 400);

            InOrden.DrawString("19", Font, Brushes.Black, 185, 400);

            InOrden.DrawString("23", Font, Brushes.Black, 205, 400);

            InOrden.DrawString("50", Font, Brushes.Black, 225, 400);

            InOrden.DrawString("54", Font, Brushes.Black, 245, 400);

            InOrden.DrawString("67", Font, Brushes.Black, 270, 400);

            InOrden.DrawString("72", Font, Brushes.Black, 295, 400);

            InOrden.DrawString("76", Font, Brushes.Black, 320, 400);

           ;
        }

        private void preoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo para mostrar en pantalla el proceso


            //Utilizamos el metodo para mostrar en pantalla el proceso

            Graphics PreOrden;
            PreOrden = CreateGraphics();
            PreOrden.DrawString("PreOrden :", Font, Brushes.Red, 10, 380);


            PreOrden.DrawString("50", Font, Brushes.Black, 105, 380);

            PreOrden.DrawString("17", Font, Brushes.Black, 125, 380);

            PreOrden.DrawString("12", Font, Brushes.Black, 145, 380);

            PreOrden.DrawString("9", Font, Brushes.Black, 165, 380);

            PreOrden.DrawString("14", Font, Brushes.Black, 185, 380);

            PreOrden.DrawString("23", Font, Brushes.Black, 205, 380);

            PreOrden.DrawString("19", Font, Brushes.Black, 225, 380);

            PreOrden.DrawString("72", Font, Brushes.Black, 245, 380);

            PreOrden.DrawString("54", Font, Brushes.Black, 270, 380);

            PreOrden.DrawString("67", Font, Brushes.Black, 295, 380);

            PreOrden.DrawString("76", Font, Brushes.Black, 320, 380);

            
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo para mostrar en pantalla el proceso

            Graphics PostOrden;
            PostOrden = CreateGraphics();
            PostOrden.DrawString("PostOrden :", Font, Brushes.Red, 10, 420);


            PostOrden.DrawString("9", Font, Brushes.Black, 105, 420);

            PostOrden.DrawString("14", Font, Brushes.Black, 125, 420);

            PostOrden.DrawString("12", Font, Brushes.Black, 145, 420);

            PostOrden.DrawString("19", Font, Brushes.Black, 165, 420);

            PostOrden.DrawString("23", Font, Brushes.Black, 185, 420);

            PostOrden.DrawString("17", Font, Brushes.Black, 200, 420);

            PostOrden.DrawString("67", Font, Brushes.Black, 225, 420);

            PostOrden.DrawString("54", Font, Brushes.Black, 245, 420);

            PostOrden.DrawString("76", Font, Brushes.Black, 270, 420);

            PostOrden.DrawString("72", Font, Brushes.Black, 295, 420);

            PostOrden.DrawString("50", Font, Brushes.Black, 320, 420);

          
        }
    }
}
