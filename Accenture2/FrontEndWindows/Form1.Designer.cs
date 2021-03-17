
namespace FrontEndWindows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombe = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnSueldoFinal = new System.Windows.Forms.Button();
            this.lblSueldoFinal = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(105, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INGRESO DE DATOS DE UN EMPLEADO";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDni, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNombe, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSueldo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSueldo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaIngreso, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSueldoFinal, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSueldoFinal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDatos, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDni, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(168, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 305);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(210, 95);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 27);
            this.txtNombre.TabIndex = 8;
            // 
            // lblDni
            // 
            this.lblDni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(111, 13);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(90, 20);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Ingrese DNI:";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(132, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombe
            // 
            this.lblNombe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombe.AutoSize = true;
            this.lblNombe.Location = new System.Drawing.Point(134, 99);
            this.lblNombe.Name = "lblNombe";
            this.lblNombe.Size = new System.Drawing.Size(67, 20);
            this.lblNombe.TabIndex = 2;
            this.lblNombe.Text = "Nombre:";
            this.lblNombe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(98, 142);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha Ingreso:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSueldo
            // 
            this.lblSueldo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(96, 185);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(105, 20);
            this.lblSueldo.TabIndex = 4;
            this.lblSueldo.Text = "Sueldo Basico:";
            this.lblSueldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(210, 52);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 27);
            this.txtApellido.TabIndex = 6;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSueldo.Location = new System.Drawing.Point(210, 181);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(196, 27);
            this.txtSueldo.TabIndex = 9;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(210, 138);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(196, 27);
            this.dtpFechaIngreso.TabIndex = 10;
            // 
            // btnSueldoFinal
            // 
            this.btnSueldoFinal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSueldoFinal.Location = new System.Drawing.Point(6, 267);
            this.btnSueldoFinal.Name = "btnSueldoFinal";
            this.btnSueldoFinal.Size = new System.Drawing.Size(195, 29);
            this.btnSueldoFinal.TabIndex = 11;
            this.btnSueldoFinal.Text = "Ver Sueldo Final";
            this.btnSueldoFinal.UseVisualStyleBackColor = true;
            this.btnSueldoFinal.Click += new System.EventHandler(this.btnSueldoFinal_Click);
            // 
            // lblSueldoFinal
            // 
            this.lblSueldoFinal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSueldoFinal.AutoSize = true;
            this.lblSueldoFinal.Location = new System.Drawing.Point(210, 271);
            this.lblSueldoFinal.Name = "lblSueldoFinal";
            this.lblSueldoFinal.Size = new System.Drawing.Size(96, 20);
            this.lblSueldoFinal.TabIndex = 13;
            this.lblSueldoFinal.Text = "(sueldo final)";
            // 
            // lblDatos
            // 
            this.lblDatos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(210, 228);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(56, 20);
            this.lblDatos.TabIndex = 12;
            this.lblDatos.Text = "(datos)";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(6, 223);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(195, 29);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDni.Location = new System.Drawing.Point(210, 9);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(196, 27);
            this.txtDni.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombe;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnSueldoFinal;
        private System.Windows.Forms.Label lblSueldoFinal;
        private System.Windows.Forms.Label lblDatos;
    }
}

