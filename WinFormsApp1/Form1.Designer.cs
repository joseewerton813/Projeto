namespace Cadastro_de_Atletas
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
            Altura = new Label();
            Peso = new Label();
            TipoSanguíneo = new Label();
            txtaltura = new MaskedTextBox();
            txtpeso = new MaskedTextBox();
            txtsangue = new ComboBox();
            Alergias = new Label();
            txtalergia = new TextBox();
            panel2 = new Panel();
            txtdata = new DateTimePicker();
            Datadenascimento = new Label();
            Modalidade = new Label();
            Genero = new Label();
            Nacionalidade = new Label();
            Nome = new Label();
            txtgenero = new ComboBox();
            txtmodalidade = new TextBox();
            txtnacionalidade = new TextBox();
            txtnome = new TextBox();
            Dadospessoais = new Label();
            Informaçõespessoais = new Label();
            Resultado = new TabPage();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Atualizar = new Button();
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
            Cadastrar.Click += Cadastrar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Altura);
            panel3.Controls.Add(Peso);
            panel3.Controls.Add(TipoSanguíneo);
            panel3.Controls.Add(txtaltura);
            panel3.Controls.Add(txtpeso);
            panel3.Controls.Add(txtsangue);
            panel3.Controls.Add(Alergias);
            panel3.Controls.Add(txtalergia);
            panel3.Location = new Point(22, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 250);
            panel3.TabIndex = 3;
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
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Location = new Point(257, 24);
            Peso.Name = "Peso";
            Peso.Size = new Size(32, 15);
            Peso.TabIndex = 8;
            Peso.Text = "Peso";
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
            // txtaltura
            // 
            txtaltura.Location = new Point(441, 58);
            txtaltura.Mask = "0,00";
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 23);
            txtaltura.TabIndex = 6;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(257, 58);
            txtpeso.Mask = "000,0";
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(100, 23);
            txtpeso.TabIndex = 5;
            // 
            // txtsangue
            // 
            txtsangue.FormattingEnabled = true;
            txtsangue.Location = new Point(55, 58);
            txtsangue.Name = "txtsangue";
            txtsangue.Size = new Size(121, 23);
            txtsangue.TabIndex = 3;
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
            // txtalergia
            // 
            txtalergia.Location = new Point(55, 135);
            txtalergia.Multiline = true;
            txtalergia.Name = "txtalergia";
            txtalergia.Size = new Size(540, 84);
            txtalergia.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtdata);
            panel2.Controls.Add(Datadenascimento);
            panel2.Controls.Add(Modalidade);
            panel2.Controls.Add(Genero);
            panel2.Controls.Add(Nacionalidade);
            panel2.Controls.Add(Nome);
            panel2.Controls.Add(txtgenero);
            panel2.Controls.Add(txtmodalidade);
            panel2.Controls.Add(txtnacionalidade);
            panel2.Controls.Add(txtnome);
            panel2.Location = new Point(22, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 143);
            panel2.TabIndex = 2;
            // 
            // txtdata
            // 
            txtdata.Location = new Point(140, 105);
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(245, 23);
            txtdata.TabIndex = 8;
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
            // txtgenero
            // 
            txtgenero.FormattingEnabled = true;
            txtgenero.Location = new Point(312, 43);
            txtgenero.Name = "txtgenero";
            txtgenero.Size = new Size(121, 23);
            txtgenero.TabIndex = 2;
            // 
            // txtmodalidade
            // 
            txtmodalidade.Location = new Point(495, 43);
            txtmodalidade.Name = "txtmodalidade";
            txtmodalidade.Size = new Size(100, 23);
            txtmodalidade.TabIndex = 2;
            // 
            // txtnacionalidade
            // 
            txtnacionalidade.Location = new Point(168, 43);
            txtnacionalidade.Name = "txtnacionalidade";
            txtnacionalidade.Size = new Size(100, 23);
            txtnacionalidade.TabIndex = 1;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(20, 43);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 0;
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
            Resultado.Controls.Add(Atualizar);
            Resultado.Controls.Add(dataGridView1);
            Resultado.Location = new Point(4, 24);
            Resultado.Name = "Resultado";
            Resultado.Padding = new Padding(3);
            Resultado.Size = new Size(911, 519);
            Resultado.TabIndex = 1;
            Resultado.Text = "Resultado";
            Resultado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(899, 441);
            dataGridView1.TabIndex = 0;
            // 
            // Atualizar
            // 
            Atualizar.Location = new Point(425, 469);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(75, 23);
            Atualizar.TabIndex = 1;
            Atualizar.Text = "Atualizar";
            Atualizar.UseVisualStyleBackColor = true;
            Atualizar.Click += Atualizar_Click;
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
        private TextBox txtmodalidade;
        private TextBox txtnacionalidade;
        private TextBox txtnome;
        private Button Cadastrar;
        private Label Alergias;
        private TextBox txtalergia;
        private ComboBox txtgenero;
        private Label Datadenascimento;
        private Label Modalidade;
        private Label Genero;
        private Label Nacionalidade;
        private Label Nome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox txtsangue;
        private DateTimePicker txtdata;
        private MaskedTextBox txtpeso;
        private Label Altura;
        private Label Peso;
        private Label TipoSanguíneo;
        private MaskedTextBox txtaltura;
        private DataGridView dataGridView1;
        private Button Atualizar;
    }
}
