﻿namespace Tu_primer_formulario_GUI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 13);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 12F);
            lblNombre.Location = new Point(23, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(140, 18);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Ingrese su nombre:";
            lblNombre.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(310, 162);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 27);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial", 12F);
            lblResultado.Location = new Point(127, 96);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 18);
            lblResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 211);
            Controls.Add(lblResultado);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnAceptar;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblResultado;
    }
}
