using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.NPOI
{
    public class NPOIService
    {
        #region 将泛型集合中的实体导出到指定的Excel文件

        /// <summary>
        /// 将泛型集合中的实体导出到指定的Excel文件
        /// </summary>
        /// <typeparam name="T">泛型方法中的类型</typeparam>
        /// <param name="fileName">Excel路径和文件名</param>
        /// <param name="dataList">包含若干对象的泛型集合</param>
        /// <param name="columnNames">实体列的中文标题集合</param>
        /// <param name="version">Excel的版本号，规定0:2007以前版本，否则为2007及以上版本</param>
        /// <returns>成功返回ture</returns>
        public static bool ExportToExcel<T>(string fileName, List<T> dataList,
            Dictionary<string, string> columnNames, int version = 0) where T : class
        {
            //【1】基于NPOI创建工作簿和工作表对象
            HSSFWorkbook hssf = new HSSFWorkbook();   //2007以下版本
            XSSFWorkbook xssf = new XSSFWorkbook();   //2007以上版本
            //根据不同的office版本创建不同的工作簿对象
            IWorkbook workBook = null;
            if (version == 0)
                workBook = hssf;
            else
                workBook = xssf;

            //【2】创建工作表
            ISheet sheet = workBook.CreateSheet("sheet1");//请学员根据实际需要把工作表的名称，变成一个参数

            Type type = typeof(T);
            PropertyInfo[] propertyinfos = type.GetProperties();//获取类型的公共属性

            //【3】循环生成列标题和设置样式
            IRow rowTitle = sheet.CreateRow(0);
            for (int i = 0; i < propertyinfos.Length; i++)
            {
                ICell cell = rowTitle.CreateCell(i);   //创建单元格  propertyinfos[i].Name
                cell.SetCellValue(columnNames[propertyinfos[i].Name]);// 设置行标题
                SetCellStyle(workBook, cell);                                                 //设置单元格边框 
                SetColumnWidth(sheet, i, 20);                                                //设置列宽   
            }
            //【4】循环实体集合生成各行数据
            for (int i = 0; i < dataList.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < propertyinfos.Length; j++)
                {
                    ICell cell = row.CreateCell(j);
                    T model = dataList[i];    //根据泛型找到具体化的实体对象
                    string value = propertyinfos[j].GetValue(model, null).ToString();//基于反射获取实体属性值
                    cell.SetCellValue(value);  //赋值
                    SetCellStyle(workBook, cell);
                }
            }
            //【5】保存为Excel文件
            using (FileStream fs = File.OpenWrite(fileName))
            {
                workBook.Write(fs);
                return true;
            }
        }

        #region 辅助方法

        /// <summary>
        /// 设置cell单元格边框的公共方法
        /// </summary>
        /// <param name="workBook">接口类型的工作簿，能适应不同版本</param>
        /// <param name="cell">cell单元格对象</param>
        private static void SetCellStyle(IWorkbook workBook, ICell cell)
        {
            ICellStyle style = workBook.CreateCellStyle();
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;
            style.Alignment = HorizontalAlignment.Center;//水平对齐
            style.VerticalAlignment = VerticalAlignment.Center;//垂直对齐
            //设置字体
            IFont font = workBook.CreateFont();
            font.FontName = "微软雅黑";
            font.FontHeight = 4*4;
            font.Color = IndexedColors.Green.Index;   //字体颜色         
            //font.Color =(short )FontColor .Red  ;
            style.SetFont(font);
            cell.CellStyle = style;
        }
        /// <summary>
        /// 设置cell单元格列宽的公共方法
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="index">第几列</param>
        /// <param name="width">具体宽度值</param>
        private static void SetColumnWidth(ISheet sheet, int index, int width)
        {
            //sheet.SetColumnWidth(index, width * 256);
            sheet.SetColumnWidth(index, width*256);

        }

        #endregion

        #endregion

        #region Excel数据导入到通用泛型集合【请学过高级扩展课程的学员自学】

        /// <summary>
        /// 导入Excel文件到泛型集合。Excel文件必须是指定格式的模板
        /// </summary>
        /// <typeparam name="T">泛型类，必须实现new()约束</typeparam>
        /// <param name="fileName">Excel文件</param>
        /// <returns>返回泛型集合</returns>
        public static List<T> ImportToList<T>(string fileName) where T : new()
        {
            //创建文件流读入文件
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                //【1】创建工作簿
                string extName = Path.GetExtension(fileName);
                dynamic workbook = null;
                if (extName == ".xls")
                {
                    HSSFWorkbook objHSSF = new HSSFWorkbook(fs);//2007以下版本
                    workbook = objHSSF;
                }
                else
                {
                    XSSFWorkbook objXSSF = new XSSFWorkbook(fs);//2007及以上版本
                    workbook = objXSSF;
                }
                //【2】获取第一个工作表
                ISheet sheet = workbook.GetSheetAt(0);

                Type type = typeof(T);//获取泛型的具体类型
                PropertyInfo[] properInfos = type.GetProperties();//获取类型的公共属性

                //【3】循环将Excel各行数据读取到集合中
                List<T> modelList = new List<T>();//创建泛型集合
                for (int i = 1; i < sheet.LastRowNum + 1; i++)
                {
                    IRow row = sheet.GetRow(i);//获取行，行号从0开始，0行是标题，所以从第1行开始
                    if (row != null)
                    {
                        //T model=default (T);//这样不行
                        T model = new T();//因为是对象类型，所以用了约束
                        for (int j = 0; j < properInfos.Length; j++)
                        {
                            var cell = row.GetCell(j);//根据行和列号获取cell对象
                            object value;//因为不确定泛型类成员的具体数据类型，所以用object
                            if (cell != null)
                            {
                                string str = properInfos[j].PropertyType.Name;
                                switch (str)//根据泛型类的成员属性进行数据类型转换，此处需要继续扩展
                                {
                                    case "String":
                                        value = cell.ToString();
                                        break;
                                    case "Decimal":
                                        value = Convert.ToDecimal(cell.ToString());
                                        break;
                                    case "Double":
                                        value = Convert.ToDateTime(cell.ToString());
                                        break;
                                    case "Int16":
                                    case "Int32":
                                    case "Int64":
                                        value = Convert.ToInt32(cell.ToString());
                                        break;
                                    case "DateTime":
                                        value = Convert.ToDateTime(cell.ToString());
                                        //value = DateTime.ParseExact(cell.ToString(), "yyyyMMddHHmmss", new System.Globalization.CultureInfo("zh - CN", true)).ToString();
                                        break;
                                    case "Boolean":
                                        value = Convert.ToBoolean(cell.ToString());
                                        break;
                                    default:
                                        value = cell.ToString();
                                        break;
                                }
                                //给实体对象的属性赋值
                                properInfos[j].SetValue(model, value, null);
                            }
                        }
                        modelList.Add(model);
                    }
                }
                return modelList;
            }
        }

        #endregion
    }
}
