
namespace pSC08
{
    partial class frmPuesto
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDepartamento = new System.Windows.Forms.TextBox();
            this.txtNombreFabrica = new System.Windows.Forms.TextBox();
            this.txtIdFabrica = new System.Windows.Forms.TextBox();
            this.txtNombrePosicion = new System.Windows.Forms.TextBox();
            this.txtIdPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textNombreDepartamento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::pSC08.Properties.Resources.exiticon;
            this.btnSalir.Location = new System.Drawing.Point(937, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 88);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::pSC08.Properties.Resources.deleteicon;
            this.btnBorrar.Location = new System.Drawing.Point(793, 0);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 88);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::pSC08.Properties.Resources.clearicon;
            this.btnLimpiar.Location = new System.Drawing.Point(649, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 88);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 88);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puestos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdDepartamento
            // 
            this.txtIdDepartamento.Location = new System.Drawing.Point(392, 287);
            this.txtIdDepartamento.Multiline = true;
            this.txtIdDepartamento.Name = "txtIdDepartamento";
            this.txtIdDepartamento.Size = new System.Drawing.Size(224, 32);
            this.txtIdDepartamento.TabIndex = 21;
            // 
            // txtNombreFabrica
            // 
            this.txtNombreFabrica.Location = new System.Drawing.Point(392, 247);
            this.txtNombreFabrica.Multiline = true;
            this.txtNombreFabrica.Name = "txtNombreFabrica";
            this.txtNombreFabrica.PasswordChar = '*';
            this.txtNombreFabrica.Size = new System.Drawing.Size(512, 32);
            this.txtNombreFabrica.TabIndex = 20;
            // 
            // txtIdFabrica
            // 
            this.txtIdFabrica.Location = new System.Drawing.Point(392, 207);
            this.txtIdFabrica.Multiline = true;
            this.txtIdFabrica.Name = "txtIdFabrica";
            this.txtIdFabrica.Size = new System.Drawing.Size(224, 32);
            this.txtIdFabrica.TabIndex = 19;
            // 
            // txtNombrePosicion
            // 
            this.txtNombrePosicion.Location = new System.Drawing.Point(392, 167);
            this.txtNombrePosicion.Multiline = true;
            this.txtNombrePosicion.Name = "txtNombrePosicion";
            this.txtNombrePosicion.Size = new System.Drawing.Size(512, 32);
            this.txtNombrePosicion.TabIndex = 18;
            // 
            // txtIdPosition
            // 
            this.txtIdPosition.Location = new System.Drawing.Point(392, 127);
            this.txtIdPosition.Multiline = true;
            this.txtIdPosition.Name = "txtIdPosition";
            this.txtIdPosition.Size = new System.Drawing.Size(224, 32);
            this.txtIdPosition.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID del Departamento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre de la Fabrica";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID de Fabrica";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = " Nombre de la Posición";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID de Posición";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::pSC08.Properties.Resources.saveicon1;
            this.btnGuardar.Location = new System.Drawing.Point(505, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 88);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nombre del Departamento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textNombreDepartamento
            // 
            this.textNombreDepartamento.Location = new System.Drawing.Point(392, 332);
            this.textNombreDepartamento.Multiline = true;
            this.textNombreDepartamento.Name = "textNombreDepartamento";
            this.textNombreDepartamento.PasswordChar = '*';
            this.textNombreDepartamento.Size = new System.Drawing.Size(512, 32);
            this.textNombreDepartamento.TabIndex = 29;
            // 
            // frmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 403);
            this.Controls.Add(this.textNombreDepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdDepartamento);
            this.Controls.Add(this.txtNombreFabrica);
            this.Controls.Add(this.txtIdFabrica);
            this.Controls.Add(this.txtNombrePosicion);
            this.Controls.Add(this.txtIdPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmPuesto";
            this.Text = "frmPuesto";
            this.Load += new System.EventHandler(this.frmPuesto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPuesto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDepartamento;
        private System.Windows.Forms.TextBox txtNombreFabrica;
        private System.Windows.Forms.TextBox txtIdFabrica;
        private System.Windows.Forms.TextBox txtNombrePosicion;
        private System.Windows.Forms.TextBox txtIdPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNombreDepartamento;
    }
}