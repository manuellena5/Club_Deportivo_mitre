using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data;

namespace UI.Escritorio
{
    public class ExportarAexcel2
    {

        public void exporta_a_excel(DataGridView dgv)
        {

            SaveFileDialog fichero = new SaveFileDialog();
               fichero.Filter = "Excel (*.xls)|*.xls";
               if (fichero.ShowDialog() == DialogResult.OK)
               {
            Microsoft.Office.Interop.Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            libros_trabajo = aplicacion.Application.Workbooks.Add(true);
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {

                ColumnIndex++;
                aplicacion.Cells[1, ColumnIndex] = col.Name;

            }
            int rowIndex = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {

                rowIndex++;
                ColumnIndex = 0;

                foreach (DataGridViewColumn col in dgv.Columns)
                {

                    ColumnIndex++;
                    aplicacion.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;

                }

            }

            //aplicacion.Visible = true;
            Worksheet worksheet = (Worksheet)aplicacion.ActiveSheet;
            //worksheet.Activate();
                   libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                   libros_trabajo.Close(true);
                   aplicacion.Quit();
        }

         



              } 

    }
}
