﻿namespace PasswordContainer
{
    partial class fAniadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAniadir));
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureCaja = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCuenta.Location = new System.Drawing.Point(23, 85);
            this.txtNombreCuenta.MaxLength = 16;
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.Size = new System.Drawing.Size(269, 21);
            this.txtNombreCuenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la cuenta*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario*";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(23, 143);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(269, 21);
            this.txtUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña*";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(23, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureCaja
            // 
            this.pictureCaja.Image = ((System.Drawing.Image)(resources.GetObject("pictureCaja.Image")));
            this.pictureCaja.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureCaja.InitialImage")));
            this.pictureCaja.Location = new System.Drawing.Point(314, 37);
            this.pictureCaja.Name = "pictureCaja";
            this.pictureCaja.Size = new System.Drawing.Size(165, 150);
            this.pictureCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCaja.TabIndex = 8;
            this.pictureCaja.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(314, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 54);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnVer
            // 
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(255, 200);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(37, 23);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "(*) Campos Obligatorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Añadir Cuenta";
            // 
            // fAniadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureCaja);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fAniadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureCaja;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}