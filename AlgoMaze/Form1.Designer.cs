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
            this.components = new System.ComponentModel.Container();
            this.listCommands = new System.Windows.Forms.ListBox();
            this.choiceOrientation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SouthOrientation = new System.Windows.Forms.Button();
            this.SouthEast = new System.Windows.Forms.Button();
            this.SouthWest = new System.Windows.Forms.Button();
            this.NorthEast = new System.Windows.Forms.Button();
            this.WestOrientation = new System.Windows.Forms.Button();
            this.EastOrientation = new System.Windows.Forms.Button();
            this.NorthOrientation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerExecuteCommand = new System.Windows.Forms.Timer(this.components);
            this.NorthWest = new System.Windows.Forms.Button();
            this.ClearCommands = new System.Windows.Forms.PictureBox();
            this.DelCommand = new System.Windows.Forms.PictureBox();
            this.rotateCommand = new System.Windows.Forms.PictureBox();
            this.RunUserCode = new System.Windows.Forms.PictureBox();
            this.moveCommand = new System.Windows.Forms.PictureBox();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.choiceOrientation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunUserCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // listCommands
            // 
            this.listCommands.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listCommands.FormattingEnabled = true;
            this.listCommands.ItemHeight = 24;
            this.listCommands.Items.AddRange(new object[] {
            "North"});
            this.listCommands.Location = new System.Drawing.Point(604, 209);
            this.listCommands.Name = "listCommands";
            this.listCommands.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCommands.Size = new System.Drawing.Size(381, 268);
            this.listCommands.TabIndex = 7;
            // 
            // choiceOrientation
            // 
            this.choiceOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.choiceOrientation.Location = new System.Drawing.Point(604, 209);
            this.choiceOrientation.Name = "choiceOrientation";
            this.choiceOrientation.Size = new System.Drawing.Size(398, 222);
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
            this.button1.Location = new System.Drawing.Point(126, 192);
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
            this.SouthOrientation.Location = new System.Drawing.Point(155, 136);
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
            this.SouthEast.Location = new System.Drawing.Point(249, 136);
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
            this.SouthWest.Location = new System.Drawing.Point(3, 136);
            this.SouthWest.Name = "SouthWest";
            this.SouthWest.Size = new System.Drawing.Size(146, 30);
            this.SouthWest.TabIndex = 8;
            this.SouthWest.Text = "South-West";
            this.SouthWest.UseVisualStyleBackColor = false;
            // 
            // NorthEast
            // 
            this.NorthEast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthEast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.NorthEast.Cursor = System.Windows.Forms.Cursors.Default;
            this.NorthEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NorthEast.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthEast.Location = new System.Drawing.Point(251, 64);
            this.NorthEast.Name = "NorthEast";
            this.NorthEast.Size = new System.Drawing.Size(133, 30);
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
            this.WestOrientation.Location = new System.Drawing.Point(59, 100);
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
            this.EastOrientation.Location = new System.Drawing.Point(251, 100);
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
            this.NorthOrientation.Location = new System.Drawing.Point(155, 64);
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
            this.label1.Text = "//Choose Orientation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NorthWest
            // 
            this.NorthWest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthWest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.NorthWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NorthWest.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthWest.Location = new System.Drawing.Point(3, 64);
            this.NorthWest.Name = "NorthWest";
            this.NorthWest.Size = new System.Drawing.Size(146, 30);
            this.NorthWest.TabIndex = 7;
            this.NorthWest.Text = "North-West";
            this.NorthWest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NorthWest.UseVisualStyleBackColor = false;
            this.NorthWest.Click += new System.EventHandler(this.NorthWest_Click);
            // 
            // ClearCommands
            // 
            this.ClearCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCommands.Location = new System.Drawing.Point(832, 123);
            this.ClearCommands.Name = "ClearCommands";
            this.ClearCommands.Size = new System.Drawing.Size(70, 70);
            this.ClearCommands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearCommands.TabIndex = 10;
            this.ClearCommands.TabStop = false;
            this.ClearCommands.Click += new System.EventHandler(this.ClearCommands_Click);
            // 
            // DelCommand
            // 
            this.DelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelCommand.Image = global::AlgoMaze.Properties.Resources.DelCommand;
            this.DelCommand.Location = new System.Drawing.Point(756, 123);
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
            this.rotateCommand.Location = new System.Drawing.Point(680, 123);
            this.rotateCommand.Name = "rotateCommand";
            this.rotateCommand.Size = new System.Drawing.Size(70, 70);
            this.rotateCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rotateCommand.TabIndex = 6;
            this.rotateCommand.TabStop = false;
            this.rotateCommand.Click += new System.EventHandler(this.rotateCommand_Click);
            // 
            // RunUserCode
            // 
            this.RunUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunUserCode.Image = global::AlgoMaze.Properties.Resources.compileAndRun;
            this.RunUserCode.Location = new System.Drawing.Point(604, 36);
            this.RunUserCode.Name = "RunUserCode";
            this.RunUserCode.Size = new System.Drawing.Size(210, 70);
            this.RunUserCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunUserCode.TabIndex = 5;
            this.RunUserCode.TabStop = false;
            this.RunUserCode.Click += new System.EventHandler(this.RunUserCode_Click);
            // 
            // moveCommand
            // 
            this.moveCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveCommand.Image = global::AlgoMaze.Properties.Resources.MoveCommand;
            this.moveCommand.Location = new System.Drawing.Point(604, 123);
            this.moveCommand.Name = "moveCommand";
            this.moveCommand.Size = new System.Drawing.Size(70, 70);
            this.moveCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveCommand.TabIndex = 4;
            this.moveCommand.TabStop = false;
            this.moveCommand.Click += new System.EventHandler(this.moveCommand_Click);
            // 
            // closeForm
            // 
            this.closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeForm.Image = global::AlgoMaze.Properties.Resources.exitButton;
            this.closeForm.Location = new System.Drawing.Point(945, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(70, 70);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeForm.TabIndex = 3;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1016, 507);
            this.Controls.Add(this.ClearCommands);
            this.Controls.Add(this.choiceOrientation);
            this.Controls.Add(this.DelCommand);
            this.Controls.Add(this.listCommands);
            this.Controls.Add(this.rotateCommand);
            this.Controls.Add(this.RunUserCode);
            this.Controls.Add(this.moveCommand);
            this.Controls.Add(this.closeForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.choiceOrientation.ResumeLayout(false);
            this.choiceOrientation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunUserCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.PictureBox moveCommand;
        private System.Windows.Forms.PictureBox RunUserCode;
        private System.Windows.Forms.PictureBox rotateCommand;
        private System.Windows.Forms.ListBox listCommands;
        private System.Windows.Forms.PictureBox DelCommand;
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
        private System.Windows.Forms.Timer timerExecuteCommand;
    }
}

