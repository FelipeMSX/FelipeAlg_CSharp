namespace Project_Report
{
	partial class Main
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
			this.reportSource1 = new Project_Report.Components.ReportSource();
			this.SuspendLayout();
			// 
			// reportSource1
			// 
			this.reportSource1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportSource1.Location = new System.Drawing.Point(0, 0);
			this.reportSource1.Name = "reportSource1";
			this.reportSource1.Size = new System.Drawing.Size(536, 381);
			this.reportSource1.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 381);
			this.Controls.Add(this.reportSource1);
			this.Name = "Main";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Components.ReportSource reportSource1;
	}
}

