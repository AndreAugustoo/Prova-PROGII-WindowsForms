
namespace Prova
{
    partial class frmPrincipal
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
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.btCancelarCadastrar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtDono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbExcluir = new System.Windows.Forms.GroupBox();
            this.btCancelarExcluir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbAnimais = new System.Windows.Forms.GroupBox();
            this.listAnimais = new System.Windows.Forms.ListBox();
            this.gbCadastrar.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbExcluir.SuspendLayout();
            this.gbAnimais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbCadastrar.Controls.Add(this.btCancelarCadastrar);
            this.gbCadastrar.Controls.Add(this.btCadastrar);
            this.gbCadastrar.Controls.Add(this.label4);
            this.gbCadastrar.Controls.Add(this.cbTipo);
            this.gbCadastrar.Controls.Add(this.txtDono);
            this.gbCadastrar.Controls.Add(this.label3);
            this.gbCadastrar.Controls.Add(this.gbSexo);
            this.gbCadastrar.Controls.Add(this.txtNome);
            this.gbCadastrar.Controls.Add(this.label1);
            this.gbCadastrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCadastrar.Location = new System.Drawing.Point(25, 26);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(339, 434);
            this.gbCadastrar.TabIndex = 7;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastrar animal:";
            // 
            // btCancelarCadastrar
            // 
            this.btCancelarCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelarCadastrar.BackColor = System.Drawing.Color.Crimson;
            this.btCancelarCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelarCadastrar.Location = new System.Drawing.Point(179, 355);
            this.btCancelarCadastrar.Name = "btCancelarCadastrar";
            this.btCancelarCadastrar.Size = new System.Drawing.Size(130, 37);
            this.btCancelarCadastrar.TabIndex = 7;
            this.btCancelarCadastrar.Text = "Cancelar";
            this.btCancelarCadastrar.UseVisualStyleBackColor = false;
            this.btCancelarCadastrar.Click += new System.EventHandler(this.btCancelarCadastrar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCadastrar.Location = new System.Drawing.Point(27, 355);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 37);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Confirmar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Cachorro",
            "Gato",
            "Outros"});
            this.cbTipo.Location = new System.Drawing.Point(85, 142);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(224, 33);
            this.cbTipo.TabIndex = 3;
            // 
            // txtDono
            // 
            this.txtDono.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDono.Location = new System.Drawing.Point(85, 103);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(224, 32);
            this.txtDono.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dono:";
            // 
            // gbSexo
            // 
            this.gbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbSexo.Location = new System.Drawing.Point(33, 201);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(276, 118);
            this.gbSexo.TabIndex = 10;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(6, 72);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(108, 29);
            this.rbFeminino.TabIndex = 5;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 37);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(117, 29);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(85, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 32);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // gbExcluir
            // 
            this.gbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbExcluir.Controls.Add(this.btCancelarExcluir);
            this.gbExcluir.Controls.Add(this.btExcluir);
            this.gbExcluir.Controls.Add(this.txtExcluir);
            this.gbExcluir.Controls.Add(this.label7);
            this.gbExcluir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbExcluir.Location = new System.Drawing.Point(385, 26);
            this.gbExcluir.Name = "gbExcluir";
            this.gbExcluir.Size = new System.Drawing.Size(339, 434);
            this.gbExcluir.TabIndex = 8;
            this.gbExcluir.TabStop = false;
            this.gbExcluir.Text = "Excluir animal:";
            // 
            // btCancelarExcluir
            // 
            this.btCancelarExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelarExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btCancelarExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarExcluir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelarExcluir.Location = new System.Drawing.Point(179, 355);
            this.btCancelarExcluir.Name = "btCancelarExcluir";
            this.btCancelarExcluir.Size = new System.Drawing.Size(130, 37);
            this.btCancelarExcluir.TabIndex = 10;
            this.btCancelarExcluir.Text = "Cancelar";
            this.btCancelarExcluir.UseVisualStyleBackColor = false;
            this.btCancelarExcluir.Click += new System.EventHandler(this.btCancelarExcluir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.BackColor = System.Drawing.Color.SeaGreen;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.Location = new System.Drawing.Point(27, 355);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 37);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Confirmar";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExcluir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExcluir.Location = new System.Drawing.Point(27, 182);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(282, 32);
            this.txtExcluir.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Digite o nome do animal a ser excluído:";
            // 
            // gbAnimais
            // 
            this.gbAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAnimais.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbAnimais.Controls.Add(this.listAnimais);
            this.gbAnimais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbAnimais.Location = new System.Drawing.Point(743, 26);
            this.gbAnimais.Name = "gbAnimais";
            this.gbAnimais.Size = new System.Drawing.Size(568, 434);
            this.gbAnimais.TabIndex = 9;
            this.gbAnimais.TabStop = false;
            this.gbAnimais.Text = "Lista de animais:";
            // 
            // listAnimais
            // 
            this.listAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAnimais.BackColor = System.Drawing.SystemColors.Menu;
            this.listAnimais.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listAnimais.FormattingEnabled = true;
            this.listAnimais.ItemHeight = 25;
            this.listAnimais.Location = new System.Drawing.Point(27, 61);
            this.listAnimais.Name = "listAnimais";
            this.listAnimais.Size = new System.Drawing.Size(515, 354);
            this.listAnimais.TabIndex = 17;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1333, 493);
            this.Controls.Add(this.gbAnimais);
            this.Controls.Add(this.gbExcluir);
            this.Controls.Add(this.gbCadastrar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Mais";
            this.gbCadastrar.ResumeLayout(false);
            this.gbCadastrar.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbExcluir.ResumeLayout(false);
            this.gbExcluir.PerformLayout();
            this.gbAnimais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.Button btCancelarCadastrar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtDono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbExcluir;
        private System.Windows.Forms.Button btCancelarExcluir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbAnimais;
        private System.Windows.Forms.ListBox listAnimais;
    }
}

