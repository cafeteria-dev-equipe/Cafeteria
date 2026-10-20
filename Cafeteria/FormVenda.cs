using System;
using System.Drawing;
using System.Windows.Forms;
using Cafeteria.Models;

namespace Cafeteria
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();

            Text = "Venda de Café";
            Size = new Size(450, 350);
            StartPosition = FormStartPosition.CenterScreen;

            Label lblCafe = new Label
            {
                Text = "Escolha o café:",
                Location = new Point(30, 30),
                AutoSize = true
            };

            ComboBox cbCafe = new ComboBox
            {
                Location = new Point(30, 60),
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cbCafe.Items.AddRange(new object[]
            {
                "Expresso",
                "Cappuccino",
                "Latte"
            });

            Label lblQuantidade = new Label
            {
                Text = "Quantidade:",
                Location = new Point(30, 100),
                AutoSize = true
            };

            NumericUpDown quantidade = new NumericUpDown
            {
                Location = new Point(30, 130),
                Minimum = 1,
                Maximum = 100,
                Value = 1
            };

            Button btnVender = new Button
            {
                Text = "Finalizar Venda",
                Location = new Point(30, 190),
                Size = new Size(200, 45)
            };

            btnVender.Click += (s, e) =>
            {
                if (cbCafe.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um café.");
                    return;
                }

                string produto = cbCafe.SelectedItem.ToString()!;

                decimal preco = produto switch
                {
                    "Expresso" => 5.00m,
                    "Cappuccino" => 8.00m,
                    "Latte" => 10.00m,
                    _ => 0m
                };

                Venda venda = new Venda
                {
                    Produto = produto,
                    Quantidade = (int)quantidade.Value,
                    PrecoUnitario = preco
                };

                VendaRepository.Adicionar(venda);

                MessageBox.Show(
                    $"Venda registrada!\nTotal: {venda.Total:C}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            };

            Controls.Add(lblCafe);
            Controls.Add(cbCafe);
            Controls.Add(lblQuantidade);
            Controls.Add(quantidade);
            Controls.Add(btnVender);
        }
    }
}