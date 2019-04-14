namespace CinePromo
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
            this.lblFilme = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.rdbSegunda = new System.Windows.Forms.RadioButton();
            this.rdbQuarta = new System.Windows.Forms.RadioButton();
            this.rdbTerca = new System.Windows.Forms.RadioButton();
            this.rdbQuinta = new System.Windows.Forms.RadioButton();
            this.rdbSexta = new System.Windows.Forms.RadioButton();
            this.rdbSabado = new System.Windows.Forms.RadioButton();
            this.rdbDomingo = new System.Windows.Forms.RadioButton();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDiaSem = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilme.Location = new System.Drawing.Point(26, 29);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(62, 22);
            this.lblFilme.TabIndex = 0;
            this.lblFilme.Text = "Filme:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(267, 30);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(52, 22);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(26, 69);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(113, 22);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia Semana";
            // 
            // rdbSegunda
            // 
            this.rdbSegunda.AutoSize = true;
            this.rdbSegunda.Location = new System.Drawing.Point(30, 116);
            this.rdbSegunda.Name = "rdbSegunda";
            this.rdbSegunda.Size = new System.Drawing.Size(68, 17);
            this.rdbSegunda.TabIndex = 3;
            this.rdbSegunda.TabStop = true;
            this.rdbSegunda.Text = "Segunda";
            this.rdbSegunda.UseVisualStyleBackColor = true;
            this.rdbSegunda.CheckedChanged += new System.EventHandler(this.rdbSegunda_CheckedChanged);
            // 
            // rdbQuarta
            // 
            this.rdbQuarta.AutoSize = true;
            this.rdbQuarta.Location = new System.Drawing.Point(30, 150);
            this.rdbQuarta.Name = "rdbQuarta";
            this.rdbQuarta.Size = new System.Drawing.Size(57, 17);
            this.rdbQuarta.TabIndex = 4;
            this.rdbQuarta.TabStop = true;
            this.rdbQuarta.Text = "Quarta";
            this.rdbQuarta.UseVisualStyleBackColor = true;
            this.rdbQuarta.CheckedChanged += new System.EventHandler(this.rdbQuarta_CheckedChanged);
            // 
            // rdbTerca
            // 
            this.rdbTerca.AutoSize = true;
            this.rdbTerca.Location = new System.Drawing.Point(104, 116);
            this.rdbTerca.Name = "rdbTerca";
            this.rdbTerca.Size = new System.Drawing.Size(53, 17);
            this.rdbTerca.TabIndex = 5;
            this.rdbTerca.TabStop = true;
            this.rdbTerca.Text = "Terça";
            this.rdbTerca.UseVisualStyleBackColor = true;
            this.rdbTerca.CheckedChanged += new System.EventHandler(this.rdbTerca_CheckedChanged);
            // 
            // rdbQuinta
            // 
            this.rdbQuinta.AutoSize = true;
            this.rdbQuinta.Location = new System.Drawing.Point(104, 150);
            this.rdbQuinta.Name = "rdbQuinta";
            this.rdbQuinta.Size = new System.Drawing.Size(56, 17);
            this.rdbQuinta.TabIndex = 6;
            this.rdbQuinta.TabStop = true;
            this.rdbQuinta.Text = "Quinta";
            this.rdbQuinta.UseVisualStyleBackColor = true;
            this.rdbQuinta.CheckedChanged += new System.EventHandler(this.rdbQuinta_CheckedChanged);
            // 
            // rdbSexta
            // 
            this.rdbSexta.AutoSize = true;
            this.rdbSexta.Location = new System.Drawing.Point(30, 184);
            this.rdbSexta.Name = "rdbSexta";
            this.rdbSexta.Size = new System.Drawing.Size(52, 17);
            this.rdbSexta.TabIndex = 7;
            this.rdbSexta.TabStop = true;
            this.rdbSexta.Text = "Sexta";
            this.rdbSexta.UseVisualStyleBackColor = true;
            this.rdbSexta.CheckedChanged += new System.EventHandler(this.rdbSexta_CheckedChanged);
            // 
            // rdbSabado
            // 
            this.rdbSabado.AutoSize = true;
            this.rdbSabado.Location = new System.Drawing.Point(104, 184);
            this.rdbSabado.Name = "rdbSabado";
            this.rdbSabado.Size = new System.Drawing.Size(62, 17);
            this.rdbSabado.TabIndex = 8;
            this.rdbSabado.TabStop = true;
            this.rdbSabado.Text = "Sábado";
            this.rdbSabado.UseVisualStyleBackColor = true;
            this.rdbSabado.CheckedChanged += new System.EventHandler(this.rdbSabado_CheckedChanged);
            // 
            // rdbDomingo
            // 
            this.rdbDomingo.AutoSize = true;
            this.rdbDomingo.Location = new System.Drawing.Point(30, 219);
            this.rdbDomingo.Name = "rdbDomingo";
            this.rdbDomingo.Size = new System.Drawing.Size(67, 17);
            this.rdbDomingo.TabIndex = 9;
            this.rdbDomingo.TabStop = true;
            this.rdbDomingo.Text = "Domingo";
            this.rdbDomingo.UseVisualStyleBackColor = true;
            this.rdbDomingo.CheckedChanged += new System.EventHandler(this.rdbDomingo_CheckedChanged);
            // 
            // txtFilme
            // 
            this.txtFilme.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilme.Location = new System.Drawing.Point(95, 23);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(147, 29);
            this.txtFilme.TabIndex = 10;
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSala.Location = new System.Drawing.Point(325, 22);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(63, 29);
            this.txtSala.TabIndex = 11;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(232, 115);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 55);
            this.lblPreco.TabIndex = 12;
            // 
            // lblDiaSem
            // 
            this.lblDiaSem.AutoSize = true;
            this.lblDiaSem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSem.Location = new System.Drawing.Point(234, 93);
            this.lblDiaSem.Name = "lblDiaSem";
            this.lblDiaSem.Size = new System.Drawing.Size(0, 18);
            this.lblDiaSem.TabIndex = 13;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(249, 181);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 13);
            this.lblDados.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblDiaSem);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.rdbDomingo);
            this.Controls.Add(this.rdbSabado);
            this.Controls.Add(this.rdbSexta);
            this.Controls.Add(this.rdbQuinta);
            this.Controls.Add(this.rdbTerca);
            this.Controls.Add(this.rdbQuarta);
            this.Controls.Add(this.rdbSegunda);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblFilme);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.RadioButton rdbSegunda;
        private System.Windows.Forms.RadioButton rdbQuarta;
        private System.Windows.Forms.RadioButton rdbTerca;
        private System.Windows.Forms.RadioButton rdbQuinta;
        private System.Windows.Forms.RadioButton rdbSexta;
        private System.Windows.Forms.RadioButton rdbSabado;
        private System.Windows.Forms.RadioButton rdbDomingo;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDiaSem;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label label1;
    }
}

