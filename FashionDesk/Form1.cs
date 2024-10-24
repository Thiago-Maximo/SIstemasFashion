namespace FashionDesk;
using FashionLib;
using static System.Windows.Forms.LinkLabel;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_load(object sender, EventArgs e)
    {
        CarregaGrid();
    }

    private void btnInserir_Click(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new(TextName.Text, TextCpf.Text, dateData_nasc.Value);
            cliente.Inserir();

            if (cliente.Id > 0)
            {
                textId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome}, Foi Gravado com Sucesso, com o ID {cliente.Id}");
                TextName.Clear();
                TextCpf.Clear();
                TextName.Focus();
                Form1_load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Gravar Cliente!!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao gravar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Continua com a aplicação
        }
    }

    private void CarregaGrid(string? nome = "")
    {
        var lista = Cliente.ObterPorLista(nome);
        dgvClientes.Rows.Clear();
        int cont = 0;

        foreach (var cliente in lista)
        {
            dgvClientes.Rows.Add();
            dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
            dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
            dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
            dgvClientes.Rows[cont].Cells[3].Value = cliente.Data_Nasc;

            cont++;
        }
    }

    private void txtBusca_TextChanged(object sender, EventArgs e)
    {
        if (txtBusca.Text.Length > 0)
        {
            CarregaGrid(txtBusca.Text);
        }
        else
        {
            CarregaGrid();
        }
    }
}
