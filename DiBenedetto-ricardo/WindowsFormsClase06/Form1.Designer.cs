namespace WindowsFormsClase06
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rdoSexoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoSexoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoSexoOtros = new System.Windows.Forms.RadioButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Location = new System.Drawing.Point(48, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellido.Location = new System.Drawing.Point(210, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnContinuar.Location = new System.Drawing.Point(48, 363);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(312, 44);
            this.btnContinuar.TabIndex = 11;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(48, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkEmail.Location = new System.Drawing.Point(48, 133);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(274, 17);
            this.chkEmail.TabIndex = 3;
            this.chkEmail.Text = "Quiero usar mi direccion actual de correo electronico";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(166, 219);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(194, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(48, 257);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // rdoSexoMasculino
            // 
            this.rdoSexoMasculino.AutoSize = true;
            this.rdoSexoMasculino.Location = new System.Drawing.Point(12, 21);
            this.rdoSexoMasculino.Name = "rdoSexoMasculino";
            this.rdoSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoSexoMasculino.TabIndex = 8;
            this.rdoSexoMasculino.TabStop = true;
            this.rdoSexoMasculino.Text = "Masculino";
            this.rdoSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoSexoFemenino
            // 
            this.rdoSexoFemenino.AutoSize = true;
            this.rdoSexoFemenino.Location = new System.Drawing.Point(109, 21);
            this.rdoSexoFemenino.Name = "rdoSexoFemenino";
            this.rdoSexoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdoSexoFemenino.TabIndex = 9;
            this.rdoSexoFemenino.TabStop = true;
            this.rdoSexoFemenino.Text = "Femenino";
            this.rdoSexoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoSexoOtros
            // 
            this.rdoSexoOtros.AutoSize = true;
            this.rdoSexoOtros.Location = new System.Drawing.Point(219, 19);
            this.rdoSexoOtros.Name = "rdoSexoOtros";
            this.rdoSexoOtros.Size = new System.Drawing.Size(50, 17);
            this.rdoSexoOtros.TabIndex = 10;
            this.rdoSexoOtros.TabStop = true;
            this.rdoSexoOtros.Text = "Otros";
            this.rdoSexoOtros.UseVisualStyleBackColor = true;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(154, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(89, 16);
            this.lbltitle.TabIndex = 11;
            this.lbltitle.Text = "Registrarse";
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblsubtitle.Location = new System.Drawing.Point(45, 26);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(236, 13);
            this.lblsubtitle.TabIndex = 12;
            this.lblsubtitle.Text = "Crear una direccion de correo electronico Yahoo";
            // 
            // cmbNumero
            // 
            this.cmbNumero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Items.AddRange(new object[] {
            "+1",
            "+54",
            "+2",
            "+24",
            "+365"});
            this.cmbNumero.Location = new System.Drawing.Point(48, 218);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(112, 21);
            this.cmbNumero.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Direccion de correo electronico";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(45, 202);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(93, 13);
            this.lblCelular.TabIndex = 17;
            this.lblCelular.Text = "Numero de celular";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(48, 179);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(312, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(45, 163);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(67, 13);
            this.lblContraseña.TabIndex = 19;
            this.lblContraseña.Text = "Conteraseña";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(50, 241);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 20;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rdoSexoMasculino);
            this.grbSexo.Controls.Add(this.rdoSexoFemenino);
            this.grbSexo.Controls.Add(this.rdoSexoOtros);
            this.grbSexo.Location = new System.Drawing.Point(48, 283);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(312, 58);
            this.grbSexo.TabIndex = 22;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 419);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.lblsubtitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Pagina de registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.Button btnContinuar;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.CheckBox chkEmail;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    private System.Windows.Forms.RadioButton rdoSexoMasculino;
    private System.Windows.Forms.RadioButton rdoSexoFemenino;
    private System.Windows.Forms.RadioButton rdoSexoOtros;
    private System.Windows.Forms.Label lbltitle;
    private System.Windows.Forms.Label lblsubtitle;
    private System.Windows.Forms.ComboBox cmbNumero;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblCelular;
    private System.Windows.Forms.TextBox txtContraseña;
    private System.Windows.Forms.Label lblContraseña;
    private System.Windows.Forms.Label lblFechaNacimiento;
    private System.Windows.Forms.GroupBox grbSexo;
  }
}

