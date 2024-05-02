namespace PIM_III_ADS_ADM.View
{
    partial class Adm
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
            gbVisitante = new GroupBox();
            txbCep = new TextBox();
            txbData = new MaskedTextBox();
            label3 = new Label();
            txbCodigo = new TextBox();
            lblId = new Label();
            btnRemover = new Button();
            btnSalvar = new Button();
            lblCep = new Label();
            txbIdade = new TextBox();
            lblEnail = new Label();
            txbEmail = new TextBox();
            lblIdade = new Label();
            txbNome = new TextBox();
            lblNome = new Label();
            btnBuscar = new Button();
            gbEditar = new GroupBox();
            txbEmailBuscar = new TextBox();
            lblIdBuscar = new Label();
            txbNomeBuscar = new TextBox();
            lblNomeBuscar = new Label();
            btnRelatorios = new Button();
            dgvPessoa = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            gbVisitante.SuspendLayout();
            gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoa).BeginInit();
            SuspendLayout();
            // 
            // gbVisitante
            // 
            gbVisitante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbVisitante.BackColor = Color.Transparent;
            gbVisitante.Controls.Add(txbCep);
            gbVisitante.Controls.Add(txbData);
            gbVisitante.Controls.Add(label3);
            gbVisitante.Controls.Add(txbCodigo);
            gbVisitante.Controls.Add(lblId);
            gbVisitante.Controls.Add(btnRemover);
            gbVisitante.Controls.Add(btnSalvar);
            gbVisitante.Controls.Add(lblCep);
            gbVisitante.Controls.Add(txbIdade);
            gbVisitante.Controls.Add(lblEnail);
            gbVisitante.Controls.Add(txbEmail);
            gbVisitante.Controls.Add(lblIdade);
            gbVisitante.Controls.Add(txbNome);
            gbVisitante.Controls.Add(lblNome);
            gbVisitante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbVisitante.ForeColor = Color.White;
            gbVisitante.Location = new Point(779, 6);
            gbVisitante.Name = "gbVisitante";
            gbVisitante.Size = new Size(430, 363);
            gbVisitante.TabIndex = 1;
            gbVisitante.TabStop = false;
            gbVisitante.Text = "Visitante";
            // 
            // txbCep
            // 
            txbCep.Location = new Point(29, 196);
            txbCep.Name = "txbCep";
            txbCep.Size = new Size(100, 23);
            txbCep.TabIndex = 3;
            // 
            // txbData
            // 
            txbData.Enabled = false;
            txbData.Location = new Point(311, 196);
            txbData.Mask = "00/00/0000";
            txbData.Name = "txbData";
            txbData.Size = new Size(100, 23);
            txbData.TabIndex = 5;
            txbData.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(311, 178);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Data ";
            // 
            // txbCodigo
            // 
            txbCodigo.Enabled = false;
            txbCodigo.Location = new Point(29, 249);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(100, 23);
            txbCodigo.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(29, 231);
            lblId.Name = "lblId";
            lblId.Size = new Size(45, 15);
            lblId.TabIndex = 8;
            lblId.Text = "Código";
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(29, 292);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(90, 35);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += BtnRemover_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(321, 292);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 35);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.ForeColor = Color.White;
            lblCep.Location = new Point(29, 178);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(27, 15);
            lblCep.TabIndex = 6;
            lblCep.Text = "CEP";
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(29, 90);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(100, 23);
            txbIdade.TabIndex = 1;
            // 
            // lblEnail
            // 
            lblEnail.AutoSize = true;
            lblEnail.BackColor = Color.Transparent;
            lblEnail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnail.ForeColor = Color.White;
            lblEnail.Location = new Point(29, 125);
            lblEnail.Name = "lblEnail";
            lblEnail.Size = new Size(41, 15);
            lblEnail.TabIndex = 4;
            lblEnail.Text = "E-mail";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(29, 143);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(382, 23);
            txbEmail.TabIndex = 2;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = Color.Transparent;
            lblIdade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = Color.White;
            lblIdade.Location = new Point(29, 72);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(38, 15);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade";
            // 
            // txbNome
            // 
            txbNome.BackColor = SystemColors.ControlLightLight;
            txbNome.Location = new Point(29, 37);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(382, 23);
            txbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(29, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(41, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(321, 118);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // gbEditar
            // 
            gbEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbEditar.BackColor = Color.Transparent;
            gbEditar.Controls.Add(txbEmailBuscar);
            gbEditar.Controls.Add(lblIdBuscar);
            gbEditar.Controls.Add(txbNomeBuscar);
            gbEditar.Controls.Add(lblNomeBuscar);
            gbEditar.Controls.Add(btnBuscar);
            gbEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbEditar.ForeColor = Color.White;
            gbEditar.Location = new Point(779, 383);
            gbEditar.Name = "gbEditar";
            gbEditar.Size = new Size(430, 162);
            gbEditar.TabIndex = 8;
            gbEditar.TabStop = false;
            gbEditar.Text = "Editar";
            // 
            // txbEmailBuscar
            // 
            txbEmailBuscar.Location = new Point(29, 85);
            txbEmailBuscar.Name = "txbEmailBuscar";
            txbEmailBuscar.Size = new Size(382, 23);
            txbEmailBuscar.TabIndex = 1;
            // 
            // lblIdBuscar
            // 
            lblIdBuscar.AutoSize = true;
            lblIdBuscar.Location = new Point(29, 67);
            lblIdBuscar.Name = "lblIdBuscar";
            lblIdBuscar.Size = new Size(41, 15);
            lblIdBuscar.TabIndex = 11;
            lblIdBuscar.Text = "E-mail";
            // 
            // txbNomeBuscar
            // 
            txbNomeBuscar.Location = new Point(29, 37);
            txbNomeBuscar.Name = "txbNomeBuscar";
            txbNomeBuscar.Size = new Size(382, 23);
            txbNomeBuscar.TabIndex = 0;
            // 
            // lblNomeBuscar
            // 
            lblNomeBuscar.AutoSize = true;
            lblNomeBuscar.Location = new Point(29, 19);
            lblNomeBuscar.Name = "lblNomeBuscar";
            lblNomeBuscar.Size = new Size(41, 15);
            lblNomeBuscar.TabIndex = 11;
            lblNomeBuscar.Text = "Nome";
            // 
            // btnRelatorios
            // 
            btnRelatorios.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRelatorios.BackColor = Color.Black;
            btnRelatorios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRelatorios.ForeColor = SystemColors.ControlLightLight;
            btnRelatorios.Location = new Point(914, 771);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(160, 57);
            btnRelatorios.TabIndex = 0;
            btnRelatorios.Text = "Relatorios";
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += BtnRelatorios_Click;
            // 
            // dgvPessoa
            // 
            dgvPessoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoa.Location = new Point(12, 12);
            dgvPessoa.Name = "dgvPessoa";
            dgvPessoa.RowTemplate.Height = 25;
            dgvPessoa.Size = new Size(761, 816);
            dgvPessoa.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(914, 634);
            button1.Name = "button1";
            button1.Size = new Size(160, 57);
            button1.TabIndex = 10;
            button1.Text = "Relatorios";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(914, 571);
            button2.Name = "button2";
            button2.Size = new Size(160, 57);
            button2.TabIndex = 11;
            button2.Text = "Relatorios";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(914, 697);
            button3.Name = "button3";
            button3.Size = new Size(160, 57);
            button3.TabIndex = 12;
            button3.Text = "Relatorios";
            button3.UseVisualStyleBackColor = false;
            // 
            // Adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1221, 840);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvPessoa);
            Controls.Add(btnRelatorios);
            Controls.Add(gbEditar);
            Controls.Add(gbVisitante);
            Name = "Adm";
            Text = "Cadastro";
            Load += Adm_Load;
            gbVisitante.ResumeLayout(false);
            gbVisitante.PerformLayout();
            gbEditar.ResumeLayout(false);
            gbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoa).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbVisitante;
        private TextBox txbCodigo;
        private Label lblId;
        private Label lblCep;
        private TextBox txbIdade;
        private Label lblEnail;
        private TextBox txbEmail;
        private Label lblIdade;
        private TextBox txbNome;
        private Label lblNome;
        private Button btnSalvar;
        private Button btnRemover;
        private Button btnBuscar;
        private GroupBox gbEditar;
        private TextBox txbEmailBuscar;
        private Label lblIdBuscar;
        private TextBox txbNomeBuscar;
        private Label lblNomeBuscar;
        private MaskedTextBox txbData;
        private Label label3;
        private Button btnRelatorios;
        private TextBox txbCep;
        private DataGridView dgvPessoa;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
