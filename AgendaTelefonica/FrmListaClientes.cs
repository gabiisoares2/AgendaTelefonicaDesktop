using AgendaTelefonica.Business.Class;
using AgendaTelefonica.DAO.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AgendaTelefonica
{
    public partial class FrmListaClientes : MaterialForm
    {
        #region Objetos
        BLL_Cliente bLL_Cliente = new BLL_Cliente();
        Cliente cliente = new Cliente();
        List<Cliente> listaCliente = new List<Cliente>();
        BLL_Cliente_Telefone bLL_Cliente_Telefone = new BLL_Cliente_Telefone();
        ClienteTelefone clienteTelefone = new ClienteTelefone();
        List<ClienteTelefone> listaTelefone = new List<ClienteTelefone>();
        HttpClient client = new HttpClient();
        #endregion

        public FrmListaClientes()
        {           
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey700, Primary.BlueGrey900,
                Primary.BlueGrey900, Accent.DeepPurple200,
                TextShade.WHITE
            );
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            CarregaLista();
        }
        
        private void dgvListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetalhe frm = new FrmDetalhe();
            frm.IdCliente = int.Parse(dgvListaCliente.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            frm.Show();
        }
        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            CarregaLista();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvListaCliente.DataSource = bLL_Cliente.SelecionarTodosNome(txtPesquisar.Text);
        }

        private async void btnGravar_Click(object sender, EventArgs e)
        {
            await GravarCliente();

        }
        #region Metodos

        private async Task GravarCliente()
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^0-9]");
            if (!((string.IsNullOrEmpty(txtNome.Text)) && (string.IsNullOrEmpty(txtEmail.Text)) && (regex.Replace(txtDataAniversario.Text, string.Empty).Length != 8)))
            {
                if ((regex.Replace(txtCelular.Text, string.Empty).Length == 11) || (regex.Replace(txtCasa.Text, string.Empty).Length == 10) || (regex.Replace(txtTrabalho.Text, string.Empty).Length == 10))
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.DataNascimento = Convert.ToDateTime(txtDataAniversario.Text);
                    try
                    {
                        string url = "http://localhost:49805/Clientes/Incluir/";
                        var uri = new Uri(string.Format(url));
                        var data = JsonConvert.SerializeObject(cliente);
                        var content = new StringContent(data, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = null;
                        response = await client.PostAsync(uri, content);
                        var classe = await response.Content.ReadAsStringAsync();
                        var _cliente = JsonConvert.DeserializeObject<Cliente>(classe);
                        cliente.Id = _cliente.Id;
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception("Erro ao incluir Cliente");
                        }
                        else
                        {
                            GravarTelefones(regex);
                            MessageBox.Show("Cliente Cadastrado com sucesso!");
                            LimpaTextBox();
                        }
                    }
                    catch (Exception ex)
                    {
                        bLL_Cliente.AdicionarCliente(cliente);
                        if(cliente.exceptionFull.StatusAtual == true)
                        {
                            GravarTelefones(regex);
                            MessageBox.Show("Cliente Cadastrado com sucesso!");
                            LimpaTextBox();
                        }                        
                    }
                    CarregaLista();
                }
                else
                {
                    MessageBox.Show("Por favor, coloque pelo menos um número de telefone para contato!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
            }
        }

        private void GravarTelefones(System.Text.RegularExpressions.Regex regex)
        {
            if ((regex.Replace(txtCelular.Text, string.Empty).Length == 11))
            {
                clienteTelefone.Numero = txtCelular.Text;
                clienteTelefone.Descricao = "Celular";
                clienteTelefone.cliente.Id = cliente.Id;
                bLL_Cliente_Telefone.AdicionarClienteTelefone(clienteTelefone);
            }
            if ((regex.Replace(txtCasa.Text, string.Empty).Length == 10))
            {
                clienteTelefone.Numero = txtCasa.Text;
                clienteTelefone.Descricao = "Casa";
                clienteTelefone.cliente.Id = cliente.Id;
                bLL_Cliente_Telefone.AdicionarClienteTelefone(clienteTelefone);
            }
            if ((regex.Replace(txtTrabalho.Text, string.Empty).Length == 10))
            {
                clienteTelefone.Numero = txtTrabalho.Text;
                clienteTelefone.Descricao = "Trabalho";
                clienteTelefone.cliente.Id = cliente.Id;
                bLL_Cliente_Telefone.AdicionarClienteTelefone(clienteTelefone);
            }
        }

        public async void CarregaLista()
        {            
            try
            {
                string url = " http://localhost:49805/Clientes/ListarTodos";
                var response = await client.GetStringAsync(url);
                dgvListaCliente.DataSource = JsonConvert.DeserializeObject<List<Cliente>>(response);
            }
            catch (Exception ex)
            {
                dgvListaCliente.DataSource = bLL_Cliente.SelecionarTodos();
            }

        }

        private void LimpaTextBox()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtDataAniversario.Text = "";
            txtCelular.Text = "";
            txtCasa.Text = "";
            txtTrabalho.Text = "";
        }

        #endregion
    }
}
