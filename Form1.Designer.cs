namespace JsonWindowForm
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
			tablaListado = new DataGridView();
			NOMBRES = new DataGridViewTextBoxColumn();
			SEXO = new DataGridViewTextBoxColumn();
			TELEFONO = new DataGridViewTextBoxColumn();
			COMPANIA = new DataGridViewTextBoxColumn();
			DIRECCION = new DataGridViewTextBoxColumn();
			label1 = new Label();
			label3 = new Label();
			label2 = new Label();
			label5 = new Label();
			nombres_text = new TextBox();
			sexo_combo = new ComboBox();
			direccion_text = new TextBox();
			button1 = new Button();
			button3 = new Button();
			compania_combo = new ComboBox();
			telefono_text = new TextBox();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)tablaListado).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// tablaListado
			// 
			tablaListado.AllowUserToAddRows = false;
			tablaListado.AllowUserToDeleteRows = false;
			tablaListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tablaListado.Columns.AddRange(new DataGridViewColumn[] { NOMBRES, SEXO, TELEFONO, COMPANIA, DIRECCION });
			tablaListado.Location = new Point(261, 24);
			tablaListado.Name = "tablaListado";
			tablaListado.ReadOnly = true;
			tablaListado.Size = new Size(617, 332);
			tablaListado.TabIndex = 0;
			// 
			// NOMBRES
			// 
			NOMBRES.HeaderText = "NOMBRES";
			NOMBRES.Name = "NOMBRES";
			NOMBRES.ReadOnly = true;
			// 
			// SEXO
			// 
			SEXO.HeaderText = "SEXO";
			SEXO.Name = "SEXO";
			SEXO.ReadOnly = true;
			// 
			// TELEFONO
			// 
			TELEFONO.HeaderText = "TELEFONOS";
			TELEFONO.Name = "TELEFONO";
			TELEFONO.ReadOnly = true;
			// 
			// COMPANIA
			// 
			COMPANIA.HeaderText = "COMPANIA";
			COMPANIA.Name = "COMPANIA";
			COMPANIA.ReadOnly = true;
			// 
			// DIRECCION
			// 
			DIRECCION.HeaderText = "DIRECCION";
			DIRECCION.Name = "DIRECCION";
			DIRECCION.ReadOnly = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(18, 24);
			label1.Name = "label1";
			label1.Size = new Size(87, 21);
			label1.TabIndex = 1;
			label1.Text = "NOMBRES:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(22, 96);
			label3.Name = "label3";
			label3.Size = new Size(51, 21);
			label3.TabIndex = 3;
			label3.Text = "SEXO:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(18, 131);
			label2.Name = "label2";
			label2.Size = new Size(89, 21);
			label2.TabIndex = 5;
			label2.Text = "TELEFONO:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F);
			label5.Location = new Point(18, 206);
			label5.Name = "label5";
			label5.Size = new Size(94, 21);
			label5.TabIndex = 6;
			label5.Text = "DIRECCION:";
			// 
			// nombres_text
			// 
			nombres_text.Font = new Font("Segoe UI", 12F);
			nombres_text.Location = new Point(18, 52);
			nombres_text.Name = "nombres_text";
			nombres_text.Size = new Size(211, 29);
			nombres_text.TabIndex = 7;
			// 
			// sexo_combo
			// 
			sexo_combo.Font = new Font("Segoe UI", 12F);
			sexo_combo.FormattingEnabled = true;
			sexo_combo.Items.AddRange(new object[] { "FEMENINO", "MASCULINO" });
			sexo_combo.Location = new Point(75, 92);
			sexo_combo.Name = "sexo_combo";
			sexo_combo.Size = new Size(154, 29);
			sexo_combo.TabIndex = 8;
			// 
			// direccion_text
			// 
			direccion_text.Font = new Font("Segoe UI", 12F);
			direccion_text.Location = new Point(18, 235);
			direccion_text.Multiline = true;
			direccion_text.Name = "direccion_text";
			direccion_text.Size = new Size(211, 70);
			direccion_text.TabIndex = 11;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 12F);
			button1.Location = new Point(539, 370);
			button1.Name = "button1";
			button1.Size = new Size(137, 62);
			button1.TabIndex = 12;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Guardar_Boton1;
			// 
			// button3
			// 
			button3.Location = new Point(18, 315);
			button3.Name = "button3";
			button3.Size = new Size(211, 41);
			button3.TabIndex = 14;
			button3.Text = "AGREGAR AL LISTADO";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// compania_combo
			// 
			compania_combo.Font = new Font("Segoe UI", 12F);
			compania_combo.FormattingEnabled = true;
			compania_combo.Items.AddRange(new object[] { "CLARO", "TIGO", "FIJO" });
			compania_combo.Location = new Point(133, 159);
			compania_combo.Name = "compania_combo";
			compania_combo.Size = new Size(96, 29);
			compania_combo.TabIndex = 16;
			// 
			// telefono_text
			// 
			telefono_text.Font = new Font("Segoe UI", 12F);
			telefono_text.Location = new Point(18, 159);
			telefono_text.Name = "telefono_text";
			telefono_text.Size = new Size(109, 29);
			telefono_text.TabIndex = 15;
			// 
			// panel1
			// 
			panel1.Controls.Add(tablaListado);
			panel1.Controls.Add(compania_combo);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(telefono_text);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(nombres_text);
			panel1.Controls.Add(direccion_text);
			panel1.Controls.Add(sexo_combo);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(898, 443);
			panel1.TabIndex = 17;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(898, 443);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)tablaListado).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView tablaListado;
		private Label label1;
		private Label label3;
		private Label label2;
		private Label label5;
		private TextBox nombres_text;
		private ComboBox sexo_combo;
		private TextBox direccion_text;
		private Button button1;
		private Button button3;
		private ComboBox compania_combo;
		private TextBox telefono_text;
		private DataGridViewTextBoxColumn NOMBRES;
		private DataGridViewTextBoxColumn SEXO;
		private DataGridViewTextBoxColumn TELEFONO;
		private DataGridViewTextBoxColumn COMPANIA;
		private DataGridViewTextBoxColumn DIRECCION;
		private Panel panel1;
	}
}
