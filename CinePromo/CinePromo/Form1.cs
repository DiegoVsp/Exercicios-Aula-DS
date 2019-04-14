using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinePromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*form.close()*/

        private void rdbSegunda_CheckedChanged(object sender, EventArgs e)
        {
            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.DiaDaSemana = "Segunda";

            string preco = cine.PrecoFilme.ToString("F");

            if (rdbSegunda.Checked)
            {

                lblDiaSem.Text = "Segunda - Preço Dia";
                lblPreco.Text = preco;
                lblDados.Text = cine.MostrarDados();
            }

        }

        private void rdbTerca_CheckedChanged(object sender, EventArgs e)
        {

            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.DiaDaSemana = "Terca";

            cine.NroSala = Convert.ToInt16(txtSala.Text);
            string preco = cine.PrecoFilme.ToString("F");

            if (rdbTerca.Checked)
            {
                lblDiaSem.Text = "Terca - Preço Dia";
                lblPreco.Text = preco;
                lblDados.Text = cine.MostrarDados();
            }
        }

        private void rdbQuarta_CheckedChanged(object sender, EventArgs e)
        {
            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.NroSala = Convert.ToInt16(txtSala.Text);

            cine.DiaDaSemana = "Quarta";
            cine.CalcDesconto();
            cine.MostrarDados();

            string desc = cine.Desconto.ToString("F");






            if (rdbQuarta.Checked)
            {

                lblDiaSem.Text = "Quarta - PROMOÇÃO";
                lblPreco.Text = desc;
                lblDados.Text = cine.MostrarDados();

            }


        }

        private void rdbQuinta_CheckedChanged(object sender, EventArgs e)
        {
            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.DiaDaSemana = "Quinta";
            cine.NroSala = Convert.ToInt16(txtSala.Text);

            string preco = cine.PrecoFilme.ToString("F");

            if (rdbQuinta.Checked)
            {
                lblDiaSem.Text = "Quinta - Preço Dia";
                lblPreco.Text = preco;
                lblDados.Text = cine.MostrarDados();
            }
        }

        private void rdbSexta_CheckedChanged(object sender, EventArgs e)
        {
            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.DiaDaSemana = "Sexta";
            cine.NroSala = Convert.ToInt16(txtSala.Text);

            string preco = cine.PrecoFilme.ToString("F");

            if (rdbSexta.Checked)
            {
                lblDiaSem.Text = "Sexta - Preço Dia";
                lblPreco.Text = preco;
                lblDados.Text = cine.MostrarDados();
            }
        }

        private void rdbSabado_CheckedChanged(object sender, EventArgs e)
        {
            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.DiaDaSemana = "Sabado";
            cine.NroSala = Convert.ToInt16(txtSala.Text);

            string preco = cine.PrecoFilme.ToString("F");

            if (rdbSabado.Checked)
            {
                lblDiaSem.Text = "Sabado - Preço Dia";
                lblPreco.Text = preco;
                lblDados.Text = cine.MostrarDados();
            }
        }

        private void rdbDomingo_CheckedChanged(object sender, EventArgs e)
        {
            string movie;
            movie = Convert.ToString(txtFilme.Text);


            Cinema cine = new Cinema(movie);
            cine.DiaDaSemana = "Domingo";
            cine.NroSala = Convert.ToInt16(txtSala.Text);

            string preco = cine.PrecoFilme.ToString("F");

            if (rdbDomingo.Checked)
            {
                lblDiaSem.Text = "Domingo - Preço Dia";
                lblPreco.Text = preco;
                lblDados.Text = cine.MostrarDados();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
