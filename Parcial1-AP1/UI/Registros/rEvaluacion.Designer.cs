namespace Parcial1_AP1.UI.Registros
{
    partial class rEvaluacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEvaluacion));
            this.IDEvaluacionlabel = new System.Windows.Forms.Label();
            this.IDEvaluacionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.EstudiantetextBox = new System.Windows.Forms.TextBox();
            this.CalificaciongroupBox = new System.Windows.Forms.GroupBox();
            this.LogradotextBox = new System.Windows.Forms.TextBox();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.Menoslabel = new System.Windows.Forms.Label();
            this.Guionlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logradolabel = new System.Windows.Forms.Label();
            this.Valorlabel = new System.Windows.Forms.Label();
            this.PerdidotextBox = new System.Windows.Forms.TextBox();
            this.PronosticocomboBox = new System.Windows.Forms.ComboBox();
            this.Pronosticolabel = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Gurdarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDEvaluacionnumericUpDown)).BeginInit();
            this.CalificaciongroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDEvaluacionlabel
            // 
            this.IDEvaluacionlabel.AutoSize = true;
            this.IDEvaluacionlabel.Location = new System.Drawing.Point(28, 26);
            this.IDEvaluacionlabel.Name = "IDEvaluacionlabel";
            this.IDEvaluacionlabel.Size = new System.Drawing.Size(18, 13);
            this.IDEvaluacionlabel.TabIndex = 0;
            this.IDEvaluacionlabel.Text = "ID";
            // 
            // IDEvaluacionnumericUpDown
            // 
            this.IDEvaluacionnumericUpDown.Location = new System.Drawing.Point(109, 19);
            this.IDEvaluacionnumericUpDown.Name = "IDEvaluacionnumericUpDown";
            this.IDEvaluacionnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IDEvaluacionnumericUpDown.TabIndex = 1;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(323, 21);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(366, 16);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.FechadateTimePicker.TabIndex = 2;
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Location = new System.Drawing.Point(28, 75);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(57, 13);
            this.Estudiantelabel.TabIndex = 0;
            this.Estudiantelabel.Text = "Estudiante";
            // 
            // EstudiantetextBox
            // 
            this.EstudiantetextBox.Location = new System.Drawing.Point(109, 68);
            this.EstudiantetextBox.Name = "EstudiantetextBox";
            this.EstudiantetextBox.Size = new System.Drawing.Size(256, 20);
            this.EstudiantetextBox.TabIndex = 3;
            // 
            // CalificaciongroupBox
            // 
            this.CalificaciongroupBox.Controls.Add(this.LogradotextBox);
            this.CalificaciongroupBox.Controls.Add(this.ValortextBox);
            this.CalificaciongroupBox.Controls.Add(this.Menoslabel);
            this.CalificaciongroupBox.Controls.Add(this.Guionlabel);
            this.CalificaciongroupBox.Controls.Add(this.label1);
            this.CalificaciongroupBox.Controls.Add(this.Logradolabel);
            this.CalificaciongroupBox.Controls.Add(this.Valorlabel);
            this.CalificaciongroupBox.Controls.Add(this.PerdidotextBox);
            this.CalificaciongroupBox.Location = new System.Drawing.Point(31, 120);
            this.CalificaciongroupBox.Name = "CalificaciongroupBox";
            this.CalificaciongroupBox.Size = new System.Drawing.Size(334, 94);
            this.CalificaciongroupBox.TabIndex = 4;
            this.CalificaciongroupBox.TabStop = false;
            this.CalificaciongroupBox.Text = "Calificación Tareas y Parcial";
            // 
            // LogradotextBox
            // 
            this.LogradotextBox.Location = new System.Drawing.Point(107, 47);
            this.LogradotextBox.Name = "LogradotextBox";
            this.LogradotextBox.Size = new System.Drawing.Size(44, 20);
            this.LogradotextBox.TabIndex = 5;
            this.LogradotextBox.TextChanged += new System.EventHandler(this.LogradotextBox_TextChanged);
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(10, 48);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(44, 20);
            this.ValortextBox.TabIndex = 5;
            // 
            // Menoslabel
            // 
            this.Menoslabel.AutoSize = true;
            this.Menoslabel.Location = new System.Drawing.Point(75, 51);
            this.Menoslabel.Name = "Menoslabel";
            this.Menoslabel.Size = new System.Drawing.Size(10, 13);
            this.Menoslabel.TabIndex = 4;
            this.Menoslabel.Text = "-";
            // 
            // Guionlabel
            // 
            this.Guionlabel.AutoSize = true;
            this.Guionlabel.Location = new System.Drawing.Point(169, 50);
            this.Guionlabel.Name = "Guionlabel";
            this.Guionlabel.Size = new System.Drawing.Size(13, 13);
            this.Guionlabel.TabIndex = 0;
            this.Guionlabel.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perdido";
            // 
            // Logradolabel
            // 
            this.Logradolabel.AutoSize = true;
            this.Logradolabel.Location = new System.Drawing.Point(105, 31);
            this.Logradolabel.Name = "Logradolabel";
            this.Logradolabel.Size = new System.Drawing.Size(46, 13);
            this.Logradolabel.TabIndex = 0;
            this.Logradolabel.Text = "Logrado";
            // 
            // Valorlabel
            // 
            this.Valorlabel.AutoSize = true;
            this.Valorlabel.Location = new System.Drawing.Point(7, 31);
            this.Valorlabel.Name = "Valorlabel";
            this.Valorlabel.Size = new System.Drawing.Size(31, 13);
            this.Valorlabel.TabIndex = 0;
            this.Valorlabel.Text = "Valor";
            // 
            // PerdidotextBox
            // 
            this.PerdidotextBox.Location = new System.Drawing.Point(201, 47);
            this.PerdidotextBox.Name = "PerdidotextBox";
            this.PerdidotextBox.ReadOnly = true;
            this.PerdidotextBox.Size = new System.Drawing.Size(63, 20);
            this.PerdidotextBox.TabIndex = 3;
            // 
            // PronosticocomboBox
            // 
            this.PronosticocomboBox.FormattingEnabled = true;
            this.PronosticocomboBox.Items.AddRange(new object[] {
            "Continuar",
            "Suspenso",
            "Retirar"});
            this.PronosticocomboBox.Location = new System.Drawing.Point(31, 259);
            this.PronosticocomboBox.Name = "PronosticocomboBox";
            this.PronosticocomboBox.Size = new System.Drawing.Size(121, 21);
            this.PronosticocomboBox.TabIndex = 5;
            // 
            // Pronosticolabel
            // 
            this.Pronosticolabel.AutoSize = true;
            this.Pronosticolabel.Location = new System.Drawing.Point(28, 231);
            this.Pronosticolabel.Name = "Pronosticolabel";
            this.Pronosticolabel.Size = new System.Drawing.Size(118, 13);
            this.Pronosticolabel.TabIndex = 0;
            this.Pronosticolabel.Text = "Por como vas deberias:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(31, 306);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(115, 57);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Gurdarbutton
            // 
            this.Gurdarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gurdarbutton.Image")));
            this.Gurdarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gurdarbutton.Location = new System.Drawing.Point(203, 306);
            this.Gurdarbutton.Name = "Gurdarbutton";
            this.Gurdarbutton.Size = new System.Drawing.Size(105, 57);
            this.Gurdarbutton.TabIndex = 7;
            this.Gurdarbutton.Text = "Guardar";
            this.Gurdarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gurdarbutton.UseVisualStyleBackColor = true;
            this.Gurdarbutton.Click += new System.EventHandler(this.Gurdarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(357, 306);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(101, 57);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(242, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 375);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Gurdarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.PronosticocomboBox);
            this.Controls.Add(this.CalificaciongroupBox);
            this.Controls.Add(this.EstudiantetextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IDEvaluacionnumericUpDown);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Pronosticolabel);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.IDEvaluacionlabel);
            this.MaximizeBox = false;
            this.Name = "rEvaluacion";
            this.Text = "Registro de Evaluación";
            ((System.ComponentModel.ISupportInitialize)(this.IDEvaluacionnumericUpDown)).EndInit();
            this.CalificaciongroupBox.ResumeLayout(false);
            this.CalificaciongroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDEvaluacionlabel;
        private System.Windows.Forms.NumericUpDown IDEvaluacionnumericUpDown;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.TextBox EstudiantetextBox;
        private System.Windows.Forms.GroupBox CalificaciongroupBox;
        private System.Windows.Forms.Label Valorlabel;
        private System.Windows.Forms.Label Guionlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Logradolabel;
        private System.Windows.Forms.TextBox PerdidotextBox;
        private System.Windows.Forms.ComboBox PronosticocomboBox;
        private System.Windows.Forms.Label Pronosticolabel;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Gurdarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label Menoslabel;
        private System.Windows.Forms.TextBox LogradotextBox;
        private System.Windows.Forms.TextBox ValortextBox;
    }
}