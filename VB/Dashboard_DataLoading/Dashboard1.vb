Imports System
Imports Dashboard_DataLoading.nwindDataSetTableAdapters
Imports DevExpress.DashboardCommon

Namespace Dashboard_DataLoading
    Partial Public Class Dashboard1
        Inherits DevExpress.DashboardCommon.Dashboard

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Dashboard1_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) _
            Handles MyBase.DataLoading
            Dim categories As New SalesPersonTableAdapter()
            categories.Fill(Me.nwindDataSet1.SalesPerson)
            If e.DataSource.ComponentName = "dashboardObjectDataSource1" Then
                e.Data = Me.nwindDataSet1.SalesPerson
            End If
        End Sub
    End Class
End Namespace
