using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoHotel
{
    public partial class Reservacion : Form
    {
        public Reservacion()
        {
            InitializeComponent();
        }
        

             private void Reservacion_Load(object sender, EventArgs e)
        {
            Reservaciones();
            if (!File.Exists("Reservaciones.txt"))
            {
                StreamWriter bloc = new StreamWriter("Reservaciones.txt");
                bloc.Close();
            }
        }
        private void Reservaciones()
        {

            dshotelTableAdapters.reservacionTableAdapter res = new dshotelTableAdapters.reservacionTableAdapter();
            dshotel.reservacionDataTable dt = res.GetDatar();
            dataGridView1.DataSource = dt;
        }
        private void Limpiar()
        {
            textR.Text = "";
            cmbC.Text = "";
            cmbH.Text = "";
            cmbU.Text = "";
            cmbP.Text = "";

        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.reservacionTableAdapter res = new dshotelTableAdapters.reservacionTableAdapter();
            res.addr(int.Parse(textR.Text), int.Parse(cmbC.Text), dtpR.Value, dtpI.Value, dtpS.Value, int.Parse(cmbH.Text), int.Parse(cmbP.Text), int.Parse(cmbU.Text));
            Reservaciones();
            Limpiar();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.reservacionTableAdapter res = new dshotelTableAdapters.reservacionTableAdapter();
            res.Modificar(int.Parse(cmbC.Text), dtpR.Value, dtpI.Value, dtpS.Value, int.Parse(cmbH.Text), int.Parse(cmbP.Text), int.Parse(cmbU.Text), int.Parse(textR.Text), int.Parse(textR.Text));
            Reservaciones();
            Limpiar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.reservacionTableAdapter res = new dshotelTableAdapters.reservacionTableAdapter();
            res.Eliminar(int.Parse(textR.Text));
            Reservaciones();
            Limpiar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btntxt_Click(object sender, EventArgs e)
        {
            GuardarNotas();
        }
        //este es el metodo que se invoca en el boton
        private void GuardarNotas()
        {
            StreamWriter bloc = new StreamWriter("Reservaciones.txt", true);
            bloc.WriteLine(textR.Text);
            bloc.WriteLine(cmbC.Text);
            bloc.WriteLine(dtpR.Text);
            bloc.WriteLine(dtpI.Text);
            bloc.WriteLine(dtpS.Text);
            bloc.WriteLine(cmbH.Text);
            bloc.WriteLine(cmbP.Text);
            bloc.WriteLine(cmbU.Text);
            bloc.Close();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                // save.Filter = "PDF (*.pdf |*.pdf)";
                save.Filter = "PDF|.pdf  ";
                save.FileName = "ReservacionesPDF";
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
        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }


    }

}


