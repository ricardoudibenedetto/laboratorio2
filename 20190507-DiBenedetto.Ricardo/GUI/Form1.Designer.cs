namespace GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudMemoria = new System.Windows.Forms.NumericUpDown();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.rtxtSystemInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.nudMemoria);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Placa de Video";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(203, 106);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudMemoria
            // 
            this.nudMemoria.Location = new System.Drawing.Point(85, 80);
            this.nudMemoria.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMemoria.Name = "nudMemoria";
            this.nudMemoria.Size = new System.Drawing.Size(193, 20);
            this.nudMemoria.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(85, 46);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(193, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(85, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(193, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Memoria (MB)";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(7, 49);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(7, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(153, 169);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(166, 23);
            this.btnSystemInfo.TabIndex = 8;
            this.btnSystemInfo.Text = "System info";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // rtxtSystemInfo
            // 
            this.rtxtSystemInfo.Location = new System.Drawing.Point(22, 198);
            this.rtxtSystemInfo.Name = "rtxtSystemInfo";
            this.rtxtSystemInfo.Size = new System.Drawing.Size(297, 150);
            this.rtxtSystemInfo.TabIndex = 9;
            this.rtxtSystemInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.rtxtSystemInfo);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Di Benedetto Ricardo 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSacar;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.NumericUpDown nudMemoria;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblModelo;
    private System.Windows.Forms.Label lblMarca;
    private System.Windows.Forms.Button btnSystemInfo;
    private System.Windows.Forms.RichTextBox rtxtSystemInfo;
  }
}

