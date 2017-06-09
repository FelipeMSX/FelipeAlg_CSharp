namespace ScanFiles
{
	partial class ReportSafe
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsTotal = new System.Windows.Forms.ToolStripLabel();
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(228, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Selecione o diretório onde residem os relatórios";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(390, 78);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Pesquisar";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTotal});
			this.toolStrip1.Location = new System.Drawing.Point(0, 108);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(471, 25);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsTotal
			// 
			this.tsTotal.Name = "tsTotal";
			this.tsTotal.Size = new System.Drawing.Size(0, 22);
			// 
			// ReportSafe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 133);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDirectory);
			this.Controls.Add(this.btnDirectory);
			this.DoubleBuffered = true;
			this.Name = "ReportSafe";
			this.RightToLeftLayout = true;
			this.Text = "Escaneador de relatórios";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnDirectory;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TextBox txtDirectory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tsTotal;
	}
}

