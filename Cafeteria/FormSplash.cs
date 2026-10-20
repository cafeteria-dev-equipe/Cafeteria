using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();

            Text = "Cafeteria Dev";
            Size = new Size(500, 300);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.SaddleBrown;

            Label titulo = new Label
            {
                Text = "CAFETERIA DEV",
                ForeColor = Color.White,
                Font = new Font("Arial", 24, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Controls.Add(titulo);

            System.Windows.Forms.Timer timer =
                new System.Windows.Forms.Timer();

            timer.Interval = 3000;

            timer.Tick += (s, e) =>
            {
                timer.Stop();
                Close();
            };

            timer.Start();
        }
    }
}