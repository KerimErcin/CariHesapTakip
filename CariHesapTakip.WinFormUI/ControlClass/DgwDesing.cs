using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakip.WinFormUI.ControlClass
{
    class DgwDesing
    {
        public DataGridView dtwHome(DataGridView dataGridView)
        {
            #region GenelBilgi
            //Müşteri İşlerinin Bulunduğu DGW
            //Başlıklar vb.
            #endregion
            dataGridView.Columns[0].HeaderText = "Sıra";
            dataGridView.Columns[1].HeaderText = "Ünvan";
            dataGridView.Columns[2].HeaderText = "Şehir";
            dataGridView.Columns[3].HeaderText = "Mail";
            dataGridView.Columns[4].HeaderText = "Bakiye";
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11);
            for (int i = 0; i < 8; i++)
            {
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            return dataGridView;
        }
    }
}
