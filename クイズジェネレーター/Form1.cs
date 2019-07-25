using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace クイズジェネレーター
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void append_Click(object sender, EventArgs e)
        {

            Quiz4Post addQuiz = new Quiz4Post()
            {
                Question = questionBox.Text,
                A0 = answerBox0.Text,
                A1 = answerBox1.Text,
                A2 = answerBox2.Text,
                A3 = answerBox3.Text,
                Answer = (int)answer.Value,
                Genre = presenterBox.Text,
                Presenter = genreBox.Text,

            };
            File.AppendAllLines("quiz.txt", new string[] { addQuiz.Question, addQuiz.A0, addQuiz.A1, addQuiz.A2, addQuiz.A3, addQuiz.Answer.ToString(), addQuiz.Genre, addQuiz.Presenter });
            File.AppendAllText("quiz.json", JsonConvert.SerializeObject(addQuiz) + Environment.NewLine);
            System.Diagnostics.Process.Start("Notepad", "quiz.txt");
            System.Diagnostics.Process.Start("Notepad", "quiz.json");

        }


    }
}
