using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace FillComboBox {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colParameter;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if( disposing ) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParameter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Table1";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Parameter";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Unit";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Value";
            this.dataColumn3.DataType = typeof(decimal);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParameter,
            this.colUnit,
            this.colValue});
            this.gridView1.GridControl = this.gridControl1;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Name = "gridView1";
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            // 
            // colParameter
            // 
            resources.ApplyResources(this.colParameter, "colParameter");
            this.colParameter.FieldName = "Parameter";
            this.colParameter.Name = "colParameter";
            // 
            // colUnit
            // 
            resources.ApplyResources(this.colUnit, "colUnit");
            this.colUnit.ColumnEdit = this.repositoryItemComboBox1;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // repositoryItemComboBox1
            // 
            resources.ApplyResources(this.repositoryItemComboBox1, "repositoryItemComboBox1");
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox1.Buttons"))))});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colValue
            // 
            resources.ApplyResources(this.colValue, "colValue");
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new Form1());
        }

        Hashtable units = new Hashtable();

        private void Form1_Load(object sender, System.EventArgs e) {
            dataTable1.Rows.Add("length", "m", 2.1);
            dataTable1.Rows.Add("color", "Red", 1.1);
            dataTable1.Rows.Add("weight", "kg", 20);

            string[] sizes = new string[] { "m", "cm", "inch" };
            string[] weights = new string[] { "kg", "pound" };
            string[] colors = new string[] { "Red", "Green", "Blue" };

            units.Add("length", sizes);
            units.Add("weight", weights);
            units.Add("color", colors);
        }

		
        private void gridView1_ShownEditor(object sender, System.EventArgs e) {
            GridView view = sender as GridView;
            if(view.FocusedColumn.FieldName == "Unit") {
                ComboBoxEdit edit = (ComboBoxEdit)view.ActiveEditor;
                edit.Properties.Items.Clear();
				
                object parameter = view.GetRowCellValue(view.FocusedRowHandle, "Parameter");
                if(units[parameter] != null)
                    edit.Properties.Items.AddRange((ICollection)units[parameter]);
            }
        }
    }
}