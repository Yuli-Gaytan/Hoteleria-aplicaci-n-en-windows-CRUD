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
using Org.BouncyCastle.Crypto.Macs;

namespace ProyectoHotel
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        
        
        private void Cliente_Load(object sender, EventArgs e)
        {
            Clientes();
            if (!File.Exists("Clientes.txt"))
            {
                StreamWriter bloc = new StreamWriter("Clientes.txt");
                bloc.Close();
            }

        }
        private void Clientes()
        {
            dshotelTableAdapters.ClienteTableAdapter cli = new dshotelTableAdapters.ClienteTableAdapter();
            dshotel.ClienteDataTable dt = cli.GetDatac();
            dataGridView1.DataSource = dt;
        }
        private void Limpiar()
        {
            textC.Text = "";
            textN.Text = "";

        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.ClienteTableAdapter cli = new dshotelTableAdapters.ClienteTableAdapter();
            cli.addc(int.Parse(textC.Text), textN.Text);
            Clientes();
            Limpiar();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.ClienteTableAdapter cli = new dshotelTableAdapters.ClienteTableAdapter();
            cli.Modificar(textN.Text, int.Parse(textC.Text), int.Parse(textC.Text));
            Clientes();
            Limpiar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            dshotelTableAdapters.ClienteTableAdapter cli = new dshotelTableAdapters.ClienteTableAdapter();
            cli.Eliminar(int.Parse(textC.Text));
            Clientes();
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
            StreamWriter bloc = new StreamWriter("Clientes.txt", true);
            bloc.WriteLine(textC.Text);
            bloc.WriteLine(textN.Text);
            bloc.Close();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                // save.Filter = "PDF (*.pdf |*.pdf)";
                save.Filter = "PDF|.pdf  ";
                save.FileName = "ClientesPDF";
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
                            pTable.DefaultCell.Padding = 2;
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

     
    


     
    

