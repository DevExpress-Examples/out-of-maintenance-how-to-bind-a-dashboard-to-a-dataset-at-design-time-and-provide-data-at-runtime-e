Imports Microsoft.VisualBasic
Imports System
Imports Dashboard_DataLoading.nwindDataSetTableAdapters

Namespace Dashboard_DataLoading
	Partial Public Class Dashboard1
		Inherits DevExpress.DashboardCommon.Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Dashboard1_DashboardLoading(ByVal sender As Object, ByVal e As EventArgs) _
            Handles MyBase.DashboardLoading
            Dim categories As New SalesPersonTableAdapter()
            categories.Fill(Me.nwindDataSet1.SalesPerson)
        End Sub
	End Class
End Namespace
