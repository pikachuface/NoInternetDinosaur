using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace NoInternetDinosaur
{
    public partial class ScoreForm : Form
    {
        private string filename = "score";

        private List<Person> people = new List<Person>();
        private int newScore;

        public ScoreForm(int score)
        {
            InitializeComponent();
            this.newScore = score;
            getScoreBoard();
            SetScore();
        }

        private void getScoreBoard()
        {
            if (File.Exists(filename))
            {
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] input = sr.ReadLine().Split('~');
                            if (Int32.TryParse(input[1], out int parsedScore))
                            {
                                string name = input[0];
                                int score = parsedScore;
                                people.Add(new Person(name, parsedScore));
                            }
                            else
                            {
                                File.Delete(filename);
                            }
                        }
                    }
                }
            }
        }

        private void WriteScoreBoard()
        {
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < 10 && i < people.Count; i++)
                    {
                        sw.WriteLine($"{people[i].Name}~{people[i].Score}");
                    }
                }
            }
        }

        private void SetScore()
        {
            bool newBest = false;
            if (people.Count < 9)
            {
                newBest = true;
            }
            else
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Score < newScore)
                    {
                        newBest = true;
                    }
                }
            }

            if (newBest) GoToNewBest();
            else outputScore();


        }

        private void GoToNewBest()
        {
            this.Size = new Size(296, 102 + 30);
            scoreLabel.Text = $"Score: {newScore}";
            newScorePanel.Visible = true;
        }

        private void GoToLeaderBoard()
        {
            this.Size = new Size(312, 381);
            newScorePanel.Visible = false;
        }

        private void outputScore()
        {
            for (int i = 0; i < 10 && i < people.Count; i++)
            {
                outputBox.Text += $"{i + 1}. {people[i].Name} {people[i].Score}" + Environment.NewLine;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!inputNameBox.Text.Contains("~") && !String.IsNullOrWhiteSpace(inputNameBox.Text))
            {
                if (inputNameBox.Text.Length < 20)
                {
                    people.Add(new Person(inputNameBox.Text, newScore));
                    people.Sort((x, y) => y.Score.CompareTo(x.Score));
                    if (people.Count > 10)
                    {
                        people.RemoveAt(people.Count - 1);
                    }
                    WriteScoreBoard();
                    GoToLeaderBoard();
                    outputScore();
                }
            }
        }

        private void newScoreClosebtn_Click(object sender, EventArgs e)
        {
            GoToLeaderBoard();
            outputScore();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the leader board??", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result==DialogResult.Yes)
            {
                File.Delete(filename);
                this.Close();
            }
        }
    }


}
