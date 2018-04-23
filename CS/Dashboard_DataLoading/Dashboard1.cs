using System;
using Dashboard_DataLoading.nwindDataSetTableAdapters;
using DevExpress.DashboardCommon;

namespace Dashboard_DataLoading {
    public partial class Dashboard1 : DevExpress.DashboardCommon.Dashboard {
        public Dashboard1() {
            InitializeComponent();
        }

        private void Dashboard1_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
            SalesPersonTableAdapter categories = new SalesPersonTableAdapter();
            categories.Fill(this.nwindDataSet1.SalesPerson);
            if (e.DataSource.ComponentName == "dashboardObjectDataSource1") {
                e.Data = this.nwindDataSet1.SalesPerson;
            }
        }
    }
}
