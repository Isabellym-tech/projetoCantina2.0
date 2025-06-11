namespace projetoCantina2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbProdutos = new ListBox();
            Adicionar = new Button();
            Remover = new Button();
            quantidade = new NumericUpDown();
            lbPedidos = new ListBox();
            lbTotal = new Label();
            pagamento = new ComboBox();
            nota = new TextBox();
            finalizarPedido = new Button();
            Balcao = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbTroco = new Label();
            Viagem = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            SuspendLayout();
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(72, 134);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(242, 304);
            lbProdutos.TabIndex = 0;
            lbProdutos.SelectedIndexChanged += Produtos_SelectedIndexChanged;
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(336, 279);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(178, 60);
            Adicionar.TabIndex = 1;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Remover
            // 
            Remover.Location = new Point(336, 369);
            Remover.Name = "Remover";
            Remover.Size = new Size(181, 69);
            Remover.TabIndex = 2;
            Remover.Text = "Remover";
            Remover.UseVisualStyleBackColor = true;
            Remover.Click += Remover_Click;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(336, 172);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(190, 23);
            quantidade.TabIndex = 3;
            quantidade.ValueChanged += quantidade_ValueChanged;
            // 
            // lbPedidos
            // 
            lbPedidos.FormattingEnabled = true;
            lbPedidos.ItemHeight = 15;
            lbPedidos.Location = new Point(662, 134);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(216, 304);
            lbPedidos.TabIndex = 4;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(1087, 137);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(33, 15);
            lbTotal.TabIndex = 5;
            lbTotal.Text = "Total";
            // 
            // pagamento
            // 
            pagamento.FormattingEnabled = true;
            pagamento.Location = new Point(1087, 193);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(163, 23);
            pagamento.TabIndex = 6;
            pagamento.SelectedIndexChanged += pagamento_SelectedIndexChanged;
            // 
            // nota
            // 
            nota.Location = new Point(1087, 248);
            nota.Name = "nota";
            nota.Size = new Size(185, 23);
            nota.TabIndex = 7;
            nota.TextChanged += nota_TextChanged;
            // 
            // finalizarPedido
            // 
            finalizarPedido.Location = new Point(1084, 348);
            finalizarPedido.Name = "finalizarPedido";
            finalizarPedido.Size = new Size(206, 91);
            finalizarPedido.TabIndex = 8;
            finalizarPedido.Text = "Finalizar Pedido";
            finalizarPedido.UseVisualStyleBackColor = true;
            finalizarPedido.Click += finalizarPedido_Click;
            // 
            // Balcao
            // 
            Balcao.Location = new Point(1089, 509);
            Balcao.Name = "Balcao";
            Balcao.Size = new Size(200, 40);
            Balcao.TabIndex = 9;
            Balcao.Text = "Balcão";
            Balcao.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 56);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome do cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1089, 172);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 12;
            label2.Text = "Escolha a forma de pagamento";
            // 
            // lbTroco
            // 
            lbTroco.AutoSize = true;
            lbTroco.Location = new Point(1087, 279);
            lbTroco.Name = "lbTroco";
            lbTroco.Size = new Size(40, 15);
            lbTroco.TabIndex = 13;
            lbTroco.Text = "Troco:";
            lbTroco.Click += lbTroco_Click;
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.Location = new Point(934, 155);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(71, 19);
            Viagem.TabIndex = 14;
            Viagem.Text = "Viagem?";
            Viagem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 625);
            Controls.Add(Viagem);
            Controls.Add(lbTroco);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Balcao);
            Controls.Add(finalizarPedido);
            Controls.Add(nota);
            Controls.Add(pagamento);
            Controls.Add(lbTotal);
            Controls.Add(lbPedidos);
            Controls.Add(quantidade);
            Controls.Add(Remover);
            Controls.Add(Adicionar);
            Controls.Add(lbProdutos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbProdutos;
        private Button Adicionar;
        private Button Remover;
        private NumericUpDown quantidade;
        private ListBox lbPedidos;
        private Label lbTotal;
        private ComboBox pagamento;
        private TextBox nota;
        private Button finalizarPedido;
        private Button Balcao;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label lbTroco;
        private CheckBox Viagem;
    }
}
