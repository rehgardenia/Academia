namespace Tarefa01
{
    partial class Academia
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
            button1 = new Button();
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
            lts_disponiveis = new ListBox();
            gr_modalidades = new GroupBox();
            lts_selecionadas = new ListBox();
            button5 = new Button();
            btn = new Button();
            btn_individualEsquerda = new Button();
            btn_individualDireita = new Button();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            groupBox4 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gr_periodo.SuspendLayout();
            gr_modalidades.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 631);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 51);
            button1.TabIndex = 0;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            lb_nome.Click += label1_Click;
            // 
            // txt_nome
            // 
            txt_nome.CharacterCasing = CharacterCasing.Upper;
            txt_nome.Location = new Point(41, 61);
            txt_nome.Margin = new Padding(3, 4, 3, 4);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(574, 27);
            txt_nome.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(661, 37);
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
            txt_email.Location = new Point(41, 120);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(574, 27);
            txt_email.TabIndex = 11;
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
            gr_periodo.Location = new Point(43, 168);
            gr_periodo.Margin = new Padding(3, 4, 3, 4);
            gr_periodo.Name = "gr_periodo";
            gr_periodo.Padding = new Padding(3, 4, 3, 4);
            gr_periodo.Size = new Size(573, 65);
            gr_periodo.TabIndex = 15;
            gr_periodo.TabStop = false;
            gr_periodo.Text = "Período";
            gr_periodo.Enter += groupBox1_Enter;
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
            // 
            // lts_disponiveis
            // 
            lts_disponiveis.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lts_disponiveis.FormattingEnabled = true;
            lts_disponiveis.ItemHeight = 21;
            lts_disponiveis.Items.AddRange(new object[] { "Karatê", "Muay Thai", "Judô", "Capoeira", "Boxing", "Taekwondo", "Kung-Fu" });
            lts_disponiveis.Location = new Point(14, 29);
            lts_disponiveis.Margin = new Padding(3, 4, 3, 4);
            lts_disponiveis.Name = "lts_disponiveis";
            lts_disponiveis.Size = new Size(189, 172);
            lts_disponiveis.TabIndex = 16;
            // 
            // gr_modalidades
            // 
            gr_modalidades.Controls.Add(lts_selecionadas);
            gr_modalidades.Controls.Add(button5);
            gr_modalidades.Controls.Add(btn);
            gr_modalidades.Controls.Add(btn_individualEsquerda);
            gr_modalidades.Controls.Add(btn_individualDireita);
            gr_modalidades.Controls.Add(lts_disponiveis);
            gr_modalidades.ForeColor = Color.White;
            gr_modalidades.Location = new Point(43, 252);
            gr_modalidades.Margin = new Padding(3, 4, 3, 4);
            gr_modalidades.Name = "gr_modalidades";
            gr_modalidades.Padding = new Padding(3, 4, 3, 4);
            gr_modalidades.Size = new Size(573, 247);
            gr_modalidades.TabIndex = 17;
            gr_modalidades.TabStop = false;
            gr_modalidades.Text = "Modalidades";
            // 
            // lts_selecionadas
            // 
            lts_selecionadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lts_selecionadas.FormattingEnabled = true;
            lts_selecionadas.ItemHeight = 21;
            lts_selecionadas.Location = new Point(338, 29);
            lts_selecionadas.Margin = new Padding(3, 4, 3, 4);
            lts_selecionadas.Name = "lts_selecionadas";
            lts_selecionadas.Size = new Size(207, 172);
            lts_selecionadas.TabIndex = 22;
            // 
            // button5
            // 
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(230, 184);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(73, 43);
            button5.TabIndex = 21;
            button5.Text = "<<";
            button5.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.ForeColor = Color.Navy;
            btn.Location = new Point(230, 133);
            btn.Margin = new Padding(3, 4, 3, 4);
            btn.Name = "btn";
            btn.Size = new Size(73, 43);
            btn.TabIndex = 20;
            btn.Text = ">>";
            btn.UseVisualStyleBackColor = true;
            // 
            // btn_individualEsquerda
            // 
            btn_individualEsquerda.ForeColor = Color.Navy;
            btn_individualEsquerda.Location = new Point(230, 83);
            btn_individualEsquerda.Margin = new Padding(3, 4, 3, 4);
            btn_individualEsquerda.Name = "btn_individualEsquerda";
            btn_individualEsquerda.Size = new Size(73, 43);
            btn_individualEsquerda.TabIndex = 19;
            btn_individualEsquerda.Text = "<";
            btn_individualEsquerda.UseVisualStyleBackColor = true;
            // 
            // btn_individualDireita
            // 
            btn_individualDireita.ForeColor = Color.Navy;
            btn_individualDireita.Location = new Point(230, 29);
            btn_individualDireita.Margin = new Padding(3, 4, 3, 4);
            btn_individualDireita.Name = "btn_individualDireita";
            btn_individualDireita.Size = new Size(73, 43);
            btn_individualDireita.TabIndex = 18;
            btn_individualDireita.Text = ">";
            btn_individualDireita.UseVisualStyleBackColor = true;
            btn_individualDireita.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox3);
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
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Red;
            textBox5.Location = new Point(643, 36);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.RightToLeft = RightToLeft.Yes;
            textBox5.Size = new Size(114, 29);
            textBox5.TabIndex = 5;
            textBox5.Text = "0";
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
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(371, 36);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(114, 29);
            textBox4.TabIndex = 3;
            textBox4.Text = "0";
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(99, 36);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(114, 29);
            textBox3.TabIndex = 1;
            textBox3.Text = "0";
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
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 631);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 51);
            button2.TabIndex = 19;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox5);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
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
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = Color.White;
            checkBox5.Location = new Point(16, 177);
            checkBox5.Margin = new Padding(3, 4, 3, 4);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(109, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Musculação";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(16, 144);
            checkBox4.Margin = new Padding(3, 4, 3, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(87, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Natação";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(16, 111);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(74, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Pilates";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(16, 77);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Yoga";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(16, 44);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Meditação";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Academia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(864, 711);
            Controls.Add(groupBox4);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(gr_modalidades);
            Controls.Add(gr_periodo);
            Controls.Add(txt_email);
            Controls.Add(lb_email);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_nome);
            Controls.Add(lb_nome);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Academia";
            Text = "Academia";
            Load += Form1_Load;
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

        private Button button1;
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
        private ListBox lts_disponiveis;
        private GroupBox gr_modalidades;
        private Button btn_individualDireita;
        private ListBox lts_selecionadas;
        private Button button5;
        private Button btn;
        private Button btn_individualEsquerda;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
        private GroupBox groupBox4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
