namespace examen_practco_ra2_lennynoeldeleon
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
            txt_matricula = new TextBox();
            txt_email = new TextBox();
            txt_maestro = new TextBox();
            txt_telefono = new TextBox();
            txt_nombre = new TextBox();
            txt_direccion = new TextBox();
            lbl_matricula = new Label();
            lbl_Maestro = new Label();
            lbl_nombre = new Label();
            lbl_direccion = new Label();
            lbl_telefono = new Label();
            lbl_email = new Label();
            cmb_areas = new ComboBox();
            cmb_cursos = new ComboBox();
            cmb_secciones = new ComboBox();
            gbx_genero = new GroupBox();
            rbn_Masculino = new RadioButton();
            rbn_Femenino = new RadioButton();
            btn_Nuevo = new Button();
            dgv_todo = new DataGridView();
            Matricula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Maestro = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            E_mail = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            Sección = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            btn_Agregar = new Button();
            btn_guardar = new Button();
            btn_Eliminar = new Button();
            btn_Salir = new Button();
            btn_Limpiar = new Button();
            gbx_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_todo).BeginInit();
            SuspendLayout();
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(73, 63);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(100, 23);
            txt_matricula.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(261, 180);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 1;
            // 
            // txt_maestro
            // 
            txt_maestro.Location = new Point(73, 180);
            txt_maestro.Name = "txt_maestro";
            txt_maestro.Size = new Size(100, 23);
            txt_maestro.TabIndex = 2;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(261, 120);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(100, 23);
            txt_telefono.TabIndex = 3;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(73, 120);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 4;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(261, 63);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(100, 23);
            txt_direccion.TabIndex = 5;
            // 
            // lbl_matricula
            // 
            lbl_matricula.AutoSize = true;
            lbl_matricula.Location = new Point(10, 68);
            lbl_matricula.Name = "lbl_matricula";
            lbl_matricula.Size = new Size(57, 15);
            lbl_matricula.TabIndex = 6;
            lbl_matricula.Text = "Matricula";
            // 
            // lbl_Maestro
            // 
            lbl_Maestro.AutoSize = true;
            lbl_Maestro.Location = new Point(17, 180);
            lbl_Maestro.Name = "lbl_Maestro";
            lbl_Maestro.Size = new Size(50, 15);
            lbl_Maestro.TabIndex = 7;
            lbl_Maestro.Text = "Maestro";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(16, 123);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 8;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(201, 71);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 9;
            lbl_direccion.Text = "Dirección";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(206, 123);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(52, 15);
            lbl_telefono.TabIndex = 10;
            lbl_telefono.Text = "Télefono";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(217, 183);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(41, 15);
            lbl_email.TabIndex = 11;
            lbl_email.Text = "E-mail";
            // 
            // cmb_areas
            // 
            cmb_areas.BackColor = Color.FromArgb(192, 255, 255);
            cmb_areas.FormattingEnabled = true;
            cmb_areas.Items.AddRange(new object[] { "Informática", "Enférmeria", "Gastronomia", "Eléctricidad", "Contabilidad" });
            cmb_areas.Location = new Point(458, 65);
            cmb_areas.Name = "cmb_areas";
            cmb_areas.Size = new Size(121, 23);
            cmb_areas.TabIndex = 12;
            cmb_areas.Text = "Área";
            // 
            // cmb_cursos
            // 
            cmb_cursos.BackColor = Color.FromArgb(192, 255, 255);
            cmb_cursos.FormattingEnabled = true;
            cmb_cursos.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cmb_cursos.Location = new Point(458, 172);
            cmb_cursos.Name = "cmb_cursos";
            cmb_cursos.Size = new Size(121, 23);
            cmb_cursos.TabIndex = 13;
            cmb_cursos.Text = "Curso";
            // 
            // cmb_secciones
            // 
            cmb_secciones.BackColor = Color.FromArgb(192, 255, 255);
            cmb_secciones.FormattingEnabled = true;
            cmb_secciones.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cmb_secciones.Location = new Point(458, 115);
            cmb_secciones.Name = "cmb_secciones";
            cmb_secciones.Size = new Size(121, 23);
            cmb_secciones.TabIndex = 14;
            cmb_secciones.Text = "Sección";
            // 
            // gbx_genero
            // 
            gbx_genero.Controls.Add(rbn_Masculino);
            gbx_genero.Controls.Add(rbn_Femenino);
            gbx_genero.Location = new Point(628, 63);
            gbx_genero.Name = "gbx_genero";
            gbx_genero.Size = new Size(200, 148);
            gbx_genero.TabIndex = 15;
            gbx_genero.TabStop = false;
            gbx_genero.Text = "Género";
            // 
            // rbn_Masculino
            // 
            rbn_Masculino.AutoSize = true;
            rbn_Masculino.Location = new Point(23, 61);
            rbn_Masculino.Name = "rbn_Masculino";
            rbn_Masculino.Size = new Size(80, 19);
            rbn_Masculino.TabIndex = 1;
            rbn_Masculino.TabStop = true;
            rbn_Masculino.Text = "Másculino";
            rbn_Masculino.UseVisualStyleBackColor = true;
            // 
            // rbn_Femenino
            // 
            rbn_Femenino.AutoSize = true;
            rbn_Femenino.Location = new Point(23, 32);
            rbn_Femenino.Name = "rbn_Femenino";
            rbn_Femenino.Size = new Size(78, 19);
            rbn_Femenino.TabIndex = 0;
            rbn_Femenino.TabStop = true;
            rbn_Femenino.Text = "Fémenino";
            rbn_Femenino.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.BackColor = Color.FromArgb(128, 255, 128);
            btn_Nuevo.Location = new Point(879, 11);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(90, 27);
            btn_Nuevo.TabIndex = 16;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.UseVisualStyleBackColor = false;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // dgv_todo
            // 
            dgv_todo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_todo.Columns.AddRange(new DataGridViewColumn[] { Matricula, Nombre, Maestro, Direccion, Telefono, E_mail, Area, Curso, Sección, Genero });
            dgv_todo.Location = new Point(10, 229);
            dgv_todo.Name = "dgv_todo";
            dgv_todo.ReadOnly = true;
            dgv_todo.Size = new Size(1036, 150);
            dgv_todo.TabIndex = 17;
            
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.Name = "Matricula";
            Matricula.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Maestro
            // 
            Maestro.HeaderText = "Maestro";
            Maestro.Name = "Maestro";
            Maestro.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Télefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // E_mail
            // 
            E_mail.HeaderText = "E-mail";
            E_mail.Name = "E_mail";
            E_mail.ReadOnly = true;
            // 
            // Area
            // 
            Area.HeaderText = "Área";
            Area.Name = "Area";
            Area.ReadOnly = true;
            // 
            // Curso
            // 
            Curso.HeaderText = "Curso";
            Curso.Name = "Curso";
            Curso.ReadOnly = true;
            // 
            // Sección
            // 
            Sección.HeaderText = "Sección";
            Sección.Name = "Sección";
            Sección.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.HeaderText = "Género";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(128, 255, 128);
            btn_Agregar.Location = new Point(879, 77);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(90, 27);
            btn_Agregar.TabIndex = 18;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(128, 255, 128);
            btn_guardar.Location = new Point(879, 44);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(90, 27);
            btn_guardar.TabIndex = 19;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(255, 128, 128);
            btn_Eliminar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Eliminar.Location = new Point(879, 110);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(90, 27);
            btn_Eliminar.TabIndex = 20;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(255, 128, 128);
            btn_Salir.ForeColor = SystemColors.ActiveCaptionText;
            btn_Salir.Location = new Point(879, 176);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(90, 27);
            btn_Salir.TabIndex = 21;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.FromArgb(255, 128, 128);
            btn_Limpiar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Limpiar.Location = new Point(879, 143);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(90, 27);
            btn_Limpiar.TabIndex = 22;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1078, 450);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_todo);
            Controls.Add(btn_Nuevo);
            Controls.Add(gbx_genero);
            Controls.Add(cmb_secciones);
            Controls.Add(cmb_cursos);
            Controls.Add(cmb_areas);
            Controls.Add(lbl_email);
            Controls.Add(lbl_telefono);
            Controls.Add(lbl_direccion);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_Maestro);
            Controls.Add(lbl_matricula);
            Controls.Add(txt_direccion);
            Controls.Add(txt_nombre);
            Controls.Add(txt_telefono);
            Controls.Add(txt_maestro);
            Controls.Add(txt_email);
            Controls.Add(txt_matricula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbx_genero.ResumeLayout(false);
            gbx_genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_todo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_matricula;
        private TextBox txt_email;
        private TextBox txt_maestro;
        private TextBox txt_telefono;
        private TextBox txt_nombre;
        private TextBox txt_direccion;
        private Label lbl_matricula;
        private Label lbl_Maestro;
        private Label lbl_nombre;
        private Label lbl_direccion;
        private Label lbl_telefono;
        private Label lbl_email;
        private ComboBox cmb_areas;
        private ComboBox cmb_cursos;
        private ComboBox cmb_secciones;
        private GroupBox gbx_genero;
        private Button btn_Nuevo;
        private DataGridView dgv_todo;
        private Button btn_Agregar;
        private Button btn_guardar;
        private Button btn_Eliminar;
        private Button btn_Salir;
        private RadioButton rdb_Masculino;
        private RadioButton rdb_Femenino;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Maestro;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn E_mail;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Sección;
        private DataGridViewTextBoxColumn Genero;
        private Button btn_Limpiar;
        private RadioButton rbn_Masculino;
        private RadioButton rbn_Femenino;
    }
}
