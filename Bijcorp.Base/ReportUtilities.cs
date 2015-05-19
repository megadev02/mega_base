using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastReport;
using FastReport.Utils;
using FastReport.Export;
using System.Data;
using System.IO;

namespace Bijcorp.Base
{
    public class ReportUtilities
    {
        #region atributes

        public Report FReport;
        private DataSet FDataSet = new DataSet();
        public Dictionary<string, object> Parameters = new Dictionary<string, object>();

        #endregion

        #region properties

        public string DirectoryFrx { get; set; }
        public string ReportName { get; set; }

        #endregion

        #region constructors

        public ReportUtilities()
        {
            FReport = new Report();
        }

        #endregion

        #region methods

        private string GetReportsFolder()
        {
            string thisFolder = Config.ApplicationFolder;

            for (int i = 0; i < 6; i++)
            {

                if (System.IO.Directory.Exists(thisFolder + @"Reports"))
                {
                    return Path.GetFullPath(thisFolder + @"Reports\");
                }
                thisFolder += @"..\";
            }

            throw new Exception("Could not locate the Reports folder.");
        }

        public void ShowPreviewReport()
        {            
            string pathReportName = GetReportsFolder() + ReportName;
            FReport.Load(pathReportName);
            LoadParameters();
            RegisterDataReport();
            FReport.Prepare();
            FReport.ShowPrepared();
        }

        public void AddParameter(string key, object value)
        {
            if (!Parameters.ContainsKey(key))
                Parameters.Add(key, value);
            else
                Parameters[key] = value;
        }

        private void LoadParameters()
        {
            foreach (KeyValuePair<string, object> kvp in Parameters)
            {
                FReport.SetParameterValue(kvp.Key, kvp.Value);
            }
        }

        public void DesignReport()
        {            

            // get path of report
            string pathReportName = GetReportsFolder() + ReportName;

            // load the existing report
            if (System.IO.File.Exists(pathReportName))
                FReport.Load(pathReportName);

            // load parameters
            LoadParameters();

            // register the dataset
            RegisterDataReport();

            // enable the "Employees" datasource programmatically. 
            // You can also do this in the "Report|Choose Report Data..." menu.
            //FReport.GetDataSource("Employees").Enabled = true;

            // design the report
            FReport.Design();

            // free resources used by report
            //FReport.Dispose();
        }

        public void ShowReport()
        {
            // get path of report
            string pathReportName = GetReportsFolder() + ReportName;

            // load the existing report
            if (System.IO.File.Exists(pathReportName))
                FReport.Load(pathReportName);

            RegisterDataReport();

            // run the report
            FReport.Show();

            // free resources used by report
            FReport.Dispose();
        }

        public void ShowReport(FastReport.Preview.PreviewControl preview)
        {            
            // get path of report
            string pathReportName = GetReportsFolder() + ReportName;

            FReport.Preview = preview;

            // load the existing report
            if (System.IO.File.Exists(pathReportName))
                FReport.Load(pathReportName);

            RegisterDataReport();

            // run the report
            //FReport.Show();

            // free resources used by report
            //FReport.Dispose();


            FReport.Prepare();
            FReport.ShowPrepared();
        }

        public void RegisterDataReport()
        {
            // register the dataset            
            FReport.RegisterData(FDataSet);
        }

        public void RegisterDataTable(DataTable datatable, string name)
        {
            // register the datatable            
            datatable.TableName = name;
            if (FDataSet.Tables.Contains(name))
                FDataSet.Tables.Remove(name);
            FDataSet.Tables.Add(datatable);
        }

        #endregion
    }
}
