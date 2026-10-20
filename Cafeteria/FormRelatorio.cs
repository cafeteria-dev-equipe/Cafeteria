using System;
using System.Drawing;
using System.Windows.Forms;
using Cafeteria.Models;

namespace Cafeteria
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();

            Text = "Relatório de Vendas";
            Size = new Size(650, 450);
            StartPosition = FormStartPosition.CenterScreen;

            // Tabela para visualizar as vendas
            DataGridView tabela = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 300,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill
            };

            tabela.Columns.Add("Produto", "Produto");
            tabela.Columns.Add("Quantidade", "Quantidade");
            tabela.Columns.Add("Total", "Total");

            // Carrega as vendas registradas
            foreach (Venda venda in VendaRepository.Listar())
            {
                tabela.Rows.Add(
                    venda.Produto,
                    venda.Quantidade,
                    venda.Total.ToString("C")
                );
            }

            // Exibe o valor total vendido
            Label lblTotal = new Label
            {
                Text = $"Total vendido: {VendaRepository.TotalVendido():C}",
                Dock = DockStyle.Bottom,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };

            Controls.Add(tabela);
            Controls.Add(lblTotal);
        }
    }
}