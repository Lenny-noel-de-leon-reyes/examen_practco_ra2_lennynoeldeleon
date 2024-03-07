using System;
using System.IO;
using System.Windows.Forms;

namespace examen_practco_ra2_lennynoeldeleon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal class Estudiantes
        {
            public int Matricula { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Genero { get; set; }
            public int Telefono { get; set; }
            public string Email { get; set; }
            public string Curso { get; set; }
            public string AreaTecnica { get; set; }
            public string Seccion { get; set; }
            public string MaestroTitular { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_todo.Enabled = false;
            btn_Agregar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_Salir.Enabled = false;
            btn_Limpiar.Enabled = false;
            txt_direccion.Enabled = false;
            txt_email.Enabled = false;
            txt_maestro.Enabled = false;
            txt_nombre.Enabled = false;
            txt_telefono.Enabled = false;
            txt_matricula.Enabled = false;
            rbn_Femenino.Enabled = false;
            rbn_Masculino.Enabled = false;
            cmb_areas.Enabled = false;
            cmb_cursos.Enabled = false;
            cmb_secciones.Enabled = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
            btn_Nuevo.Enabled = false;
            dgv_todo.Enabled = true;
            txt_direccion.Clear();
            txt_email.Clear();
            txt_maestro.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            txt_matricula.Clear();
            txt_matricula.Focus();
            cmb_areas.Refresh();
            txt_direccion.Enabled = true;
            txt_email.Enabled = true;
            txt_maestro.Enabled = true;
            txt_nombre.Enabled = true;
            txt_telefono.Enabled = true;
            txt_matricula.Enabled = true;
            rbn_Femenino.Enabled = true;
            rbn_Masculino.Enabled = true;
            cmb_areas.Enabled = true;
            cmb_cursos.Enabled = true;
            cmb_secciones.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            Estudiantes estudiante = new Estudiantes();
            estudiante.Matricula = Convert.ToInt32(txt_matricula.Text);
            estudiante.Nombre = txt_nombre.Text;
            estudiante.Direccion = txt_direccion.Text;
            string telefono = txt_telefono.Text.Trim();
           
           
            estudiante.Email = txt_email.Text;
            estudiante.MaestroTitular = txt_maestro.Text;
            estudiante.AreaTecnica = cmb_areas.SelectedItem.ToString();
            estudiante.Curso = cmb_cursos.SelectedItem.ToString();
            estudiante.Seccion = cmb_secciones.SelectedItem.ToString();
            estudiante.Genero = rbn_Femenino.Checked ? rbn_Femenino.Text : rbn_Masculino.Text;
            dgv_todo.Rows.Add(estudiante.Matricula,
                             estudiante.Nombre,
                             estudiante.MaestroTitular,
                             estudiante.Direccion,
                             estudiante.Telefono,
                             estudiante.Email,
                             estudiante.AreaTecnica,
                             estudiante.Curso,
                             estudiante.Seccion,
                             estudiante.Genero);


            txt_matricula.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_maestro.Clear();
            rbn_Masculino.Checked = false;
            rbn_Femenino.Checked = false;
            cmb_cursos.SelectedIndex = -1;
            cmb_secciones.SelectedIndex = -1;
            cmb_areas.SelectedIndex = -1;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que quieres salir del programa?", "Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                int Indice = dgv_todo.SelectedRows[0].Index;
                dgv_todo.Rows.RemoveAt(Indice);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_direccion.Clear();
            txt_email.Clear();
            txt_maestro.Clear();
            txt_matricula.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            cmb_areas.ResetText();
            cmb_cursos.ResetText();
            cmb_secciones.ResetText();
            rbn_Femenino.Checked = false;
            rbn_Masculino.Checked = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Agregar.Enabled = true;
            btn_Limpiar.Enabled = true;
            btn_Salir.Enabled = true;
            string path = @"C:\Users\pc\Downloads\Gama\examen_practco_ra2_lennynoeldeleon\examen_practco_ra2_lennynoeldeleon\Gama.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dgv_todo.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string Matricula = row.Cells[0].Value?.ToString() ?? "";
                        string Nombre = row.Cells[1].Value?.ToString() ?? "";
                        string Curso = row.Cells[6].Value?.ToString() ?? "";
                        string Seccion = row.Cells[7].Value?.ToString() ?? "";
                        string AreaTecnica = row.Cells[8].Value?.ToString() ?? "";
                        sw.WriteLine($"{Matricula}\t{Nombre}\t{Curso}\t{Seccion}\t{AreaTecnica}");
                    }
                }
                MessageBox.Show("Datos guardados en archivo.txt");
                btn_guardar.Enabled = false;
                btn_Eliminar.Enabled = true;
            }
        }
    }
}
