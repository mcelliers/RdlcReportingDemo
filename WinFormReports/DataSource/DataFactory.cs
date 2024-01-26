using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormReports.Models;

namespace WinFormReports.DataSource;

public static class DataFactory
{
    public static List<OperatorsModel> GetOperators()
    {
        List<OperatorsModel> Operators = new List<OperatorsModel>();
        Operators.Add(new OperatorsModel() { Id = 1, FirstName = "John", LastName = "Smith" });
        Operators.Add(new OperatorsModel() { Id = 2, FirstName = "Cindy", LastName = "Stephens" });
        Operators.Add(new OperatorsModel() { Id = 3, FirstName = "John", LastName = "Travolta" });
        Operators.Add(new OperatorsModel() { Id = 4, FirstName = "Tom", LastName = "Cruise" });
        Operators.Add(new OperatorsModel() { Id = 5, FirstName = "Jenifer", LastName = "Aniston" });

        return Operators;
    }




}
