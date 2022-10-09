namespace ControleInquilinos
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInquilinos = new System.Windows.Forms.Button();
            this.btnImoveis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVoltar.BackgroundImage = global::ControleInquilinos.Properties.Resources.botao_voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(765, 1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(30, 30);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackgroundImage = global::ControleInquilinos.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(793, 1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.BackgroundImage = global::ControleInquilinos.Properties.Resources.house_garden_transparent_png_stickpng_31;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 478);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnInquilinos);
            this.panel3.Controls.Add(this.btnImoveis);
            this.panel3.Location = new System.Drawing.Point(66, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 383);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultar Imóveis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Inquilinos";
            // 
            // btnInquilinos
            // 
            this.btnInquilinos.BackgroundImage = global::ControleInquilinos.Properties.Resources.inquilino;
            this.btnInquilinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInquilinos.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnInquilinos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnInquilinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnInquilinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquilinos.Location = new System.Drawing.Point(55, 34);
            this.btnInquilinos.Name = "btnInquilinos";
            this.btnInquilinos.Size = new System.Drawing.Size(170, 150);
            this.btnInquilinos.TabIndex = 0;
            this.btnInquilinos.UseVisualStyleBackColor = true;
            this.btnInquilinos.Click += new System.EventHandler(this.btnInquilinos_Click);
            // 
            // btnImoveis
            // 
            this.btnImoveis.BackgroundImage = global::ControleInquilinos.Properties.Resources.chale;
            this.btnImoveis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImoveis.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnImoveis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnImoveis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnImoveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImoveis.Location = new System.Drawing.Point(55, 217);
            this.btnImoveis.Name = "btnImoveis";
            this.btnImoveis.Size = new System.Drawing.Size(170, 150);
            this.btnImoveis.TabIndex = 1;
            this.btnImoveis.UseVisualStyleBackColor = true;
            this.btnImoveis.Click += new System.EventHandler(this.btnImoveis_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(828, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInquilinos;
        private System.Windows.Forms.Button btnImoveis;
        private System.Windows.Forms.Button btnVoltar;
    }
}