﻿using Microsoft.VisualBasic.ApplicationServices;
using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
     

    internal class ControllerMenuPrincipal : Controller
    {
        private FormMenuPrincipal formMenuPrincipal;
        private FormFuncionario funcionarioForm;
        private FormClientes formCliente;
        private FormExtras formExtras;

        public ControllerMenuPrincipal(FormMenuPrincipal formMenuPrincipal)
        {
            this.formMenuPrincipal = formMenuPrincipal;

            formMenuPrincipal.sidebar.Enabled = false;
        }

        public void ShowFormFuncionario()
        {
            funcionarioForm = new FormFuncionario(formMenuPrincipal);

            funcionarioForm.TopLevel = false;
            funcionarioForm.AutoScroll = true;

            formMenuPrincipal.panelShowForm.Controls.Add(funcionarioForm);

            funcionarioForm.Show();
        }

        public void ShowFormCliente()
        {
            formCliente = new FormClientes(formMenuPrincipal);

            formCliente.TopLevel = false;
            formCliente.AutoScroll = true;

            formMenuPrincipal.sidebar.Enabled = false;

            formMenuPrincipal.panelShowForm.Controls.Add(formCliente);

            formCliente.Show();
        }

        public void ShowFormExtras()
        {
            formExtras = new FormExtras(formMenuPrincipal);

            formExtras.TopLevel = false;
            formExtras.AutoScroll = true;

            formMenuPrincipal.sidebar.Enabled = false;

            formMenuPrincipal.panelShowForm.Controls.Add(formExtras);

            formExtras.Show();
        }

        public void ShowFormMultas()
        {

        }

        public void ShowFormPratos()
        {

        }

    }
}
