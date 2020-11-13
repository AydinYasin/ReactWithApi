using Involved.Cv.Contracts.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Involved.Cv.Contracts
{
    public class AllEmployeesOverviewDto
    {
        public List<EmployeeOverviewDto> EmployeesOverview { get; set; }
    }
}
