namespace naoseii
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desvioCondicionalSimplesIfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desvioCondicionalSimplesIfToolStripMenuItem,
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem,
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desvioCondicionalSimplesIfToolStripMenuItem
            // 
            this.desvioCondicionalSimplesIfToolStripMenuItem.Name = "desvioCondicionalSimplesIfToolStripMenuItem";
            this.desvioCondicionalSimplesIfToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.desvioCondicionalSimplesIfToolStripMenuItem.Text = "desvio condicional simples if";
            this.desvioCondicionalSimplesIfToolStripMenuItem.Click += new System.EventHandler(this.desvioCondicionalSimplesIfToolStripMenuItem_Click);
            // 
            // desvioCondicionalEncadeadoIfelseIfToolStripMenuItem
            // 
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem.Name = "desvioCondicionalEncadeadoIfelseIfToolStripMenuItem";
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem.Size = new System.Drawing.Size(224, 20);
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem.Text = "desvio condicional encadeado if/else if";
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem.Click += new System.EventHandler(this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem_Click);
            // 
            // desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1
            // 
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1.Name = "desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1";
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1.Size = new System.Drawing.Size(220, 20);
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1.Text = "desvio condicional composto if/else if";
            this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1.Click += new System.EventHandler(this.desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(676, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalSimplesIfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalEncadeadoIfelseIfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalEncadeadoIfelseIfToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
    }
}

