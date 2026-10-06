namespace pryFernandezGimnasio
{
    partial class frmInscripción
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
            groupBoxDatosPersonales = new GroupBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            chkEstudiante = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            gropuBoxPlan = new GroupBox();
            chkCasillero = new CheckBox();
            textBox3 = new TextBox();
            lblMeses = new Label();
            lblTurno = new Label();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            lblPlan = new Label();
            cboPago = new GroupBox();
            lblCuotas = new Label();
            comboBox1 = new ComboBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            groupBoxDatosPersonales.SuspendLayout();
            gropuBoxPlan.SuspendLayout();
            cboPago.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDatosPersonales
            // 
            groupBoxDatosPersonales.Controls.Add(txtApellido);
            groupBoxDatosPersonales.Controls.Add(lblApellido);
            groupBoxDatosPersonales.Controls.Add(chkEstudiante);
            groupBoxDatosPersonales.Controls.Add(textBox2);
            groupBoxDatosPersonales.Controls.Add(textBox1);
            groupBoxDatosPersonales.Controls.Add(lblEdad);
            groupBoxDatosPersonales.Controls.Add(lblNombre);
            groupBoxDatosPersonales.Location = new Point(25, 12);
            groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            groupBoxDatosPersonales.Size = new Size(444, 153);
            groupBoxDatosPersonales.TabIndex = 0;
            groupBoxDatosPersonales.TabStop = false;
            groupBoxDatosPersonales.Text = "Datos Personales";
            groupBoxDatosPersonales.Enter += groupBox1_Enter;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(315, 46);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(118, 27);
            txtApellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(239, 49);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(239, 92);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(100, 24);
            chkEstudiante.TabIndex = 6;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 27);
            textBox1.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(39, 92);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // gropuBoxPlan
            // 
            gropuBoxPlan.Controls.Add(chkCasillero);
            gropuBoxPlan.Controls.Add(textBox3);
            gropuBoxPlan.Controls.Add(lblMeses);
            gropuBoxPlan.Controls.Add(lblTurno);
            gropuBoxPlan.Controls.Add(cboTurno);
            gropuBoxPlan.Controls.Add(cboPlan);
            gropuBoxPlan.Controls.Add(lblPlan);
            gropuBoxPlan.Location = new Point(25, 171);
            gropuBoxPlan.Name = "gropuBoxPlan";
            gropuBoxPlan.Size = new Size(444, 145);
            gropuBoxPlan.TabIndex = 1;
            gropuBoxPlan.TabStop = false;
            gropuBoxPlan.Text = "Plan";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(239, 93);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(182, 24);
            chkCasillero.TabIndex = 6;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 92);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 27);
            textBox3.TabIndex = 5;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(39, 95);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(36, 20);
            lblMeses.TabIndex = 4;
            lblMeses.Text = "Mes";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(239, 43);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(47, 20);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana ", "Tarde", "Noche " });
            cboTurno.Location = new Point(315, 40);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(118, 28);
            cboTurno.TabIndex = 2;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "", "", "Funcional", "", "", "Natación" });
            cboPlan.Location = new Point(101, 37);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(118, 28);
            cboPlan.TabIndex = 2;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(32, 40);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // cboPago
            // 
            cboPago.Controls.Add(lblCuotas);
            cboPago.Controls.Add(comboBox1);
            cboPago.Controls.Add(rbtTarjeta);
            cboPago.Controls.Add(rbtEfectivo);
            cboPago.Location = new Point(25, 322);
            cboPago.Name = "cboPago";
            cboPago.Size = new Size(444, 107);
            cboPago.TabIndex = 2;
            cboPago.TabStop = false;
            cboPago.Text = "Forma de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(239, 49);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(54, 20);
            lblCuotas.TabIndex = 4;
            lblCuotas.Text = "Cuotas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1  ", "3", "6 " });
            comboBox1.Location = new Point(323, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 28);
            comboBox1.TabIndex = 2;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(128, 47);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(74, 24);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(18, 47);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(83, 24);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(133, 443);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(264, 443);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmInscripción
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 484);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cboPago);
            Controls.Add(gropuBoxPlan);
            Controls.Add(groupBoxDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción ";
            groupBoxDatosPersonales.ResumeLayout(false);
            groupBoxDatosPersonales.PerformLayout();
            gropuBoxPlan.ResumeLayout(false);
            gropuBoxPlan.PerformLayout();
            cboPago.ResumeLayout(false);
            cboPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDatosPersonales;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private CheckBox chkEstudiante;
        private GroupBox gropuBoxPlan;
        private ComboBox cboPlan;
        private Label lblPlan;
        private ComboBox comboBox1;
        private ComboBox cboTurno;
        private CheckBox chkCasillero;
        private TextBox textBox3;
        private Label lblMeses;
        private Label lblTurno;
        private GroupBox cboPago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Label lblCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
