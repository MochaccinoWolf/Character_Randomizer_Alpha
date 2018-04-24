using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Randomizer
{
    public partial class Form1 : Form
    {
        //int myRoll = 0;
        
        
             
        public Form1()
        {
            InitializeComponent();      
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm About = new aboutForm();
            About.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();

        }

        public int diceRoll()
        {
            
            Random RNGRoll = new Random();
            return RNGRoll.Next(1,6);
            
            
        }

        private void btn_Dice_Click(object sender, EventArgs e)
        {
           // myRoll = diceRoll();
            //lbldiceReturn.Text = ("Dice Returned " + myRoll);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            randSpecies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bn_RandAge_Click(object sender, EventArgs e)
        {
            randAge();
        }

        private void bnRandGender_Click(object sender, EventArgs e)
        {
            randGender();
        }

        private void bn_RandForm_Click(object sender, EventArgs e)
        {
            randForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randSpecies();
            randGender();
            randAge();
            randForm();
            randEffect();
        }

        private void randSpecies()
        {
            //Gen Random Species Dice roll
            Random speciesDice = new Random();
            string mySpecies = "";

            //Set Conditions
            switch (speciesDice.Next(10))
            {
                case 0:
                    mySpecies = "Human";

                    break;
                case 1:
                    mySpecies = "Dragon";
                    break;
                case 2:
                    mySpecies = "Bunny";
                    break;
                case 3:
                    mySpecies = "Raccoon";
                    break;
                case 4:
                    mySpecies = "Human";
                    break;
                case 5:
                    mySpecies = "Fox";
                    break;
                case 6:
                    mySpecies = "Wolf";
                    break;
                case 7:
                    mySpecies = "Snow Lepoard";
                    break;
                case 8:
                    mySpecies = "Iguana";
                    break;
                case 9:
                    mySpecies = "Mountain Lion";
                    break;


            }

            if (mySpecies == "Human")
            {
                bn_RandForm.Enabled = false;
                tboxForm.Clear();
                tboxForm.Enabled = false;


                lblEffect.Enabled = false;
                bnEffect.Enabled = false;
                tboxEffect.Enabled = false;

            }

            else
            {
                bn_RandForm.Enabled = true;
                tboxForm.Enabled = true;

                lblEffect.Enabled = true;
                bnEffect.Enabled = true;
                tboxEffect.Enabled = true;
            }
            //Display Results of 'Switch' in the appropriate textbox

            tboxSpecies.Text = ("Your Choosen Species is a(n) " + mySpecies + "!");
        }

        private void randGender()
        {
            bool isFemale = true;
            string whatismyGend = "";
            Random genderDice = new Random();
            double myGender = genderDice.Next(101);


            if (myGender <= 100 && myGender >= 50)
            {
                isFemale = true;
                whatismyGend = "Female";

            }

            else if (myGender <= 49 && myGender >= 0)

            {
                isFemale = false;
                whatismyGend = "Male";
            }

            tboxGender.Text = ("Your gender is " + whatismyGend + "!");

        }

        private void randAge()
        {
            Random ageDice = new Random();
            string myAge = "";

            switch (ageDice.Next(3))
            {
                case 0:
                    myAge = "Child";
                    break;
                case 1:
                    myAge = "Teenager";
                    break;
                case 2:
                    myAge = "Adult";
                    break;

            }

            tboxAge.Text = ("Your choosen age is a(n) " + myAge + ".");
        }

        private void randForm()
        {
            Random formDice = new Random();
            string myForm = "";

            switch (formDice.Next(4))
            {
                case 0:
                    myForm = "Anthro";
                    break;

                case 1:
                    myForm = "taur";
                    break;

                case 2:
                    myForm = "Satyr";
                    break;

                case 3:
                    myForm = "Feral";
                    break;

            }

            tboxForm.Text = ("Your Form is " + myForm + "!");
        }

        private void randEffect()
        {
            

            Random effectDice = new Random();
            string myEffect = "";

            switch (effectDice.Next(6))
            {
                case 0:
                    myEffect = "bottom heavy/ Weight gain";
                    break;

                case 1:
                    myEffect = "Age Regression";
                    break;

                case 2:               
                    myEffect = "Plush Toy";
                    break;

                case 3:
                    myEffect = "Macro Size";
                    break;

                case 4:
                    myEffect = "pool toy";
                    break;

                case 5:
                    myEffect = "Micro";
                    break;

                    
             

            }

            tboxEffect.Text = ("Your effect is " + myEffect + "!");

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked == true)
            {
                lblEffect.Visible = true;
                bnEffect.Visible = true;
                tboxEffect.Visible = true;

            }

            if (checkBox1.Checked == false)
            {
                lblEffect.Visible = false;
                bnEffect.Visible = false;
                tboxEffect.Visible = false;

            }
        }

        private void bnEffect_Click(object sender, EventArgs e)
        {
            randEffect();
        }
    }
}
