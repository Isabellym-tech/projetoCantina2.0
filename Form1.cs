using System.Windows.Forms;

namespace projetoCantina2._0
{
    public partial class Form1 : Form
    {
        public Form1() // inicializador, tudo o que eu quiser começar
        {
            InitializeComponent();
            adicionarProduto();
            quantidade.Minimum = 1;
            formaDePagamento();
            nota.Visible = false;
            lbTroco.Visible = false;
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

            quantidade.Maximum = 100;
        }

        private void Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        public void formaDePagamento()
        {
            pagamento.Items.Add("Dinheiro");
            pagamento.Items.Add("Cartão de Crédito");
            pagamento.Items.Add("Cartão de Débito");
            pagamento.Items.Add("Pix");
        }


        decimal totalPedido = 0;

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedItems.Count > 0)
            {

                Produtos produtoSelecionado = lbProdutos.SelectedItem as Produtos;


                if (produtoSelecionado != null)
                {

                    int quantidadeSelecionada = (int)quantidade.Value;
                    produtoSelecionado.Quantidade = quantidadeSelecionada;

                    lbPedidos.Items.Add(produtoSelecionado);

                    decimal subtotal = produtoSelecionado.Preco * quantidadeSelecionada;
                    totalPedido += subtotal;

                    lbTotal.Text = ($"Total: R$ {totalPedido:F2}");

                    quantidade.Value = 1;


                }
            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {


            if (lbPedidos.SelectedItem != null)
            {

                Produtos pedidoSelecionado = (Produtos)lbPedidos.SelectedItem;


                //int quantidadeSelecionada = (int)quantidade.Value;
                lbPedidos.Items.Remove(pedidoSelecionado);

                // decimal subtotal = pedidoSelecionado.Preco * quantidadeSelecionada;
                totalPedido -= pedidoSelecionado.Preco;
                lbTotal.Text = ($"Total: R$ {totalPedido:F2}");

            }
        }

        private void pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {



            string opcaoSelecionada = pagamento.SelectedItem.ToString();
            if (opcaoSelecionada == "Dinheiro")
            {
                nota.Visible = true;
                lbTroco.Visible = true;



            }

            else
            {
                lbTroco.Visible = false;
                nota.Visible = false;
            }
        }

        private void lbTroco_Click(object sender, EventArgs e)
        {


        }

        private void nota_TextChanged(object sender, EventArgs e)
        {
            decimal Valornota;
            decimal troco = 0;

            if (decimal.TryParse(nota.Text, out Valornota))
            {
                Valornota = decimal.Parse(nota.Text);
                Console.Write(nota);

                if (Valornota >= totalPedido)
                {
                    troco = Valornota - totalPedido;
                    lbTroco.Text = $"Troco: R$ {troco:F2}";
                }
                else
                {
                    lbTroco.Text = "Valor insuficiente para o pagamento.";
                }
            }


        }

        private void finalizarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido Finalizado com sucesso!");
        }
    }
}
