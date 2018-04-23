using System;
using Dashboard_DataLoading.nwindDataSetTableAdapters;

namespace Dashboard_DataLoading {
    public partial class Dashboard1 : DevExpress.DashboardCommon.Dashboard {
        public Dashboard1() {
            InitializeComponent();
        }

        private void Dashboard1_DashboardLoading(object sender, EventArgs e) {
            SalesPersonTableAdapter categories = new SalesPersonTableAdapter();
            categories.Fill(this.nwindDataSet1.SalesPerson);
        }
    }
}
