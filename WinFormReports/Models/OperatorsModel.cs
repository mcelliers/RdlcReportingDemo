/******************************************************************************************************\
 * Author :         Marius Celliers 
 * email  :         marius.celliers@gmail.com
 * Description :    Demo Application to Demosnstrate ReportViewer in a WinForms DotNet 6 Application 
 * Date             26/01/2024
\******************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormReports.Models;

public class OperatorsModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return ($"{Id}-{FirstName} {LastName}");
        //   return base.ToString();
    }
} //Class End
