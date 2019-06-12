using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MatchingGame
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        Label firstClick = null;
        Label secondClick = null;
        int wrongPair = 0;
        int winnerTime = 0;

       
        List<string> pictures = new List<string>()
        {
            "A","A","B","B",
            "C","C","D","D",
            "E","E","F","F",
            "G","G","H","H"
        };
       
        public MainForm()
        {      
            InitializeComponent();           
        }
        
        private void AssignPicturesToSquare()
        {
            
            foreach (Control control in tableLayoutPanel1.Controls)
            {              
                Label picturesLabel = control as Label;
                if (picturesLabel != null)
                {
                    int randomNumber = random.Next(pictures.Count);
                    picturesLabel.Text = pictures[randomNumber];
                    pictures.RemoveAt(randomNumber);
                }
            }
        }
        private void HidePicturesBack()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label picturesLabel = control as Label;
                if (picturesLabel != null)
                {
                    int randomNumber = random.Next(pictures.Count);
                    picturesLabel.ForeColor = picturesLabel.BackColor;
                }
            }
        }
        
        private void picture_Click(object sender, EventArgs e)
        {
            if (howLong.Enabled == true)
            {
                if (timer1.Enabled == true)
                    return;

                int click = Convert.ToInt32(clickCount.Text);
                click += 1;
                clickCount.Text = Convert.ToString(click);

                Label clickedPicture = sender as Label;

                if (clickedPicture != null)
                {
                    if (clickedPicture.ForeColor == Color.Black)
                        return;

                    if (firstClick == null)
                    {
                        firstClick = clickedPicture;
                        firstClick.ForeColor = Color.Black;
                        hide.Start();
                        return;
                    }

                    secondClick = clickedPicture;
                    secondClick.ForeColor = Color.Black;
                    
                    CheckForWinner();
                    
                    if (firstClick.Text == secondClick.Text)
                    {
                        firstClick = null;
                        secondClick = null;
                        CorrectPlay();
                        return;
                    }

                    timer1.Start();
                    WrongPlay();

                }
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label pictureLabel = control as Label;

                if (pictureLabel != null)
                {
                    if (pictureLabel.ForeColor == pictureLabel.BackColor)
                        return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Your time: "+winnerTime + 
                " seconds\nYour click: " + clickCount.Text + "\nWrong pair:"
                +wrongPair+"\n\nDo you want play again ?", 
                "You won !!! Congratulations !!!!",  MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                howLong.Stop();            
                this.Hide();
                MainForm newForm = new MainForm();
                newForm.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            HidePlay();
            wrongPair++;
            
            firstClick.ForeColor = firstClick.BackColor;
            secondClick.ForeColor = secondClick.BackColor;

            firstClick = null;
            secondClick = null;
        }      

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            pictureStart.Click -= PictureStart_Click;
            int timer = Convert.ToInt32(label1.Text);
            timer -= 1;
            label1.Text = Convert.ToString(timer);
            if(timer == 3)
            {
                tableLayoutPanel1.Enabled = false;
                AssignPicturesToSquare();
            }
            else if(timer == 0)
            {
                tableLayoutPanel1.Enabled = true;
                countdownTimer.Stop();
                HidePicturesBack();
                howLong.Start();
            }
        }

        private void Hide_Tick(object sender, EventArgs e)
        {
            hide.Stop();
            if(secondClick == null && secondClick != firstClick)
            {
                firstClick.ForeColor = firstClick.BackColor;
                firstClick = null;
            }
        }

        private void HowLong_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer += 1;
            label1.Text = Convert.ToString(timer);
            winnerTime++;
        }

        private void HidePlay()
        {
            Stream soundfile = Properties.Resources.hide;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }

        private void CorrectPlay()
        {
            Stream soundfile = Properties.Resources.correct;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }

        private void WrongPlay()
        {
            Stream soundfile = Properties.Resources.wrong;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }

        private void ChangeSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm newForm = new SecondForm();
            newForm.ShowDialog();
            this.Close();
        }

        private void PictureStart_Click(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }

        private void PictureReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Exit ? ",
               "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PictureSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm newForm = new SecondForm();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
