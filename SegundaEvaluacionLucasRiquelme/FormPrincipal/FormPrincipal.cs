using BibliotecaClases;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        List<Computadora> computadoraList;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            computadoraList = new List<Computadora>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            if(formAlta.ShowDialog() == DialogResult.OK) 
            {
                computadoraList.Add(formAlta.Computadora);
                dgvCargar();
            }
        }
        private void dgvCargar()
        {
            dgv_computadoras.DataSource = null;
            dgv_computadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_computadoras.DataSource = computadoraList;
        }
    }
}
