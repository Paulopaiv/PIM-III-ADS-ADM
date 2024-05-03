namespace PIM_III_ADS_ADM.View
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            LblVendaDeIngressos = new Label();
            pictureBox2 = new PictureBox();
            btnInteiro = new Button();
            btnMeia = new Button();
            btnIsento = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LblVendaDeIngressos
            // 
            LblVendaDeIngressos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LblVendaDeIngressos.AutoSize = true;
            LblVendaDeIngressos.BackColor = Color.Transparent;
            LblVendaDeIngressos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblVendaDeIngressos.ForeColor = SystemColors.ControlLightLight;
            LblVendaDeIngressos.Location = new Point(956, 198);
            LblVendaDeIngressos.Name = "LblVendaDeIngressos";
            LblVendaDeIngressos.Size = new Size(184, 25);
            LblVendaDeIngressos.TabIndex = 5;
            LblVendaDeIngressos.Text = "Venda de Ingressos";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(767, 892);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // btnInteiro
            // 
            btnInteiro.Anchor = AnchorStyles.Right;
            btnInteiro.BackgroundImageLayout = ImageLayout.Zoom;
            btnInteiro.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnInteiro.ForeColor = SystemColors.ButtonFace;
            btnInteiro.Location = new Point(898, 252);
            btnInteiro.Name = "btnInteiro";
            btnInteiro.Size = new Size(302, 38);
            btnInteiro.TabIndex = 26;
            btnInteiro.Text = "Inteira                                        R$10,00";
            btnInteiro.UseVisualStyleBackColor = false;
            btnInteiro.Click += btnInteiro_Click;
            // 
            // btnMeia
            // 
            btnMeia.Anchor = AnchorStyles.Right;
            btnMeia.BackgroundImageLayout = ImageLayout.Zoom;
            btnMeia.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeia.ForeColor = SystemColors.ButtonFace;
            btnMeia.Location = new Point(898, 405);
            btnMeia.Name = "btnMeia";
            btnMeia.Size = new Size(302, 38);
            btnMeia.TabIndex = 27;
            btnMeia.Text = "Meia                                              R$5,00";
            btnMeia.UseVisualStyleBackColor = false;
            btnMeia.Click += btnMeia_Click;
            // 
            // btnIsento
            // 
            btnIsento.Anchor = AnchorStyles.Right;
            btnIsento.BackgroundImageLayout = ImageLayout.Zoom;
            btnIsento.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnIsento.ForeColor = SystemColors.ButtonFace;
            btnIsento.Location = new Point(898, 558);
            btnIsento.Name = "btnIsento";
            btnIsento.Size = new Size(302, 38);
            btnIsento.TabIndex = 28;
            btnIsento.Text = "Isento                                           R$0,00";
            btnIsento.UseVisualStyleBackColor = false;
            btnIsento.Click += btnIsento_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1320, 851);
            Controls.Add(btnIsento);
            Controls.Add(btnMeia);
            Controls.Add(btnInteiro);
            Controls.Add(pictureBox2);
            Controls.Add(LblVendaDeIngressos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vendas";
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblVendaDeIngressos;
        private PictureBox pictureBox2;
        private Button btnInteiro;
        private Button btnMeia;
        private Button btnIsento;
    }

  
}