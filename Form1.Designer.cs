namespace Tarefa01
{
    partial class Formulario
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
            btn_limpar = new Button();
            lb_nome = new Label();
            txt_nome = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txt_email = new TextBox();
            lb_email = new Label();
            gr_periodo = new GroupBox();
            rd_manha = new RadioButton();
            rd_noite = new RadioButton();
            rd_tarde = new RadioButton();
            lst_disponiveis = new ListBox();
            gr_modalidades = new GroupBox();
            lst_selecionadas = new ListBox();
            btn_removeTodos = new Button();
            btn_addTodos = new Button();
            btn_remove = new Button();
            btn_add = new Button();
            groupBox3 = new GroupBox();
            txt_valor = new TextBox();
            label6 = new Label();
            txt_cortesia = new TextBox();
            label5 = new Label();
            txt_qtd = new TextBox();
            label4 = new Label();
            btn_sair = new Button();
            groupBox4 = new GroupBox();
            chk_musculacao = new CheckBox();
            chk_natacao = new CheckBox();
            chk_pilates = new CheckBox();
            chk_yoga = new CheckBox();
            chk_meditacao = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gr_periodo.SuspendLayout();
            gr_modalidades.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(43, 631);
            btn_limpar.Margin = new Padding(3, 4, 3, 4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(114, 51);
            btn_limpar.TabIndex = 0;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.ForeColor = Color.White;
            lb_nome.Location = new Point(41, 37);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(50, 20);
            lb_nome.TabIndex = 1;
            lb_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.CharacterCasing = CharacterCasing.Upper;
            txt_nome.Location = new Point(41, 61);
            txt_nome.Margin = new Padding(3, 4, 3, 4);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(574, 27);
            txt_nome.TabIndex = 4;
            txt_nome.Leave += txt_nome_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(661, 40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 195);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 347);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // txt_email
            // 
            txt_email.CharacterCasing = CharacterCasing.Lower;
            txt_email.Location = new Point(43, 118);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(574, 27);
            txt_email.TabIndex = 11;
            txt_email.Leave += txt_email_Leave;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.ForeColor = Color.White;
            lb_email.Location = new Point(41, 96);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(52, 20);
            lb_email.TabIndex = 10;
            lb_email.Text = "E-mail";
            // 
            // gr_periodo
            // 
            gr_periodo.Controls.Add(rd_manha);
            gr_periodo.Controls.Add(rd_noite);
            gr_periodo.Controls.Add(rd_tarde);
            gr_periodo.ForeColor = Color.White;
            gr_periodo.Location = new Point(43, 170);
            gr_periodo.Margin = new Padding(3, 4, 3, 4);
            gr_periodo.Name = "gr_periodo";
            gr_periodo.Padding = new Padding(3, 4, 3, 4);
            gr_periodo.Size = new Size(573, 65);
            gr_periodo.TabIndex = 15;
            gr_periodo.TabStop = false;
            gr_periodo.Text = "Período";
            // 
            // rd_manha
            // 
            rd_manha.AutoSize = true;
            rd_manha.ForeColor = Color.White;
            rd_manha.Location = new Point(35, 29);
            rd_manha.Margin = new Padding(3, 4, 3, 4);
            rd_manha.Name = "rd_manha";
            rd_manha.Size = new Size(75, 24);
            rd_manha.TabIndex = 16;
            rd_manha.TabStop = true;
            rd_manha.Text = "Manhã";
            rd_manha.UseVisualStyleBackColor = true;
            rd_manha.CheckedChanged += rd_manha_CheckedChanged;
            // 
            // rd_noite
            // 
            rd_noite.AutoSize = true;
            rd_noite.ForeColor = Color.White;
            rd_noite.Location = new Point(424, 29);
            rd_noite.Margin = new Padding(3, 4, 3, 4);
            rd_noite.Name = "rd_noite";
            rd_noite.Size = new Size(67, 24);
            rd_noite.TabIndex = 18;
            rd_noite.TabStop = true;
            rd_noite.Text = "Noite";
            rd_noite.UseVisualStyleBackColor = true;
            rd_noite.CheckedChanged += rd_noite_CheckedChanged;
            // 
            // rd_tarde
            // 
            rd_tarde.AutoSize = true;
            rd_tarde.ForeColor = Color.White;
            rd_tarde.Location = new Point(230, 29);
            rd_tarde.Margin = new Padding(3, 4, 3, 4);
            rd_tarde.Name = "rd_tarde";
            rd_tarde.Size = new Size(66, 24);
            rd_tarde.TabIndex = 17;
            rd_tarde.TabStop = true;
            rd_tarde.Text = "Tarde";
            rd_tarde.UseVisualStyleBackColor = true;
            rd_tarde.CheckedChanged += rd_tarde_CheckedChanged;
            
            // 
            // lst_disponiveis
            // 
            lst_disponiveis.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_disponiveis.FormattingEnabled = true;
            lst_disponiveis.ItemHeight = 21;
            lst_disponiveis.Items.AddRange(new object[] { "Karatê", "Muay Thai", "Judô", "Capoeira", "Boxing", "Taekwondo", "Kung-Fu" });
            lst_disponiveis.Location = new Point(14, 29);
            lst_disponiveis.Margin = new Padding(3, 4, 3, 4);
            lst_disponiveis.Name = "lst_disponiveis";
            lst_disponiveis.Size = new Size(189, 172);
            lst_disponiveis.TabIndex = 16;
            // 
            // gr_modalidades
            // 
            gr_modalidades.Controls.Add(lst_selecionadas);
            gr_modalidades.Controls.Add(btn_removeTodos);
            gr_modalidades.Controls.Add(btn_addTodos);
            gr_modalidades.Controls.Add(btn_remove);
            gr_modalidades.Controls.Add(btn_add);
            gr_modalidades.Controls.Add(lst_disponiveis);
            gr_modalidades.ForeColor = Color.White;
            gr_modalidades.Location = new Point(43, 250);
            gr_modalidades.Margin = new Padding(3, 4, 3, 4);
            gr_modalidades.Name = "gr_modalidades";
            gr_modalidades.Padding = new Padding(3, 4, 3, 4);
            gr_modalidades.Size = new Size(573, 247);
            gr_modalidades.TabIndex = 17;
            gr_modalidades.TabStop = false;
            gr_modalidades.Text = "Modalidades";
            // 
            // lst_selecionadas
            // 
            lst_selecionadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_selecionadas.FormattingEnabled = true;
            lst_selecionadas.ItemHeight = 21;
            lst_selecionadas.Location = new Point(338, 29);
            lst_selecionadas.Margin = new Padding(3, 4, 3, 4);
            lst_selecionadas.Name = "lst_selecionadas";
            lst_selecionadas.Size = new Size(207, 172);
            lst_selecionadas.TabIndex = 22;
            // 
            // btn_removeTodos
            // 
            btn_removeTodos.Enabled = false;
            btn_removeTodos.ForeColor = Color.Navy;
            btn_removeTodos.Location = new Point(230, 184);
            btn_removeTodos.Margin = new Padding(3, 4, 3, 4);
            btn_removeTodos.Name = "btn_removeTodos";
            btn_removeTodos.Size = new Size(73, 43);
            btn_removeTodos.TabIndex = 21;
            btn_removeTodos.Text = "<<";
            btn_removeTodos.UseVisualStyleBackColor = true;
            btn_removeTodos.Click += btn_removeTodos_Click;
            // 
            // btn_addTodos
            // 
            btn_addTodos.Enabled = false;
            btn_addTodos.ForeColor = Color.Navy;
            btn_addTodos.Location = new Point(230, 133);
            btn_addTodos.Margin = new Padding(3, 4, 3, 4);
            btn_addTodos.Name = "btn_addTodos";
            btn_addTodos.Size = new Size(73, 43);
            btn_addTodos.TabIndex = 20;
            btn_addTodos.Text = ">>";
            btn_addTodos.UseVisualStyleBackColor = true;
            btn_addTodos.Click += btn_addTodos_Click;
            // 
            // btn_remove
            // 
            btn_remove.Enabled = false;
            btn_remove.ForeColor = Color.Navy;
            btn_remove.Location = new Point(230, 83);
            btn_remove.Margin = new Padding(3, 4, 3, 4);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(73, 43);
            btn_remove.TabIndex = 19;
            btn_remove.Text = "<";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_add
            // 
            btn_add.Enabled = false;
            btn_add.ForeColor = Color.Navy;
            btn_add.Location = new Point(230, 29);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(73, 43);
            btn_add.TabIndex = 18;
            btn_add.Text = ">";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_valor);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txt_cortesia);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txt_qtd);
            groupBox3.Controls.Add(label4);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(43, 519);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(782, 89);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumo";
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_valor.ForeColor = Color.Red;
            txt_valor.Location = new Point(643, 36);
            txt_valor.Margin = new Padding(3, 4, 3, 4);
            txt_valor.Name = "txt_valor";
            txt_valor.ReadOnly = true;
            txt_valor.RightToLeft = RightToLeft.Yes;
            txt_valor.Size = new Size(114, 29);
            txt_valor.TabIndex = 5;
            txt_valor.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(527, 43);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 4;
            label6.Text = "Valor a Pagar(R$)";
            // 
            // txt_cortesia
            // 
            txt_cortesia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_cortesia.ForeColor = Color.Red;
            txt_cortesia.Location = new Point(371, 36);
            txt_cortesia.Margin = new Padding(3, 4, 3, 4);
            txt_cortesia.Name = "txt_cortesia";
            txt_cortesia.ReadOnly = true;
            txt_cortesia.RightToLeft = RightToLeft.Yes;
            txt_cortesia.Size = new Size(114, 29);
            txt_cortesia.TabIndex = 3;
            txt_cortesia.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(280, 43);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 2;
            label5.Text = "Cortesia";
            // 
            // txt_qtd
            // 
            txt_qtd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_qtd.ForeColor = Color.Red;
            txt_qtd.Location = new Point(99, 36);
            txt_qtd.Margin = new Padding(3, 4, 3, 4);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.ReadOnly = true;
            txt_qtd.RightToLeft = RightToLeft.Yes;
            txt_qtd.Size = new Size(114, 29);
            txt_qtd.TabIndex = 1;
            txt_qtd.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 43);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 0;
            label4.Text = "Quantidade";
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(182, 631);
            btn_sair.Margin = new Padding(3, 4, 3, 4);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(114, 51);
            btn_sair.TabIndex = 19;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chk_musculacao);
            groupBox4.Controls.Add(chk_natacao);
            groupBox4.Controls.Add(chk_pilates);
            groupBox4.Controls.Add(chk_yoga);
            groupBox4.Controls.Add(chk_meditacao);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(661, 252);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(165, 247);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cortesia";
            // 
            // chk_musculacao
            // 
            chk_musculacao.AutoSize = true;
            chk_musculacao.Enabled = false;
            chk_musculacao.ForeColor = Color.White;
            chk_musculacao.Location = new Point(16, 177);
            chk_musculacao.Margin = new Padding(3, 4, 3, 4);
            chk_musculacao.Name = "chk_musculacao";
            chk_musculacao.Size = new Size(109, 24);
            chk_musculacao.TabIndex = 4;
            chk_musculacao.Text = "Musculação";
            chk_musculacao.UseVisualStyleBackColor = true;
            // 
            // chk_natacao
            // 
            chk_natacao.AutoSize = true;
            chk_natacao.Enabled = false;
            chk_natacao.ForeColor = Color.White;
            chk_natacao.Location = new Point(16, 144);
            chk_natacao.Margin = new Padding(3, 4, 3, 4);
            chk_natacao.Name = "chk_natacao";
            chk_natacao.Size = new Size(87, 24);
            chk_natacao.TabIndex = 3;
            chk_natacao.Text = "Natação";
            chk_natacao.UseVisualStyleBackColor = true;
            // 
            // chk_pilates
            // 
            chk_pilates.AutoSize = true;
            chk_pilates.Enabled = false;
            chk_pilates.ForeColor = Color.White;
            chk_pilates.Location = new Point(16, 111);
            chk_pilates.Margin = new Padding(3, 4, 3, 4);
            chk_pilates.Name = "chk_pilates";
            chk_pilates.Size = new Size(74, 24);
            chk_pilates.TabIndex = 2;
            chk_pilates.Text = "Pilates";
            chk_pilates.UseVisualStyleBackColor = true;
            // 
            // chk_yoga
            // 
            chk_yoga.AutoSize = true;
            chk_yoga.Enabled = false;
            chk_yoga.ForeColor = Color.White;
            chk_yoga.Location = new Point(16, 77);
            chk_yoga.Margin = new Padding(3, 4, 3, 4);
            chk_yoga.Name = "chk_yoga";
            chk_yoga.Size = new Size(64, 24);
            chk_yoga.TabIndex = 1;
            chk_yoga.Text = "Yoga";
            chk_yoga.UseVisualStyleBackColor = true;
            // 
            // chk_meditacao
            // 
            chk_meditacao.AutoSize = true;
            chk_meditacao.Enabled = false;
            chk_meditacao.ForeColor = Color.White;
            chk_meditacao.Location = new Point(16, 44);
            chk_meditacao.Margin = new Padding(3, 4, 3, 4);
            chk_meditacao.Name = "chk_meditacao";
            chk_meditacao.Size = new Size(102, 24);
            chk_meditacao.TabIndex = 0;
            chk_meditacao.Text = "Meditação";
            chk_meditacao.UseVisualStyleBackColor = true;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(864, 711);
            Controls.Add(groupBox4);
            Controls.Add(btn_sair);
            Controls.Add(groupBox3);
            Controls.Add(gr_modalidades);
            Controls.Add(gr_periodo);
            Controls.Add(txt_email);
            Controls.Add(lb_email);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_nome);
            Controls.Add(lb_nome);
            Controls.Add(btn_limpar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formulario";
            Text = "Academia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gr_periodo.ResumeLayout(false);
            gr_periodo.PerformLayout();
            gr_modalidades.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_limpar;
        private Label lb_nome;
        private TextBox txt_nome;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txt_email;
        private Label lb_email;
        private GroupBox gr_periodo;
        private RadioButton rd_manha;
        private RadioButton rd_noite;
        private RadioButton rd_tarde;
        private ListBox lst_disponiveis;
        private GroupBox gr_modalidades;
        private Button btn_add;
        private ListBox lst_selecionadas;
        private Button btn_removeTodos;
        private Button btn_addTodos;
        private Button btn_remove;
        private GroupBox groupBox3;
        private TextBox txt_qtd;
        private Label label4;
        private Button btn_sair;
        private GroupBox groupBox4;
        private TextBox txt_valor;
        private Label label6;
        private TextBox txt_cortesia;
        private Label label5;
        private CheckBox chk_musculacao;
        private CheckBox chk_natacao;
        private CheckBox chk_pilates;
        private CheckBox chk_yoga;
        private CheckBox chk_meditacao;
    }
}
