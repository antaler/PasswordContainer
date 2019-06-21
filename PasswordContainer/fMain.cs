﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordContainer
{
    public partial class fMain : Form
    {

        private ContenedorCuentas cuentas;


        public fMain(CuentaLoginApp cuenta)
        {
            //cuentas = ManejoFicheros.CargarCuentasApp(cuenta);
            cuentas = new ContenedorCuentas();
            cuentas.Add(new CuentaApp("Facebook 1", "Facebook", new Usuario("PAcoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            cuentas.Add(new CuentaApp("Facebook 2", "Facebook", new Usuario("PAacoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            cuentas.Add(new CuentaApp("Facebook 3", "Facebook", new Usuario("PAaaaacoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            cuentas.Add(new CuentaApp("Facebook 4", "Facebook", new Usuario("PAaasaacoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            cuentas.Add(new CuentaApp("Facebook 5", "Facebook", new Usuario("PAaasaacoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            cuentas.Add(new CuentaApp("Facebook 6", "Facebook", new Usuario("PAasaacoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            cuentas.Add(new CuentaApp("Facebook 7", "Facebook", new Usuario("PAaaaaacoGarcia@gmail.com"), new PasswordCuenta("antonio!")));
            InitializeComponent();
            
        }

        private void BtnAniadir_Click(object sender, EventArgs e)
        {
            fAniadir fAniadir = new fAniadir();
            fAniadir.ShowDialog();
            if (!BufferCuentaApp.HayCuenta)
            { 
                return;
            }
            cuentas.Add(BufferCuentaApp.extraerCuentaApp());

        }

        private void FMain_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FMain_Load(sender, e);
        }
       
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            if (cuentas.size() == 0)
            {
                MessageBox.Show("No hay ninguna cuenta guardada");
                return;
            }
            CuentaApp cuenta = cuentaSeleccionada();
            mostrarCuenta(cuenta);
            if (cuentas.remove(cuenta))
            {
                MessageBox.Show("Cuenta eliminada.\nSe muestra a continuacion");
            }
            else
            {
                MessageBox.Show("Cuenta No eliminada.");
            }


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDocumento_Click(object sender, EventArgs e)
        {
            ManejoFicheros.generartxtCuentas();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

            
            if (cuentas.size() == 0)
            {
                MessageBox.Show("No hay ninguna cuenta guardada");
                return;
            }
            mostrarCuenta(cuentaSeleccionada());
            
            
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = !textPassword.UseSystemPasswordChar;
            if (textPassword.UseSystemPasswordChar)
            {
                btnVer.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btnVer.FlatAppearance.BorderSize = 1;
            }
        }

        private CuentaApp cuentaSeleccionada()
        {
            if (cuentas.size() == 0)
            {
               
                return null;
            }
            fSeleccionar fSelect = new fSeleccionar(cuentas.GetCuentaApps());
            fSelect.ShowDialog();
            return BufferCuentaApp.extraerCuentaApp();
        }

        private void mostrarCuenta(CuentaApp cuenta)
        {
            if (cuenta == null) return;
            lblNombreCuenta.Text = "Cuenta " + cuenta.NombreCuenta;
            textUser.Text = cuenta.GetUsuario().User;
            textPassword.Text = cuenta.GetPassword();
        }
    }
}
