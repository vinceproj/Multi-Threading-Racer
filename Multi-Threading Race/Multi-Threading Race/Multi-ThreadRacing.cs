using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Threading_Race
{
    public partial class mainForm : Form
    {

        int racerCount = 0;
        bool raceFlag = false;

        //Start of program
        public mainForm()
        {
            InitializeComponent();

            //Add same event handler to all radio buttons
            radOne.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radTwo.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radThree.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        //On form load automatically check radOne
        private void mainForm_Load(object sender, EventArgs e)
        {
            radOne.Checked = true;
        }

        //Event handler for radio buttons
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = sender as RadioButton;

            //Precaution to fire event once per radio button change
            if (radioButton != null){
                if (radioButton.Checked)
                {
                    if (radOne.Checked)
                    {
                        lstRacerOne.Items.Clear();
                        lstRacerTwo.Items.Clear();
                        lstRacerThree.Items.Clear();
                        lstRacerOne.Items.Add("Racer Ready!");
                        racerCount = 1;
                    }
                    else if (radTwo.Checked)
                    {
                        lstRacerThree.Items.Clear();
                        lstRacerTwo.Items.Clear();
                        lstRacerTwo.Items.Add("Racer Ready!");
                        racerCount = 2;
                    }
                    else if (radThree.Checked)
                    {
                        lstRacerTwo.Items.Clear();
                        lstRacerTwo.Items.Add("Racer Ready!");
                        lstRacerThree.Items.Add("Racer Ready!");
                        racerCount = 3;
                    }
                }
            }    
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            //Input validation
            if (txtRange.Text == "")
            {
                MessageBox.Show("Please enter a value between 0 and 100");
                return;
            }
            else
            {
                string input = txtRange.Text;
                try
                {
                    int inputInt = Int32.Parse(input);
                    if(inputInt <0 || inputInt > 100)
                    {
                        MessageBox.Show("Please enter a value between 0 and 100");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a value between 0 and 100");
                    return;
                }
            }

            //Input passed
            int targetInt = Int32.Parse(txtRange.Text);

            //Create threads for racing and start each
            switch (racerCount)
            {
                case 1:
                    Thread thr1 = new Thread(()=>runRace(targetInt,1));
                    thr1.Start();
                    break;
                case 2:
                    thr1 = new Thread(() => runRace(targetInt, 1));
                    Thread thr2 = new Thread(() => runRace(targetInt, 2));
                    thr1.Start();
                    thr2.Start();
                    break;
                case 3:
                    thr1 = new Thread(() => runRace(targetInt, 1));
                    thr2 = new Thread(() => runRace(targetInt, 2));
                    Thread thr3 = new Thread(() => runRace(targetInt, 3));
                    thr1.Start();
                    thr2.Start();
                    thr3.Start();
                    break;
            }
        }

        //Run race method
        private void runRace(int targetInt, int targetRacer)
        {
            //Seed based on time of invoke and a pre-determined number
            Random randomSeed = new Random();
            int seed = randomSeed.Next();
            int raceMarker = 0;
           
            switch (targetRacer)
            {
                case 1:
                    Random random = new Random(seed * 5);
                    while(raceFlag == false)
                    {
               
                        //Allow thread to speak to UI thread; get random number and print
                        BeginInvoke(new Action(() => {
                            raceMarker = random.Next(0, 100);
                            lstRacerOne.Items.Add(raceMarker.ToString());
                            }));
                        //If target has been found set flag to end race
                        if(raceMarker == targetInt)
                        {
                            raceFlag = true;
                            BeginInvoke(new Action(()=>{
                                lstRacerOne.Items.Add("");
                                lstRacerOne.Items.Add("Racer One Wins!");
                            }));
                            //Message the winner to the user; Due to threading and communication timing
                            //Winner will be determined by which thread manages to actually set the flag rather than find number
                            MessageBox.Show("Racer One finds " +raceMarker.ToString() + " first!");
                        }
                    }
                    break;
                case 2:
                    random = new Random(seed * 10);
                    while (raceFlag == false)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            raceMarker = random.Next(0, 100);
                            lstRacerTwo.Items.Add(raceMarker.ToString());
                        }));
                        if (raceMarker == targetInt)
                        {
                            raceFlag = true;
                            BeginInvoke(new Action(() =>
                            {
                                lstRacerTwo.Items.Add("");
                                lstRacerTwo.Items.Add("Racer Two Wins!");
                            }));
                            MessageBox.Show("Racer Two finds " + raceMarker.ToString() + " first!");
                        }
                    }
                    break;
                case 3:
                    random = new Random(seed * 15);
                    while (raceFlag == false)
                    {

                        BeginInvoke(new Action(() => {
                            raceMarker = random.Next(0, 100);
                            lstRacerThree.Items.Add(raceMarker.ToString());
                        }));
                        if (raceMarker == targetInt)
                        {
                            raceFlag = true;
                            BeginInvoke(new Action(() => {
                                lstRacerThree.Items.Add("");
                                lstRacerThree.Items.Add("Racer Three Wins!");
                            }));
                            MessageBox.Show("Racer Three finds " + raceMarker.ToString() + " first!");
                        }
                    }
                    break;
            }
        }

        //Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear lists
            lstRacerOne.Items.Clear();
            lstRacerTwo.Items.Clear();
            lstRacerThree.Items.Clear();
            //Reset radio buttons and Input
            radOne.Checked = false;
            radOne.Checked = true;
            txtRange.Text = "";
            raceFlag = false;
        }   
    }
}
