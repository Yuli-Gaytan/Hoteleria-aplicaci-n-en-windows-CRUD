
namespace ProyectoHotel
{
    partial class Cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.textC = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.textN = new System.Windows.Forms.TextBox();
            this.btntxt = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre:";
            // 
            // textC
            // 
            this.textC.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textC.Location = new System.Drawing.Point(95, 57);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(65, 22);
            this.textC.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 207);
            this.dataGridView1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Clientes";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Snow;
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(455, 106);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(113, 32);
            this.btn_Limpiar.TabIndex = 48;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Snow;
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(312, 106);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(113, 32);
            this.btn_Eliminar.TabIndex = 47;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Snow;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.Btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.Location = new System.Drawing.Point(177, 106);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(113, 32);
            this.Btn_Modificar.TabIndex = 46;
            this.Btn_Modificar.Text = "Actualizar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.Snow;
            this.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.Btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar.Location = new System.Drawing.Point(33, 106);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(113, 32);
            this.Btn_Agregar.TabIndex = 45;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // textN
            // 
            this.textN.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textN.Location = new System.Drawing.Point(267, 56);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(269, 22);
            this.textN.TabIndex = 49;
            // 
            // btntxt
            // 
            this.btntxt.BackColor = System.Drawing.Color.Snow;
            this.btntxt.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btntxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btntxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntxt.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntxt.ForeColor = System.Drawing.Color.Black;
            this.btntxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntxt.Location = new System.Drawing.Point(267, 360);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(74, 48);
            this.btntxt.TabIndex = 52;
            this.btntxt.Text = "txt";
            this.btntxt.UseVisualStyleBackColor = false;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.Snow;
            this.btnexcel.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnexcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.Black;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(455, 357);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(74, 48);
            this.btnexcel.TabIndex = 51;
            this.btnexcel.Text = "excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.Snow;
            this.btn_pdf.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btn_pdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.ForeColor = System.Drawing.Color.Black;
            this.btn_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pdf.Location = new System.Drawing.Point(86, 360);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(74, 48);
            this.btn_pdf.TabIndex = 50;
            this.btn_pdf.Text = "pdf";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Cliente";
            this.Text = "Cliente:";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btn_pdf;
    }
}