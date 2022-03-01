using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        string halfCat = "";
        string previousSale = "no";
        double costCat = 7.49;
        double costRock = 12.99;
        double costJelly = 2.49;
        double numberCat = 0;
        double numberRock = 0;
        double numberJelly = 0;
        double totalOrder = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalCost = 0;
        double amountTendered = 0;
        double changeDue = 0.0001;    //placeholder number cannot be equal to any number within 2 decimal places
        double changeDueCopy = 0.0001;  
        int receiptPause = 250;
        double cleared = 1;

        //sound player creation
        SoundPlayer selection = new SoundPlayer(Properties.Resources.selection);  
        SoundPlayer cashIn = new SoundPlayer(Properties.Resources.cash);
        SoundPlayer receipt = new SoundPlayer(Properties.Resources.receipt);
        SoundPlayer reset = new SoundPlayer(Properties.Resources.reset);
        SoundPlayer error = new SoundPlayer(Properties.Resources.error);
        SoundPlayer meow = new SoundPlayer(Properties.Resources.meowthatworks);
        
        public Form1()
        {
            InitializeComponent();
            receiptOutput2.Parent = receiptOutput;
            receiptOutput2.Location = new Point(105, 20);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //colect numbers        
                numberCat = Convert.ToDouble(feralCatInput.Text);
                {
                    halfCat = "";
                    if (numberCat == 0.5)
                    {
                        halfCat = "I'd rather not sell a severed cat...";
                    }
                } //hidden end message
                numberRock = Convert.ToDouble(rockInput.Text);
                numberJelly = Convert.ToDouble(jellyInput.Text);

                //sound
                selection.Play();

                //round to whole (you shouldn't buy half of a cat)     
                numberCat = Math.Round(numberCat, 0, MidpointRounding.AwayFromZero);
                numberRock = Math.Round(numberRock, 0, MidpointRounding.AwayFromZero);
                numberJelly = Math.Round(numberJelly, 0, MidpointRounding.AwayFromZero);                

                //deal with negatives
                if (numberCat < 0)
                {
                    numberCat = numberCat * -1;
                }
                if (numberRock < 0)
                {
                    numberRock = numberRock * -1;
                }
                if (numberJelly < 0)
                {
                    numberJelly = numberJelly * -1;
                }

                //display any corrections
                feralCatInput.Text = Convert.ToString(numberCat);
                rockInput.Text = Convert.ToString(numberRock);
                jellyInput.Text = Convert.ToString(numberJelly);

                //calculate costs
                totalOrder = numberCat * costCat + numberRock * costRock + numberJelly * costJelly;
                taxAmount = totalOrder * taxRate;
                totalCost = totalOrder + taxAmount;

                //display
                subTotalOutput.Text = $"{totalOrder.ToString("C")} ";
                taxOutput.Text = $"{taxAmount.ToString("C")} ";
                totalOutput.Text = $"{totalCost.ToString("C")} ";
                tenderedInput.Text = "0";
                changeOutput.Text = "";

                //button settings
                changeButton.Enabled = true;
                changeButton.BackColor = Color.DarkGray;
                tenderedInput.Enabled = true;
                tenderedInput.BackColor = Color.DimGray;
                receiptButton.Enabled = false;
                receiptButton.BackColor = Color.IndianRed;
                
                //previous sale
                if (previousSale == "yes")
                {
                    previousSaleOutput.Visible = true;
                }
            }
            catch
            {
                //catching, fixing and informing of the error
                if (feralCatInput.Text == "")
                {
                    feralCatInput.Text = "0";
                    feralCatInput.ForeColor = Color.Red;                 
                }
                if (rockInput.Text == "")
                {
                    rockInput.Text = "0";
                    rockInput.ForeColor = Color.Red;                 
                }
                if (jellyInput.Text == "")
                {
                    jellyInput.Text = "0";
                    jellyInput.ForeColor = Color.Red;
                }
                error.Play();
                Refresh();
                Thread.Sleep(25);
                feralCatInput.ForeColor = Color.Snow;
                rockInput.ForeColor = Color.Snow;
                jellyInput.ForeColor = Color.Snow;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //collect numbers, round
                amountTendered = Convert.ToDouble(tenderedInput.Text);
                amountTendered = Math.Round(amountTendered, 2, MidpointRounding.AwayFromZero);

                //deal with negatives
                if (amountTendered <= 0)
                {
                    amountTendered = amountTendered * -1;
                }

                //display any corrections
                tenderedInput.Text = Convert.ToString(amountTendered);

                //add copy of change due to prevent sounds playing multiple times
                changeDueCopy = changeDue;

                //calculations
                changeDue = amountTendered - totalCost;

                if (changeDue != changeDueCopy)
                {
                    //make sure they paid enough
                    if (changeDue <= -0.01)
                    {
                        //button settings
                        receiptButton.Enabled = false;
                        receiptButton.BackColor = Color.IndianRed;

                        //reset
                        tenderedInput.Text = "0";
                        tenderedInput.ForeColor = Color.Red;
                        error.Play();
                        Refresh();
                        Thread.Sleep(25);
                        tenderedInput.ForeColor = Color.Snow;
                    }
                    else
                    {
                        //cash register sound
                        cashIn.Play();

                        //display
                        changeOutput.Text = $"{changeDue.ToString("C")} ";

                        //button settings
                        receiptButton.Enabled = true;
                        receiptButton.BackColor = Color.DarkGray;

                        //previous sale
                        if (previousSale == "yes")
                        {
                            previousSaleOutput.Visible = true;
                        }
                    }
                }                             
            }
            catch 
            {
                tenderedInput.Text = "0";
                tenderedInput.ForeColor = Color.IndianRed;
                error.Play();
                Refresh();
                Thread.Sleep(25);
                tenderedInput.ForeColor = Color.Snow;
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //current sale
            previousSaleOutput.Visible = false;
            previousSale = "yes";
            receiptOutput.Text = "";
            receiptOutput2.Text = "";
            Refresh();

            //removing the ability to spam the button
            receiptButton.Enabled = false;

            //reciept printing sound
            receipt.Play();

            //display receipt
            receiptOutput.Visible = true;
            receiptOutput2.Visible = true;
            receiptOutput.Refresh();
            receiptOutput2.Refresh(); 

            //number ordered
            receiptOutput.Text = "     Don't let anyone see this...";
            receiptOutput.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n\n  Feral Cats  x{numberCat}";
            receiptOutput2.Text = $"\n{costCat.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n  White Rock  x{numberRock}";
            receiptOutput2.Text += $"\n{costRock.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n  Jelly Bean  x{numberJelly}";
            receiptOutput2.Text += $"\n{costJelly.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n\n  Subtotal";
            receiptOutput2.Text += $"\n\n{totalOrder.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n  Tax";
            receiptOutput2.Text += $"\n{taxAmount.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n  Total";
            receiptOutput2.Text += $"\n{totalCost.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n\n  Tendered";
            receiptOutput2.Text += $"\n\n{amountTendered.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
            receiptOutput.Text += $"\n  Change";
            receiptOutput2.Text += $"\n{changeDue.ToString("C")}";
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);

            if (halfCat == "I'd rather not sell a severed cat...")      //special end text
            {
                receiptOutput.Text += $"\n\n\n{halfCat}                                                                                       -John";
                meow.Play();
            }
            else
            {
                receiptOutput.Text += "\n\n\nNot exacty a legal transaction...                                                                        -John";
            }
            receiptOutput.Refresh();
            receiptOutput2.Refresh();
            Thread.Sleep(receiptPause);
        }
        private void resetButton_Click(object sender, EventArgs e)  
        {
            //check if it needs to be reset (I do this so that the button won't be spammed, which would cause the noise to play repeatedly)
            {
                try
                {
                    numberCat = Convert.ToDouble(feralCatInput.Text);
                    numberRock = Convert.ToDouble(rockInput.Text);
                    numberJelly = Convert.ToDouble(jellyInput.Text);
                    amountTendered = Convert.ToDouble(tenderedInput.Text);
                }
                catch
                {
                    numberCat = 1;
                }

                {
                    if (numberCat != 0)
                    {
                        cleared = 0;
                    }
                    if (numberRock != 0)
                    {
                        cleared = 0;
                    }
                    if (numberJelly != 0)
                    {
                        cleared = 0;
                    }
                    if (amountTendered != 0)
                    {
                        cleared = 0;
                    }
                    if (receiptOutput.Visible == true)
                    {
                        cleared = 0;
                    }
                    if (changeButton.Enabled == true)
                    {
                        cleared = 0;
                    }
                } //flagging that it can be reset
            }

            //reset everything
            if (cleared != 1)
            {
                subTotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";
                numberCat = 0;
                numberRock = 0;
                numberJelly = 0;
                totalOrder = 0;
                taxAmount = 0;
                totalCost = 0;
                receiptOutput.Visible = false;
                receiptOutput2.Visible = false;
                receiptOutput.Text = "";
                receiptOutput2.Text = "";
                feralCatInput.Text = "0";
                rockInput.Text = "0";
                jellyInput.Text = "0";
                tenderedInput.Text = "0";
                halfCat = "";
                previousSale = "no";
                previousSaleOutput.Visible = false;

                //sound
                reset.Play();

                //button settings
                changeButton.Enabled = false;
                changeButton.BackColor = Color.IndianRed;
                receiptButton.Enabled = false;
                receiptButton.BackColor = Color.IndianRed;
                tenderedInput.Enabled = false;
                tenderedInput.BackColor = Color.IndianRed;
            }
            //screen is empty
            cleared = 1;
        } 
    }
}