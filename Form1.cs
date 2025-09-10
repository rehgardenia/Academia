namespace Tarefa01
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }


        private void AtivarSelecao()
        {
            if (!string.IsNullOrWhiteSpace(txt_nome.Text) &&
                !string.IsNullOrWhiteSpace(txt_email.Text) &&
                (rd_manha.Checked || rd_tarde.Checked || rd_noite.Checked))
            {
                btn_add.Enabled = true;
                btn_remove.Enabled = true;
                btn_addTodos.Enabled = true;
                btn_removeTodos.Enabled = true;

                chk_yoga.Enabled = true;
                chk_meditacao.Enabled = true;
                chk_natacao.Enabled = true;
                chk_pilates.Enabled = true;
                chk_musculacao.Enabled = true;
            }
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();

            rd_manha.Checked = rd_tarde.Checked = rd_noite.Checked = false;

            lst_disponiveis.Items.Clear();
            lst_selecionadas.Items.Clear();
            lst_disponiveis.Items.AddRange(new object[] {
                "Karatê",
"Muay Thai",
"Judô",
"Capoeira",
"Boxing",
"Taekwondo",
"Kung-Fu"
            });

            chk_yoga.Checked = chk_meditacao.Checked = chk_pilates.Checked = chk_natacao.Checked = chk_musculacao.Checked = false;

            txt_qtd.Text = "0";
            txt_cortesia.Text = "0";
            txt_valor.Text = "0,00";

            txt_nome.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (lst_disponiveis.SelectedItem != null)
            {
                lst_selecionadas.Items.Add(lst_disponiveis.SelectedItem);
                lst_disponiveis.Items.Remove(lst_disponiveis.SelectedItem);
                CalcularPreco();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lst_selecionadas.SelectedItem != null)
            {
                lst_disponiveis.Items.Add(lst_selecionadas.SelectedItem);
                lst_selecionadas.Items.Remove(lst_selecionadas.SelectedItem);
                CalcularPreco();
            }
        }

        private void btn_addTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in lst_disponiveis.Items)
            {
                lst_selecionadas.Items.Add(item);
            }
            lst_disponiveis.Items.Clear();
            CalcularPreco();
        }

        private void btn_removeTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in lst_selecionadas.Items)
            {
                lst_disponiveis.Items.Add(item);
            }
            lst_selecionadas.Items.Clear();
            CalcularPreco();
        }
        private void Cortesia_CheckedChanged(object sender, EventArgs e)
        {
            int qtd = CortesiaSelecionadas();
            if (qtd > 3)
            {
                MessageBox.Show("Máximo de 3 cortesias!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((CheckBox)sender).Checked = false;
            }
            CalcularPreco();
        }

        private int CortesiaSelecionadas()
        {
            return new[] { chk_yoga, chk_meditacao, chk_pilates, chk_natacao, chk_musculacao }
                   .Count(c => c.Checked);
        }

        private void CalcularPreco()
        {
            int qtd = lst_selecionadas.Items.Count;
            int qtdCortesia = CortesiaSelecionadas();
            txt_qtd.Text = qtd.ToString();
            txt_cortesia.Text = qtdCortesia.ToString();

            if (qtd == 0)
            {
                txt_valor.Text = "0,00";
                return;
            }

            decimal preco = 0;
            if (qtd <= 2) preco = 100;
            else if (qtd <= 4) preco = 150;
            else if (qtd <= 6) preco = 200;
            else preco = 250;

            // desconto da tarde
            if (rd_tarde.Checked)
                preco -= preco * 0.15m;

            txt_valor.Text = preco.ToString("F2");
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            AtivarSelecao();
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            AtivarSelecao();
        }

        private void gr_periodo_Enter(object sender, EventArgs e)
        {

        }

        private void rd_manha_Leave(object sender, EventArgs e)
        {
            AtivarSelecao();
        }
    }
}
