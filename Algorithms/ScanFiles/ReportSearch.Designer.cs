namespace ScanFiles
{
	partial class ReportSearch
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
			this.btnDirectory = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.txtDirectory = new System.Windows.Forms.TextBox();
			this.dataGridViewResult = new System.Windows.Forms.DataGridView();
			this.nm_file = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nu_threadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMatch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsTotal = new System.Windows.Forms.ToolStripLabel();
			this.buttonClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDirectory
			// 
			this.btnDirectory.Location = new System.Drawing.Point(388, 26);
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
			this.txtDirectory.Location = new System.Drawing.Point(13, 27);
			this.txtDirectory.Name = "txtDirectory";
			this.txtDirectory.ReadOnly = true;
			this.txtDirectory.Size = new System.Drawing.Size(369, 20);
			this.txtDirectory.TabIndex = 1;
			// 
			// dataGridViewResult
			// 
			this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nm_file,
			this.nu_threadId});
			this.dataGridViewResult.Location = new System.Drawing.Point(13, 105);
			this.dataGridViewResult.Name = "dataGridViewResult";
			this.dataGridViewResult.ShowCellErrors = false;
			this.dataGridViewResult.ShowCellToolTips = false;
			this.dataGridViewResult.ShowEditingIcon = false;
			this.dataGridViewResult.ShowRowErrors = false;
			this.dataGridViewResult.Size = new System.Drawing.Size(369, 150);
			this.dataGridViewResult.TabIndex = 2;
			this.dataGridViewResult.VirtualMode = true;
			// 
			// nm_file
			// 
			this.nm_file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nm_file.DataPropertyName = "nm_file";
			this.nm_file.HeaderText = "Nome do Arquivo";
			this.nm_file.Name = "nm_file";
			this.nm_file.ReadOnly = true;
			// 
			// nu_threadId
			// 
			this.nu_threadId.DataPropertyName = "nu_threadId";
			this.nu_threadId.HeaderText = "Thread ID";
			this.nu_threadId.Name = "nu_threadId";
			this.nu_threadId.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "O que você está procurando?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(228, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Selecione o diretório onde residem os relatórios";
			// 
			// txtMatch
			// 
			this.txtMatch.Location = new System.Drawing.Point(13, 79);
			this.txtMatch.Name = "txtMatch";
			this.txtMatch.Size = new System.Drawing.Size(369, 20);
			this.txtMatch.TabIndex = 5;
			this.txtMatch.Text = "funcionario";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(388, 78);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Pesquisar";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsTotal});
			this.toolStrip1.Location = new System.Drawing.Point(0, 262);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(593, 25);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsTotal
			// 
			this.tsTotal.Name = "tsTotal";
			this.tsTotal.Size = new System.Drawing.Size(0, 22);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(469, 79);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 8;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// formReportSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 287);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtMatch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewResult);
			this.Controls.Add(this.txtDirectory);
			this.Controls.Add(this.btnDirectory);
			this.DoubleBuffered = true;
			this.Name = "formReportSearch";
			this.RightToLeftLayout = true;
			this.Text = "Escaneador de relatórios";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnDirectory;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TextBox txtDirectory;
		private System.Windows.Forms.DataGridView dataGridViewResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMatch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tsTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn nm_file;
		private System.Windows.Forms.DataGridViewTextBoxColumn nu_threadId;
		private System.Windows.Forms.Button buttonClear;
	}
}

