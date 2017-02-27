using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework;
using Microsoft.Office.Interop.Excel;
using VotingSystem.Models;

namespace VotingSystem
{
    public partial class FrmExport : MetroForm
    {
        private Records _records = null;
        public FrmExport()
        {
            InitializeComponent();
            _records = new Records();
        }

        private void FrmExport_Load(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var list = _records.GetAllRecords();
            foreach (var item in list)
            {
                var listView = new ListViewItem(item.CandidatePin);
                listView.SubItems.Add(item.Position);
                listView.SubItems.Add(item.Firstname);
                listView.SubItems.Add(item.Lastname);
                listView.SubItems.Add(item.CandidateEmail);
                listView.SubItems.Add(item.VoterPin);
                listView.SubItems.Add(item.Gender);
                listView.SubItems.Add(item.Phonenumber);
                listView.SubItems.Add(item.VoterEmail);
                mtListView.Items.Add(listView);
            }
            Cursor.Current = Cursors.Default;
        }

        private void lnkExport_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (var sfd = new SaveFileDialog() {Filter = @"Excel Workbook|*.xls", ValidateNames = true})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var app = new Microsoft.Office.Interop.Excel.Application();
                    var wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    var ws = (Worksheet) app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Candidate Pin";
                    ws.Cells[1, 2] = "Position";
                    ws.Cells[1, 3] = "Firstname";
                    ws.Cells[1, 4] = "Lastname";
                    ws.Cells[1, 5] = "Candidate Email";
                    ws.Cells[1, 6] = "Voters Pin";
                    ws.Cells[1, 7] = "Gender";
                    ws.Cells[1, 8] = "Voters Phonenumber";
                    ws.Cells[1, 9] = "Voters Email";
                    var i = 2;
                    foreach (ListViewItem item in mtListView.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        ws.Cells[i, 8] = item.SubItems[7].Text;
                        ws.Cells[i, 9] = item.SubItems[8].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange,
                        XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MetroMessageBox.Show(this, @"Your data has been successfully exported", @"Export records",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            Cursor.Current = Cursors.Default;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
