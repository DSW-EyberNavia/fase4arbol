namespace Fase4EyberNavia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LABEL1 = new Label();
            button1 = new Button();
            pass = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Location = new Point(48, 9);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(173, 15);
            LABEL1.TabIndex = 0;
            LABEL1.Text = "ARBOL BINARIO DE BUSQUEDA";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(86, 280);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pass
            // 
            pass.Location = new Point(109, 56);
            pass.Name = "pass";
            pass.PasswordChar = '-';
            pass.Size = new Size(100, 23);
            pass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 59);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(256, 311);
            Controls.Add(label2);
            Controls.Add(pass);
            Controls.Add(button1);
            Controls.Add(LABEL1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABEL1;
        private Button button1;
        private TextBox pass;
        private Label label2;
    }
}