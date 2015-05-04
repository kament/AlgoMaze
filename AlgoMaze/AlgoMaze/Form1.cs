using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlgoMaze
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         Board 10x10 will be represented by an array from cells
         Each cell could be different type(Free, Obstacle and so on)
         */

        class Cell : PictureBox
        /*we create the cell class, which is basically a picturebox
        with an additional property, which would be very helpful
        because we could save the map of the level in a text file
        */
        {
            public string TypeInString; //contains the type of the pictureBox (free, wall..) in string format;
        }

        Cell[,] cell = new Cell[10, 10]; //array of cells, to represent the board

        Image FreeCell = Properties.Resources.freePoint;
        Image RobotCell = Properties.Resources.robotInPoint;
        Image ExitCell = Properties.Resources.Exit;
        Image WallCell = Properties.Resources.closed;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMaze();
            SetLevel(0);
            InitializeMainMenu();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SetCellAccordingToForm(int i, int j) //scales the cell to fit the screen
        {
            int CellLineLength = (int)(this.Height / 11); //to fit the screen, but the cell has to still be square
            cell[i, j].Size = new Size(CellLineLength, CellLineLength);
            Point LocationCell = new Point();
            LocationCell.X = (this.Width / 10) + (i - 1) * cell[i, j].Size.Width;
            LocationCell.Y = (int)(this.Height / 1.34) - (j - 1) * cell[i, j].Size.Height;
            cell[i, j].Location = LocationCell;
        }

        private void InitializeMainMenu()
        {
            MainMenu.Visible = true;
            MainMenu.Height = this.Height;
            MainMenu.Width = this.Width;
            MainMenu.BackgroundImage = Properties.Resources.MainMenuBackground;
            MainMenuLogo.Anchor = AnchorStyles.Top;
        }

        void InitializeMaze() // a function that adds the cells to the form and makes them freeCell
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    cell[i, j] = new Cell();
                    /*to fit different resolutions, we must 
                     define the size and the location of the cells
                     depending on the size of the screen
                     */
                    SetCellAccordingToForm(i, j);
                    cell[i, j].Anchor = AnchorStyles.None;
                    cell[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    SetFreeCell(i, j);
                    cell[i, j].Visible = true;
                    this.Controls.Add(cell[i, j]);
                }
            }
            closeForm.Size = new Size(cell[0, 0].Size.Height / 2, cell[0, 0].Size.Width / 2);
            moveCommand.Size = cell[0, 0].Size;
            RunUserCode.Size = new Size(cell[0, 0].Size.Width * 3 + 60, cell[0, 0].Size.Width);
            rotateCommand.Size = moveCommand.Size;
            DelCommand.Size = moveCommand.Size;
            closeForm.Size = moveCommand.Size;

        }

        void SetLevel(int level)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    SetFreeCell(i, j);
                    ClearAllCommands();
                }
            //in each case, we set the level
            switch (level)
            {
                case 0:
                    //set level 0
                    SetExitCell(5, 8);
                    //set robot cell
                    SetRobotCell(0, 5);
                    //set the walls
                    SetWallCell(0, 0);
                    SetWallCell(0, 9);
                    for (int j = 0; j < 10; j++)
                    {
                        if (j != 2) SetWallCell(1, j);
                    }
                    for (int j = 1; j < 5; j++)
                    {
                        if (j != 3) SetWallCell(2, j);
                    }
                    SetWallCell(2, 7);
                    SetWallCell(3, 6);
                    for (int j = 3; j < 8; j++)
                    {
                        if (j != 6) SetWallCell(4, j);
                    }
                    for (int j = 1; j < 5; j++)
                    {
                        SetWallCell(5, j);
                    }
                    SetWallCell(5, 9);
                    SetWallCell(6, 0);
                    SetWallCell(6, 1);
                    for (int j = 4; j < 8; j++)
                    {
                        if (j != 6) SetWallCell(6, j);
                    }
                    SetWallCell(7, 0);
                    SetWallCell(7, 5);
                    for (int j = 5; j < 9; j++)
                    {
                        SetWallCell(8, j);
                    }
                    SetWallCell(9, 5);
                    SetWallCell(9, 9);
                    break;
            }
        }

        void SetFreeCell(int x, int y)
        {
            cell[x, y].Image = FreeCell;
            cell[x, y].TypeInString = "Free";
        }

        Point ExitCoordinates = new Point();
        void SetExitCell(int x, int y)
        {
            cell[x, y].Image = ExitCell;
            cell[x, y].TypeInString = "Exit";
            ExitCoordinates.X = x;
            ExitCoordinates.Y = y;
        }

        void SetRobotCell(int x, int y)
        {
            cell[x, y].Image = RobotCell;
            cell[x, y].TypeInString = "Robot";
            robot.x = x;
            robot.y = y;
        }

        void SetWallCell(int x, int y)
        {
            cell[x, y].Image = WallCell;
            cell[x, y].TypeInString = "Wall";
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = true;
        }

        private void moveCommand_Click(object sender, EventArgs e)
        {
            listCommands.Items.Add("MoveForward");
        }

        private void rotateCommand_Click(object sender, EventArgs e)
        {
            choiceOrientation.Visible = true;
        }

        private void DelCommand_Click(object sender, EventArgs e)
        {
            try
            {
                listCommands.Items.RemoveAt(listCommands.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please stop hitting the del button");
            }
        }

        // Image Buffer;
        struct Robot
        {
            public string Orientation;
            public int x;
            public int y;
        };
        Robot robot;

        private void NorthWest_Click(object sender, EventArgs e)
        {
            robot.Orientation = "";
            robot.Orientation = (sender as Button).Text;
            choiceOrientation.Visible = false;
        }

        private void choiceOrientation_VisibleChanged(object sender, EventArgs e)
        {
            if (choiceOrientation.Visible)
            {
                NorthOrientation.Click += new EventHandler(NorthWest_Click);
                NorthWest.Click += new EventHandler(NorthWest_Click);
                NorthEast.Click += new EventHandler(NorthWest_Click);
                WestOrientation.Click += new EventHandler(NorthWest_Click);
                EastOrientation.Click += new EventHandler(NorthWest_Click);
                SouthWest.Click += new EventHandler(NorthWest_Click);
                SouthOrientation.Click += new EventHandler(NorthWest_Click);
                SouthEast.Click += new EventHandler(NorthWest_Click);
            }
            else
            {
                if (robot.Orientation != null)
                    listCommands.Items.Add(robot.Orientation);
            }
        }

        private void RunUserCode_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listCommands.Items.Count; i++)
            {
                ExecuteCommand(listCommands.Items[i].ToString());
            }
            CheckIfWin();
        }

        string CurrentPath = Directory.GetCurrentDirectory();

        private void CheckIfWin()
        {
            if (listCommands.Items.Count > 30)
            {
                MessBox("// Error - StackOverflowException", "You have a maximum of 30 moves!");
            }
            else
            {
                if (cell[ExitCoordinates.X, ExitCoordinates.Y].TypeInString != "Exit")
                {
                    MessBox("// You won!", "Thank you for playing!");
                    CurrentPath += "\\";
                    try
                    {
                        System.Diagnostics.Process.Start(CurrentPath + "3DAlgoMaze.exe");
                    }
                    catch(Exception)
                    {

                    }
                    listCommands.Items.Clear();
                }
                else
                {
                    MessBox("// Error - 'You lost'", "Try reaching the exit!");
                    SetLevel(0);
                }
            }
        }

        Point oldRobot = new Point();
        Timer moveDelay = new Timer();

        void ExecuteCommand(string command)
        {
            if (command == "MoveForward")
            {
                MessageBox.Show("Moving");
                MakeMove(robot.x, robot.y, robot.Orientation);
            }
            else
            {
                robot.Orientation = command;
            }
        }

        //private void moveDelay_Tick(object sender, EventArgs e)
        //{
        //}

        void MakeMove(int x, int y, string command)
        {
            oldRobot.X = robot.x;
            oldRobot.Y = robot.y;

            switch (command)
            {
                case "North":
                    if (movePossible(oldRobot.X, oldRobot.Y + 1))
                    {
                        SetRobotCell(oldRobot.X, oldRobot.Y + 1);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "North-East":
                    if (movePossible(oldRobot.X + 1, oldRobot.Y + 1))
                    {
                        SetRobotCell(oldRobot.X + 1, oldRobot.Y + 1);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "East":
                    if (movePossible(oldRobot.X + 1, oldRobot.Y))
                    {
                        SetRobotCell(oldRobot.X + 1, oldRobot.Y);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "South-East":
                    if (movePossible(oldRobot.X + 1, oldRobot.Y - 1))
                    {
                        SetRobotCell(oldRobot.X + 1, oldRobot.Y - 1);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "South":
                    if (movePossible(oldRobot.X, oldRobot.Y - 1))
                    {
                        SetRobotCell(oldRobot.X, oldRobot.Y - 1);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "South-West":
                    if (movePossible(oldRobot.X - 1, oldRobot.Y - 1))
                    {
                        SetRobotCell(oldRobot.X - 1, oldRobot.Y - 1);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "West":
                    if (movePossible(oldRobot.X - 1, oldRobot.Y))
                    {
                        SetRobotCell(oldRobot.X - 1, oldRobot.Y);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
                case "North-West":
                    if (movePossible(oldRobot.X - 1, oldRobot.Y + 1))
                    {
                        SetRobotCell(oldRobot.X - 1, oldRobot.Y + 1);
                        SetFreeCell(oldRobot.X, oldRobot.Y);
                    }
                    break;
            }


        }

        private bool movePossible(int x, int y)
        {
            bool insideRange = x < 10 && x > -1 && y < 10 && y > -1;
            bool isWall = false;
            if (insideRange)
            {
                isWall = cell[x, y].TypeInString == "Wall";
            }
            if (insideRange && !isWall)
            {
                return true;
            }
            else
            {
                //TODO: MessBox
                SetLevel(0);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            robot.Orientation = null;
            choiceOrientation.Visible = false;
        }

        private void ClearCommands_Click(object sender, EventArgs e)
        {
            ClearAllCommands();
        }

        public void ClearAllCommands()
        {
            listCommands.Items.Clear();
            listCommands.Items.Add("North");
        }

        private void choiceOrientation_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeGame_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = false;
        }

        private void MessBox(string title, string content)
        {
            CustomMessageBox.Visible = true;
            Title.Text = title;
            MessageText.Text = content;
            CustomMessageBox.BringToFront();

            CustomMessageBox.Location = new Point(
                this.ClientSize.Width / 2 - CustomMessageBox.Size.Width / 2,
                this.ClientSize.Height / 2 - CustomMessageBox.Size.Height / 2);
            CustomMessageBox.Anchor = AnchorStyles.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Visible = false;
        }

        private void RenderTutorial_Click(object sender, EventArgs e)
        {
            tutorialPanel.Visible = true;
            tutorialPanel.Height = this.Height;
            tutorialPanel.Width = this.Width;
        }

        private void tutorialExit_Click(object sender, EventArgs e)
        {
            tutorialPanel.Visible = false;
        }
    }
}
