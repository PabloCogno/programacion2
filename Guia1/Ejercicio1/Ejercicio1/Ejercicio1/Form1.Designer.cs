namespace Ejercicio1
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
            bAgregar = new Button();
            bMostrar = new Button();
            lBlistado = new ListBox();
            label1 = new Label();
            cBtipo = new ComboBox();
            SuspendLayout();
            // 
            // bAgregar
            // 
            bAgregar.DialogResult = DialogResult.OK;
            bAgregar.Location = new Point(524, 400);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(94, 29);
            bAgregar.TabIndex = 0;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            bAgregar.Click += bAgregar_Click;
            // 
            // bMostrar
            // 
            bMostrar.DialogResult = DialogResult.Yes;
            bMostrar.Location = new Point(322, 33);
            bMostrar.Name = "bMostrar";
            bMostrar.Size = new Size(94, 29);
            bMostrar.TabIndex = 1;
            bMostrar.Text = "Mostrar";
            bMostrar.UseVisualStyleBackColor = true;
            bMostrar.Click += bMostrar_Click;
            // 
            // lBlistado
            // 
            lBlistado.FormattingEnabled = true;
            lBlistado.ItemHeight = 20;
            lBlistado.Location = new Point(12, 77);
            lBlistado.Name = "lBlistado";
            lBlistado.Size = new Size(595, 304);
            lBlistado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipo";
            // 
            // cBtipo
            // 
            cBtipo.FormattingEnabled = true;
            cBtipo.Items.AddRange(new object[] { "Perro", "Gato", "Conejo", "Hamster", "Otro" });
            cBtipo.Location = new Point(104, 34);
            cBtipo.Name = "cBtipo";
            cBtipo.Size = new Size(151, 28);
            cBtipo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cBtipo);
            Controls.Add(label1);
            Controls.Add(lBlistado);
            Controls.Add(bMostrar);
            Controls.Add(bAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bAgregar;
        private Button bMostrar;
        private ListBox lBlistado;
        private Label label1;
        private ComboBox cBtipo;
    }
}