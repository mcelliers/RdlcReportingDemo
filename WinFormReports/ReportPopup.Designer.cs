namespace WinFormReports
{
    partial class ReportPopup
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
            MyReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // MyReportViewer
            // 
            MyReportViewer.Location = new Point(0, 0);
            MyReportViewer.Name = "ReportViewer";
            MyReportViewer.ServerReport.BearerToken = null;
            MyReportViewer.Size = new Size(850, 550);
            MyReportViewer.TabIndex = 0;
            // 
            // ReportPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(MyReportViewer);
            Name = "ReportPopup";
            Text = "ReportPopup";
            Load += ReportPopup_Load;
            Paint += ReportPopup_Paint;
            ResumeLayout(false);
        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer MyReportViewer;
    }
} //Class End