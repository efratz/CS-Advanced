using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Advanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unit1_Tuple unit1_Tuple = new Unit1_Tuple();
            unit1_Tuple.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unit1_Delegate unit1_Delegate = new Unit1_Delegate();
            unit1_Delegate.Run();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Unit1_Event unit1_Event = new Unit1_Event();
            //unit1_Event.Run();
            Operate operate = new Operate();
            operate.Init();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Unit2_Foreach unit2_Foreach = new Unit2_Foreach();
            unit2_Foreach.RumMyItems();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Unit3_Nullable unit3_Nullable = new Unit3_Nullable();
            unit3_Nullable.Val();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Unit5_ExtensionMethods unit5_ExtensionMethods = new Unit5_ExtensionMethods();   
            unit5_ExtensionMethods.Run();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Unit5_GarbageCollector unit5_GarbageCollector = new Unit5_GarbageCollector();  
            unit5_GarbageCollector.Run();
        }
    }
}
