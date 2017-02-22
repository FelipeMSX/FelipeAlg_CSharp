namespace AspectProgramming
{
	partial class Principal
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
			this.btOK = new DevComponents.DotNetBar.ButtonX();
			this.SuspendLayout();
			// 
			// btOK
			// 
			this.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btOK.Location = new System.Drawing.Point(484, 274);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 23);
			this.btOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btOK.TabIndex = 0;
			this.btOK.Text = "OK";
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 309);
			this.Controls.Add(this.btOK);
			this.Name = "Principal";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.ButtonX btOK;
	}
}

