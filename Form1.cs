using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        mycalculator cal = new mycalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void cbm_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbm_choice.Text=="ADD")
            {
                try
                {
                    txt_answer.Text = cal.ADD(Convert.ToInt32(txt_valueOne.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                    txt_valueOne.Clear();
                    txt_valueTwo.Clear();
                    lbl_PA.Text = "previous ans is: "; 

                    
                }
               catch(Exception error)
                {
                    lbl_Error.Text = "Ivalid input";
                 
                }
            }
            else if (cbm_choice.Text == "SUB")
            {
                try
                {
                    txt_answer.Text = cal.SUB(Convert.ToInt32(txt_valueOne.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                     txt_valueOne.Clear();
                    txt_valueTwo.Clear();
                }
                catch (Exception error)
                {
                    lbl_Error.Text = "Invalid input";
                   
                }
            }
            else if (cbm_choice.Text == "MUL")
            {
                try
                {
                    txt_answer.Text = cal.MUL(Convert.ToInt32(txt_valueOne.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                    txt_valueOne.Clear();
                    txt_valueTwo.Clear();
                   
                }
                catch(Exception error)
                {
                    lbl_Error.Text = "Invalid Input";
                   

                }
            }
            else if (cbm_choice.Text == "DIVID")
            {
                try
                {

                
                txt_answer.Text = cal.DIVID(Convert.ToInt32(txt_valueOne.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                txt_valueOne.Clear();
                txt_valueTwo.Clear();
                
                }
                catch(Exception error)
                {
                    lbl_Error.Text= "Invalid Input";
                   
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_valueOne.Clear();
            txt_valueTwo.Clear();
            txt_answer.Clear();
        }

       

      
    }
}
