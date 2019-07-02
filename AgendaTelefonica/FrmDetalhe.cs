using AgendaTelefonica.Business.Class;
using AgendaTelefonica.DAO.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FrmDetalhe : MaterialForm
    {
        #region Objetos e variaveis
        BLL_Cliente bLL_Cliente = new BLL_Cliente();
        Cliente cliente = new Cliente();
        List<Cliente> listaCliente = new List<Cliente>();
        BLL_Cliente_Telefone bLL_Cliente_Telefone = new BLL_Cliente_Telefone();
        ClienteTelefone clienteTelefone = new ClienteTelefone();
        List<ClienteTelefone> listaTelefone = new List<ClienteTelefone>();
        FrmListaClientes frm = new FrmListaClientes();
        HttpClient client = new HttpClient();
        public int IdCel { get; set; }
        public int IdCasa { get; set; }
        public int IdTrabalho { get; set; }
        public int IdCliente { get; set; }
        #endregion        

        public FrmDetalhe()
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
        private void FrmDetalhe_Load(object sender, EventArgs e)
        {
            AbasteceTextBox();
        }
        #region Botóes de excluir
        private void btnExcluirCel_Click(object sender, EventArgs e)
        {
            bLL_Cliente_Telefone.DeletarNumero(IdCel);
            MessageBox.Show("Celular Excluido com sucesso!");
            txtCelular.Text = "";
            AbasteceTextBox();
        }

        private void btnExcluirCasa_Click(object sender, EventArgs e)
        {
            bLL_Cliente_Telefone.DeletarNumero(IdCasa);
            MessageBox.Show("Casa Excluido com sucesso!");
            txtCasa.Text = "";
            AbasteceTextBox();
        }

        private void btnExcluirTrab_Click(object sender, EventArgs e)
        {
            bLL_Cliente_Telefone.DeletarNumero(IdTrabalho);
            MessageBox.Show("Trabalho Excluido com sucesso!");
            txtTrabalho.Text = "";
            AbasteceTextBox();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            bLL_Cliente_Telefone.DeletarNumeroCliente(IdCliente);           
            try
            {
                string url = "http://localhost:49805/Clientes/Remover/{0}";
                var uri = new Uri(string.Format(url, cliente.Id));
                await client.DeleteAsync(uri);
            }
            catch (Exception ex)
            {
               bLL_Cliente.DeletarCliente(IdCliente);
            }
            MessageBox.Show("Cliente excluído com sucesso!");
            this.Close();
        }

        #endregion

        private void AbasteceTextBox()
        {
            cliente.Id = IdCliente;
            clienteTelefone.cliente.Id = IdCliente;
            bLL_Cliente.SelecionarCliente(cliente);
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtDataAniversario.Text = cliente.DataNascimento.ToShortDateString();
            foreach (var item in bLL_Cliente_Telefone.SelecionarTodosPorCliente(clienteTelefone))
            {
                if (item.Descricao == "Celular")
                {
                    IdCel = item.Id;
                    txtCelular.Text = item.Numero;
                }
                if (item.Descricao == "Casa")
                {
                    IdCasa = item.Id;
                    txtCasa.Text = item.Numero;
                }
                if (item.Descricao == "Trabalho")
                {
                    IdTrabalho = item.Id;
                    txtTrabalho.Text = item.Numero;
                }
            }
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
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
                        string url = "http://localhost:49805/Clientes/Alterar/";
                        var uri = new Uri(string.Format(url));
                        var data = JsonConvert.SerializeObject(cliente);
                        var content = new StringContent(data, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = null;
                        response = await client.PutAsync(uri, content);
                        AtualizaTelefones(regex);
                        MessageBox.Show("Cliente Alterado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        bLL_Cliente.AlterarCliente(cliente);
                        AtualizaTelefones(regex);
                        MessageBox.Show("Cliente Alterado com sucesso!");
                    }
                    
                    AbasteceTextBox();
                }
            }
        }

        private void AtualizaTelefones(System.Text.RegularExpressions.Regex regex)
        {
            if ((regex.Replace(txtCelular.Text, string.Empty).Length == 11))
            {
                clienteTelefone.Numero = txtCelular.Text;
                clienteTelefone.Descricao = "Celular";
                clienteTelefone.cliente.Id = cliente.Id;
                if (IdCel == 0)
                {
                    bLL_Cliente_Telefone.AdicionarClienteTelefone(clienteTelefone);
                }
                else
                {
                    clienteTelefone.Id = IdCel;
                    bLL_Cliente_Telefone.AlterarTelefone(clienteTelefone);
                }
            }
            if ((regex.Replace(txtCasa.Text, string.Empty).Length == 10))
            {
                clienteTelefone.Numero = txtCasa.Text;
                clienteTelefone.Descricao = "Casa";
                clienteTelefone.cliente.Id = cliente.Id;
                if (IdCasa == 0)
                {
                    bLL_Cliente_Telefone.AdicionarClienteTelefone(clienteTelefone);
                }
                else
                {
                    clienteTelefone.Id = IdCasa;
                    bLL_Cliente_Telefone.AlterarTelefone(clienteTelefone);
                }
            }
            if ((regex.Replace(txtTrabalho.Text, string.Empty).Length == 10))
            {
                clienteTelefone.Numero = txtTrabalho.Text;
                clienteTelefone.Descricao = "Trabalho";
                clienteTelefone.cliente.Id = cliente.Id;
                if (IdTrabalho == 0)
                {
                    bLL_Cliente_Telefone.AdicionarClienteTelefone(clienteTelefone);
                }
                else
                {
                    clienteTelefone.Id = IdTrabalho;
                    bLL_Cliente_Telefone.AlterarTelefone(clienteTelefone);
                }
            }
        }
    }
}
