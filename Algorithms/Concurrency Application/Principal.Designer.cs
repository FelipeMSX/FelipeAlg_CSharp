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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gbAcessarDados = new System.Windows.Forms.GroupBox();
			this.radioButton12 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.gbTaskBloqueante = new System.Windows.Forms.GroupBox();
			this.btnLancarBloqueante = new System.Windows.Forms.Button();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConsoleLock = new System.Windows.Forms.TextBox();
			this.gbTaskNormal = new System.Windows.Forms.GroupBox();
			this.rbGetCount = new System.Windows.Forms.RadioButton();
			this.rbGetPerson = new System.Windows.Forms.RadioButton();
			this.rbSetPerson = new System.Windows.Forms.RadioButton();
			this.rbIncCount = new System.Windows.Forms.RadioButton();
			this.btnLancarNormal = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.gbAcessarDados.SuspendLayout();
			this.gbTaskBloqueante.SuspendLayout();
			this.gbTaskNormal.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(53, 9);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(66, 20);
			this.txtTotal.TabIndex = 1;
			// 
			// txtConsole
			// 
			this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConsole.Location = new System.Drawing.Point(4, 140);
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.ReadOnly = true;
			this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtConsole.Size = new System.Drawing.Size(804, 178);
			this.txtConsole.TabIndex = 2;
			// 
			// lbConsole
			// 
			this.lbConsole.AutoSize = true;
			this.lbConsole.Location = new System.Drawing.Point(6, 124);
			this.lbConsole.Name = "lbConsole";
			this.lbConsole.Size = new System.Drawing.Size(48, 13);
			this.lbConsole.TabIndex = 3;
			this.lbConsole.Text = "Console:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Async B1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btLoop
			// 
			this.btLoop.Location = new System.Drawing.Point(6, 98);
			this.btLoop.Name = "btLoop";
			this.btLoop.Size = new System.Drawing.Size(105, 23);
			this.btLoop.TabIndex = 5;
			this.btLoop.Text = "Código Bloquante";
			this.btLoop.UseVisualStyleBackColor = true;
			this.btLoop.Click += new System.EventHandler(this.btLoop_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 69);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Async B2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.buttonAsyncSecond_Click);
			// 
			// btSameTime
			// 
			this.btSameTime.Location = new System.Drawing.Point(127, 40);
			this.btSameTime.Name = "btSameTime";
			this.btSameTime.Size = new System.Drawing.Size(105, 23);
			this.btSameTime.TabIndex = 7;
			this.btSameTime.Text = "Mesmo Tempo";
			this.btSameTime.UseVisualStyleBackColor = true;
			this.btSameTime.Click += new System.EventHandler(this.btSameTime_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(655, 359);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.lbConsole);
			this.tabPage1.Controls.Add(this.txtConsole);
			this.tabPage1.Controls.Add(this.btSameTime);
			this.tabPage1.Controls.Add(this.btLoop);
			this.tabPage1.Controls.Add(this.txtTotal);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(647, 333);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.gbAcessarDados);
			this.tabPage2.Controls.Add(this.gbTaskBloqueante);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.txtConsoleLock);
			this.tabPage2.Controls.Add(this.gbTaskNormal);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(647, 333);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Lock Study";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gbAcessarDados
			// 
			this.gbAcessarDados.Controls.Add(this.radioButton12);
			this.gbAcessarDados.Controls.Add(this.radioButton7);
			this.gbAcessarDados.Controls.Add(this.radioButton8);
			this.gbAcessarDados.Controls.Add(this.radioButton9);
			this.gbAcessarDados.Location = new System.Drawing.Point(443, 6);
			this.gbAcessarDados.Name = "gbAcessarDados";
			this.gbAcessarDados.Size = new System.Drawing.Size(200, 200);
			this.gbAcessarDados.TabIndex = 7;
			this.gbAcessarDados.TabStop = false;
			this.gbAcessarDados.Text = "Acessar Dados";
			// 
			// radioButton12
			// 
			this.radioButton12.AutoSize = true;
			this.radioButton12.Location = new System.Drawing.Point(11, 89);
			this.radioButton12.Name = "radioButton12";
			this.radioButton12.Size = new System.Drawing.Size(164, 17);
			this.radioButton12.TabIndex = 3;
			this.radioButton12.TabStop = true;
			this.radioButton12.Text = "Acessar tipo pessoa qualquer";
			this.radioButton12.UseVisualStyleBackColor = true;
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Location = new System.Drawing.Point(11, 66);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(158, 17);
			this.radioButton7.TabIndex = 2;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Acessar tipo inteiro qualquer";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(11, 43);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(100, 17);
			this.radioButton8.TabIndex = 1;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "Acessar pessoa";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(11, 20);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(108, 17);
			this.radioButton9.TabIndex = 0;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "Acessar contador";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// gbTaskBloqueante
			// 
			this.gbTaskBloqueante.Controls.Add(this.btnLancarBloqueante);
			this.gbTaskBloqueante.Controls.Add(this.radioButton10);
			this.gbTaskBloqueante.Controls.Add(this.radioButton4);
			this.gbTaskBloqueante.Controls.Add(this.radioButton5);
			this.gbTaskBloqueante.Controls.Add(this.radioButton6);
			this.gbTaskBloqueante.Location = new System.Drawing.Point(210, 6);
			this.gbTaskBloqueante.Name = "gbTaskBloqueante";
			this.gbTaskBloqueante.Size = new System.Drawing.Size(227, 200);
			this.gbTaskBloqueante.TabIndex = 6;
			this.gbTaskBloqueante.TabStop = false;
			this.gbTaskBloqueante.Text = "Task Bloqueante";
			// 
			// btnLancarBloqueante
			// 
			this.btnLancarBloqueante.Location = new System.Drawing.Point(160, 171);
			this.btnLancarBloqueante.Name = "btnLancarBloqueante";
			this.btnLancarBloqueante.Size = new System.Drawing.Size(61, 23);
			this.btnLancarBloqueante.TabIndex = 7;
			this.btnLancarBloqueante.Text = "Lançar";
			this.btnLancarBloqueante.UseVisualStyleBackColor = true;
			this.btnLancarBloqueante.Click += new System.EventHandler(this.btnLancarBloqueante_Click);
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Location = new System.Drawing.Point(9, 86);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(200, 17);
			this.radioButton10.TabIndex = 3;
			this.radioButton10.TabStop = true;
			this.radioButton10.Text = "Atribuir pessoa com lock de instância";
			this.radioButton10.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(9, 64);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(187, 17);
			this.radioButton4.TabIndex = 2;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Atribuir pessoa com lock de objeto";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(9, 42);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(217, 17);
			this.radioButton5.TabIndex = 1;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Incrementar contador com lock instância";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(9, 20);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(195, 17);
			this.radioButton6.TabIndex = 0;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Incrementar contador com lock type";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Console:";
			// 
			// txtConsoleLock
			// 
			this.txtConsoleLock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConsoleLock.Location = new System.Drawing.Point(4, 225);
			this.txtConsoleLock.Multiline = true;
			this.txtConsoleLock.Name = "txtConsoleLock";
			this.txtConsoleLock.ReadOnly = true;
			this.txtConsoleLock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtConsoleLock.Size = new System.Drawing.Size(640, 101);
			this.txtConsoleLock.TabIndex = 4;
			// 
			// gbTaskNormal
			// 
			this.gbTaskNormal.Controls.Add(this.btnLancarNormal);
			this.gbTaskNormal.Controls.Add(this.rbGetCount);
			this.gbTaskNormal.Controls.Add(this.rbGetPerson);
			this.gbTaskNormal.Controls.Add(this.rbSetPerson);
			this.gbTaskNormal.Controls.Add(this.rbIncCount);
			this.gbTaskNormal.Location = new System.Drawing.Point(4, 6);
			this.gbTaskNormal.Name = "gbTaskNormal";
			this.gbTaskNormal.Size = new System.Drawing.Size(200, 200);
			this.gbTaskNormal.TabIndex = 0;
			this.gbTaskNormal.TabStop = false;
			this.gbTaskNormal.Text = "Task Normal";
			// 
			// rbGetCount
			// 
			this.rbGetCount.AutoSize = true;
			this.rbGetCount.Location = new System.Drawing.Point(9, 89);
			this.rbGetCount.Name = "rbGetCount";
			this.rbGetCount.Size = new System.Drawing.Size(109, 17);
			this.rbGetCount.TabIndex = 3;
			this.rbGetCount.TabStop = true;
			this.rbGetCount.Text = "Acessar Contador";
			this.rbGetCount.UseVisualStyleBackColor = true;
			// 
			// rbGetPerson
			// 
			this.rbGetPerson.AutoSize = true;
			this.rbGetPerson.Location = new System.Drawing.Point(9, 66);
			this.rbGetPerson.Name = "rbGetPerson";
			this.rbGetPerson.Size = new System.Drawing.Size(101, 17);
			this.rbGetPerson.TabIndex = 2;
			this.rbGetPerson.TabStop = true;
			this.rbGetPerson.Text = "Acessar Pessoa";
			this.rbGetPerson.UseVisualStyleBackColor = true;
			// 
			// rbSetPerson
			// 
			this.rbSetPerson.AutoSize = true;
			this.rbSetPerson.Location = new System.Drawing.Point(9, 43);
			this.rbSetPerson.Name = "rbSetPerson";
			this.rbSetPerson.Size = new System.Drawing.Size(95, 17);
			this.rbSetPerson.TabIndex = 1;
			this.rbSetPerson.TabStop = true;
			this.rbSetPerson.Text = "Atribuir Pessoa";
			this.rbSetPerson.UseVisualStyleBackColor = true;
			// 
			// rbIncCount
			// 
			this.rbIncCount.AutoSize = true;
			this.rbIncCount.Location = new System.Drawing.Point(9, 20);
			this.rbIncCount.Name = "rbIncCount";
			this.rbIncCount.Size = new System.Drawing.Size(107, 17);
			this.rbIncCount.TabIndex = 0;
			this.rbIncCount.TabStop = true;
			this.rbIncCount.Text = "Incrementar valor";
			this.rbIncCount.UseVisualStyleBackColor = true;
			// 
			// btnLancarNormal
			// 
			this.btnLancarNormal.Location = new System.Drawing.Point(134, 171);
			this.btnLancarNormal.Name = "btnLancarNormal";
			this.btnLancarNormal.Size = new System.Drawing.Size(61, 23);
			this.btnLancarNormal.TabIndex = 4;
			this.btnLancarNormal.Text = "Lançar";
			this.btnLancarNormal.UseVisualStyleBackColor = true;
			this.btnLancarNormal.Click += new System.EventHandler(this.btnLancarNormal_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 359);
			this.Controls.Add(this.tabControl1);
			this.Name = "Principal";
			this.Text = "Concorrência Estudo";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.gbAcessarDados.ResumeLayout(false);
			this.gbAcessarDados.PerformLayout();
			this.gbTaskBloqueante.ResumeLayout(false);
			this.gbTaskBloqueante.PerformLayout();
			this.gbTaskNormal.ResumeLayout(false);
			this.gbTaskNormal.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox gbTaskNormal;
		private System.Windows.Forms.RadioButton rbGetPerson;
		private System.Windows.Forms.RadioButton rbSetPerson;
		private System.Windows.Forms.RadioButton rbIncCount;
		private System.Windows.Forms.GroupBox gbAcessarDados;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.GroupBox gbTaskBloqueante;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtConsoleLock;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton12;
		private System.Windows.Forms.RadioButton rbGetCount;
		private System.Windows.Forms.Button btnLancarBloqueante;
		private System.Windows.Forms.Button btnLancarNormal;
	}
}

