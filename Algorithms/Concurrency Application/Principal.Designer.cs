namespace Concurrency_Application
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtConsole = new System.Windows.Forms.TextBox();
			this.lbConsole = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btLoop = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btSameTime = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(49, 12);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(66, 20);
			this.txtTotal.TabIndex = 1;
			// 
			// txtConsole
			// 
			this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConsole.Location = new System.Drawing.Point(12, 169);
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.ReadOnly = true;
			this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtConsole.Size = new System.Drawing.Size(506, 178);
			this.txtConsole.TabIndex = 2;
			// 
			// lbConsole
			// 
			this.lbConsole.AutoSize = true;
			this.lbConsole.Location = new System.Drawing.Point(14, 153);
			this.lbConsole.Name = "lbConsole";
			this.lbConsole.Size = new System.Drawing.Size(48, 13);
			this.lbConsole.TabIndex = 3;
			this.lbConsole.Text = "Console:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Async B1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btLoop
			// 
			this.btLoop.Location = new System.Drawing.Point(17, 114);
			this.btLoop.Name = "btLoop";
			this.btLoop.Size = new System.Drawing.Size(105, 23);
			this.btLoop.TabIndex = 5;
			this.btLoop.Text = "Código Bloquante";
			this.btLoop.UseVisualStyleBackColor = true;
			this.btLoop.Click += new System.EventHandler(this.btLoop_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(17, 85);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Async B2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.buttonAsyncSecond_Click);
			// 
			// btSameTime
			// 
			this.btSameTime.Location = new System.Drawing.Point(138, 56);
			this.btSameTime.Name = "btSameTime";
			this.btSameTime.Size = new System.Drawing.Size(105, 23);
			this.btSameTime.TabIndex = 7;
			this.btSameTime.Text = "Mesmo Tempo";
			this.btSameTime.UseVisualStyleBackColor = true;
			this.btSameTime.Click += new System.EventHandler(this.btSameTime_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 359);
			this.Controls.Add(this.btSameTime);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btLoop);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbConsole);
			this.Controls.Add(this.txtConsole);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label1);
			this.Name = "Principal";
			this.Text = "Concorrência Estudo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtConsole;
		private System.Windows.Forms.Label lbConsole;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btLoop;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btSameTime;
	}
}

