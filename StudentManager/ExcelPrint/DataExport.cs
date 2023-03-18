using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.ExcelPrint
{
    public class DataExport
    {
        //把dgv里的数据导出到Excel里
        // 需要在 nuget  上下载  Microsoft.Office.Interop.Excel
        public bool Export(DataGridView dgv)
        {
            //定义Excel操作对象
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //定义Excel工作表
            Microsoft.Office.Interop.Excel.Worksheet workSheet = excelApp.Workbooks.Add().Worksheets[1];

            //设置标题的样式（从第2行，第2列开始）
            workSheet.Cells[2, 2] = "学生成绩表";//设置标题内容
            workSheet.Cells[2, 2].RowHeight = 25;
            Microsoft.Office.Interop.Excel.Range range = workSheet.get_Range("B2", "H2");
            range.Merge(0);//合并表头单元格
            range.Borders.Value = 1;//设置表头的边框
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;//设置单元格内容居中显示
            range.Font.Size = 15;

            //获取总列数和总行数
            int columCount = dgv.ColumnCount;
            int rowCount = dgv.RowCount;

            //显示列标题
            for (int i = 0; i < columCount; i++)
            {
                //从第3行开始
                workSheet.Cells[3, i + 2] = dgv.Columns[i].HeaderText;
                workSheet.Cells[3, i + 2].Borders.Value = 1;
                workSheet.Cells[3, i + 2].RowHeight = 23;
            }
            //显示数据,从第4行，第2列，开始
            for (int i = 0; i < rowCount; i++)
            {
                for (int n = 0; n < columCount; n++)
                {
                    workSheet.Cells[i + 4, n + 2] = dgv.Rows[i].Cells[n].Value;
                    workSheet.Cells[i + 4, n + 2].Borders.Value = 1;
                    workSheet.Cells[i + 4, n + 2].RowHeight = 23;
                }
            }
            //设置列宽和数据一致
            workSheet.Columns.AutoFit();

            //打印预览
            excelApp.Visible = true;
            excelApp.Sheets.PrintPreview();
            //释放对象
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            excelApp = null;
            return true;
        }
    }
}
