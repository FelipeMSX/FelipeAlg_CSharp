namespace Project_Report.Components
{
	partial class ReportSource
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMain = new DevComponents.DotNetBar.PanelEx();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(525, 348);
			this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelMain.Style.BackColor1.Color = System.Drawing.Color.White;
			this.panelMain.Style.BackColor2.Color = System.Drawing.Color.White;
			this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelMain.Style.GradientAngle = 90;
			this.panelMain.TabIndex = 1;
			// 
			// ReportSource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelMain);
			this.Name = "ReportSource";
			this.Size = new System.Drawing.Size(525, 348);
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.PanelEx panelMain;
	}
}
