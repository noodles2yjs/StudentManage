using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.ExcelPrint
{
    public class PrintStudent
    {
        public void ExecPrint(Student student)
        {
            //【1】定义一个Excel工作薄对象
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //【2】获取已创建好的工作薄路径
            string execlBookPath = Environment.CurrentDirectory + "\\StudentInfo.xls";
            //【3】将现有工作薄加入已经定义的工作薄集合
            excelApp.Workbooks.Add(execlBookPath);
            //【4】获取第一个工作表
            Microsoft.Office.Interop.Excel.Worksheet sheet = excelApp.Worksheets[1];
            //【5】在当前Excel工作表中写入数据
            #region 默认图片字符串
            string defaultImageStr = "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";
            #endregion

            // 三种情况
            // 1有图片且不为默认图片
            // 2默认图片
            // 3图片为null

            Image image= null;
           var s= student.StuImage;
            if (student.StuImage ==DBNull.Value.ToString())
            {
                image = Image.FromFile("StuIcon.png");

            }
            else  if (student.StuImage !=null && student.StuImage.Equals(defaultImageStr))
            {
                image = Image.FromFile("default.png");
            }
            else
            {
                image = (Image)new SerializeObjectToString().DeserializeObject(student.StuImage);
            }

            //将图片保存到指定的位置
            string imagePath = Environment.CurrentDirectory + "\\Student.jpg";
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
            //保存图片到系统目录中
            image.Save(imagePath);
            //将图片插入到Excel中
            sheet.Shapes.AddPicture(imagePath, Microsoft.Office.Core.MsoTriState.msoFalse,
             Microsoft.Office.Core.MsoTriState.msoTrue, 10, 50, 90, 100);
            //使用完毕后删除保存的图片
            File.Delete(imagePath);
            //写入其他相关数据
            sheet.Cells[4, 4] = student.StudentId;
            sheet.Cells[4, 6] = student.StudentName;
            sheet.Cells[4, 8] = student.Gender;
            sheet.Cells[6, 4] = student.ClassName;
            sheet.Cells[6, 6] = student.PhoneNumber;
            sheet.Cells[8, 4] = student.StudentAddress;

            /* if (student.StuImage.Length != 0  && student.StuImage.Equals(defaultImageStr))//判断是否有图片，且为默认图片
             {
                 //将图片保存到指定的位置
                 Image image = (Image) new SerializeObjectToString().DeserializeObject(student.StuImage);
                 string imagePath = Environment.CurrentDirectory + "\\Student.jpg";
                 if (File.Exists(imagePath))
                 {
                     File.Delete(imagePath);
                 }
                 else
                 {
                     //保存图片到系统目录中
                     image.Save(imagePath);
                     //将图片插入到Excel中
                     sheet.Shapes.AddPicture(imagePath, Microsoft.Office.Core.MsoTriState.msoFalse,
                      Microsoft.Office.Core.MsoTriState.msoTrue, 10, 50, 90, 100);
                     //使用完毕后删除保存的图片
                     File.Delete(imagePath);

                   

                 }
             }
             else if (student.StuImage.Length != 0)
             {

             }
             {

             }*/

            //备注信息...

            //【6】打印预览
            excelApp.Visible = true;
            excelApp.Sheets.PrintPreview(true);

            //【7】释放对象
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            excelApp = null;
        }
    }
}
