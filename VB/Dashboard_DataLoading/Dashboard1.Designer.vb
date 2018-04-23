Namespace Dashboard_DataLoading
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim card2 As New DevExpress.DashboardCommon.Card()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim chartPane2 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.nwindDataSet1 = New Dashboard_DataLoading.nwindDataSet()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' cardDashboardItem1
            ' 
            measure3.DataMember = "Extended Price"
            card2.AddDataItem("ActualValue", measure3)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card2})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension4.DataMember = "Sales Person"
            dimension5.DataMember = "OrderDate"
            dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension5, "DataItem2")
            Me.cardDashboardItem1.DataSource = Me.dashboardObjectDataSource1
            Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.cardDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.cardDashboardItem1.Name = "Sales Person"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
            Me.cardDashboardItem1.ShowCaption = True
            Me.cardDashboardItem1.SparklineArgument = dimension5
            ' 
            ' dashboardObjectDataSource1
            ' 
            Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
            Me.dashboardObjectDataSource1.DataMember = "SalesPerson"
            Me.dashboardObjectDataSource1.DataSchema = resources.GetString("dashboardObjectDataSource1.DataSchema")
            Me.dashboardObjectDataSource1.Name = "Object Data Source 1"
            ' 
            ' chartDashboardItem1
            ' 
            dimension1.DataMember = "CategoryName"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure1.DataMember = "Extended Price"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1")
            Me.chartDashboardItem1.DataSource = Me.dashboardObjectDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Sales by Category"
            chartPane2.Name = "Pane 1"
            chartPane2.PrimaryAxisY.ShowGridLines = True
            chartPane2.PrimaryAxisY.TitleVisible = True
            chartPane2.SecondaryAxisY.ShowGridLines = False
            chartPane2.SecondaryAxisY.TitleVisible = True
            simpleSeries2.AddDataItem("Value", measure1)
            chartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries2})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane2})
            Me.chartDashboardItem1.ShowCaption = True
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.cardDashboardItem1, Me.chartDashboardItem1})
            dashboardLayoutItem3.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem3.Weight = 27.456258411843876R
            dashboardLayoutItem4.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem4.Weight = 72.543741588156124R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
            dashboardLayoutGroup2.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup2
            Me.Title.Text = "Dashboard"
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private nwindDataSet1 As nwindDataSet
        Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
    End Class
End Namespace
