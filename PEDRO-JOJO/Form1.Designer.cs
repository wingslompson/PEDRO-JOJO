namespace PEDRO_JOJO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.INICIAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INICIAR
            // 
            this.INICIAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.INICIAR.AutoSize = true;
            this.INICIAR.BackColor = System.Drawing.Color.Transparent;
            this.INICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INICIAR.ForeColor = System.Drawing.Color.HotPink;
            this.INICIAR.Location = new System.Drawing.Point(273, 234);
            this.INICIAR.Name = "INICIAR";
            this.INICIAR.Size = new System.Drawing.Size(119, 51);
            this.INICIAR.TabIndex = 1;
            this.INICIAR.Text = "INICIAR";
            this.INICIAR.UseVisualStyleBackColor = false;
            this.INICIAR.Click += new System.EventHandler(this.INICIAR_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.INICIAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PEDRO_JOJO.Properties.Resources.capa_botao_;
            this.ClientSize = new System.Drawing.Size(682, 396);
            this.Controls.Add(this.INICIAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button INICIAR;
    }
}

