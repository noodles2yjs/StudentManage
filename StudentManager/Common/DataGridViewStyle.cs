using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Common
{
    /// <summary>
    /// 设置DataGridView的样式
    /// </summary>
    public class DataGridViewStyle
    {      
        /// <summary>
        /// 普通的样式
        /// </summary>        
        public void DgvStyle1(DataGridView dgv)
        {
            //奇数行的背景色
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //默认的行样式
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            //数据网格颜色
            dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            //列标题的宽度
            dgv.ColumnHeadersHeight = 30;

        }
        /// <summary>
        /// 凹凸样式
        /// </summary>
        /// 需要手动设置this.RowTemplate.DividerHeight = 2;    
        public void DgvStyle2(DataGridView dgv)
        {
            //奇数行的背景色
            // this.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            //单元格边框样式
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            //列标题的边框样式
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dgv.ColumnHeadersHeight = 28;
            //行的边框样式
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //this.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            //this.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            dgv.RowTemplate.DividerHeight = 1;
            ////禁止当前默认的视觉样式
            dgv.EnableHeadersVisualStyles = false;

            //自动调整列宽
            // this.AutoResizeColumns();
        }
        /// <summary>
        /// 华丽的样式
        /// </summary>
        public void DgvStyle3(DataGridView dgv)
        {
            //未显示数据时的背景色
            dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            //显示数据时的背景色
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Black;
            //数据网格颜色
            dgv.GridColor = System.Drawing.Color.Red;
            //列标题的边框样式
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //行的边框样式
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            ////禁止当前默认的视觉样式
            dgv.EnableHeadersVisualStyles = false;
            //列标题的宽度
            dgv.ColumnHeadersHeight = 35;

            //列标题的字体颜色
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            //列标题的背景颜色
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            //所有数据字体的颜色
            int RowsCount = dgv.Columns.Count;
            for (int i = 0; i < RowsCount; i++)
            {
                dgv.Columns[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        /// <summary>
        /// 给DataGridView添加行号
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        public static void DgvRowPostPaint(DataGridView dgv, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                //添加行号 
                SolidBrush v_SolidBrush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;
                string v_Line = v_LineNo.ToString();
                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加行号时发生错误，错误信息：" + ex.Message, "操作失败");
            }
        }

    }
}
