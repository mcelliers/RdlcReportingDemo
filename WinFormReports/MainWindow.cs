using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.Common;
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
        reportpath = System.AppDomain.CurrentDomain.BaseDirectory + @"Reports\UsersReport.rdlc";

        //"D:\Development\Reports\FastReportsTestApp\WinFormReports\bin\Debug\net6.0-windows\Reports\UsersReport.rdlc"
        //LoadReport();
        //Or Add as Ambedded Resource "ProjectName.ReportDefinitions.UserReport.rdlc"
        //MyData.DataSetName = "OperatorData";

        if (File.Exists(reportpath))
        {
            CreateOperators();   //Create Dummy Operators
            //LoadReportPopup();
        }
        else
        {
            MessageBox.Show(reportpath, "File Not Found");
        }




        //MyReportViewer.LocalReport.DataSources.Clear();
        //MyReportViewer.LocalReport.DataSources.Add()
        //MyReportViewer.Refresh();
    }

    private void MainWindow_Paint(object sender, PaintEventArgs e)
    {
        //    if (MyReportViewer.Width != this.Width || MyReportViewer.Height != this.Height)
        //    {  MyReportViewer.Height = this.Height; MyReportViewer.Width = this.Width;}
    }

    private void CreateOperators()
    {
        Operators.Add(new OperatorsModel() { Id = 1, FirstName = "Marius", LastName = "Celliers" });
        Operators.Add(new OperatorsModel() { Id = 2, FirstName = "Cindy", LastName = "Celliers" });
    }

    private void LoadReport()
    {
        var reportDataSource = new ReportDataSource("dsOperators", Operators); // DataSetName should match the dataset name in your RDLC file

        //MyReportViewer.Width = this.Width;
        //MyReportViewer.Height = this.Height;
        MyReportViewer.LocalReport.ReportPath = reportpath;

        MyReportViewer.LocalReport.DataSources.Clear();
        MyReportViewer.LocalReport.DataSources.Add(reportDataSource);

        MyReportViewer.RefreshReport();
    }

    private void LoadReportPopup()
    {
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