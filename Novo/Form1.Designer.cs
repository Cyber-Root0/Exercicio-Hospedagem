namespace Novo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.l_nome = new System.Windows.Forms.Label();
            this.l_idade = new System.Windows.Forms.Label();
            this.l_tipo = new System.Windows.Forms.Label();
            this.l_quant = new System.Windows.Forms.Label();
            this.l_valor = new System.Windows.Forms.Label();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.tb_dias = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(153, 34);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(194, 29);
            this.tb_nome.TabIndex = 0;
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nome.Location = new System.Drawing.Point(36, 30);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(86, 31);
            this.l_nome.TabIndex = 2;
            this.l_nome.Text = "Nome";
            // 
            // l_idade
            // 
            this.l_idade.AutoSize = true;
            this.l_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_idade.Location = new System.Drawing.Point(36, 97);
            this.l_idade.Name = "l_idade";
            this.l_idade.Size = new System.Drawing.Size(89, 31);
            this.l_idade.TabIndex = 3;
            this.l_idade.Text = "Idade ";
            // 
            // l_tipo
            // 
            this.l_tipo.AutoSize = true;
            this.l_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tipo.Location = new System.Drawing.Point(36, 165);
            this.l_tipo.Name = "l_tipo";
            this.l_tipo.Size = new System.Drawing.Size(67, 31);
            this.l_tipo.TabIndex = 4;
            this.l_tipo.Text = "Tipo";
            // 
            // l_quant
            // 
            this.l_quant.AutoSize = true;
            this.l_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_quant.Location = new System.Drawing.Point(36, 240);
            this.l_quant.Name = "l_quant";
            this.l_quant.Size = new System.Drawing.Size(225, 31);
            this.l_quant.TabIndex = 5;
            this.l_quant.Text = "Quantidade DIAS";
            // 
            // l_valor
            // 
            this.l_valor.AutoSize = true;
            this.l_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_valor.Location = new System.Drawing.Point(36, 306);
            this.l_valor.Name = "l_valor";
            this.l_valor.Size = new System.Drawing.Size(226, 31);
            this.l_valor.TabIndex = 6;
            this.l_valor.Text = "Valor CONSUMO";
            // 
            // tb_idade
            // 
            this.tb_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idade.Location = new System.Drawing.Point(153, 97);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(150, 29);
            this.tb_idade.TabIndex = 7;
            // 
            // tb_dias
            // 
            this.tb_dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dias.Location = new System.Drawing.Point(280, 240);
            this.tb_dias.Name = "tb_dias";
            this.tb_dias.Size = new System.Drawing.Size(157, 29);
            this.tb_dias.TabIndex = 9;
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(280, 306);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(128, 29);
            this.tb_valor.TabIndex = 10;
            // 
            // cb_tipo
            // 
            this.cb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cb_tipo.Location = new System.Drawing.Point(153, 169);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 32);
            this.cb_tipo.TabIndex = 12;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(167, 370);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(107, 55);
            this.bt1.TabIndex = 13;
            this.bt1.Text = "Calcular";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.tb_dias);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.l_valor);
            this.Controls.Add(this.l_quant);
            this.Controls.Add(this.l_tipo);
            this.Controls.Add(this.l_idade);
            this.Controls.Add(this.l_nome);
            this.Controls.Add(this.tb_nome);
            this.Name = "Form1";
            this.Text = "Exercicio - HOTEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label l_nome;
        private System.Windows.Forms.Label l_idade;
        private System.Windows.Forms.Label l_tipo;
        private System.Windows.Forms.Label l_quant;
        private System.Windows.Forms.Label l_valor;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.TextBox tb_dias;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Button bt1;
    }
}

