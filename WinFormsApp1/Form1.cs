using MySql.Data.MySqlClient;

namespace Cadastro_de_Atletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtgenero.Items.Add("M");
            txtgenero.Items.Add("F");


            txtsangue.Items.Add("A-");
            txtsangue.Items.Add("A+");
            txtsangue.Items.Add("B-");
            txtsangue.Items.Add("B+");
            txtsangue.Items.Add("AB-");
            txtsangue.Items.Add("AB+");
            txtsangue.Items.Add("O+");
            txtsangue.Items.Add("O-");

        }
        private double CalculaImc(Atleta atleta)
        {
            return (atleta.InformacoesMedicas.Peso / (atleta.InformacoesMedicas.Altura * atleta.InformacoesMedicas.Altura));
        }
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Atleta atleta = new Atleta();
            atleta.Nome = txtnome.Text;
            atleta.Nacionalidade = txtnacionalidade.Text;
            atleta.Modalidade = txtmodalidade.Text;
            atleta.Genero = txtgenero.SelectedItem.ToString();
            atleta.DataNascimento = txtdata.Value.Date;
            atleta.Idade = DateTime.Now.Year - atleta.DataNascimento.Year;
            atleta.InformacoesMedicas.Altura = Convert.ToDouble(txtaltura.Text);
            atleta.InformacoesMedicas.Peso = Convert.ToDouble(txtpeso.Text);
            atleta.InformacoesMedicas.TipoSanguineo = txtsangue.SelectedItem.ToString();
            atleta.InformacoesMedicas.Alergia = txtalergia.Text;
            atleta.InformacoesMedicas.IMC = CalculaImc(atleta);

            if (!BancoDeDados.InserirAtleta(atleta))
            {
                return; 
            }

            MessageBox.Show("Atleta Cadastro");

            txtalergia.Text = txtaltura.Text = txtmodalidade.Text = txtnacionalidade.Text = txtnome.Text
                = txtpeso.Text = string.Empty;
            txtgenero.SelectedIndex = txtsangue.SelectedIndex = -1;
            txtdata.Value = DateTime.Now;

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BancoDeDados.BuscaAtletas();
            dataGridView1.Update();
        }

    }
}
