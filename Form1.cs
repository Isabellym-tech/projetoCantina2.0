using System.Windows.Forms;

namespace projetoCantina2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adicionarProduto();

        }

        public void adicionarProduto() // ele faz uma ação
        {
            int Quantidade = (int)quantidade.Value;
            lbProdutos.Items.Add(new Produtos("Pão de queijo", 5.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Coxinha", 5.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Pastel de Carne", 6.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Pastel dequeijo", 5.50m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Suco Natural (300ml)", 4.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Refrigerante Lata", 4.50m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Hambúrguer Simples", 8.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Hambúrguer com Queijo", 9.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("X-Tudo", 12.00m, Quantidade));
            lbProdutos.Items.Add(new Produtos("Água Mineral (500ml)", 2.50m, Quantidade));
        }


        private void quantidade_ValueChanged(object sender, EventArgs e)
        {


            quantidade.Minimum = 1;
            quantidade.Maximum = 100;



        }

        private void Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        decimal totalPedido = 0;
        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedItems.Count > 0)
            {
                Produtos produtoSelecionado = (Produtos)lbProdutos.SelectedItem;
                lbPedidos.Items.Add($"{produtoSelecionado}");
                //totalPedido += totalPedido + preco;

            }

             

        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (lbPedidos.SelectedItems.Count > 0)
            {
                string pedidoSelecionado = lbPedidos.SelectedItem.ToString();
                lbPedidos.Items.Remove(pedidoSelecionado);
            }
        }
    }
}
