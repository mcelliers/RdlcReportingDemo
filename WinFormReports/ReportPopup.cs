/******************************************************************************************************\
 * Author :         Marius Celliers 
 * email  :         marius.celliers@gmail.com
 * Description :    Demo Application to Demosnstrate ReportViewer in a WinForms DotNet 6 Application 
 * Date             26/01/2024
\******************************************************************************************************/


using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormReports;

public partial class ReportPopup : Form
{
    public ReportPopup()
    {
        InitializeComponent();
    }

    private void ReportPopup_Load(object sender, EventArgs e)
    {
        MyReportViewer.Width = this.Width;
        MyReportViewer.Height = this.Height;
        MyReportViewer.RefreshReport();
        //MyReportViewer.LocalReport.ReportEmbeddedResource = reportpath;
    }

    private void ReportPopup_Paint(object sender, PaintEventArgs e)
    {
        //Resize the ReportViewer
        if (MyReportViewer.Width != this.Width || MyReportViewer.Height != this.Height)
        { MyReportViewer.Height = this.Height; MyReportViewer.Width = this.Width; }
    }
} //Class End
