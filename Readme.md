<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580126/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5160)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Dashboard1.cs](./CS/Dashboard_DataLoading/Dashboard1.cs) (VB: [Dashboard1.vb](./VB/Dashboard_DataLoading/Dashboard1.vb))
* [WebForm1.aspx](./CS/Dashboard_DataLoading/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_DataLoading/WebForm1.aspx))
<!-- default file list end -->
# How to bind a dashboard to a DataSet at design time and provide data at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5160)**
<!-- run online end -->


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to bind a dashboard to a <strong>DataSet</strong> at design time and fill it with data from the <em>SalesPerson</em> table in the Northwind database.</p>
<p>In this example, the dashboard is created at design time within Visual Studio and displayed in the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a>. The dataset is filled with data in the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_DataLoadingtopic">Dashboard.DataLoading</a> event handler.</p>

<br/>


