using HyattCalculator.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class History : Form
    {
     

      
        public History()
        {
            InitializeComponent();
        }

        public void history_load()
        {
            this.ActiveControl = label1;
            
        }
       
        public void history_box_TextChanged(object sender, EventArgs e)
        {

        }

        public void print(String s) 
        {
            history_box.Text = s;
            history_box.Select(history_box.Text.Length, 0); //deselect all
        }



        
    }
}
