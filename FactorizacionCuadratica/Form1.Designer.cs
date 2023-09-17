namespace FactorizacionCuadratica
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLimpiar = new Guna.UI.WinForms.GunaButton();
            this.txtCoeficienteA = new Guna.UI.WinForms.GunaTextBox();
            this.txtCoeficienteB = new Guna.UI.WinForms.GunaTextBox();
            this.txtCoeficienteC = new Guna.UI.WinForms.GunaTextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.btnSalir = new Guna.UI.WinForms.GunaButton();
            this.btnCalcular = new Guna.UI.WinForms.GunaButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AnimationHoverSpeed = 0.07F;
            this.btnLimpiar.AnimationSpeed = 0.03F;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiar.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiar.Location = new System.Drawing.Point(57, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiar.OnHoverImage = null;
            this.btnLimpiar.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiar.Radius = 5;
            this.btnLimpiar.Size = new System.Drawing.Size(135, 51);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCoeficienteA
            // 
            this.txtCoeficienteA.BackColor = System.Drawing.Color.Transparent;
            this.txtCoeficienteA.BaseColor = System.Drawing.Color.White;
            this.txtCoeficienteA.BorderColor = System.Drawing.Color.Silver;
            this.txtCoeficienteA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoeficienteA.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCoeficienteA.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCoeficienteA.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCoeficienteA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCoeficienteA.Location = new System.Drawing.Point(25, 114);
            this.txtCoeficienteA.Name = "txtCoeficienteA";
            this.txtCoeficienteA.PasswordChar = '\0';
            this.txtCoeficienteA.Radius = 5;
            this.txtCoeficienteA.Size = new System.Drawing.Size(160, 30);
            this.txtCoeficienteA.TabIndex = 6;
            // 
            // txtCoeficienteB
            // 
            this.txtCoeficienteB.BackColor = System.Drawing.Color.Transparent;
            this.txtCoeficienteB.BaseColor = System.Drawing.Color.White;
            this.txtCoeficienteB.BorderColor = System.Drawing.Color.Silver;
            this.txtCoeficienteB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoeficienteB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCoeficienteB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCoeficienteB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCoeficienteB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCoeficienteB.Location = new System.Drawing.Point(25, 166);
            this.txtCoeficienteB.Name = "txtCoeficienteB";
            this.txtCoeficienteB.PasswordChar = '\0';
            this.txtCoeficienteB.Radius = 5;
            this.txtCoeficienteB.Size = new System.Drawing.Size(160, 30);
            this.txtCoeficienteB.TabIndex = 7;
            // 
            // txtCoeficienteC
            // 
            this.txtCoeficienteC.BackColor = System.Drawing.Color.Transparent;
            this.txtCoeficienteC.BaseColor = System.Drawing.Color.White;
            this.txtCoeficienteC.BorderColor = System.Drawing.Color.Silver;
            this.txtCoeficienteC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoeficienteC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCoeficienteC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCoeficienteC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCoeficienteC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCoeficienteC.Location = new System.Drawing.Point(25, 224);
            this.txtCoeficienteC.Name = "txtCoeficienteC";
            this.txtCoeficienteC.PasswordChar = '\0';
            this.txtCoeficienteC.Radius = 5;
            this.txtCoeficienteC.Size = new System.Drawing.Size(160, 30);
            this.txtCoeficienteC.TabIndex = 8;
            this.txtCoeficienteC.TextChanged += new System.EventHandler(this.txtCoeficienteC_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(207, 174);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(0, 13);
            this.txtResultado.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.AnimationHoverSpeed = 0.07F;
            this.btnSalir.AnimationSpeed = 0.03F;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSalir.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalir.Location = new System.Drawing.Point(395, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSalir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalir.OnHoverImage = null;
            this.btnSalir.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalir.Radius = 5;
            this.btnSalir.Size = new System.Drawing.Size(135, 51);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AnimationHoverSpeed = 0.07F;
            this.btnCalcular.AnimationSpeed = 0.03F;
            this.btnCalcular.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCalcular.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalcular.FocusedColor = System.Drawing.Color.Empty;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCalcular.Location = new System.Drawing.Point(225, 350);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCalcular.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalcular.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalcular.OnHoverImage = null;
            this.btnCalcular.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalcular.Size = new System.Drawing.Size(135, 51);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(141, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(303, 32);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "EXPRESIÓN CUADRATICA";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(198, 406);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(189, 15);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Create by: Yael Moises May Caamal";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 430);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCoeficienteC);
            this.Controls.Add(this.txtCoeficienteB);
            this.Controls.Add(this.txtCoeficienteA);
            this.Controls.Add(this.btnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorizacion Cuadratica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnLimpiar;
        private Guna.UI.WinForms.GunaTextBox txtCoeficienteA;
        private Guna.UI.WinForms.GunaTextBox txtCoeficienteB;
        private Guna.UI.WinForms.GunaTextBox txtCoeficienteC;
        private System.Windows.Forms.Label txtResultado;
        private Guna.UI.WinForms.GunaButton btnSalir;
        private Guna.UI.WinForms.GunaButton btnCalcular;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}

