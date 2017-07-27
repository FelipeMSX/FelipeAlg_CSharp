namespace ScanFiles
{
	partial class FileSearch
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
            this.btnDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTotal = new System.Windows.Forms.ToolStripLabel();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop = new DevComponents.DotNetBar.PanelEx();
            this.panelExBottom = new DevComponents.DotNetBar.PanelEx();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fileTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.directoryExceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSearch = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTypeBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panelExBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryExceptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(388, 81);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnDirectory.TabIndex = 0;
            this.btnDirectory.Text = "Diretório";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\WorkDir\\3Tecnos\\Workspaces\\ERP Contabilis\\Felipe\\Contabilis\\Reports";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(13, 82);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(369, 20);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.Text = "C:\\WorkDir\\3Tecnos\\Workspaces\\ERP Contabilis\\Felipe\\Contabilis";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.AutoGenerateColumns = false;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.fileInfoDataGridViewTextBoxColumn});
            this.dataGridViewResult.DataSource = this.fileTypeBindingSource;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.ShowCellErrors = false;
            this.dataGridViewResult.ShowCellToolTips = false;
            this.dataGridViewResult.ShowEditingIcon = false;
            this.dataGridViewResult.ShowRowErrors = false;
            this.dataGridViewResult.Size = new System.Drawing.Size(554, 263);
            this.dataGridViewResult.TabIndex = 2;
            this.dataGridViewResult.VirtualMode = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            this.extensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileInfoDataGridViewTextBoxColumn
            // 
            this.fileInfoDataGridViewTextBoxColumn.DataPropertyName = "FileInfo";
            this.fileInfoDataGridViewTextBoxColumn.HeaderText = "FileInfo";
            this.fileInfoDataGridViewTextBoxColumn.Name = "fileInfoDataGridViewTextBoxColumn";
            this.fileInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileTypeBindingSource
            // 
            this.fileTypeBindingSource.DataSource = typeof(ScanFiles.Model.FileType);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8F);
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o diretório onde residem os relatórios";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTotal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 464);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsTotal
            // 
            this.tsTotal.Name = "tsTotal";
            this.tsTotal.Size = new System.Drawing.Size(0, 22);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(ScanFiles.Model.FileType);
            // 
            // panelTop
            // 
            this.panelTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(578, 61);
            this.panelTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTop.Style.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.panelTop.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTop.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelTop.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
            this.panelTop.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.panelTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTop.Style.GradientAngle = 90;
            this.panelTop.TabIndex = 9;
            // 
            // panelExBottom
            // 
            this.panelExBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExBottom.Controls.Add(this.comboBox1);
            this.panelExBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExBottom.Location = new System.Drawing.Point(0, 411);
            this.panelExBottom.Name = "panelExBottom";
            this.panelExBottom.Size = new System.Drawing.Size(578, 53);
            this.panelExBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExBottom.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelExBottom.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelExBottom.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft;
            this.panelExBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExBottom.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
            this.panelExBottom.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this.panelExBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExBottom.Style.GradientAngle = 90;
            this.panelExBottom.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fileTypeBindingSource1;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // fileTypeBindingSource1
            // 
            this.fileTypeBindingSource1.DataSource = typeof(ScanFiles.Model.FileType);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSearch.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(469, 81);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.TextColor = System.Drawing.Color.Black;
            this.buttonSearch.ThemeAware = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 489);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelExBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnDirectory);
            this.DoubleBuffered = true;
            this.Name = "FileSearch";
            this.RightToLeftLayout = true;
            this.Text = "Escaneador de relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTypeBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panelExBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryExceptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnDirectory;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TextBox txtDirectory;
		private System.Windows.Forms.DataGridView dataGridViewResult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tsTotal;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fileTypeBindingSource;
        private DevComponents.DotNetBar.PanelEx panelTop;
        private DevComponents.DotNetBar.PanelEx panelExBottom;
        private DevComponents.DotNetBar.ButtonX buttonSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource directoryExceptionBindingSource;
        private System.Windows.Forms.BindingSource fileTypeBindingSource1;
    }
}

