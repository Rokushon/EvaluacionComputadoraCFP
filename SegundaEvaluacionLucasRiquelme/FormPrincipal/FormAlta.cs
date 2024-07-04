using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace FormPrincipal
{
    public partial class FormAlta : Form
    {
        Computadora computadora;

        public Computadora Computadora { get { return computadora; } }
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            List<string> procesadores = Computadora.ListadoDeProcesadores();
            cmb_procesador.DataSource = procesadores;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            string procesador = cmb_procesador.Text;
            int capacidadDisco = (int)numeric_disco.Value;
            int memoriaRam = (int)numeric_memoria_ram.Value;
            string sistemaOperativo = getSistemaOperativo();
            computadora = new Computadora(procesador, capacidadDisco, memoriaRam, sistemaOperativo);
            DialogResult = DialogResult.OK;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private string getSistemaOperativo()
        {
            string sistemaoperativo = string.Empty;
            foreach (RadioButton rb in gb_sistemas.Controls)
            {
                if (rb.Checked)
                {
                    sistemaoperativo = rb.Text;
                    break;
                }
            }
            return sistemaoperativo;
        }

        /*private void settearPrograma()
        {
            foreach(CheckBox cb in gb_programas.Controls)
            {
                if (cb.Checked)
                {
                    computadora.SetPrograma(cb.Text);
                }
            }
        }*/

    }
}
