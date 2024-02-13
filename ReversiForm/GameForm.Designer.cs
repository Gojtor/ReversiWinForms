namespace Reversi
{
    partial class Board
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newGame = new Button();
            loadGame = new Button();
            quit = new Button();
            mediumTable = new RadioButton();
            smallTable = new RadioButton();
            largeTable = new RadioButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            p1PassBtn = new Button();
            p1PassLabel = new Label();
            p1TimerLabel = new Label();
            pauseBtn = new Button();
            p1CountLabel = new Label();
            label2 = new Label();
            Player1Label = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            p2PassBtn = new Button();
            p2PassLabel = new Label();
            p2TimerLabel = new Label();
            p2CountLabel = new Label();
            label3 = new Label();
            Player2Label = new Label();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            panelMenu = new Panel();
            saveGame = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // newGame
            // 
            newGame.Location = new Point(46, 51);
            newGame.Margin = new Padding(2, 1, 2, 1);
            newGame.Name = "newGame";
            newGame.Size = new Size(200, 50);
            newGame.TabIndex = 0;
            newGame.Text = "New Game";
            newGame.UseVisualStyleBackColor = true;
            newGame.Click += newGame_Click;
            // 
            // loadGame
            // 
            loadGame.Location = new Point(46, 242);
            loadGame.Margin = new Padding(2, 1, 2, 1);
            loadGame.Name = "loadGame";
            loadGame.Size = new Size(200, 50);
            loadGame.TabIndex = 1;
            loadGame.Text = "Load Game";
            loadGame.UseVisualStyleBackColor = true;
            loadGame.Click += loadGame_Click;
            // 
            // quit
            // 
            quit.Location = new Point(46, 329);
            quit.Margin = new Padding(2, 1, 2, 1);
            quit.Name = "quit";
            quit.Size = new Size(200, 47);
            quit.TabIndex = 2;
            quit.Text = "Quit";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // mediumTable
            // 
            mediumTable.AutoSize = true;
            mediumTable.Location = new Point(99, 150);
            mediumTable.Name = "mediumTable";
            mediumTable.Size = new Size(99, 19);
            mediumTable.TabIndex = 3;
            mediumTable.Text = "Medium table";
            mediumTable.UseVisualStyleBackColor = true;
            // 
            // smallTable
            // 
            smallTable.AutoSize = true;
            smallTable.Checked = true;
            smallTable.Location = new Point(99, 116);
            smallTable.Name = "smallTable";
            smallTable.Size = new Size(83, 19);
            smallTable.TabIndex = 4;
            smallTable.TabStop = true;
            smallTable.Text = "Small table";
            smallTable.UseVisualStyleBackColor = true;
            // 
            // largeTable
            // 
            largeTable.AutoSize = true;
            largeTable.Location = new Point(99, 189);
            largeTable.Name = "largeTable";
            largeTable.Size = new Size(83, 19);
            largeTable.TabIndex = 5;
            largeTable.Text = "Large table";
            largeTable.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(p1PassBtn);
            panel1.Controls.Add(p1PassLabel);
            panel1.Controls.Add(p1TimerLabel);
            panel1.Controls.Add(pauseBtn);
            panel1.Controls.Add(p1CountLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Player1Label);
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 40);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ReversiForm.Properties.Resources.blackPiece;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(62, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // p1PassBtn
            // 
            p1PassBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p1PassBtn.Location = new Point(461, 4);
            p1PassBtn.Name = "p1PassBtn";
            p1PassBtn.Size = new Size(75, 29);
            p1PassBtn.TabIndex = 12;
            p1PassBtn.Text = "Pass";
            p1PassBtn.UseVisualStyleBackColor = true;
            p1PassBtn.Visible = false;
            p1PassBtn.Click += passBtn_Click;
            // 
            // p1PassLabel
            // 
            p1PassLabel.AutoSize = true;
            p1PassLabel.BackColor = Color.LightGray;
            p1PassLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p1PassLabel.ForeColor = Color.Red;
            p1PassLabel.Location = new Point(308, 8);
            p1PassLabel.Name = "p1PassLabel";
            p1PassLabel.Size = new Size(147, 21);
            p1PassLabel.TabIndex = 6;
            p1PassLabel.Text = "You have to pass ->";
            p1PassLabel.Visible = false;
            // 
            // p1TimerLabel
            // 
            p1TimerLabel.AutoSize = true;
            p1TimerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p1TimerLabel.Location = new Point(206, 8);
            p1TimerLabel.Name = "p1TimerLabel";
            p1TimerLabel.Size = new Size(70, 21);
            p1TimerLabel.TabIndex = 4;
            p1TimerLabel.Text = "00:00:00";
            // 
            // pauseBtn
            // 
            pauseBtn.Location = new Point(741, 8);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(75, 23);
            pauseBtn.TabIndex = 3;
            pauseBtn.Text = "Pause";
            pauseBtn.UseVisualStyleBackColor = true;
            pauseBtn.Visible = false;
            pauseBtn.Click += pauseBtn_Click;
            // 
            // p1CountLabel
            // 
            p1CountLabel.AutoSize = true;
            p1CountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p1CountLabel.Location = new Point(148, 8);
            p1CountLabel.Name = "p1CountLabel";
            p1CountLabel.Size = new Size(19, 21);
            p1CountLabel.TabIndex = 2;
            p1CountLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 8);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Pieces:";
            // 
            // Player1Label
            // 
            Player1Label.AutoSize = true;
            Player1Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Player1Label.Location = new Point(3, 8);
            Player1Label.Name = "Player1Label";
            Player1Label.Size = new Size(62, 21);
            Player1Label.TabIndex = 0;
            Player1Label.Text = "Player1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(p2PassBtn);
            panel2.Controls.Add(p2PassLabel);
            panel2.Controls.Add(p2TimerLabel);
            panel2.Controls.Add(p2CountLabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Player2Label);
            panel2.Location = new Point(5, 765);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 40);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ReversiForm.Properties.Resources.whitePiece;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(62, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // p2PassBtn
            // 
            p2PassBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p2PassBtn.Location = new Point(461, 4);
            p2PassBtn.Name = "p2PassBtn";
            p2PassBtn.Size = new Size(75, 29);
            p2PassBtn.TabIndex = 11;
            p2PassBtn.Text = "Pass";
            p2PassBtn.UseVisualStyleBackColor = true;
            p2PassBtn.Visible = false;
            p2PassBtn.Click += passBtn_Click;
            // 
            // p2PassLabel
            // 
            p2PassLabel.AutoSize = true;
            p2PassLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p2PassLabel.ForeColor = Color.Red;
            p2PassLabel.Location = new Point(308, 8);
            p2PassLabel.Name = "p2PassLabel";
            p2PassLabel.Size = new Size(147, 21);
            p2PassLabel.TabIndex = 10;
            p2PassLabel.Text = "You have to pass ->";
            p2PassLabel.Visible = false;
            // 
            // p2TimerLabel
            // 
            p2TimerLabel.AutoSize = true;
            p2TimerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p2TimerLabel.Location = new Point(206, 8);
            p2TimerLabel.Name = "p2TimerLabel";
            p2TimerLabel.Size = new Size(70, 21);
            p2TimerLabel.TabIndex = 10;
            p2TimerLabel.Text = "00:00:00";
            // 
            // p2CountLabel
            // 
            p2CountLabel.AutoSize = true;
            p2CountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p2CountLabel.Location = new Point(148, 8);
            p2CountLabel.Name = "p2CountLabel";
            p2CountLabel.Size = new Size(19, 21);
            p2CountLabel.TabIndex = 10;
            p2CountLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 8);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 10;
            label3.Text = "Pieces:";
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Player2Label.Location = new Point(3, 8);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(62, 21);
            Player2Label.TabIndex = 1;
            Player2Label.Text = "Player2";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Reversi tábla (*.json)|*.json";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Reversi tábla (*.json)|*.json";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.RosyBrown;
            panelMenu.Controls.Add(largeTable);
            panelMenu.Controls.Add(smallTable);
            panelMenu.Controls.Add(mediumTable);
            panelMenu.Controls.Add(quit);
            panelMenu.Controls.Add(loadGame);
            panelMenu.Controls.Add(newGame);
            panelMenu.Controls.Add(saveGame);
            panelMenu.Location = new Point(270, 150);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 500);
            panelMenu.TabIndex = 10;
            // 
            // saveGame
            // 
            saveGame.Location = new Point(46, 329);
            saveGame.Margin = new Padding(2, 1, 2, 1);
            saveGame.Name = "saveGame";
            saveGame.Size = new Size(200, 47);
            saveGame.TabIndex = 11;
            saveGame.Text = "Save Game";
            saveGame.UseVisualStyleBackColor = true;
            saveGame.Visible = false;
            saveGame.Click += saveBtn_Click;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(834, 811);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "Board";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reversi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button newGame;
        private Button loadGame;
        private Button quit;
        private RadioButton mediumTable;
        private RadioButton smallTable;
        private RadioButton largeTable;
        private Panel panel1;
        private Label Player1Label;
        private Panel panel2;
        private Label Player2Label;
        private Label p1CountLabel;
        private Label label2;
        private Label p2CountLabel;
        private Label label3;
        private Button pauseBtn;
        private Label p1TimerLabel;
        private Label p2TimerLabel;
        private Label p1PassLabel;
        private Label p2PassLabel;
        private Button p2PassBtn;
        private Button p1PassBtn;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Panel panelMenu;
        private Button saveGame;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}