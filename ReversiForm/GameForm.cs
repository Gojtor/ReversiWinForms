using System.Windows.Forms;
using Reversi.Persistance;
using Reversi.Model;
using System.Security.Cryptography.X509Certificates;
using System;
using Microsoft.VisualBasic.ApplicationServices;

namespace Reversi
{
    public partial class Board : Form
    {
        private IReversiDataAccess dataAccess;
        private ReversiGameModel model = null!;
        private Button[,] boardButtons = null!;
        private System.Windows.Forms.Timer timer = null!;
        private bool pauseBtnClicked = false;
        private Image black = ReversiForm.Properties.Resources.blackPiece;
        private Image white = ReversiForm.Properties.Resources.whitePiece;

        public Board()
        {
            InitializeComponent();

            dataAccess = new ReversiFileDataAccess();
            model = new ReversiGameModel(dataAccess);
            model.Advance += new EventHandler<ReversiEventArgs>(Game_Advance);
            model.GameOver += new EventHandler<ReversiEventArgs>(Game_Over);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Game_Advance(object? sender, ReversiEventArgs e)
        {
            if (!model.IsGameOver)
            {


                p2TimerLabel.Text = TimeSpan.FromSeconds(e.Player2Time).ToString();
                p1TimerLabel.Text = TimeSpan.FromSeconds(e.Player1Time).ToString();

                p1CountLabel.Text = e.Player1PieceCount.ToString();
                p2CountLabel.Text = e.Player2PieceCount.ToString();

                if (model.GetCurrentPlayerStatus)
                {
                    Player2Label.BackColor = Color.LightGreen;
                    Player1Label.BackColor = Color.LightGray;
                }
                else
                {
                    Player2Label.BackColor = Color.LightGray;
                    Player1Label.BackColor = Color.LightGreen;
                }

                if (e.Player1Pass)
                {
                    p1PassLabel.Show();
                    p1PassBtn.Show();
                }
                else if (e.Player2Pass)
                {
                    p2PassLabel.Show();
                    p2PassBtn.Show();
                }
            }
        }
        private void Game_Over(object? sender, ReversiEventArgs e)
        {
            timer.Stop();
            foreach (Button button in boardButtons)
            {
                button.Enabled = false;
            }
            if (e.Player1Won)
            {
                MessageBox.Show("Player 1 won the game!",
                                "Reversi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else if (e.Player2Won)
            {
                MessageBox.Show("Player 2 won the game!",
                                "Reversi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("It's a tie!",
                                "Reversi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
        }
        private void newGame_Click(object? sender, EventArgs e)
        {
            panelMenu.Hide();
            pauseBtn.Show();
            pauseBtnClicked = false;
            quit.Location = new Point(saveGame.Location.X, saveGame.Location.Y + 80);
            if (smallTable.Checked) { model.NewGame(10); }
            if (mediumTable.Checked) { model.NewGame(20); }
            if (largeTable.Checked) { model.NewGame(30); }
            if (boardButtons == null)
            {
                GenerateTable();
            }
            else
            {
                foreach (Button button in boardButtons)
                {
                    Controls.Remove(button);
                    button.Dispose();
                }
                boardButtons = null!;
                GenerateTable();
            }
            model.CheckValidPlaces();
            SetTable();
            p1CountLabel.Text = "2";
            p2CountLabel.Text = "2";
            p1TimerLabel.Text = "00:00:00";
            p2TimerLabel.Text = "00:00:00";
            Player1Label.BackColor = Color.LightGreen;
            timer.Start();
        }

        private void GenerateTable()
        {
            int tableSize = model.Table.FieldSize;
            int size = (this.Size.Height - panel1.Height * 4) / tableSize;
            boardButtons = new Button[tableSize, tableSize];

            SuspendLayout();
            for (int i = 0; i < tableSize; i++)
            {
                for (int j = 0; j < tableSize; j++)
                {
                    boardButtons[i, j] = new Button();
                    boardButtons[i, j].Size = new Size(size, size);
                    boardButtons[i, j].Location = new Point((this.Size.Width - size * tableSize) / 2 - 10 + size * j, (this.Size.Height - size * tableSize) / 2 - panel1.Height / 2 + size * i);
                    //boardButtons[i, j].Font = new Font(FontFamily.GenericSansSerif, size / 5, FontStyle.Bold);
                    boardButtons[i, j].TabIndex = 100 + i * tableSize + j;
                    boardButtons[i, j].FlatStyle = FlatStyle.Flat;
                    boardButtons[i, j].Click += putPiece_Click;
                    Controls.Add(boardButtons[i, j]);
                }
            }
            ResumeLayout(false);
        }
        private void SetTable()
        {
            int boardSize = boardButtons.GetLength(0);
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    int value = model.Table.GetValue(i, j);
                    if (value == 1)
                    {
                        boardButtons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        boardButtons[i, j].BackgroundImage = black;
                        boardButtons[i, j].BackColor = Color.PaleVioletRed;
                        boardButtons[i, j].Enabled = false;
                    }
                    if (value == -1)
                    {
                        boardButtons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        boardButtons[i, j].BackgroundImage = white;
                        boardButtons[i, j].BackColor = Color.PaleVioletRed;
                        boardButtons[i, j].Enabled = false;
                    }
                    if (value == 2)
                    {
                        boardButtons[i, j].BackColor = Color.Green;
                        boardButtons[i, j].Enabled = true;
                    }
                    if (value == 0)
                    {
                        boardButtons[i, j].BackColor = Color.White;
                        boardButtons[i, j].Enabled = false;
                    }
                }
            }
        }

        private async void loadGame_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    await model.LoadGameAsync(openFileDialog.FileName);

                }
                catch (ReversiDataException)
                {
                    MessageBox.Show("Couldn't load the game! The file type or path is incorrect!", "Reversi game", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    model.NewGame(10);

                }

                panelMenu.Hide();
                pauseBtn.Show();
                pauseBtnClicked = false;
                quit.Location = new Point(saveGame.Location.X, saveGame.Location.Y + 80);

                if (boardButtons == null)
                {
                    GenerateTable();
                }
                else
                {
                    SuspendLayout();
                    foreach (Button button in boardButtons)
                    {
                        Controls.Remove(button);
                        button.Dispose();
                    }
                    ResumeLayout(false);
                    boardButtons = null!;
                    GenerateTable();
                }
                model.CheckValidPlaces();
                SetTable();
                p1CountLabel.Text = model.Player1PieceCount.ToString();
                p2CountLabel.Text = model.Player2PieceCount.ToString();
                if (model.GetCurrentPlayerStatus)
                {
                    Player2Label.BackColor = Color.LightGreen;
                }
                else
                {
                    Player1Label.BackColor = Color.LightGreen;
                }
                timer.Start();
                
            }
        }
        private void putPiece_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int x = (button.TabIndex - 100) / model.Table.FieldSize;
                int y = (button.TabIndex - 100) % model.Table.FieldSize;
                model.Update(x, y);
                SetTable();
            }
        }
        private void quit_Click(object sender, EventArgs e)
        {
            bool restartTimer = timer.Enabled;
            timer.Stop();

            if (MessageBox.Show("Are you sure you want to quit?", "Reversi game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                if (restartTimer) { timer.Start(); }
            }

        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {

            bool restartTimer = timer.Enabled;
            timer.Stop();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await model.SaveGameAsync(saveFileDialog.FileName);
                }
                catch (ReversiDataException)
                {
                    MessageBox.Show("Couldn't save the game!.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (restartTimer)
                timer.Start();
        }
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (pauseBtnClicked)
            {
                timer.Start();
                panelMenu.Visible = false;
                pauseBtnClicked = false;
            }
            else
            {
                timer.Stop();
                panelMenu.Visible = true;
                saveGame.Visible = true;
                pauseBtnClicked = true;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            model.Tick();
        }
        private void passBtn_Click(object sender, EventArgs e)
        {
            model.ChangePlayer();
            SetTable();
            p1PassLabel.Hide();
            p1PassBtn.Hide();
            p2PassLabel.Hide();
            p2PassBtn.Hide();
        }
    }
}