/******************************************************************************************************\
 * Author :         Marius Celliers 
 * email  :         marius.celliers@gmail.com
 * Description :    Demo Application to Demosnstrate ReportViewer in a WinForms DotNet 6 Application 
 * Date             26/01/2024
\******************************************************************************************************/

using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.Common;
using WinFormReports.DataSource;
using WinFormReports.Models;



namespace WinFormReports;

public partial class MainWindow : Form
{

    public List<OperatorsModel> Operators { get; set; } = new List<OperatorsModel>();
    public DataSet MyData = new DataSet();
    public DataTable MyTable = new DataTable();
    public string reportpath { get; set; } = string.Empty;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {

        // This Report Is not Embedded but in the Application/Reports Folder
        reportpath = System.AppDomain.CurrentDomain.BaseDirectory + @"Reports\UsersReport.rdlc";

        if (File.Exists(reportpath))
        {

        }
        else
        {
            MessageBox.Show(reportpath, "File Not Found");
        }
    }

    private void MainWindow_Paint(object sender, PaintEventArgs e)
    {
        //    if (MyReportViewer.Width != this.Width || MyReportViewer.Height != this.Height)
        //    {  MyReportViewer.Height = this.Height; MyReportViewer.Width = this.Width;}
    }



    private void LoadReportPopup()
    {

        Operators = DataFactory.GetOperators(); // See the Dumy List in Satasource/DataFactory

        // 
        var reportDataSource = new ReportDataSource("dsOperators", Operators); // DataSetName should match the dataset name in your RDLC file

        ReportViewer viewer = new ReportViewer();
        viewer.LocalReport.ReportPath = reportpath;
        viewer.LocalReport.DataSources.Clear();
        viewer.LocalReport.DataSources.Add(reportDataSource);
        viewer.RefreshReport();

        ReportPopup popup = new ReportPopup();
        popup.MyReportViewer.LocalReport.ReportPath = reportpath;
        popup.MyReportViewer.LocalReport.DataSources.Clear();
        popup.MyReportViewer.LocalReport.DataSources.Add(reportDataSource);

        popup.ShowDialog();

    }

    private void UsersReportButton_Click(object sender, EventArgs e)
    {
        LoadReportPopup();
    }
} //Class End