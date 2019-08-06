﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    [Serializable]
    public class CuentaLoginApp : Cuenta 
    {
        private PasswordLoginApp password;
        public string Fichero { get; private set; }



        public CuentaLoginApp(Usuario usuario, PasswordLoginApp password) : base(usuario)
        {
            this.password = password;
            Fichero = ManejoFicheros.crearNombreFichero();
        }

        public PasswordLoginApp GetPassword()
        {
            return password;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CuentaLoginApp)) return false;
            CuentaLoginApp cuenta = (CuentaLoginApp)obj;
            return cuenta.GetUsuario().User.Equals(GetUsuario().User) && cuenta.GetPassword().Equals(GetPassword());

        }






    }
}
