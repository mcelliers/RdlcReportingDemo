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
using WinFormReports.Models;

namespace WinFormReports.DataSource;

public static class DataFactory
{
    //Added Dummy Data to The Operators list
    public static List<OperatorsModel> GetOperators()
    {

        /*      HERE YOU CAN LINK UP TO A SQL DATABASE TO RETRIEVE THE DATA YOU REQUIRE         */

        List<OperatorsModel> Operators = new List<OperatorsModel>();
        Operators.Add(new OperatorsModel() { Id = 1, FirstName = "John", LastName = "Smith" });
        Operators.Add(new OperatorsModel() { Id = 2, FirstName = "Cindy", LastName = "Stephens" });
        Operators.Add(new OperatorsModel() { Id = 3, FirstName = "John", LastName = "Travolta" });
        Operators.Add(new OperatorsModel() { Id = 4, FirstName = "Tom", LastName = "Cruise" });
        Operators.Add(new OperatorsModel() { Id = 5, FirstName = "Jenifer", LastName = "Aniston" });
        Operators.Add(new OperatorsModel() { Id = 5, FirstName = "Vanilla", LastName = "Ice" });

        return Operators;
    }

} //Class End
