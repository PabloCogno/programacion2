namespace WinFormsApp1
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
            tBprimero = new TextBox();
            tBsegundo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bResultados = new Button();
            lBresultados = new ListBox();
            SuspendLayout();
            // 
            // tBprimero
            // 
            tBprimero.Location = new Point(219, 89);
            tBprimero.Name = "tBprimero";
            tBprimero.Size = new Size(125, 27);
            tBprimero.TabIndex = 0;
            // 
            // tBsegundo
            // 
            tBsegundo.Location = new Point(219, 151);
            tBsegundo.Name = "tBsegundo";
            tBsegundo.Size = new Size(125, 27);
            tBsegundo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 89);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Primer numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 151);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 3;
            label2.Text = "Segundo numero:";
            // 
            // bResultados
            // 
            bResultados.Location = new Point(346, 215);
            bResultados.Name = "bResultados";
            bResultados.Size = new Size(94, 29);
            bResultados.TabIndex = 4;
            bResultados.Text = "Resultados";
            bResultados.UseVisualStyleBackColor = true;
            bResultados.Click += bResultados_Click;
            // 
            // lBresultados
            // 
            lBresultados.FormattingEnabled = true;
            lBresultados.ItemHeight = 20;
            lBresultados.Location = new Point(12, 268);
            lBresultados.Name = "lBresultados";
            lBresultados.Size = new Size(534, 164);
            lBresultados.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 452);
            Controls.Add(lBresultados);
            Controls.Add(bResultados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBsegundo);
            Controls.Add(tBprimero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBprimero;
        private TextBox tBsegundo;
        private Label label1;
        private Label label2;
        private Button bResultados;
        private ListBox lBresultados;
    }
}