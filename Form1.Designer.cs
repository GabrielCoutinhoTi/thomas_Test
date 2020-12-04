namespace TesteThomasGreg
{
    partial class frm_main
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.txt_NvDor = new System.Windows.Forms.TextBox();
            this.txt_Distancia = new System.Windows.Forms.TextBox();
            this.txt_Custo = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Custo = new System.Windows.Forms.Label();
            this.lbl_Cap = new System.Windows.Forms.Label();
            this.lbl_Distancia = new System.Windows.Forms.Label();
            this.lbl_NvDor = new System.Windows.Forms.Label();
            this.dtVoo = new System.Windows.Forms.DataGridView();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(624, 360);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(521, 360);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(521, 41);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 2;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.Btn_Incluir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(624, 41);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // txt_NvDor
            // 
            this.txt_NvDor.Location = new System.Drawing.Point(522, 258);
            this.txt_NvDor.MaxLength = 2;
            this.txt_NvDor.Name = "txt_NvDor";
            this.txt_NvDor.Size = new System.Drawing.Size(178, 20);
            this.txt_NvDor.TabIndex = 4;
            this.txt_NvDor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NvDor_KeyPress);
            // 
            // txt_Distancia
            // 
            this.txt_Distancia.Location = new System.Drawing.Point(521, 169);
            this.txt_Distancia.Name = "txt_Distancia";
            this.txt_Distancia.Size = new System.Drawing.Size(178, 20);
            this.txt_Distancia.TabIndex = 5;
            this.txt_Distancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Distancia_KeyPress);
            // 
            // txt_Custo
            // 
            this.txt_Custo.Location = new System.Drawing.Point(521, 128);
            this.txt_Custo.Name = "txt_Custo";
            this.txt_Custo.Size = new System.Drawing.Size(178, 20);
            this.txt_Custo.TabIndex = 6;
            this.txt_Custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Custo_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(522, 215);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Não";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(644, 215);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sim";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(461, 96);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(30, 13);
            this.lbl_Data.TabIndex = 10;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_Custo
            // 
            this.lbl_Custo.AutoSize = true;
            this.lbl_Custo.Location = new System.Drawing.Point(461, 135);
            this.lbl_Custo.Name = "lbl_Custo";
            this.lbl_Custo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Custo.TabIndex = 11;
            this.lbl_Custo.Text = "Custo";
            // 
            // lbl_Cap
            // 
            this.lbl_Cap.AutoSize = true;
            this.lbl_Cap.Location = new System.Drawing.Point(462, 219);
            this.lbl_Cap.Name = "lbl_Cap";
            this.lbl_Cap.Size = new System.Drawing.Size(47, 13);
            this.lbl_Cap.TabIndex = 12;
            this.lbl_Cap.Text = "Capturar";
            // 
            // lbl_Distancia
            // 
            this.lbl_Distancia.AutoSize = true;
            this.lbl_Distancia.Location = new System.Drawing.Point(461, 176);
            this.lbl_Distancia.Name = "lbl_Distancia";
            this.lbl_Distancia.Size = new System.Drawing.Size(51, 13);
            this.lbl_Distancia.TabIndex = 13;
            this.lbl_Distancia.Text = "Distancia";
            // 
            // lbl_NvDor
            // 
            this.lbl_NvDor.AutoSize = true;
            this.lbl_NvDor.Location = new System.Drawing.Point(462, 265);
            this.lbl_NvDor.Name = "lbl_NvDor";
            this.lbl_NvDor.Size = new System.Drawing.Size(51, 13);
            this.lbl_NvDor.TabIndex = 14;
            this.lbl_NvDor.Text = "Nivel Dor";
            // 
            // dtVoo
            // 
            this.dtVoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVoo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtVoo.Location = new System.Drawing.Point(12, 41);
            this.dtVoo.MultiSelect = false;
            this.dtVoo.Name = "dtVoo";
            this.dtVoo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtVoo.Size = new System.Drawing.Size(428, 342);
            this.dtVoo.TabIndex = 15;
            this.dtVoo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVoo_CellClick);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(522, 90);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(178, 20);
            this.dtp_Data.TabIndex = 16;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 410);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.dtVoo);
            this.Controls.Add(this.lbl_NvDor);
            this.Controls.Add(this.lbl_Distancia);
            this.Controls.Add(this.lbl_Cap);
            this.Controls.Add(this.lbl_Custo);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_Custo);
            this.Controls.Add(this.txt_Distancia);
            this.Controls.Add(this.txt_NvDor);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cancelar);
            this.Name = "frm_main";
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.TextBox txt_NvDor;
        private System.Windows.Forms.TextBox txt_Distancia;
        private System.Windows.Forms.TextBox txt_Custo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Custo;
        private System.Windows.Forms.Label lbl_Cap;
        private System.Windows.Forms.Label lbl_Distancia;
        private System.Windows.Forms.Label lbl_NvDor;
        private System.Windows.Forms.DataGridView dtVoo;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}

