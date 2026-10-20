using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FormMenu : Form
    {
        private Button btnVendas;
        private Button btnRelatorio;

        public FormMenu()
        {
            InitializeComponent();

            Text = "Menu - Cafeteria Dev";
            Size = new Size(500, 350);
            StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label
            {
                Text = "Menu Principal",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(130, 30),
                AutoSize = true
            };

            btnVendas = new Button
            {
                Text = "Realizar Venda",
                Size = new Size(200, 50),
                Location = new Point(140, 110)
            };

            btnRelatorio = new Button
            {
                Text = "Relatório de Vendas",
                Size = new Size(200, 50),
                Location = new Point(140, 180)
            };

            Controls.Add(titulo);
            Controls.Add(btnVendas);
            Controls.Add(btnRelatorio);
        }
    }
}