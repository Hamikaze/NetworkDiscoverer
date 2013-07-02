using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

// All Controllers must inherit from this Abstract Controller!

namespace NetworkDiscoverer
{
    abstract class Controller
    {
        // those vars are potentially usfull in all controller subclasses.
        protected string startIPAddress;
        protected string endIPAddress;
        protected string passwd;
        protected string community;
        protected int netmask;
        protected string oid;

        public string EndIPAddress
        {
            get { return endIPAddress; }
            //set { endIPAddress = value; }
        }

        public int Netmask
        {
            get { return netmask; }
            //set { netmask = value; }
        }

        public string Community
        {
            get { return community; }
            //set { community = value; }
        }

        public string Passwd
        {
            get { return passwd; }
            //set { passwd = value; }
        }


        public string StartIPAddress
        {
            get { return startIPAddress; }
            //set { startIPAddress = value; }
        }


    }
}
