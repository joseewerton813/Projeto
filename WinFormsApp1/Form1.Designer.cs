namespace WinFormsApp1
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
            tabControl1 = new TabControl();
            Cadastro = new TabPage();
            Cadastrar = new Button();
            panel3 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            Alergias = new Label();
            textBox4 = new TextBox();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            Datadenascimento = new Label();
            Modalidade = new Label();
            Genero = new Label();
            Nacionalidade = new Label();
            Nome = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Dadospessoais = new Label();
            Informaçõespessoais = new Label();
            Resultado = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            maskedTextBox2 = new MaskedTextBox();
            TipoSanguíneo = new Label();
            Peso = new Label();
            Altura = new Label();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            Cadastro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Cadastro);
            tabControl1.Controls.Add(Resultado);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(919, 547);
            tabControl1.TabIndex = 0;
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(Cadastrar);
            Cadastro.Controls.Add(panel3);
            Cadastro.Controls.Add(panel2);
            Cadastro.Controls.Add(Dadospessoais);
            Cadastro.Controls.Add(Informaçõespessoais);
            Cadastro.Location = new Point(4, 24);
            Cadastro.Name = "Cadastro";
            Cadastro.Padding = new Padding(3);
            Cadastro.Size = new Size(911, 519);
            Cadastro.TabIndex = 0;
            Cadastro.Text = "Cadastro";
            Cadastro.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(380, 490);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(75, 23);
            Cadastrar.TabIndex = 4;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(Altura);
            panel3.Controls.Add(Peso);
            panel3.Controls.Add(TipoSanguíneo);
            panel3.Controls.Add(maskedTextBox2);
            panel3.Controls.Add(maskedTextBox1);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(Alergias);
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(22, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 250);
            panel3.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(257, 58);
            maskedTextBox1.Mask = "000,0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(55, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // Alergias
            // 
            Alergias.AutoSize = true;
            Alergias.Location = new Point(55, 117);
            Alergias.Name = "Alergias";
            Alergias.Size = new Size(49, 15);
            Alergias.TabIndex = 1;
            Alergias.Text = "Alergias";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(55, 135);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(540, 84);
            textBox4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(Datadenascimento);
            panel2.Controls.Add(Modalidade);
            panel2.Controls.Add(Genero);
            panel2.Controls.Add(Nacionalidade);
            panel2.Controls.Add(Nome);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(22, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 143);
            panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // Datadenascimento
            // 
            Datadenascimento.AutoSize = true;
            Datadenascimento.Location = new Point(20, 111);
            Datadenascimento.Name = "Datadenascimento";
            Datadenascimento.Size = new Size(114, 15);
            Datadenascimento.TabIndex = 7;
            Datadenascimento.Text = "Data de Nascimento";
            // 
            // Modalidade
            // 
            Modalidade.AutoSize = true;
            Modalidade.Location = new Point(495, 11);
            Modalidade.Name = "Modalidade";
            Modalidade.Size = new Size(70, 15);
            Modalidade.TabIndex = 6;
            Modalidade.Text = "Modalidade";
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Location = new Point(312, 11);
            Genero.Name = "Genero";
            Genero.Size = new Size(45, 15);
            Genero.TabIndex = 5;
            Genero.Text = "Gênero";
            // 
            // Nacionalidade
            // 
            Nacionalidade.AutoSize = true;
            Nacionalidade.Location = new Point(168, 11);
            Nacionalidade.Name = "Nacionalidade";
            Nacionalidade.Size = new Size(83, 15);
            Nacionalidade.TabIndex = 4;
            Nacionalidade.Text = "Nacionalidade";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(20, 11);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 3;
            Nome.Text = "Nome";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(495, 43);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // Dadospessoais
            // 
            Dadospessoais.AutoSize = true;
            Dadospessoais.Location = new Point(22, 14);
            Dadospessoais.Name = "Dadospessoais";
            Dadospessoais.Size = new Size(87, 15);
            Dadospessoais.TabIndex = 1;
            Dadospessoais.Text = "Dados Pessoais";
            // 
            // Informaçõespessoais
            // 
            Informaçõespessoais.AutoSize = true;
            Informaçõespessoais.Location = new Point(22, 199);
            Informaçõespessoais.Name = "Informaçõespessoais";
            Informaçõespessoais.Size = new Size(120, 15);
            Informaçõespessoais.TabIndex = 0;
            Informaçõespessoais.Text = "Informações Pessoais";
            // 
            // Resultado
            // 
            Resultado.Controls.Add(dataGridView1);
            Resultado.Location = new Point(4, 24);
            Resultado.Name = "Resultado";
            Resultado.Padding = new Padding(3);
            Resultado.Size = new Size(911, 519);
            Resultado.TabIndex = 1;
            Resultado.Text = "Resultado";
            Resultado.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(441, 58);
            maskedTextBox2.Mask = "0,00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 6;
            // 
            // TipoSanguíneo
            // 
            TipoSanguíneo.AutoSize = true;
            TipoSanguíneo.Location = new Point(55, 24);
            TipoSanguíneo.Name = "TipoSanguíneo";
            TipoSanguíneo.Size = new Size(90, 15);
            TipoSanguíneo.TabIndex = 7;
            TipoSanguíneo.Text = "Tipo Sanguíneo";
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Location = new Point(257, 24);
            Peso.Name = "Peso";
            Peso.Size = new Size(32, 15);
            Peso.TabIndex = 8;
            Peso.Text = "Peso";
            // 
            // Altura
            // 
            Altura.AutoSize = true;
            Altura.Location = new Point(441, 24);
            Altura.Name = "Altura";
            Altura.Size = new Size(39, 15);
            Altura.TabIndex = 9;
            Altura.Text = "Altura";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(899, 507);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Cadastro.ResumeLayout(false);
            Cadastro.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Cadastro;
        private Panel panel3;
        private Panel panel2;
        private Label Dadospessoais;
        private Label Informaçõespessoais;
        private TabPage Resultado;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Cadastrar;
        private Label Alergias;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label Datadenascimento;
        private Label Modalidade;
        private Label Genero;
        private Label Nacionalidade;
        private Label Nome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label Altura;
        private Label Peso;
        private Label TipoSanguíneo;
        private MaskedTextBox maskedTextBox2;
        private DataGridView dataGridView1;
    }
}
