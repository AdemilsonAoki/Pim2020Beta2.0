﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm.ControlesDeUsuario
{
    public partial class CU_CadastrosUsuarios : UserControl
    {
        public CU_CadastrosUsuarios()
        {
            InitializeComponent();
        }
        Funcionario funcionario = new Funcionario();

        private void cU_RelatoriosVendas1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            Formularios.frmAddFuncionario addFuncionario = new Formularios.frmAddFuncionario();

            addFuncionario.Show();
        }

      

        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = funcionario.Listar();
        }

        private void dgvFuncionario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idDgv;
            string nomeDgv;
            string enderecoDgv;
            string numeroDgv;
            string loginDgv;
            string senhaDgv;
            string cpfDgv;
            string cargoDgv;
            string telefoneDgv;

            // dgvCliente.CurrentRow.Selected = true;

            idDgv = this.dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
            nomeDgv = this.dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            enderecoDgv = this.dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
            numeroDgv = this.dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
            loginDgv = this.dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            senhaDgv = this.dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
            cpfDgv = this.dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
            cargoDgv = this.dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
            telefoneDgv = this.dgvFuncionario.CurrentRow.Cells[8].Value.ToString();


            using (Formularios.frmAddFuncionario abn = new Formularios.frmAddFuncionario())
            {
                abn.RecebendoValorDgv(idDgv, nomeDgv, enderecoDgv, numeroDgv, telefoneDgv, cpfDgv, cargoDgv, loginDgv, senhaDgv);
                abn.ShowDialog();

            }
        }
    }
}
