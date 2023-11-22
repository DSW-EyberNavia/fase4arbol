namespace Fase4EyberNavia
{
    partial class Escenario1
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
            recorridosToolStripMenuItem = new ToolStripMenuItem();
            preOrdenToolStripMenuItem = new ToolStripMenuItem();
            iToolStripMenuItem = new ToolStripMenuItem();
            postOrdenToolStripMenuItem = new ToolStripMenuItem();
            volverAlMenúToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { graficaToolStripMenuItem, recorridosToolStripMenuItem, volverAlMenúToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            // recorridosToolStripMenuItem
            // 
            recorridosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preOrdenToolStripMenuItem, iToolStripMenuItem, postOrdenToolStripMenuItem });
            recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            recorridosToolStripMenuItem.Size = new Size(75, 20);
            recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            preOrdenToolStripMenuItem.Size = new Size(180, 22);
            preOrdenToolStripMenuItem.Text = "PreOrden";
            preOrdenToolStripMenuItem.Click += preOrdenToolStripMenuItem_Click;
            // 
            // iToolStripMenuItem
            // 
            iToolStripMenuItem.Name = "iToolStripMenuItem";
            iToolStripMenuItem.Size = new Size(180, 22);
            iToolStripMenuItem.Text = "InOrden";
            iToolStripMenuItem.Click += iToolStripMenuItem_Click;
            // 
            // postOrdenToolStripMenuItem
            // 
            postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            postOrdenToolStripMenuItem.Size = new Size(180, 22);
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
            // Escenario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Escenario1";
            Text = "Escenario1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem graficaToolStripMenuItem;
        private ToolStripMenuItem recorridosToolStripMenuItem;
        private ToolStripMenuItem volverAlMenúToolStripMenuItem;
        private ToolStripMenuItem preOrdenToolStripMenuItem;
        private ToolStripMenuItem iToolStripMenuItem;
        private ToolStripMenuItem postOrdenToolStripMenuItem;
    }
}