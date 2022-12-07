using System;

namespace Depuración_GAG_22_23
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lResultado = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.radioButtonOrdinario = new System.Windows.Forms.RadioButton();
            this.radioButtonUrgente = new System.Windows.Forms.RadioButton();
            this.buttonCoste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(85, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.Location = new System.Drawing.Point(115, 294);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(0, 16);
            this.lResultado.TabIndex = 3;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(88, 101);
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(404, 96);
            this.txtTelegrama.TabIndex = 5;
            this.txtTelegrama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coste: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(136, 288);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // radioButtonOrdinario
            // 
            this.radioButtonOrdinario.AutoSize = true;
            this.radioButtonOrdinario.Location = new System.Drawing.Point(88, 256);
            this.radioButtonOrdinario.Name = "radioButtonOrdinario";
            this.radioButtonOrdinario.Size = new System.Drawing.Size(83, 20);
            this.radioButtonOrdinario.TabIndex = 9;
            this.radioButtonOrdinario.TabStop = true;
            this.radioButtonOrdinario.Text = "Ordinario";
            this.radioButtonOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioButtonUrgente
            // 
            this.radioButtonUrgente.AutoSize = true;
            this.radioButtonUrgente.Location = new System.Drawing.Point(188, 256);
            this.radioButtonUrgente.Name = "radioButtonUrgente";
            this.radioButtonUrgente.Size = new System.Drawing.Size(76, 20);
            this.radioButtonUrgente.TabIndex = 10;
            this.radioButtonUrgente.TabStop = true;
            this.radioButtonUrgente.Text = "Urgente";
            this.radioButtonUrgente.UseVisualStyleBackColor = true;
            // 
            // buttonCoste
            // 
            this.buttonCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCoste.Location = new System.Drawing.Point(383, 256);
            this.buttonCoste.Name = "buttonCoste";
            this.buttonCoste.Size = new System.Drawing.Size(109, 54);
            this.buttonCoste.TabIndex = 11;
            this.buttonCoste.Text = "Calcular";
            this.buttonCoste.UseVisualStyleBackColor = true;
            this.buttonCoste.Click += new System.EventHandler(this.buttonCoste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 444);
            this.Controls.Add(this.buttonCoste);
            this.Controls.Add(this.radioButtonUrgente);
            this.Controls.Add(this.radioButtonOrdinario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.RichTextBox txtTelegrama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton radioButtonOrdinario;
        private System.Windows.Forms.RadioButton radioButtonUrgente;
        private System.Windows.Forms.Button buttonCoste;
    }
}

