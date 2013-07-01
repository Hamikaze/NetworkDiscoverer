using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkDiscoverer
{
    class ControlCenter : Controller
    {
        Form1 mainView;
        public ControlCenter(Form1 mainView)
        {
            this.mainView = mainView;
            //the thrown event gets registred with the RunDiscovery method here
            mainView.ThrowEvent += (sender, args) => { RunDiscovery(); };
        }
        

        void RunDiscovery()
        {
            this.startIPAddress = mainView.getLowestIPText;
            this.endIPAddress = mainView.getHiestIPText;
            this.community = mainView.getCommunityString;
            this.oid = mainView.getOID;
            this.passwd = mainView.getPasswd;
            try
            {
                this.netmask = Convert.ToInt32(mainView.getNetMask);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Input string is not a sequence of digits at netmask field."+e);
                return;
            }

            if (this.startIPAddress != "")
            {
                FindAllIPAddressesInGivenNetwork findAllIPAddressesInGivenNetwork = new FindAllIPAddressesInGivenNetwork(this.startIPAddress, this.netmask);
                List<string> AllValidIP = findAllIPAddressesInGivenNetwork.getIpRange();
                string ip = "";
                foreach (String i in AllValidIP)
                {
                    ip += i + "  ";
                }

                //MessageBox.Show(ip);
            }
            else
            {
                //not implemented jet
            }
            
            
        }
       
    }
}
