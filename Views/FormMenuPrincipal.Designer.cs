﻿using System;

namespace PSI_DA_PL1_F.Views
{
    partial class FormMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.clienteTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.settingsTransition = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.professorMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Professor = new System.Windows.Forms.Button();
            this.btnFormMultas = new System.Windows.Forms.Button();
            this.btnFormMenuRefeicao = new System.Windows.Forms.Button();
            this.estudanteMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFormCliente = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.btnReservarRefeicao = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.btnFormExtras = new System.Windows.Forms.Button();
            this.btnFormPratos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.estudanteMenu.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panelShowForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteTransition
            // 
            this.clienteTransition.Interval = 10;
            this.clienteTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // settingsTransition
            // 
            this.settingsTransition.Interval = 10;
            this.settingsTransition.Tick += new System.EventHandler(this.settingsTransition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "iCantina";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.MinimumSize = new System.Drawing.Size(112, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(3, 5);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 34);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // professorMenu
            // 
            this.professorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.professorMenu.Location = new System.Drawing.Point(3, 94);
            this.professorMenu.Name = "professorMenu";
            this.professorMenu.Size = new System.Drawing.Size(233, 85);
            this.professorMenu.TabIndex = 10;
            // 
            // Professor
            // 
            this.Professor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.Professor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Professor.ForeColor = System.Drawing.SystemColors.Window;
            this.Professor.Image = ((System.Drawing.Image)(resources.GetObject("Professor.Image")));
            this.Professor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Professor.Location = new System.Drawing.Point(123, -8);
            this.Professor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Professor.Name = "Professor";
            this.Professor.Size = new System.Drawing.Size(230, 76);
            this.Professor.TabIndex = 5;
            this.Professor.Text = "                       Opções";
            this.Professor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Professor.UseVisualStyleBackColor = false;
            this.Professor.Click += new System.EventHandler(this.Settings_Click);
            // 
            // btnFormMultas
            // 
            this.btnFormMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnFormMultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormMultas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFormMultas.Image = ((System.Drawing.Image)(resources.GetObject("btnFormMultas.Image")));
            this.btnFormMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMultas.Location = new System.Drawing.Point(123, 160);
            this.btnFormMultas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormMultas.Name = "btnFormMultas";
            this.btnFormMultas.Size = new System.Drawing.Size(230, 76);
            this.btnFormMultas.TabIndex = 4;
            this.btnFormMultas.Text = "                       Multas";
            this.btnFormMultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMultas.UseVisualStyleBackColor = false;
            // 
            // btnFormMenuRefeicao
            // 
            this.btnFormMenuRefeicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnFormMenuRefeicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormMenuRefeicao.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFormMenuRefeicao.Image = ((System.Drawing.Image)(resources.GetObject("btnFormMenuRefeicao.Image")));
            this.btnFormMenuRefeicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMenuRefeicao.Location = new System.Drawing.Point(123, 244);
            this.btnFormMenuRefeicao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormMenuRefeicao.Name = "btnFormMenuRefeicao";
            this.btnFormMenuRefeicao.Size = new System.Drawing.Size(230, 76);
            this.btnFormMenuRefeicao.TabIndex = 6;
            this.btnFormMenuRefeicao.Text = "                       Menu Refeições";
            this.btnFormMenuRefeicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMenuRefeicao.UseVisualStyleBackColor = false;
            // 
            // estudanteMenu
            // 
            this.estudanteMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.estudanteMenu.Controls.Add(this.Clientes);
            this.estudanteMenu.Controls.Add(this.btnReservarRefeicao);
            this.estudanteMenu.Controls.Add(this.btnFormCliente);
            this.estudanteMenu.Location = new System.Drawing.Point(3, 3);
            this.estudanteMenu.Name = "estudanteMenu";
            this.estudanteMenu.Size = new System.Drawing.Size(233, 85);
            this.estudanteMenu.TabIndex = 9;
            // 
            // btnFormCliente
            // 
            this.btnFormCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnFormCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFormCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnFormCliente.Image")));
            this.btnFormCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormCliente.Location = new System.Drawing.Point(3, 172);
            this.btnFormCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormCliente.Name = "btnFormCliente";
            this.btnFormCliente.Size = new System.Drawing.Size(230, 76);
            this.btnFormCliente.TabIndex = 6;
            this.btnFormCliente.Text = "                  Opções Clientes";
            this.btnFormCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormCliente.UseVisualStyleBackColor = false;
            this.btnFormCliente.Click += new System.EventHandler(this.btnFormClientes);
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Clientes.ForeColor = System.Drawing.SystemColors.Window;
            this.Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Clientes.Image")));
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(3, 4);
            this.Clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(230, 76);
            this.Clientes.TabIndex = 5;
            this.Clientes.Text = "                       Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // btnReservarRefeicao
            // 
            this.btnReservarRefeicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnReservarRefeicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReservarRefeicao.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReservarRefeicao.Image = ((System.Drawing.Image)(resources.GetObject("btnReservarRefeicao.Image")));
            this.btnReservarRefeicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservarRefeicao.Location = new System.Drawing.Point(3, 88);
            this.btnReservarRefeicao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReservarRefeicao.Name = "btnReservarRefeicao";
            this.btnReservarRefeicao.Size = new System.Drawing.Size(230, 76);
            this.btnReservarRefeicao.TabIndex = 7;
            this.btnReservarRefeicao.Text = "                  Reservar Refeição";
            this.btnReservarRefeicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservarRefeicao.UseVisualStyleBackColor = false;
            this.btnReservarRefeicao.Click += new System.EventHandler(this.btnReservarRefeicao_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.sidebar.Controls.Add(this.estudanteMenu);
            this.sidebar.Controls.Add(this.professorMenu);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Enabled = false;
            this.sidebar.Location = new System.Drawing.Point(0, 42);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(237, 687);
            this.sidebar.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 186);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 76);
            this.button4.TabIndex = 4;
            this.button4.Text = "                       Outros";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Image = global::PSI_DA_PL1_F.Properties.Resources.Logout_1_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 270);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(230, 76);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "                       Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelShowForm
            // 
            this.panelShowForm.Controls.Add(this.btnFormPratos);
            this.panelShowForm.Controls.Add(this.btnFormMenuRefeicao);
            this.panelShowForm.Controls.Add(this.btnFormMultas);
            this.panelShowForm.Controls.Add(this.btnFormExtras);
            this.panelShowForm.Controls.Add(this.Professor);
            this.panelShowForm.Location = new System.Drawing.Point(243, 50);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(963, 667);
            this.panelShowForm.TabIndex = 2;
            // 
            // btnFormExtras
            // 
            this.btnFormExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnFormExtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormExtras.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFormExtras.Image = ((System.Drawing.Image)(resources.GetObject("btnFormExtras.Image")));
            this.btnFormExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormExtras.Location = new System.Drawing.Point(123, 76);
            this.btnFormExtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormExtras.Name = "btnFormExtras";
            this.btnFormExtras.Size = new System.Drawing.Size(230, 76);
            this.btnFormExtras.TabIndex = 7;
            this.btnFormExtras.Text = "                       Extras";
            this.btnFormExtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormExtras.UseVisualStyleBackColor = false;
            this.btnFormExtras.Click += new System.EventHandler(this.btnFormExtras_Click);
            // 
            // btnFormPratos
            // 
            this.btnFormPratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.btnFormPratos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormPratos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFormPratos.Image = ((System.Drawing.Image)(resources.GetObject("btnFormPratos.Image")));
            this.btnFormPratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormPratos.Location = new System.Drawing.Point(123, 328);
            this.btnFormPratos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormPratos.Name = "btnFormPratos";
            this.btnFormPratos.Size = new System.Drawing.Size(230, 76);
            this.btnFormPratos.TabIndex = 8;
            this.btnFormPratos.Text = "                       Pratos";
            this.btnFormPratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormPratos.UseVisualStyleBackColor = false;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 729);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.estudanteMenu.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panelShowForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //quando adicionarem coisas dentro desta funcao tirem isto
        }

        #endregion
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer clienteTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer settingsTransition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel professorMenu;
        private System.Windows.Forms.Button Professor;
        private System.Windows.Forms.Button btnFormMultas;
        private System.Windows.Forms.Button btnFormMenuRefeicao;
        private System.Windows.Forms.FlowLayoutPanel estudanteMenu;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button btnFormCliente;
        public System.Windows.Forms.FlowLayoutPanel sidebar;
        public System.Windows.Forms.Panel panelShowForm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReservarRefeicao;
        private System.Windows.Forms.Button btnFormExtras;
        private System.Windows.Forms.Button btnFormPratos;
    }
}

