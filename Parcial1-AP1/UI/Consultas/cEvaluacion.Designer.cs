namespace Parcial1_AP1.UI.Consultas
{
    partial class cEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEvaluacion));
            this.Desdelabel = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.ConsultardataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(13, 13);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 0;
            this.Desdelabel.Text = "Desde";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(16, 39);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.DesdedateTimePicker.TabIndex = 1;
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Location = new System.Drawing.Point(140, 9);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(35, 13);
            this.Hastalabel.TabIndex = 0;
            this.Hastalabel.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(143, 39);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.HastadateTimePicker.TabIndex = 1;
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Location = new System.Drawing.Point(278, 9);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(29, 13);
            this.Filtrolabel.TabIndex = 0;
            this.Filtrolabel.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Nombre o Estudiante"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(281, 38);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(433, 9);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 0;
            this.Criteriolabel.Text = "Criterio";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(436, 38);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(155, 20);
            this.CriteriotextBox.TabIndex = 3;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Consultarbutton.Image")));
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(607, 34);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(80, 23);
            this.Consultarbutton.TabIndex = 4;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // ConsultardataGridView
            // 
            this.ConsultardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultardataGridView.Location = new System.Drawing.Point(16, 78);
            this.ConsultardataGridView.Name = "ConsultardataGridView";
            this.ConsultardataGridView.ReadOnly = true;
            this.ConsultardataGridView.Size = new System.Drawing.Size(672, 203);
            this.ConsultardataGridView.TabIndex = 5;
            // 
            // cEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 293);
            this.Controls.Add(this.ConsultardataGridView);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.Criteriolabel);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.Desdelabel);
            this.MaximizeBox = false;
            this.Name = "cEvaluacion";
            this.Text = "Consultar Evaluación";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.DataGridView ConsultardataGridView;
    }
}