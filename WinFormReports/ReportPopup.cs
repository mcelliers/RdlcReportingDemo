﻿using Microsoft.Reporting.WinForms;
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
} //Class End