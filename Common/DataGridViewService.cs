using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Common
{
    public class DataGridViewService
    {
        public static void VisibleRowOrder(DataGridView dgv, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
            e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgv.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgv.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        public static void SetColorForDGV(DataGridViewCellFormattingEventArgs e, object sender, string ColAmount, string colVioCode)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.ColumnIndex == dgv.Columns[ColAmount].Index)  //代交罚款
            {
                if (e.Value != null)
                {
                    if ((decimal)e.Value >= 1000)
                    {
                        if (!(dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Orange || dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Yellow))
                        {


                            dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 0, 0);
                            dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }

            if (e.ColumnIndex == dgv.Columns[colVioCode].Index)  //违章代码
            {
                if (e.Value != null)
                {

                    if (e.Value.ToString() == "8001" || e.Value.ToString() == "8002" || e.Value.ToString() == "8003")
                    {


                        dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(202, 132, 0);
                        dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    }
                }
            }
        }

    }
}
