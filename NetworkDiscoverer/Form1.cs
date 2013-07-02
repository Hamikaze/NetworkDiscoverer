using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkDiscoverer
{
    public partial class Form1 : Form
    {
        public delegate void EventHandler(object sender, EventArgs args);
        public event EventHandler ThrowEvent = delegate { };// ThrowEvent needs a delegate, so it knows its parameters

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            String communityString = AddCommunityString.Text.Trim(); // remove all whitespaces
            if ( communityString.Length !=0)
            {
                ComunityStringsSelectionBox.Items.Add(communityString);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ComunityStringsSelectionBox.Items.Remove(ComunityStringsSelectionBox.SelectedItem);
        }


        public void RunDiscoveryButton_Click(object sender, EventArgs e)
        {
            string selectionBoxString = "";
            try
            {
                selectionBoxString = ComunityStringsSelectionBox.SelectedItem.ToString();
            }
            catch (NullReferenceException e2)
            {
               // MessageBox.Show("You must select a Community");
            }
            if (LowestIPField.Text == "" || NetmaskSelector.Text == "" || oidField.Text == ""||selectionBoxString== "")
            {
                MessageBox.Show("Please fill out all mandatory fields!");
            }
            else
            {
                ThrowEvent(this, new EventArgs());// throw the event. the registred listener gets informed (ControlCenter) 
            }
        }


        //getters for all local vars
        public string getLowestIPText
        {
            get { return LowestIPField.Text; }
        }

        public string getHiestIPText
        {
            get { return HighestIPField.Text; }
        }

        public string getCommunityString
        {
            get { return ComunityStringsSelectionBox.SelectedItem.ToString(); }// returns the selected string
        }

        public string getOID
        {
            get { return oidField.Text; }
        }

        public string getNetMask
        {
            get { return NetmaskSelector.Text; }
        }

        public string getPasswd
        {
            get { return Password.Text;}
        }



    }
}
