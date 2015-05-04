namespace AlgoMaze
{
    partial class MainForm
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
            this.listCommands = new System.Windows.Forms.ListBox();
            this.choiceOrientation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SouthOrientation = new System.Windows.Forms.Button();
            this.SouthEast = new System.Windows.Forms.Button();
            this.SouthWest = new System.Windows.Forms.Button();
            this.NorthWest = new System.Windows.Forms.Button();
            this.NorthEast = new System.Windows.Forms.Button();
            this.WestOrientation = new System.Windows.Forms.Button();
            this.EastOrientation = new System.Windows.Forms.Button();
            this.NorthOrientation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.RunUserCode = new System.Windows.Forms.PictureBox();
            this.commandsPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearCommands = new System.Windows.Forms.PictureBox();
            this.moveCommand = new System.Windows.Forms.PictureBox();
            this.DelCommand = new System.Windows.Forms.PictureBox();
            this.rotateCommand = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.tutorialPanel = new System.Windows.Forms.Panel();
            this.tutorialExit = new System.Windows.Forms.Button();
            this.ApplicationExit = new System.Windows.Forms.Button();
            this.RenderTutorial = new System.Windows.Forms.Button();
            this.InitializeGame = new System.Windows.Forms.Button();
            this.MainMenuLogo = new System.Windows.Forms.PictureBox();
            this.CustomMessageBox = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.Label();
            this.MessageTitle = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.choiceOrientation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunUserCode)).BeginInit();
            this.commandsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCommand)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.tutorialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuLogo)).BeginInit();
            this.CustomMessageBox.SuspendLayout();
            this.MessageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCommands
            // 
            this.listCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCommands.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCommands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(118)))), ((int)(((byte)(224)))));
            this.listCommands.FormattingEnabled = true;
            this.listCommands.ItemHeight = 20;
            this.listCommands.Items.AddRange(new object[] {
            "North"});
            this.listCommands.Location = new System.Drawing.Point(17, 107);
            this.listCommands.Name = "listCommands";
            this.listCommands.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCommands.Size = new System.Drawing.Size(397, 560);
            this.listCommands.TabIndex = 7;
            // 
            // choiceOrientation
            // 
            this.choiceOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.choiceOrientation.Controls.Add(this.button1);
            this.choiceOrientation.Controls.Add(this.SouthOrientation);
            this.choiceOrientation.Controls.Add(this.SouthEast);
            this.choiceOrientation.Controls.Add(this.SouthWest);
            this.choiceOrientation.Controls.Add(this.NorthWest);
            this.choiceOrientation.Controls.Add(this.NorthEast);
            this.choiceOrientation.Controls.Add(this.WestOrientation);
            this.choiceOrientation.Controls.Add(this.EastOrientation);
            this.choiceOrientation.Controls.Add(this.NorthOrientation);
            this.choiceOrientation.Controls.Add(this.label1);
            this.choiceOrientation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.choiceOrientation.Location = new System.Drawing.Point(0, 477);
            this.choiceOrientation.Name = "choiceOrientation";
            this.choiceOrientation.Size = new System.Drawing.Size(427, 222);
            this.choiceOrientation.TabIndex = 9;
            this.choiceOrientation.Visible = false;
            this.choiceOrientation.VisibleChanged += new System.EventHandler(this.choiceOrientation_VisibleChanged);
            this.choiceOrientation.Paint += new System.Windows.Forms.PaintEventHandler(this.choiceOrientation_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SouthOrientation
            // 
            this.SouthOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.SouthOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SouthOrientation.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthOrientation.Location = new System.Drawing.Point(169, 136);
            this.SouthOrientation.Name = "SouthOrientation";
            this.SouthOrientation.Size = new System.Drawing.Size(90, 30);
            this.SouthOrientation.TabIndex = 10;
            this.SouthOrientation.Text = "South";
            this.SouthOrientation.UseVisualStyleBackColor = false;
            // 
            // SouthEast
            // 
            this.SouthEast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthEast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.SouthEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SouthEast.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthEast.Location = new System.Drawing.Point(263, 136);
            this.SouthEast.Name = "SouthEast";
            this.SouthEast.Size = new System.Drawing.Size(146, 30);
            this.SouthEast.TabIndex = 9;
            this.SouthEast.Text = "South-East";
            this.SouthEast.UseVisualStyleBackColor = false;
            // 
            // SouthWest
            // 
            this.SouthWest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthWest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.SouthWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SouthWest.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthWest.Location = new System.Drawing.Point(17, 136);
            this.SouthWest.Name = "SouthWest";
            this.SouthWest.Size = new System.Drawing.Size(146, 30);
            this.SouthWest.TabIndex = 8;
            this.SouthWest.Text = "South-West";
            this.SouthWest.UseVisualStyleBackColor = false;
            // 
            // NorthWest
            // 
            this.NorthWest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthWest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.NorthWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NorthWest.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthWest.Location = new System.Drawing.Point(17, 64);
            this.NorthWest.Name = "NorthWest";
            this.NorthWest.Size = new System.Drawing.Size(146, 30);
            this.NorthWest.TabIndex = 7;
            this.NorthWest.Text = "North-West";
            this.NorthWest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NorthWest.UseVisualStyleBackColor = false;
            this.NorthWest.Click += new System.EventHandler(this.NorthWest_Click);
            // 
            // NorthEast
            // 
            this.NorthEast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthEast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.NorthEast.Cursor = System.Windows.Forms.Cursors.Default;
            this.NorthEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NorthEast.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthEast.Location = new System.Drawing.Point(265, 64);
            this.NorthEast.Name = "NorthEast";
            this.NorthEast.Size = new System.Drawing.Size(144, 30);
            this.NorthEast.TabIndex = 6;
            this.NorthEast.Text = "North-East";
            this.NorthEast.UseVisualStyleBackColor = false;
            // 
            // WestOrientation
            // 
            this.WestOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WestOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.WestOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WestOrientation.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WestOrientation.Location = new System.Drawing.Point(73, 100);
            this.WestOrientation.Name = "WestOrientation";
            this.WestOrientation.Size = new System.Drawing.Size(90, 30);
            this.WestOrientation.TabIndex = 5;
            this.WestOrientation.Text = "West";
            this.WestOrientation.UseVisualStyleBackColor = false;
            // 
            // EastOrientation
            // 
            this.EastOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EastOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.EastOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EastOrientation.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EastOrientation.Location = new System.Drawing.Point(265, 100);
            this.EastOrientation.Name = "EastOrientation";
            this.EastOrientation.Size = new System.Drawing.Size(90, 30);
            this.EastOrientation.TabIndex = 4;
            this.EastOrientation.Text = "East";
            this.EastOrientation.UseVisualStyleBackColor = false;
            // 
            // NorthOrientation
            // 
            this.NorthOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.NorthOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NorthOrientation.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthOrientation.Location = new System.Drawing.Point(169, 64);
            this.NorthOrientation.Name = "NorthOrientation";
            this.NorthOrientation.Size = new System.Drawing.Size(90, 30);
            this.NorthOrientation.TabIndex = 1;
            this.NorthOrientation.Text = "North";
            this.NorthOrientation.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "// Choose Orientation\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(161)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Controls.Add(this.RunUserCode);
            this.panel1.Location = new System.Drawing.Point(636, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 93);
            this.panel1.TabIndex = 11;
            // 
            // closeForm
            // 
            this.closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeForm.Image = global::AlgoMaze.Properties.Resources.menuIcon;
            this.closeForm.Location = new System.Drawing.Point(342, 12);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(72, 70);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeForm.TabIndex = 3;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // RunUserCode
            // 
            this.RunUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunUserCode.BackgroundImage = global::AlgoMaze.Properties.Resources.compileAndRun;
            this.RunUserCode.Image = global::AlgoMaze.Properties.Resources.run;
            this.RunUserCode.Location = new System.Drawing.Point(17, 12);
            this.RunUserCode.Name = "RunUserCode";
            this.RunUserCode.Size = new System.Drawing.Size(269, 70);
            this.RunUserCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunUserCode.TabIndex = 5;
            this.RunUserCode.TabStop = false;
            this.RunUserCode.Click += new System.EventHandler(this.RunUserCode_Click);
            // 
            // commandsPanel
            // 
            this.commandsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandsPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commandsPanel.Controls.Add(this.choiceOrientation);
            this.commandsPanel.Controls.Add(this.panel3);
            this.commandsPanel.Controls.Add(this.listCommands);
            this.commandsPanel.Location = new System.Drawing.Point(636, 89);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Size = new System.Drawing.Size(427, 699);
            this.commandsPanel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.ClearCommands);
            this.panel3.Controls.Add(this.moveCommand);
            this.panel3.Controls.Add(this.DelCommand);
            this.panel3.Controls.Add(this.rotateCommand);
            this.panel3.Location = new System.Drawing.Point(17, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 85);
            this.panel3.TabIndex = 13;
            // 
            // ClearCommands
            // 
            this.ClearCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCommands.Image = global::AlgoMaze.Properties.Resources.clearAll;
            this.ClearCommands.Location = new System.Drawing.Point(236, 8);
            this.ClearCommands.Name = "ClearCommands";
            this.ClearCommands.Size = new System.Drawing.Size(70, 70);
            this.ClearCommands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearCommands.TabIndex = 10;
            this.ClearCommands.TabStop = false;
            this.ClearCommands.Click += new System.EventHandler(this.ClearCommands_Click);
            // 
            // moveCommand
            // 
            this.moveCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveCommand.Image = global::AlgoMaze.Properties.Resources.MoveCommand;
            this.moveCommand.Location = new System.Drawing.Point(8, 8);
            this.moveCommand.Name = "moveCommand";
            this.moveCommand.Size = new System.Drawing.Size(70, 70);
            this.moveCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveCommand.TabIndex = 4;
            this.moveCommand.TabStop = false;
            this.moveCommand.Click += new System.EventHandler(this.moveCommand_Click);
            // 
            // DelCommand
            // 
            this.DelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelCommand.Image = global::AlgoMaze.Properties.Resources.DelCommand;
            this.DelCommand.Location = new System.Drawing.Point(160, 8);
            this.DelCommand.Name = "DelCommand";
            this.DelCommand.Size = new System.Drawing.Size(70, 70);
            this.DelCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DelCommand.TabIndex = 8;
            this.DelCommand.TabStop = false;
            this.DelCommand.Click += new System.EventHandler(this.DelCommand_Click);
            // 
            // rotateCommand
            // 
            this.rotateCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateCommand.Image = global::AlgoMaze.Properties.Resources.rotation;
            this.rotateCommand.Location = new System.Drawing.Point(84, 8);
            this.rotateCommand.Name = "rotateCommand";
            this.rotateCommand.Size = new System.Drawing.Size(70, 70);
            this.rotateCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rotateCommand.TabIndex = 6;
            this.rotateCommand.TabStop = false;
            this.rotateCommand.Click += new System.EventHandler(this.rotateCommand_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.MainMenu.Controls.Add(this.tutorialPanel);
            this.MainMenu.Controls.Add(this.ApplicationExit);
            this.MainMenu.Controls.Add(this.RenderTutorial);
            this.MainMenu.Controls.Add(this.InitializeGame);
            this.MainMenu.Controls.Add(this.MainMenuLogo);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(612, 788);
            this.MainMenu.TabIndex = 13;
            this.MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tutorialPanel
            // 
            this.tutorialPanel.BackgroundImage = global::AlgoMaze.Properties.Resources.tutorial;
            this.tutorialPanel.Controls.Add(this.tutorialExit);
            this.tutorialPanel.Location = new System.Drawing.Point(3, 3);
            this.tutorialPanel.Name = "tutorialPanel";
            this.tutorialPanel.Size = new System.Drawing.Size(558, 281);
            this.tutorialPanel.TabIndex = 4;
            this.tutorialPanel.Visible = false;
            // 
            // tutorialExit
            // 
            this.tutorialExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tutorialExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.tutorialExit.FlatAppearance.BorderSize = 0;
            this.tutorialExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorialExit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialExit.Location = new System.Drawing.Point(402, 225);
            this.tutorialExit.Name = "tutorialExit";
            this.tutorialExit.Size = new System.Drawing.Size(133, 37);
            this.tutorialExit.TabIndex = 8;
            this.tutorialExit.Text = "Cancel";
            this.tutorialExit.UseVisualStyleBackColor = false;
            this.tutorialExit.Click += new System.EventHandler(this.tutorialExit_Click);
            // 
            // ApplicationExit
            // 
            this.ApplicationExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ApplicationExit.FlatAppearance.BorderSize = 0;
            this.ApplicationExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationExit.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.ApplicationExit.Location = new System.Drawing.Point(278, 28);
            this.ApplicationExit.Name = "ApplicationExit";
            this.ApplicationExit.Size = new System.Drawing.Size(312, 55);
            this.ApplicationExit.TabIndex = 3;
            this.ApplicationExit.Text = "Application.Exit();\r\n";
            this.ApplicationExit.UseVisualStyleBackColor = false;
            this.ApplicationExit.Click += new System.EventHandler(this.ApplicationExit_Click);
            // 
            // RenderTutorial
            // 
            this.RenderTutorial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RenderTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RenderTutorial.FlatAppearance.BorderSize = 0;
            this.RenderTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderTutorial.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenderTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.RenderTutorial.Location = new System.Drawing.Point(125, 663);
            this.RenderTutorial.Name = "RenderTutorial";
            this.RenderTutorial.Size = new System.Drawing.Size(282, 55);
            this.RenderTutorial.TabIndex = 2;
            this.RenderTutorial.Text = "RenderTutorial();\r\n";
            this.RenderTutorial.UseVisualStyleBackColor = false;
            this.RenderTutorial.Click += new System.EventHandler(this.RenderTutorial_Click);
            // 
            // InitializeGame
            // 
            this.InitializeGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InitializeGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InitializeGame.FlatAppearance.BorderSize = 0;
            this.InitializeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitializeGame.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitializeGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.InitializeGame.Location = new System.Drawing.Point(91, 583);
            this.InitializeGame.Name = "InitializeGame";
            this.InitializeGame.Size = new System.Drawing.Size(354, 70);
            this.InitializeGame.TabIndex = 1;
            this.InitializeGame.Text = "InitializeGame();";
            this.InitializeGame.UseVisualStyleBackColor = false;
            this.InitializeGame.Click += new System.EventHandler(this.InitializeGame_Click);
            // 
            // MainMenuLogo
            // 
            this.MainMenuLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuLogo.Image = global::AlgoMaze.Properties.Resources.logo;
            this.MainMenuLogo.Location = new System.Drawing.Point(-3, 0);
            this.MainMenuLogo.Name = "MainMenuLogo";
            this.MainMenuLogo.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.MainMenuLogo.Size = new System.Drawing.Size(509, 559);
            this.MainMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MainMenuLogo.TabIndex = 0;
            this.MainMenuLogo.TabStop = false;
            // 
            // CustomMessageBox
            // 
            this.CustomMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CustomMessageBox.Controls.Add(this.button2);
            this.CustomMessageBox.Controls.Add(this.MessageText);
            this.CustomMessageBox.Controls.Add(this.MessageTitle);
            this.CustomMessageBox.Location = new System.Drawing.Point(618, 207);
            this.CustomMessageBox.Name = "CustomMessageBox";
            this.CustomMessageBox.Size = new System.Drawing.Size(531, 235);
            this.CustomMessageBox.TabIndex = 4;
            this.CustomMessageBox.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(189, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.White;
            this.MessageText.Location = new System.Drawing.Point(26, 95);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(96, 25);
            this.MessageText.TabIndex = 6;
            this.MessageText.Text = "label3";
            // 
            // MessageTitle
            // 
            this.MessageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MessageTitle.Controls.Add(this.Title);
            this.MessageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageTitle.Location = new System.Drawing.Point(0, 0);
            this.MessageTitle.Name = "MessageTitle";
            this.MessageTitle.Size = new System.Drawing.Size(531, 70);
            this.MessageTitle.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(22, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(82, 25);
            this.Title.TabIndex = 6;
            this.Title.Text = "title";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1075, 788);
            this.Controls.Add(this.CustomMessageBox);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.commandsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.choiceOrientation.ResumeLayout(false);
            this.choiceOrientation.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunUserCode)).EndInit();
            this.commandsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClearCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCommand)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tutorialPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuLogo)).EndInit();
            this.CustomMessageBox.ResumeLayout(false);
            this.CustomMessageBox.PerformLayout();
            this.MessageTitle.ResumeLayout(false);
            this.MessageTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCommands;
        private System.Windows.Forms.Panel choiceOrientation;
        private System.Windows.Forms.Button SouthEast;
        private System.Windows.Forms.Button SouthWest;
        private System.Windows.Forms.Button NorthWest;
        private System.Windows.Forms.Button NorthEast;
        private System.Windows.Forms.Button WestOrientation;
        private System.Windows.Forms.Button EastOrientation;
        private System.Windows.Forms.Button NorthOrientation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SouthOrientation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ClearCommands;
        private System.Windows.Forms.PictureBox DelCommand;
        private System.Windows.Forms.PictureBox rotateCommand;
        private System.Windows.Forms.PictureBox moveCommand;
        private System.Windows.Forms.PictureBox RunUserCode;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel commandsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.PictureBox MainMenuLogo;
        private System.Windows.Forms.Button InitializeGame;
        private System.Windows.Forms.Button RenderTutorial;
        private System.Windows.Forms.Button ApplicationExit;
        private System.Windows.Forms.Panel CustomMessageBox;
        private System.Windows.Forms.Panel MessageTitle;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel tutorialPanel;
        private System.Windows.Forms.Button tutorialExit;
    }
}

