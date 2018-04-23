Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Namespace FillComboBox
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private colParameter As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colValue As DevExpress.XtraGrid.Columns.GridColumn
		Private bindingSource1 As BindingSource
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colParameter = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnit = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1})
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Parameter"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Unit"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Value"
			Me.dataColumn3.DataType = GetType(Decimal)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colParameter, Me.colUnit, Me.colValue})
			Me.gridView1.GridControl = Me.gridControl1
			resources.ApplyResources(Me.gridView1, "gridView1")
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.ShownEditor += New System.EventHandler(Me.gridView1_ShownEditor);
			' 
			' colParameter
			' 
			resources.ApplyResources(Me.colParameter, "colParameter")
			Me.colParameter.FieldName = "Parameter"
			Me.colParameter.Name = "colParameter"
			' 
			' colUnit
			' 
			resources.ApplyResources(Me.colUnit, "colUnit")
			Me.colUnit.ColumnEdit = Me.repositoryItemComboBox1
			Me.colUnit.FieldName = "Unit"
			Me.colUnit.Name = "colUnit"
			' 
			' repositoryItemComboBox1
			' 
			resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' colValue
			' 
			resources.ApplyResources(Me.colValue, "colValue")
			Me.colValue.FieldName = "Value"
			Me.colValue.Name = "colValue"
			' 
			' Form1
			' 
			resources.ApplyResources(Me, "$this")
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private units As New Hashtable()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			dataTable1.Rows.Add("length", "m", 2.1)
			dataTable1.Rows.Add("color", "Red", 1.1)
			dataTable1.Rows.Add("weight", "kg", 20)

			Dim sizes() As String = { "m", "cm", "inch" }
			Dim weights() As String = { "kg", "pound" }
			Dim colors() As String = { "Red", "Green", "Blue" }

			units.Add("length", sizes)
			units.Add("weight", weights)
			units.Add("color", colors)
		End Sub


		Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.ShownEditor
			Dim view As GridView = TryCast(sender, GridView)
			If view.FocusedColumn.FieldName = "Unit" Then
				Dim edit As ComboBoxEdit = CType(view.ActiveEditor, ComboBoxEdit)
				edit.Properties.Items.Clear()

				Dim parameter As Object = view.GetRowCellValue(view.FocusedRowHandle, "Parameter")
				If units(parameter) IsNot Nothing Then
					edit.Properties.Items.AddRange(CType(units(parameter), ICollection))
				End If
			End If
		End Sub
	End Class
End Namespace