
namespace CalendarioPrestamo.Formularios
{
    partial class NewFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.interpagado = new System.Windows.Forms.NumericUpDown();
            this.princpagado = new System.Windows.Forms.NumericUpDown();
            this.cuotpagada = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.estado = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.canc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechavencimientos = new System.Windows.Forms.DateTimePicker();
            this.tasa = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.terminos = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.interpagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.princpagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotpagada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuota pagada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interes Pagado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Principal Pagado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // interpagado
            // 
            this.interpagado.DecimalPlaces = 2;
            this.interpagado.Location = new System.Drawing.Point(128, 197);
            this.interpagado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.interpagado.Name = "interpagado";
            this.interpagado.Size = new System.Drawing.Size(120, 20);
            this.interpagado.TabIndex = 8;
            // 
            // princpagado
            // 
            this.princpagado.DecimalPlaces = 2;
            this.princpagado.Location = new System.Drawing.Point(128, 134);
            this.princpagado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.princpagado.Name = "princpagado";
            this.princpagado.Size = new System.Drawing.Size(120, 20);
            this.princpagado.TabIndex = 9;
            // 
            // cuotpagada
            // 
            this.cuotpagada.DecimalPlaces = 2;
            this.cuotpagada.Location = new System.Drawing.Point(128, 246);
            this.cuotpagada.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cuotpagada.Name = "cuotpagada";
            this.cuotpagada.Size = new System.Drawing.Size(120, 20);
            this.cuotpagada.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Pendiente",
            "Pagado",
            "Eliminado"});
            this.estado.Location = new System.Drawing.Point(128, 86);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 21);
            this.estado.TabIndex = 13;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(3, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 50);
            this.Ok.TabIndex = 14;
            this.Ok.Text = "Aceptar";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // canc
            // 
            this.canc.Location = new System.Drawing.Point(109, 3);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(100, 50);
            this.canc.TabIndex = 15;
            this.canc.Text = "Cancelar";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tasa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de vencimiento:";
            // 
            // fechavencimientos
            // 
            this.fechavencimientos.Location = new System.Drawing.Point(470, 24);
            this.fechavencimientos.Name = "fechavencimientos";
            this.fechavencimientos.Size = new System.Drawing.Size(200, 20);
            this.fechavencimientos.TabIndex = 18;
            // 
            // tasa
            // 
            this.tasa.DecimalPlaces = 2;
            this.tasa.Location = new System.Drawing.Point(470, 87);
            this.tasa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tasa.Name = "tasa";
            this.tasa.Size = new System.Drawing.Size(120, 20);
            this.tasa.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto del prestamo:";
            // 
            // monto
            // 
            this.monto.DecimalPlaces = 2;
            this.monto.Location = new System.Drawing.Point(470, 129);
            this.monto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(120, 20);
            this.monto.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Terminos:";
            // 
            // terminos
            // 
            this.terminos.DecimalPlaces = 2;
            this.terminos.Location = new System.Drawing.Point(470, 197);
            this.terminos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.terminos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.terminos.Name = "terminos";
            this.terminos.Size = new System.Drawing.Size(120, 20);
            this.terminos.TabIndex = 24;
            this.terminos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Ok);
            this.flowLayoutPanel1.Controls.Add(this.canc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 320);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 56);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // NewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 388);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.terminos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tasa);
            this.Controls.Add(this.fechavencimientos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cuotpagada);
            this.Controls.Add(this.princpagado);
            this.Controls.Add(this.interpagado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewFrm";
            this.Text = "NewFrm";
            ((System.ComponentModel.ISupportInitialize)(this.interpagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.princpagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotpagada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown interpagado;
        private System.Windows.Forms.NumericUpDown princpagado;
        private System.Windows.Forms.NumericUpDown cuotpagada;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechavencimientos;
        private System.Windows.Forms.NumericUpDown tasa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown monto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown terminos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}