namespace ProcesoCRUD.Presentacion.Reportes
{
    partial class Frm_Rpt_Listado_pr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPLISTADOPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Reportes = new ProcesoCRUD.Presentacion.Reportes.DS_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_LISTADO_PRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_LISTADO_PRTableAdapter = new ProcesoCRUD.Presentacion.Reportes.DS_ReportesTableAdapters.USP_LISTADO_PRTableAdapter();
            this.txt_01 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPLISTADOPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_LISTADO_PRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPLISTADOPRBindingSource
            // 
            this.uSPLISTADOPRBindingSource.DataMember = "USP_LISTADO_PR";
            this.uSPLISTADOPRBindingSource.DataSource = this.DS_Reportes;
            // 
            // DS_Reportes
            // 
            this.DS_Reportes.DataSetName = "DS_Reportes";
            this.DS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPLISTADOPRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProcesoCRUD.Presentacion.Reportes.Rpt_Listado_pr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(965, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_LISTADO_PRBindingSource
            // 
            this.USP_LISTADO_PRBindingSource.DataMember = "USP_LISTADO_PR";
            this.USP_LISTADO_PRBindingSource.DataSource = this.DS_Reportes;
            // 
            // USP_LISTADO_PRTableAdapter
            // 
            this.USP_LISTADO_PRTableAdapter.ClearBeforeFill = true;
            // 
            // txt_01
            // 
            this.txt_01.Location = new System.Drawing.Point(38, 105);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(100, 20);
            this.txt_01.TabIndex = 1;
            this.txt_01.Visible = false;
            // 
            // Frm_Rpt_Listado_pr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 499);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Listado_pr";
            this.Text = "Frm_Rpt_Listado_pr";
            this.Load += new System.EventHandler(this.Frm_Rpt_Listado_pr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPLISTADOPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_LISTADO_PRBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_LISTADO_PRBindingSource;
        private DS_Reportes DS_Reportes;
        private DS_ReportesTableAdapters.USP_LISTADO_PRTableAdapter USP_LISTADO_PRTableAdapter;
        private System.Windows.Forms.BindingSource uSPLISTADOPRBindingSource;
        internal System.Windows.Forms.TextBox txt_01;
    }
}