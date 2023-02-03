
namespace DesafioAlterdata
{
    partial class FrmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGestor = new System.Windows.Forms.Panel();
            this.GroupBoxControles = new System.Windows.Forms.GroupBox();
            this.BtrnAtualizarDados = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.BtrnMinimizar = new System.Windows.Forms.Button();
            this.BtrnAtualizar = new System.Windows.Forms.Button();
            this.BtrnNovo = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.Dgv_Dados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGestor.SuspendLayout();
            this.GroupBoxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestor
            // 
            this.panelGestor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGestor.Controls.Add(this.GroupBoxControles);
            this.panelGestor.Controls.Add(this.groupBoxMenu);
            this.panelGestor.Controls.Add(this.Dgv_Dados);
            this.panelGestor.Location = new System.Drawing.Point(-3, -10);
            this.panelGestor.Name = "panelGestor";
            this.panelGestor.Size = new System.Drawing.Size(1270, 691);
            this.panelGestor.TabIndex = 8;
            // 
            // GroupBoxControles
            // 
            this.GroupBoxControles.Controls.Add(this.label2);
            this.GroupBoxControles.Controls.Add(this.label1);
            this.GroupBoxControles.Controls.Add(this.BtrnAtualizarDados);
            this.GroupBoxControles.Controls.Add(this.lbltotal);
            this.GroupBoxControles.Controls.Add(this.lblQuantidade);
            this.GroupBoxControles.Controls.Add(this.BtrnMinimizar);
            this.GroupBoxControles.Controls.Add(this.BtrnAtualizar);
            this.GroupBoxControles.Controls.Add(this.BtrnNovo);
            this.GroupBoxControles.Location = new System.Drawing.Point(16, 559);
            this.GroupBoxControles.Name = "GroupBoxControles";
            this.GroupBoxControles.Size = new System.Drawing.Size(1242, 100);
            this.GroupBoxControles.TabIndex = 5;
            this.GroupBoxControles.TabStop = false;
            this.GroupBoxControles.Text = "Controles:";
            // 
            // BtrnAtualizarDados
            // 
            this.BtrnAtualizarDados.Image = global::DesafioAlterdata.Properties.Resources.finalizar32x32;
            this.BtrnAtualizarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtrnAtualizarDados.Location = new System.Drawing.Point(483, 29);
            this.BtrnAtualizarDados.Name = "BtrnAtualizarDados";
            this.BtrnAtualizarDados.Size = new System.Drawing.Size(150, 45);
            this.BtrnAtualizarDados.TabIndex = 25;
            this.BtrnAtualizarDados.Text = "Atualizar Dados";
            this.BtrnAtualizarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtrnAtualizarDados.UseVisualStyleBackColor = true;
            this.BtrnAtualizarDados.Click += new System.EventHandler(this.BtrnAtualizarDados_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.ForeColor = System.Drawing.Color.Maroon;
            this.lbltotal.Location = new System.Drawing.Point(999, 42);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 15);
            this.lbltotal.TabIndex = 24;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(842, 40);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(155, 18);
            this.lblQuantidade.TabIndex = 23;
            this.lblQuantidade.Text = "Quantidade de Registros:";
            // 
            // BtrnMinimizar
            // 
            this.BtrnMinimizar.Image = global::DesafioAlterdata.Properties.Resources.minimzar32x32;
            this.BtrnMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtrnMinimizar.Location = new System.Drawing.Point(327, 29);
            this.BtrnMinimizar.Name = "BtrnMinimizar";
            this.BtrnMinimizar.Size = new System.Drawing.Size(150, 45);
            this.BtrnMinimizar.TabIndex = 22;
            this.BtrnMinimizar.Text = "Minimizar";
            this.BtrnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtrnMinimizar.UseVisualStyleBackColor = true;
            this.BtrnMinimizar.Click += new System.EventHandler(this.BtrnMinimizar_Click);
            // 
            // BtrnAtualizar
            // 
            this.BtrnAtualizar.Image = global::DesafioAlterdata.Properties.Resources.atualizar32x32;
            this.BtrnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtrnAtualizar.Location = new System.Drawing.Point(174, 28);
            this.BtrnAtualizar.Name = "BtrnAtualizar";
            this.BtrnAtualizar.Size = new System.Drawing.Size(150, 45);
            this.BtrnAtualizar.TabIndex = 18;
            this.BtrnAtualizar.Text = "Alterar (F3)";
            this.BtrnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtrnAtualizar.UseVisualStyleBackColor = true;
            this.BtrnAtualizar.Click += new System.EventHandler(this.BtrnAtualizar_Click);
            // 
            // BtrnNovo
            // 
            this.BtrnNovo.Image = global::DesafioAlterdata.Properties.Resources.adicionar32x32;
            this.BtrnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtrnNovo.Location = new System.Drawing.Point(20, 28);
            this.BtrnNovo.Name = "BtrnNovo";
            this.BtrnNovo.Size = new System.Drawing.Size(150, 45);
            this.BtrnNovo.TabIndex = 17;
            this.BtrnNovo.Text = "Novo (F2)";
            this.BtrnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtrnNovo.UseVisualStyleBackColor = true;
            this.BtrnNovo.Click += new System.EventHandler(this.BtrnNovo_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMenu.Location = new System.Drawing.Point(16, 1076);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(1242, 184);
            this.groupBoxMenu.TabIndex = 2;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu de opções:";
            // 
            // Dgv_Dados
            // 
            this.Dgv_Dados.AllowUserToAddRows = false;
            this.Dgv_Dados.AllowUserToDeleteRows = false;
            this.Dgv_Dados.AllowUserToResizeColumns = false;
            this.Dgv_Dados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_Dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Dados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Dados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Dados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Dados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Dados.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Dados.Location = new System.Drawing.Point(16, 33);
            this.Dgv_Dados.MultiSelect = false;
            this.Dgv_Dados.Name = "Dgv_Dados";
            this.Dgv_Dados.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Dados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Dados.RowTemplate.Height = 25;
            this.Dgv_Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Dados.Size = new System.Drawing.Size(1242, 520);
            this.Dgv_Dados.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1120, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Versão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1164, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "1.0.1";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelGestor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panelGestor.ResumeLayout(false);
            this.GroupBoxControles.ResumeLayout(false);
            this.GroupBoxControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Dados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGestor;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox GroupBoxControles;
        private System.Windows.Forms.Button BtrnMinimizar;
        private System.Windows.Forms.Button BtrnAtualizar;
        private System.Windows.Forms.Button BtrnNovo;
        private System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.DataGridView Dgv_Dados;
        public System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button BtrnAtualizarDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

