namespace Fase4EyberNavia
{
    partial class Escenario2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            graficaToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            preoToolStripMenuItem = new ToolStripMenuItem();
            inOrdenToolStripMenuItem = new ToolStripMenuItem();
            postOrdenToolStripMenuItem = new ToolStripMenuItem();
            volverAlMenúToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { graficaToolStripMenuItem, registrosToolStripMenuItem, volverAlMenúToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // graficaToolStripMenuItem
            // 
            graficaToolStripMenuItem.Name = "graficaToolStripMenuItem";
            graficaToolStripMenuItem.Size = new Size(56, 20);
            graficaToolStripMenuItem.Text = "Grafica";
            graficaToolStripMenuItem.Click += graficaToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preoToolStripMenuItem, inOrdenToolStripMenuItem, postOrdenToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(75, 20);
            registrosToolStripMenuItem.Text = "Recorridos";
            // 
            // preoToolStripMenuItem
            // 
            preoToolStripMenuItem.Name = "preoToolStripMenuItem";
            preoToolStripMenuItem.Size = new Size(130, 22);
            preoToolStripMenuItem.Text = "PreOrden";
            preoToolStripMenuItem.Click += preoToolStripMenuItem_Click;
            // 
            // inOrdenToolStripMenuItem
            // 
            inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            inOrdenToolStripMenuItem.Size = new Size(130, 22);
            inOrdenToolStripMenuItem.Text = "InOrden";
            inOrdenToolStripMenuItem.Click += inOrdenToolStripMenuItem_Click;
            // 
            // postOrdenToolStripMenuItem
            // 
            postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            postOrdenToolStripMenuItem.Size = new Size(130, 22);
            postOrdenToolStripMenuItem.Text = "PostOrden";
            postOrdenToolStripMenuItem.Click += postOrdenToolStripMenuItem_Click;
            // 
            // volverAlMenúToolStripMenuItem
            // 
            volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            volverAlMenúToolStripMenuItem.Size = new Size(97, 20);
            volverAlMenúToolStripMenuItem.Text = "Volver al menú";
            volverAlMenúToolStripMenuItem.Click += volverAlMenúToolStripMenuItem_Click;
            // 
            // Escenario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(808, 572);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Escenario2";
            Text = "Escenario2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem graficaToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem preoToolStripMenuItem;
        private ToolStripMenuItem inOrdenToolStripMenuItem;
        private ToolStripMenuItem postOrdenToolStripMenuItem;
        private ToolStripMenuItem volverAlMenúToolStripMenuItem;
    }
}