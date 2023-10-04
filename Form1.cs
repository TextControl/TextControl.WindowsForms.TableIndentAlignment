using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Indent_alignment_for_tables
{
    public partial class Form1 : Form
    {
        int tableID = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Load();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.FontDialog();
        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.ParagraphFormatDialog();
        }

        private void insert3x4TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textControl1.Tables.Add(3, 4, tableID))
            {
                alignTable(tableID, false);
                tableID++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textControl1.ButtonBar = buttonBar1;
            textControl1.StatusBar = statusBar1;
            textControl1.RulerBar = rulerBar1;
            textControl1.VerticalRulerBar = rulerBar2;
            textControl1.Load(Application.StartupPath + "\\..\\..\\" + "table_document.rtf", TXTextControl.StreamType.RichTextFormat);
        }

        private void alignTable(int tableID, bool keepIndentInCells)
        {
            int oldSelStart = textControl1.Selection.Start;
            int oldSelLenght = textControl1.Selection.Length;
            int columns = textControl1.Tables.GetItem(tableID).Columns.Count;
            int rows = textControl1.Tables.GetItem(tableID).Rows.Count;
            int tableStart = textControl1.Selection.ParagraphFormat.LeftIndent;
            // calculate the available space for the table
            double availableWidth = textControl1.Sections.GetItem().Format.PageSize.Width * 14.4
                        - textControl1.Sections.GetItem().Format.PageMargins.Left * 14.4
                        - textControl1.Sections.GetItem().Format.PageMargins.Right * 14.4
                        - textControl1.Selection.ParagraphFormat.LeftIndent
                        - textControl1.Selection.ParagraphFormat.HangingIndent
                        - textControl1.Selection.ParagraphFormat.RightIndent;

            for (int i = rows; i >= 1; i--)
            {
                double curWidth = 0;
                // iterate all table columns and calculate the current width of the table
                for (int e = columns; e >= 1; e--)
                {
                    curWidth += textControl1.Tables.GetItem(tableID).Cells.GetItem(i, e).Width;
                }
                // calculate delta for changing the table width
                double percentageDelta = availableWidth / curWidth;

                // set the start position for the table
                textControl1.Tables.GetItem(tableID).Columns.GetItem(1).Position = tableStart;

                // resize the table cells
                for (int e = columns; e >= 1; e--)
                {
                    double newWidth = textControl1.Tables.GetItem(tableID).Cells.GetItem(i, e).Width * percentageDelta;
                    textControl1.Tables.GetItem(tableID).Cells.GetItem(i, e).Width = (int)newWidth;
                    if (!keepIndentInCells)
                    {
                        textControl1.Selection.Start = textControl1.Tables.GetItem(tableID).Cells.GetItem(i, e).Start - 1;
                        textControl1.Selection.ParagraphFormat.LeftIndent = 0;
                        textControl1.Selection.ParagraphFormat.RightIndent = 0;
                        textControl1.Selection.ParagraphFormat.HangingIndent = 0;
                    }
                }
                textControl1.Selection.Start = oldSelStart;
                textControl1.Selection.Length = oldSelLenght;
            }
        }

		private void deleteTableToolStripMenuItem_Click(object sender, EventArgs e)
		{
            textControl1.Tables.Remove();
		}
	}
}