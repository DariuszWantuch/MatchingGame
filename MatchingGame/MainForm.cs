/**
 * 
 * @file MainForm.cs
 * @author Dariusz Wantuch
 * @date June 12, 2019
 * @brief It is the main Form of project
 * 
 * This Form contains methods and variables
 * for the board 4x4
 * 
 */
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
        Random random = new Random(); /**< Use this Random object to choose random icons for the squeares */
        Label firstClick = null;      /**< It's points to the first Label control that the player clicks */
        Label secondClick = null;     /**< It's points to the second Label control that the player clicks */
        int wrongPair = 0;            /**< It's counting badly matched pairs.  */
        int winnerTime = 0;           /**< It counts the time of the game  */

        List<string> pictures = new List<string>() /**< Each of these letters is an interesting icon in the Wingdings font. */
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
        /// <summary> 
        ///Method for assign pictures to squares
        /// </summary> 
        private void AssignPicturesToSquare()
        {
            /**
             * The TableLayoutPanel has 16 labels,
             * and the icon list has 16 pictures,
             * so an picture is pulled at random from the list 
             * and added to each label.           
             */
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
        /// <summary> 
        ///Method that hides the exposed pictures
        /// </summary> 
        private void HidePicturesBack()
        {
            /**
             * The TableLayoutPanel has 16 labels,
             * so it hides all discovered pictures.           
             */

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
        /// <summary> 
        /// Every label's Click event is handled by this event handler.
        /// </summary> 
        /// <param name="sender">The label that was clicked.</param>
        /// <param name="e"></param>
        private void picture_Click(object sender, EventArgs e)
        {
            /**
             *If the howLong timer is enabled
             *the rest of the code is executed.
             */
            if (howLong.Enabled == true)
            {   
                /**
                 * If timer1 is not enabled,
                 * it ignores clicks
                 */
                if (timer1.Enabled == true)
                    return;
                /**
                 * The conversion from string to int 
                 * adds up to click + 1 and changes 
                 * back to the string.
                 */
                int click = Convert.ToInt32(clickCount.Text);
                click += 1;
                clickCount.Text = Convert.ToString(click);

                Label clickedPicture = sender as Label;

                if (clickedPicture != null)
                {
                    /**
                     * If you click a label that is reversed,
                     * the method will end.
                     */
                    if (clickedPicture.ForeColor == Color.Black)
                        return;
                    /**
                     * If firstClick is null,
                     * assign the label and turn over 
                     */
                    if (firstClick == null)
                    {
                        firstClick = clickedPicture;
                        firstClick.ForeColor = Color.Black;
                        hide.Start();
                        return;
                    }
                    /**
                     * Assign a secondClick clicked label
                     */
                    secondClick = clickedPicture;
                    secondClick.ForeColor = Color.Black;
                    /**
                     * Calling the method if the player won.
                     */
                    CheckForWinner();
                    /**
                     * A comparison if both pictures are the same
                     */
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
        /// <summary> 
        /// Check every icon to see if it is matched, by  
        /// comparing its foreground color to its background color.  
        /// If all of the icons are matched, the player wins. 
        /// </summary>
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
            /**
             * If the loop didn't return. It didin't find
             * any unmatched icons.
             * That means the user won.A dialog box will appear.
             */
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
        /// <summary> 
        /// This timer is started when the player clicks  
        /// two icons that don't match, 
        /// so it counts second  
        /// and then turns itself off and hides both icons.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>    
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
        /// <summary> 
        /// The start timer after pressing the start
        /// button shows all elements for 3 seconds.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary> 
        /// Timer will hide the first icon if the
        /// second one is not discovered after 1 second.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hide_Tick(object sender, EventArgs e)
        {
            hide.Stop();
            if(secondClick == null && secondClick != firstClick)
            {
                firstClick.ForeColor = firstClick.BackColor;
                firstClick = null;
            }
        }
        /// <summary> 
        /// The timer counts the time of the game
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HowLong_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer += 1;
            label1.Text = Convert.ToString(timer);
            winnerTime++;
        }
        /// <summary> 
        /// Method with the sound of hiding icons
        /// </summary> 
        private void HidePlay()
        {
            Stream soundfile = Properties.Resources.hide;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }
        /// <summary> 
        /// Method with the sound of correctly selected pair
        /// </summary>
        private void CorrectPlay()
        {
            Stream soundfile = Properties.Resources.correct;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }
        /// <summary> 
        /// Method with the sound of wrong selected pair
        /// </summary>
        private void WrongPlay()
        {
            Stream soundfile = Properties.Resources.wrong;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }        
        /// <summary> 
        /// Picture Click event to reset the game.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureStart_Click(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }
        /// <summary> 
        /// Picture Click event for game reset.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }
        /// <summary> 
        /// Picture Click event to close the game.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Exit ? ",
               "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary> 
        /// Picture Click event to change size.
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm newForm = new SecondForm();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
