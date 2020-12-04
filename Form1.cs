using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using TesteThomasGreg.Database;
using TesteThomasGreg.Model;
using TesteThomasGreg.Persistence;

namespace TesteThomasGreg
{
    public partial class frm_main : Form
    {
        public SQLiteConnection conn;

        Persist persist = new Persist();

        Connection connection = new Connection();

        public string IdGrid = "";
        public frm_main()
        {
            InitializeComponent();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            try
            {

                LoadGrid();
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {

            LoadGrid();
            ClearFields();
        }

        private void LoadGrid()
        {
            try
            {
                conn = connection.DbConnection();

                persist.CreateTable(conn);

                DataTable data = persist.GetVoos(conn);

                dtVoo.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void ClearFields()
        {
            txt_Custo.Text = "";
            txt_Distancia.Text = "";
            txt_NvDor.Text = "";
            dtp_Data.Text = "";
            radioButton1.Checked = false;
            btn_Excluir.Enabled = false;
            radioButton2.Checked = false;
            btn_Cancelar.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Incluir.Enabled = true;
            dtVoo.Enabled = true;
        }

        private void Btn_Incluir_Click(object sender, EventArgs e)
        {
            ClearFields();
            StatusFields();
            btn_Incluir.Enabled = false;
            dtVoo.Enabled = false;
        }

        private void StatusFields()
        {
            btn_Salvar.Enabled = true;
            btn_Cancelar.Enabled = true;

        }

        private void Txt_Custo_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Txt_Distancia_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Txt_NvDor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {

                    if (string.IsNullOrEmpty(IdGrid))
                    {
                        InsertOrUpdate(1);
                    }
                    else
                    {
                        InsertOrUpdate(2);
                    }

                    LoadGrid();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void InsertOrUpdate(int type)
        {
            Voo voo = new Voo();
            try
            {
                if (radioButton1.Checked)
                {
                    voo.CAPTURA = "N";
                }
                else if (radioButton2.Checked)
                {
                    voo.CAPTURA = "S";
                }

                voo.CUSTO = Convert.ToInt32(txt_Custo.Text);
                voo.DATA_VOO = Convert.ToDateTime(dtp_Data.Text);
                voo.DISTANCIA = Convert.ToInt32(txt_Distancia.Text);
                voo.NIVEL_DOR = Convert.ToInt32(txt_NvDor.Text);

                if (!string.IsNullOrEmpty(IdGrid))
                    voo.Id = IdGrid;

                if (type == 1)
                    persist.Add(voo, conn);
                else
                {
                    persist.Update(voo, conn);
                    IdGrid = "";
                }
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidateFields()
        {

            if (string.IsNullOrEmpty(txt_Custo.Text)) { MessageBox.Show("Favor Informar o custo"); return false; }
            if (string.IsNullOrEmpty(txt_Distancia.Text)) { MessageBox.Show("Favor Informar a distancia"); return false; }
            if (string.IsNullOrEmpty(txt_NvDor.Text)) { MessageBox.Show("Favor Informar o nivel de dor"); return false; }
            if (string.IsNullOrEmpty(dtp_Data.Text)) { MessageBox.Show("Favor Informar a data"); return false; }
            if (radioButton1.Checked == false && radioButton2.Checked == false) { MessageBox.Show("Favor Informar Captura"); return false; }
            if (Convert.ToInt32(txt_NvDor.Text) >= 11 || Convert.ToInt32(txt_NvDor.Text) <= -1) { MessageBox.Show("Nivel de dor maior que o aceitavel"); return false; }
            return true;
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                persist.Delete(IdGrid, conn);

                ClearFields();
                LoadGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DtVoo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtVoo.Rows[e.RowIndex];
            IdGrid = row.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(IdGrid))
                FindVoo(IdGrid);
        }

        public void FindVoo(string id)
        {
            try
            {
                conn = connection.DbConnection();

                persist.CreateTable(conn);

                DataTable data = persist.GetById(id, conn);

                StatusFields();
                btn_Incluir.Enabled = false;
                dtVoo.Enabled = false;

                Array voo = data.Rows[0].ItemArray;

                txt_Custo.Text = voo.GetValue(2).ToString();
                txt_Distancia.Text = voo.GetValue(3).ToString();
                txt_NvDor.Text = voo.GetValue(5).ToString();
                dtp_Data.Text = voo.GetValue(1).ToString();
                if (voo.GetValue(4).ToString() == "N")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
