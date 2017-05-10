namespace Project_Cadimuns
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
			this.components = new System.ComponentModel.Container();
			this.panelTop = new DevComponents.DotNetBar.PanelEx();
			this.bindingSourceConnection = new System.Windows.Forms.BindingSource(this.components);
			this.panelExBottom = new DevComponents.DotNetBar.PanelEx();
			this.buttonBack = new DevComponents.DotNetBar.ButtonX();
			this.buttonNext = new DevComponents.DotNetBar.ButtonX();
			this.buttonCancel = new DevComponents.DotNetBar.ButtonX();
			this.panelMain = new DevComponents.DotNetBar.PanelEx();
			this.itemPanelSteps = new DevComponents.DotNetBar.ItemPanel();
			this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
			this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
			this.tabControl1 = new DevComponents.DotNetBar.TabControl();
			this.tabMain = new DevComponents.DotNetBar.TabControlPanel();
			this.circularProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
			this.buttonTaskTest = new DevComponents.DotNetBar.ButtonX();
			this.labelProcessamento = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labal1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDoor = new System.Windows.Forms.TextBox();
			this.mskAddressIP = new System.Windows.Forms.MaskedTextBox();
			this.groupBoxLogin = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.btnConnect = new DevComponents.DotNetBar.ButtonX();
			this.label4 = new System.Windows.Forms.Label();
			this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
			this.tabControlSelectDataBase = new DevComponents.DotNetBar.TabControlPanel();
			this.labelInfoPanel2 = new System.Windows.Forms.Label();
			this.comboBoxDataBase = new System.Windows.Forms.ComboBox();
			this.bindingSourceDataBase = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
			this.errorProvidermskAddress = new System.Windows.Forms.ErrorProvider(this.components);
			this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceConnection)).BeginInit();
			this.panelExBottom.SuspendLayout();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBoxLogin.SuspendLayout();
			this.tabControlSelectDataBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvidermskAddress)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(600, 61);
			this.panelTop.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelTop.Style.BackColor1.Color = System.Drawing.SystemColors.Control;
			this.panelTop.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panelTop.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
			this.panelTop.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
			this.panelTop.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.panelTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelTop.Style.GradientAngle = 90;
			this.panelTop.TabIndex = 0;
			// 
			// bindingSourceConnection
			// 
			this.bindingSourceConnection.DataSource = typeof(Project_Cadimuns.Model.Connection);
			this.bindingSourceConnection.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingSourceConnection_AddingNew);
			this.bindingSourceConnection.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bindingSourceConnection_BindingComplete);
			this.bindingSourceConnection.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.bindingSourceConnection_DataError);
			this.bindingSourceConnection.CurrentChanged += new System.EventHandler(this.bindingSourceConnection_CurrentChanged);
			// 
			// panelExBottom
			// 
			this.panelExBottom.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelExBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelExBottom.Controls.Add(this.buttonBack);
			this.panelExBottom.Controls.Add(this.buttonNext);
			this.panelExBottom.Controls.Add(this.buttonCancel);
			this.panelExBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelExBottom.Location = new System.Drawing.Point(0, 390);
			this.panelExBottom.Name = "panelExBottom";
			this.panelExBottom.Size = new System.Drawing.Size(600, 53);
			this.panelExBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelExBottom.Style.BackColor1.Color = System.Drawing.Color.White;
			this.panelExBottom.Style.BackColor2.Color = System.Drawing.Color.White;
			this.panelExBottom.Style.BackgroundImage = global::Project_Cadimuns.Properties.Resources.bottomImage;
			this.panelExBottom.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft;
			this.panelExBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelExBottom.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
			this.panelExBottom.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
			this.panelExBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelExBottom.Style.GradientAngle = 90;
			this.panelExBottom.TabIndex = 1;
			// 
			// buttonBack
			// 
			this.buttonBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonBack.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.Location = new System.Drawing.Point(318, 18);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 2;
			this.buttonBack.Text = "Voltar";
			this.buttonBack.TextColor = System.Drawing.Color.Black;
			this.buttonBack.ThemeAware = true;
			// 
			// buttonNext
			// 
			this.buttonNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonNext.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNext.Location = new System.Drawing.Point(399, 18);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(75, 23);
			this.buttonNext.TabIndex = 1;
			this.buttonNext.Text = "Avançar";
			this.buttonNext.TextColor = System.Drawing.Color.Black;
			this.buttonNext.ThemeAware = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancel.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancel.Location = new System.Drawing.Point(508, 18);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "Cancelar";
			this.buttonCancel.TextColor = System.Drawing.Color.Black;
			this.buttonCancel.ThemeAware = true;
			// 
			// panelMain
			// 
			this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelMain.Controls.Add(this.itemPanelSteps);
			this.panelMain.Controls.Add(this.tabControl1);
			this.panelMain.Location = new System.Drawing.Point(-2, 61);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(604, 329);
			this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelMain.Style.BackColor1.Color = System.Drawing.Color.White;
			this.panelMain.Style.BackColor2.Color = System.Drawing.Color.White;
			this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelMain.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
			this.panelMain.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
			this.panelMain.Style.ForeColor.Color = System.Drawing.Color.Gray;
			this.panelMain.Style.GradientAngle = 90;
			this.panelMain.TabIndex = 2;
			// 
			// itemPanelSteps
			// 
			this.itemPanelSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.itemPanelSteps.BackgroundStyle.BackColor = System.Drawing.Color.White;
			this.itemPanelSteps.BackgroundStyle.BackColor2 = System.Drawing.Color.White;
			this.itemPanelSteps.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.itemPanelSteps.BackgroundStyle.BorderBottomWidth = 1;
			this.itemPanelSteps.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
			this.itemPanelSteps.BackgroundStyle.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(199)))));
			this.itemPanelSteps.BackgroundStyle.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground;
			this.itemPanelSteps.BackgroundStyle.BorderRightWidth = 1;
			this.itemPanelSteps.BackgroundStyle.Class = "ItemPanel";
			this.itemPanelSteps.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemPanelSteps.ContainerControlProcessDialogKey = true;
			this.itemPanelSteps.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.labelItem2});
			this.itemPanelSteps.ItemSpacing = 0;
			this.itemPanelSteps.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemPanelSteps.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.itemPanelSteps.Location = new System.Drawing.Point(1, -2);
			this.itemPanelSteps.Name = "itemPanelSteps";
			this.itemPanelSteps.Size = new System.Drawing.Size(147, 332);
			this.itemPanelSteps.TabIndex = 0;
			this.itemPanelSteps.Text = "itemPanel1";
			// 
			// labelItem1
			// 
			this.labelItem1.BackColor = System.Drawing.SystemColors.Control;
			this.labelItem1.Font = new System.Drawing.Font("Gadugi", 8F);
			this.labelItem1.ForeColor = System.Drawing.Color.Black;
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.PaddingBottom = 5;
			this.labelItem1.PaddingTop = 5;
			this.labelItem1.Text = "Conexão";
			this.labelItem1.TextAlignment = System.Drawing.StringAlignment.Center;
			// 
			// labelItem2
			// 
			this.labelItem2.Font = new System.Drawing.Font("Gadugi", 8F);
			this.labelItem2.ForeColor = System.Drawing.Color.Black;
			this.labelItem2.Name = "labelItem2";
			this.labelItem2.PaddingBottom = 5;
			this.labelItem2.PaddingTop = 5;
			this.labelItem2.Text = "Configuração";
			this.labelItem2.TextAlignment = System.Drawing.StringAlignment.Center;
			// 
			// tabControl1
			// 
			this.tabControl1.BackColor = System.Drawing.Color.Transparent;
			this.tabControl1.CanReorderTabs = true;
			this.tabControl1.ColorScheme.TabBackground = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabBackground2 = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemBackground = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemBackground2 = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemBorder = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemBorderDark = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemHotBackground2 = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemHotBorder = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemHotBorderDark = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemHotBorderLight = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabItemSelectedBorder = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabPanelBackground = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabPanelBackground2 = System.Drawing.Color.White;
			this.tabControl1.ColorScheme.TabPanelBorder = System.Drawing.Color.White;
			this.tabControl1.Controls.Add(this.tabMain);
			this.tabControl1.Controls.Add(this.tabControlSelectDataBase);
			this.tabControl1.Location = new System.Drawing.Point(148, -25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.tabControl1.SelectedTabIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(454, 354);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.tabControl1.Tabs.Add(this.tabItem1);
			this.tabControl1.Tabs.Add(this.tabItem2);
			this.tabControl1.Text = "tabControl1";
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.buttonX1);
			this.tabMain.Controls.Add(this.circularProgress);
			this.tabMain.Controls.Add(this.buttonTaskTest);
			this.tabMain.Controls.Add(this.labelProcessamento);
			this.tabMain.Controls.Add(this.groupBox1);
			this.tabMain.Controls.Add(this.groupBoxLogin);
			this.tabMain.Controls.Add(this.btnConnect);
			this.tabMain.Controls.Add(this.label4);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.Location = new System.Drawing.Point(0, 26);
			this.tabMain.Name = "tabMain";
			this.tabMain.Padding = new System.Windows.Forms.Padding(1);
			this.tabMain.Size = new System.Drawing.Size(454, 328);
			this.tabMain.Style.BackColor1.Color = System.Drawing.Color.White;
			this.tabMain.Style.BackColor2.Color = System.Drawing.Color.White;
			this.tabMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabMain.Style.BorderColor.Color = System.Drawing.Color.White;
			this.tabMain.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.tabMain.Style.GradientAngle = 90;
			this.tabMain.TabIndex = 1;
			this.tabMain.TabItem = this.tabItem1;
			// 
			// circularProgress
			// 
			this.circularProgress.BackColor = System.Drawing.Color.White;
			// 
			// 
			// 
			this.circularProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.circularProgress.Location = new System.Drawing.Point(422, 302);
			this.circularProgress.Name = "circularProgress";
			this.circularProgress.ProgressColor = System.Drawing.Color.SeaGreen;
			this.circularProgress.ProgressTextColor = System.Drawing.Color.Black;
			this.circularProgress.Size = new System.Drawing.Size(28, 23);
			this.circularProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.circularProgress.TabIndex = 25;
			this.circularProgress.Value = 6;
			this.circularProgress.Visible = false;
			// 
			// buttonTaskTest
			// 
			this.buttonTaskTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonTaskTest.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTaskTest.Location = new System.Drawing.Point(172, 258);
			this.buttonTaskTest.Name = "buttonTaskTest";
			this.buttonTaskTest.Size = new System.Drawing.Size(75, 23);
			this.buttonTaskTest.TabIndex = 26;
			this.buttonTaskTest.Text = "Iniciar";
			this.buttonTaskTest.TextColor = System.Drawing.Color.Black;
			this.buttonTaskTest.ThemeAware = true;
			this.buttonTaskTest.Click += new System.EventHandler(this.buttonTaskTest_Click);
			// 
			// labelProcessamento
			// 
			this.labelProcessamento.AutoSize = true;
			this.labelProcessamento.BackColor = System.Drawing.Color.White;
			this.labelProcessamento.Location = new System.Drawing.Point(310, 302);
			this.labelProcessamento.Name = "labelProcessamento";
			this.labelProcessamento.Size = new System.Drawing.Size(106, 13);
			this.labelProcessamento.TabIndex = 23;
			this.labelProcessamento.Text = "Em processamento...";
			this.labelProcessamento.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.labal1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDoor);
			this.groupBox1.Controls.Add(this.mskAddressIP);
			this.groupBox1.Location = new System.Drawing.Point(20, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 76);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Endereço";
			// 
			// labal1
			// 
			this.labal1.AutoSize = true;
			this.labal1.BackColor = System.Drawing.Color.White;
			this.labal1.Location = new System.Drawing.Point(3, 35);
			this.labal1.Name = "labal1";
			this.labal1.Size = new System.Drawing.Size(53, 13);
			this.labal1.TabIndex = 0;
			this.labal1.Text = "Endereço";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(176, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Porta";
			// 
			// txtDoor
			// 
			this.txtDoor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConnection, "Port", true));
			this.txtDoor.Location = new System.Drawing.Point(214, 34);
			this.txtDoor.MaxLength = 255;
			this.txtDoor.Name = "txtDoor";
			this.txtDoor.Size = new System.Drawing.Size(68, 20);
			this.txtDoor.TabIndex = 15;
			// 
			// mskAddressIP
			// 
			this.mskAddressIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConnection, "Address", true));
			this.mskAddressIP.Location = new System.Drawing.Point(63, 34);
			this.mskAddressIP.Mask = "999.999.999.999";
			this.mskAddressIP.Name = "mskAddressIP";
			this.mskAddressIP.Size = new System.Drawing.Size(100, 20);
			this.mskAddressIP.TabIndex = 16;
			this.mskAddressIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTextBox_KeyDown);
			this.mskAddressIP.Validating += new System.ComponentModel.CancelEventHandler(this.mskTextBox_Validating);
			// 
			// groupBoxLogin
			// 
			this.groupBoxLogin.BackColor = System.Drawing.Color.White;
			this.groupBoxLogin.Controls.Add(this.label1);
			this.groupBoxLogin.Controls.Add(this.label2);
			this.groupBoxLogin.Controls.Add(this.txtPassword);
			this.groupBoxLogin.Controls.Add(this.txtUser);
			this.groupBoxLogin.Location = new System.Drawing.Point(20, 123);
			this.groupBoxLogin.Name = "groupBoxLogin";
			this.groupBoxLogin.Size = new System.Drawing.Size(308, 99);
			this.groupBoxLogin.TabIndex = 21;
			this.groupBoxLogin.TabStop = false;
			this.groupBoxLogin.Text = "Login";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Senha";
			// 
			// txtPassword
			// 
			this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConnection, "Password", true));
			this.txtPassword.Location = new System.Drawing.Point(62, 58);
			this.txtPassword.MaxLength = 255;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 18;
			// 
			// txtUser
			// 
			this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConnection, "UserName", true));
			this.txtUser.Location = new System.Drawing.Point(62, 26);
			this.txtUser.MaxLength = 255;
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(100, 20);
			this.txtUser.TabIndex = 17;
			// 
			// btnConnect
			// 
			this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnConnect.BackColor = System.Drawing.Color.Transparent;
			this.btnConnect.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Image = global::Project_Cadimuns.Properties.Resources.database_connect;
			this.btnConnect.Location = new System.Drawing.Point(266, 228);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(62, 40);
			this.btnConnect.TabIndex = 20;
			this.btnConnect.TextColor = System.Drawing.Color.Black;
			this.btnConnect.ThemeAware = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(16, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(225, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Informe a conexão com o servidor SQL Server";
			// 
			// tabItem1
			// 
			this.tabItem1.AttachedControl = this.tabMain;
			this.tabItem1.Name = "tabItem1";
			this.tabItem1.Text = "tabItem1";
			// 
			// tabControlSelectDataBase
			// 
			this.tabControlSelectDataBase.Controls.Add(this.labelInfoPanel2);
			this.tabControlSelectDataBase.Controls.Add(this.comboBoxDataBase);
			this.tabControlSelectDataBase.Controls.Add(this.label5);
			this.tabControlSelectDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlSelectDataBase.Location = new System.Drawing.Point(0, 26);
			this.tabControlSelectDataBase.Name = "tabControlSelectDataBase";
			this.tabControlSelectDataBase.Padding = new System.Windows.Forms.Padding(1);
			this.tabControlSelectDataBase.Size = new System.Drawing.Size(454, 328);
			this.tabControlSelectDataBase.Style.BackColor1.Color = System.Drawing.Color.White;
			this.tabControlSelectDataBase.Style.BackColor2.Color = System.Drawing.Color.White;
			this.tabControlSelectDataBase.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabControlSelectDataBase.Style.BorderColor.Color = System.Drawing.Color.White;
			this.tabControlSelectDataBase.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.tabControlSelectDataBase.Style.GradientAngle = 90;
			this.tabControlSelectDataBase.TabIndex = 2;
			this.tabControlSelectDataBase.TabItem = this.tabItem2;
			// 
			// labelInfoPanel2
			// 
			this.labelInfoPanel2.AutoSize = true;
			this.labelInfoPanel2.BackColor = System.Drawing.Color.White;
			this.labelInfoPanel2.ForeColor = System.Drawing.Color.DarkBlue;
			this.labelInfoPanel2.Location = new System.Drawing.Point(16, 12);
			this.labelInfoPanel2.Name = "labelInfoPanel2";
			this.labelInfoPanel2.Size = new System.Drawing.Size(225, 13);
			this.labelInfoPanel2.TabIndex = 22;
			this.labelInfoPanel2.Text = "Informe a conexão com o servidor SQL Server";
			// 
			// comboBoxDataBase
			// 
			this.comboBoxDataBase.DataSource = this.bindingSourceDataBase;
			this.comboBoxDataBase.DisplayMember = "Name";
			this.comboBoxDataBase.FormattingEnabled = true;
			this.comboBoxDataBase.Location = new System.Drawing.Point(40, 73);
			this.comboBoxDataBase.Name = "comboBoxDataBase";
			this.comboBoxDataBase.Size = new System.Drawing.Size(249, 21);
			this.comboBoxDataBase.TabIndex = 21;
			// 
			// bindingSourceDataBase
			// 
			this.bindingSourceDataBase.DataSource = typeof(Project_Cadimuns.Model.DataBase);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(17, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Banco de dados";
			// 
			// tabItem2
			// 
			this.tabItem2.AttachedControl = this.tabControlSelectDataBase;
			this.tabItem2.Name = "tabItem2";
			this.tabItem2.Text = "tabItem2";
			// 
			// errorProvidermskAddress
			// 
			this.errorProvidermskAddress.ContainerControl = this;
			// 
			// buttonX1
			// 
			this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonX1.Location = new System.Drawing.Point(103, 258);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new System.Drawing.Size(63, 23);
			this.buttonX1.TabIndex = 27;
			this.buttonX1.Text = "Cancelar";
			this.buttonX1.TextColor = System.Drawing.Color.Black;
			this.buttonX1.ThemeAware = true;
			this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 443);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelExBottom);
			this.Controls.Add(this.panelTop);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Projeto Cadimuns";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceConnection)).EndInit();
			this.panelExBottom.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.tabMain.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBoxLogin.ResumeLayout(false);
			this.groupBoxLogin.PerformLayout();
			this.tabControlSelectDataBase.ResumeLayout(false);
			this.tabControlSelectDataBase.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvidermskAddress)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.PanelEx panelTop;
		private DevComponents.DotNetBar.PanelEx panelExBottom;
		private DevComponents.DotNetBar.PanelEx panelMain;
		private DevComponents.DotNetBar.ButtonX buttonCancel;
		private DevComponents.DotNetBar.ButtonX buttonBack;
		private DevComponents.DotNetBar.ButtonX buttonNext;
		private DevComponents.DotNetBar.TabControl tabControl1;
		private DevComponents.DotNetBar.TabControlPanel tabMain;
		private DevComponents.DotNetBar.TabItem tabItem1;
		private System.Windows.Forms.Label labal1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private DevComponents.DotNetBar.ItemPanel itemPanelSteps;
		private DevComponents.DotNetBar.LabelItem labelItem1;
		private DevComponents.DotNetBar.LabelItem labelItem2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ErrorProvider errorProvidermskAddress;
		private System.Windows.Forms.MaskedTextBox mskAddressIP;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtDoor;
		private System.Windows.Forms.BindingSource bindingSourceConnection;
		private DevComponents.DotNetBar.ButtonX btnConnect;
		private System.Windows.Forms.BindingSource bindingSourceDataBase;
		private DevComponents.DotNetBar.TabControlPanel tabControlSelectDataBase;
		private System.Windows.Forms.Label labelInfoPanel2;
		private System.Windows.Forms.ComboBox comboBoxDataBase;
		private System.Windows.Forms.Label label5;
		private DevComponents.DotNetBar.TabItem tabItem2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBoxLogin;
		private DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
		private System.Windows.Forms.Label labelProcessamento;
		private DevComponents.DotNetBar.ButtonX buttonTaskTest;
		private DevComponents.DotNetBar.ButtonX buttonX1;
	}
}

