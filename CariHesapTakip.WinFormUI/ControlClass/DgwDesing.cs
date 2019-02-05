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
            dataGridView.Columns[2].HeaderText = "Yetkili";
            dataGridView.Columns[3].HeaderText = "Telefon";
            dataGridView.Columns[4].HeaderText = "GSM";
            dataGridView.Columns[5].HeaderText = "Adres";
            dataGridView.Columns[6].HeaderText = "İl";
            dataGridView.Columns[7].HeaderText = "İlçe";
            dataGridView.Columns[8].HeaderText = "V.N";
            dataGridView.Columns[9].HeaderText = "V.D";
            dataGridView.Columns[10].HeaderText = "Mail";
            dataGridView.Columns[11].HeaderText = "Web";
            dataGridView.Columns[12].HeaderText = "C.L";
            dataGridView.Columns[13].HeaderText = "Durum";
            //
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].Visible = false;
            dataGridView.Columns[12].Visible = false;
            dataGridView.Columns[13].Visible = false;
            //
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11);
            for (int i = 0; i < 8; i++)
            {
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            return dataGridView;
        }

        public DataGridView dtwCompany(DataGridView dataGridView)
        {
            #region GenelBilgi
            //Comapny sayfasında bulunan şirketlerin bilgileri
            //Başlıklar vb.
            #endregion
            dataGridView.Columns[0].HeaderText = "Sıra";
            dataGridView.Columns[1].HeaderText = "Ünvan";
            dataGridView.Columns[2].HeaderText = "Yetkili";
            dataGridView.Columns[3].HeaderText = "Telefon";
            dataGridView.Columns[4].HeaderText = "GSM";
            dataGridView.Columns[5].HeaderText = "Adres";
            dataGridView.Columns[6].HeaderText = "İl";
            dataGridView.Columns[7].HeaderText = "İlçe";
            dataGridView.Columns[8].HeaderText = "V.N";
            dataGridView.Columns[9].HeaderText = "V.D";
            dataGridView.Columns[10].HeaderText = "Mail";
            dataGridView.Columns[11].HeaderText = "Web";
            dataGridView.Columns[12].HeaderText = "C.L";
            dataGridView.Columns[13].HeaderText = "Durum";
            //
            //dataGridView.Columns[0].Visible = false;
            //
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
