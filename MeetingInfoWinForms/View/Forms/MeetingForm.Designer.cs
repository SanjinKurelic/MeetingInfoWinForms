namespace MeetingInfoWinForms
{
    partial class MeetingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingForm));
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.lbYear = new System.Windows.Forms.Label();
            this.monthPicker = new System.Windows.Forms.DateTimePicker();
            this.lbMonth = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lbWeek = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.weekSelector = new MeetingInfoWinForms.CustomCalendar();
            this.printPlaner = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.weekPlaner = new MeetingInfoWinForms.WeekPlaner();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearPicker
            // 
            this.yearPicker.CalendarMonthBackground = System.Drawing.Color.Lime;
            resources.ApplyResources(this.yearPicker, "yearPicker");
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.ValueChanged += new System.EventHandler(this.yearPicker_ValueChanged);
            // 
            // lbYear
            // 
            resources.ApplyResources(this.lbYear, "lbYear");
            this.lbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbYear.Name = "lbYear";
            // 
            // monthPicker
            // 
            resources.ApplyResources(this.monthPicker, "monthPicker");
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.ShowUpDown = true;
            this.monthPicker.Value = new System.DateTime(2018, 3, 12, 0, 0, 0, 0);
            this.monthPicker.ValueChanged += new System.EventHandler(this.monthPicker_ValueChanged);
            // 
            // lbMonth
            // 
            resources.ApplyResources(this.lbMonth, "lbMonth");
            this.lbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbMonth.Name = "lbMonth";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lbWeek
            // 
            resources.ApplyResources(this.lbWeek, "lbWeek");
            this.lbWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbWeek.Name = "lbWeek";
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pHeader.Controls.Add(this.btnLanguage);
            this.pHeader.Controls.Add(this.btnPrint);
            this.pHeader.Controls.Add(this.lbMonth);
            this.pHeader.Controls.Add(this.lbWeek);
            this.pHeader.Controls.Add(this.btnNew);
            this.pHeader.Controls.Add(this.monthPicker);
            this.pHeader.Controls.Add(this.weekSelector);
            this.pHeader.Controls.Add(this.lbYear);
            this.pHeader.Controls.Add(this.yearPicker);
            resources.ApplyResources(this.pHeader, "pHeader");
            this.pHeader.Name = "pHeader";
            // 
            // btnLanguage
            // 
            resources.ApplyResources(this.btnLanguage, "btnLanguage");
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // weekSelector
            // 
            resources.ApplyResources(this.weekSelector, "weekSelector");
            this.weekSelector.Name = "weekSelector";
            // 
            // printPlaner
            // 
            this.printPlaner.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPlaner_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.AllowCurrentPage = true;
            this.printDialog.Document = this.printPlaner;
            this.printDialog.PrintToFile = true;
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Document = this.printPlaner;
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // weekPlaner
            // 
            resources.ApplyResources(this.weekPlaner, "weekPlaner");
            this.weekPlaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.weekPlaner.Name = "weekPlaner";
            // 
            // MeetingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.weekPlaner);
            this.Controls.Add(this.pHeader);
            this.Name = "MeetingForm";
            this.Load += new System.EventHandler(this.MeetingForm_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker yearPicker;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.DateTimePicker monthPicker;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Button btnNew;
        private CustomCalendar weekSelector;
        private System.Windows.Forms.Label lbWeek;
        private System.Windows.Forms.Panel pHeader;
        private System.Drawing.Printing.PrintDocument printPlaner;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button btnLanguage;
        private WeekPlaner weekPlaner;
    }
}

