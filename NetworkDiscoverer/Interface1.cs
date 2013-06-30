using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;



namespace NetworkDiscoverer
{
    interface IController
    {
        protected String startIPAddress;
        protected String endIPAddress;
        protected String passwd;
        protected String community;
        protected int netmask;

        public String EndIPAddress
        {
            get { return endIPAddress; }
            //set { endIPAddress = value; }
        }

        public int Netmask
        {
            get { return netmask; }
            //set { netmask = value; }
        }

        public String Community
        {
            get { return community; }
            //set { community = value; }
        }

        public String Passwd
        {
            get { return passwd; }
            //set { passwd = value; }
        }


        public String StartIPAddress
        {
            get { return startIPAddress; }
            //set { startIPAddress = value; }
        }

    }
}
