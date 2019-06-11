namespace ejercicioWFhilos
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
            this.components = new System.ComponentModel.Container();
            this.txtCountUno = new System.Windows.Forms.TextBox();
            this.txtCountDos = new System.Windows.Forms.TextBox();
            this.txtCountTres = new System.Windows.Forms.TextBox();
            this.txtCountCuatro = new System.Windows.Forms.TextBox();
            this.btnCountUno = new System.Windows.Forms.Button();
            this.btnCountDos = new System.Windows.Forms.Button();
            this.btnCountTres = new System.Windows.Forms.Button();
            this.btnCountCuatro = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtCountUno
            // 
            this.txtCountUno.Location = new System.Drawing.Point(12, 29);
            this.txtCountUno.Name = "txtCountUno";
            this.txtCountUno.Size = new System.Drawing.Size(100, 20);
            this.txtCountUno.TabIndex = 0;
            // 
            // txtCountDos
            // 
            this.txtCountDos.Location = new System.Drawing.Point(118, 29);
            this.txtCountDos.Name = "txtCountDos";
            this.txtCountDos.Size = new System.Drawing.Size(100, 20);
            this.txtCountDos.TabIndex = 1;
            // 
            // txtCountTres
            // 
            this.txtCountTres.Location = new System.Drawing.Point(224, 29);
            this.txtCountTres.Name = "txtCountTres";
            this.txtCountTres.Size = new System.Drawing.Size(100, 20);
            this.txtCountTres.TabIndex = 2;
            // 
            // txtCountCuatro
            // 
            this.txtCountCuatro.Location = new System.Drawing.Point(330, 29);
            this.txtCountCuatro.Name = "txtCountCuatro";
            this.txtCountCuatro.Size = new System.Drawing.Size(100, 20);
            this.txtCountCuatro.TabIndex = 3;
            // 
            // btnCountUno
            // 
            this.btnCountUno.Location = new System.Drawing.Point(13, 86);
            this.btnCountUno.Name = "btnCountUno";
            this.btnCountUno.Size = new System.Drawing.Size(99, 23);
            this.btnCountUno.TabIndex = 4;
            this.btnCountUno.Text = "1";
            this.btnCountUno.UseVisualStyleBackColor = true;
            this.btnCountUno.Click += new System.EventHandler(this.btnCountUno_Click);
            // 
            // btnCountDos
            // 
            this.btnCountDos.Location = new System.Drawing.Point(118, 86);
            this.btnCountDos.Name = "btnCountDos";
            this.btnCountDos.Size = new System.Drawing.Size(99, 23);
            this.btnCountDos.TabIndex = 5;
            this.btnCountDos.Text = "2";
            this.btnCountDos.UseVisualStyleBackColor = true;
            // 
            // btnCountTres
            // 
            this.btnCountTres.Location = new System.Drawing.Point(224, 86);
            this.btnCountTres.Name = "btnCountTres";
            this.btnCountTres.Size = new System.Drawing.Size(99, 23);
            this.btnCountTres.TabIndex = 6;
            this.btnCountTres.Text = "3";
            this.btnCountTres.UseVisualStyleBackColor = true;
            // 
            // btnCountCuatro
            // 
            this.btnCountCuatro.Location = new System.Drawing.Point(329, 86);
            this.btnCountCuatro.Name = "btnCountCuatro";
            this.btnCountCuatro.Size = new System.Drawing.Size(99, 23);
            this.btnCountCuatro.TabIndex = 7;
            this.btnCountCuatro.Text = "4";
            this.btnCountCuatro.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 158);
            this.Controls.Add(this.btnCountCuatro);
            this.Controls.Add(this.btnCountTres);
            this.Controls.Add(this.btnCountDos);
            this.Controls.Add(this.btnCountUno);
            this.Controls.Add(this.txtCountCuatro);
            this.Controls.Add(this.txtCountTres);
            this.Controls.Add(this.txtCountDos);
            this.Controls.Add(this.txtCountUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtCountUno;
    private System.Windows.Forms.TextBox txtCountDos;
    private System.Windows.Forms.TextBox txtCountTres;
    private System.Windows.Forms.TextBox txtCountCuatro;
    private System.Windows.Forms.Button btnCountUno;
    private System.Windows.Forms.Button btnCountDos;
    private System.Windows.Forms.Button btnCountTres;
    private System.Windows.Forms.Button btnCountCuatro;
    private System.Windows.Forms.Timer timer1;
  }
}

