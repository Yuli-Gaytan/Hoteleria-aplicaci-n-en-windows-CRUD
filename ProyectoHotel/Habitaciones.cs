using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Crypto.Macs;

namespace ProyectoHotel
{
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
        }


        private void Habitaciones_Load(object sender, EventArgs e)
        {
            Habitacion();
            if (!File.Exists("Habitaciones.txt"))
            {
                StreamWriter bloc = new StreamWriter("Habitaciones.txt");
                bloc.Close();
            }
        }
        private void Habitacion()
        {

            dshotelTableAdapters.HabitacionTableAdapter hab = new dshotelTableAdapters.HabitacionTableAdapter();
            dshotel.HabitacionDataTable dt = hab.GetDatah();
            dataGridView1.DataSource = dt;
        }
        private void Limpiar()
        {
            textH.Text = "";
            cmb.Text = "";
            textD.Text = "";
            textP.Text = "";
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.HabitacionTableAdapter hab = new dshotelTableAdapters.HabitacionTableAdapter();
            hab.addh(int.Parse(textH.Text), cmb.Text, textD.Text, int.Parse(textP.Text));
            Habitacion();
            Limpiar();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.HabitacionTableAdapter hab = new dshotelTableAdapters.HabitacionTableAdapter();
            hab.Modificar(cmb.Text, textD.Text, int.Parse(textP.Text), int.Parse(textH.Text), int.Parse(textH.Text));
            Habitacion();
            Limpiar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.HabitacionTableAdapter hab = new dshotelTableAdapters.HabitacionTableAdapter();
            hab.Eliminar(int.Parse(textH.Text));
            Habitacion();
            Limpiar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                // save.Filter = "PDF (*.pdf |*.pdf)";
                save.Filter = "PDF|.pdf  ";
                save.FileName = "HabitacionesPDF";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Vas bien" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 4;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Informacion exportada", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fallo la exportacion ", ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vacio", "Info");

            }
        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            GuardarNotas();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }

       
        //este es el metodo que se invoca en el boton
        private void GuardarNotas()
        {
            StreamWriter bloc = new StreamWriter("Habitaciones.txt", true);
            bloc.WriteLine(textH.Text);
            bloc.WriteLine(cmb.Text);
            bloc.WriteLine(textD.Text);
            bloc.WriteLine(textP.Text);
            bloc.Close();
        }

     
        //metodo para lo de excel
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumn = 0;
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                indicecolumn++;

                exportarexcel.Cells[1, indicecolumn] = columna.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                indicefila++;
                indicecolumn = 0;

                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    indicecolumn++;
                    exportarexcel.Cells[indicefila + 1, indicecolumn] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }
       

    }

}
