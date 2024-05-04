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
            btnInteiro = new Button();
            btnMeia = new Button();
            btnIsento = new Button();
            SuspendLayout();
            // 
            // btnInteiro
            // 
            btnInteiro.Anchor = AnchorStyles.Right;
            btnInteiro.BackColor = Color.White;
            btnInteiro.BackgroundImageLayout = ImageLayout.None;
            btnInteiro.Cursor = Cursors.Hand;
            btnInteiro.FlatAppearance.BorderSize = 0;
            btnInteiro.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnInteiro.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInteiro.ForeColor = Color.Black;
            btnInteiro.Location = new Point(1175, 388);
            btnInteiro.Name = "btnInteiro";
            btnInteiro.Size = new Size(534, 76);
            btnInteiro.TabIndex = 26;
            btnInteiro.Text = "Inteira                                                            R$10,00   ";
            btnInteiro.TextAlign = ContentAlignment.MiddleLeft;
            btnInteiro.UseVisualStyleBackColor = false;
            btnInteiro.Click += btnInteiro_Click;
            // 
            // btnMeia
            // 
            btnMeia.Anchor = AnchorStyles.Right;
            btnMeia.BackColor = Color.White;
            btnMeia.BackgroundImageLayout = ImageLayout.Zoom;
            btnMeia.Cursor = Cursors.Hand;
            btnMeia.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnMeia.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeia.ForeColor = Color.Black;
            btnMeia.Location = new Point(1175, 552);
            btnMeia.Name = "btnMeia";
            btnMeia.Size = new Size(534, 76);
            btnMeia.TabIndex = 27;
            btnMeia.Text = "Meia                                                               R$5,00   ";
            btnMeia.TextAlign = ContentAlignment.MiddleLeft;
            btnMeia.UseVisualStyleBackColor = false;
            btnMeia.Click += btnMeia_Click;
            // 
            // btnIsento
            // 
            btnIsento.Anchor = AnchorStyles.Right;
            btnIsento.BackColor = Color.White;
            btnIsento.BackgroundImageLayout = ImageLayout.Zoom;
            btnIsento.Cursor = Cursors.Hand;
            btnIsento.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnIsento.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIsento.ForeColor = Color.Black;
            btnIsento.Location = new Point(1175, 716);
            btnIsento.Name = "btnIsento";
            btnIsento.Size = new Size(534, 76);
            btnIsento.TabIndex = 28;
            btnIsento.Text = "Isento                                                            R$0,00   ";
            btnIsento.TextAlign = ContentAlignment.MiddleLeft;
            btnIsento.UseVisualStyleBackColor = false;
            btnIsento.Click += btnIsento_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1100);
            Controls.Add(btnIsento);
            Controls.Add(btnMeia);
            Controls.Add(btnInteiro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vendas";
            Text = "Vendas";
            ResumeLayout(false);
        }

        #endregion
        private Button btnInteiro;
        private Button btnMeia;
        private Button btnIsento;
    }

  
}