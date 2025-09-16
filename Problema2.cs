using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeremyR_JosephG_DanielC_Lab3
{
    //Jeremy Rodriguez, Joseph Guerra, Daniel Comrie
    public partial class Problema2 : Form
    {
        public Problema2()
        {
            InitializeComponent();
        }

        private void Problema2_Load(object sender, EventArgs e)
        {
            btProb3.Enabled = false;
            lbPalindromos.Items.Clear();

            tbRango.KeyDown += tbRango_KeyDown;
        }

        private void tbRango_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbRango_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ListarPalindromos();
            } 
        }

        private void ListarPalindromos()
        {
            lbPalindromos.Items.Clear();

            if(!TryParseRange(tbRango.Text, out int from, out int to, out string error))
            {
                MessageBox.Show(error, "Rango incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int n = from; n <= to; n++)
                if (VerificarPalindromo(n))
                    lbPalindromos.Items.Add(n);
            if (lbPalindromos.Items.Count == 0)
                lbPalindromos.Items.Add("No hay palíndromos en el rango presentado");
        }

        void VerificarCampos()
        {
            btProb3.Enabled = !string.IsNullOrWhiteSpace(tbRango.Text);
        }

        private void btProb3_Click(object sender, EventArgs e)
        {
            
        }

        private bool TryParseRange(string input, out int from, out int to, out string error)
        {
            from = 0;
            to = 0;
            error = null;

            if (string.IsNullOrWhiteSpace(input))
            {
                error = "Escriba un rango válido";
                return false;
            }
            string cadena = input.Trim();
            if (cadena.Contains("-"))
            {
                var partes = cadena.Split('-');
                if (partes.Length != 2 || !int.TryParse(partes[0].Trim(), out from) 
                || !int.TryParse(partes[1].Trim(), out to))
                {
                    error = "Formato incorrecto. Debe ingresar variable a - variable b";
                    return false;
                }
            }
            else
            {
                if (!int.TryParse(cadena, out to))
                {
                    error = "Formato incorrecto. Debe ingresar un rango entre 2 números";
                    return false;
                }
                from = 0;
            }
            if (from < 0 || to < 0)
            {
                error = "Incorrecto. No se permiten números negativos";
                return false;
            }
            if (from > to)
            {
                error = "Incorrecto. El primer valor no puede ser mayor al segundo";
                return false;
            }

            return true;
        }

        private bool VerificarPalindromo (int num)
        {
            string s = num.ToString();
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
