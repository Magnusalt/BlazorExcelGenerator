using System;

namespace ExcelReport
{
    public class Result
    {
        public DateTime ReportDate { get; set; }
        public string FactoryName { get; set; }
        public int UnitsProduced { get; set; }
        public double SampleTimeHours{ get; set; }
        public string Incidents { get; set; }
        public double HourlyProductionRate => UnitsProduced / SampleTimeHours;
    }
}