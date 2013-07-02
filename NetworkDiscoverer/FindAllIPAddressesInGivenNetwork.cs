using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace NetworkDiscoverer
{
    class FindAllIPAddressesInGivenNetwork
    {
         private string ip = null;
        private int netmask;


        public FindAllIPAddressesInGivenNetwork(string ip, int netmask)
        {
            this.ip = ip;
            this.netmask = netmask;
    }

        
       
        public List<string> getIpRange()
        {
            List<int> startIpList = new List<int>();
            string[] values = this.ip.Split('.');
            if (!(values.Length == 4)) return null;
            foreach (string value in values)
            {
                startIpList.Add(Convert.ToInt32(value));
            }
            int[] ipStart = startIpList.ToArray();



            IPAddress ip = new IPAddress(new byte[] { (byte)ipStart[0], (byte)ipStart[1], (byte)ipStart[2], (byte)ipStart[3] });
            //int bits = 25;

            uint mask = ~(uint.MaxValue >> this.netmask);

            // Convert the IP address to bytes.
            byte[] ipBytes = ip.GetAddressBytes();

            // BitConverter gives bytes in opposite order to GetAddressBytes().
            byte[] maskBytes = BitConverter.GetBytes(mask).Reverse().ToArray();

            byte[] startIPBytes = new byte[ipBytes.Length];
            byte[] endIPBytes = new byte[ipBytes.Length];

            // Calculate the bytes of the start and end IP addresses.
            for (int i = 0; i < ipBytes.Length; i++)
            {
                startIPBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
                endIPBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);
            }

            // Convert the bytes to IP addresses.
            IPAddress ipLowest = new IPAddress(startIPBytes);
            IPAddress ipEnd = new IPAddress(endIPBytes);

            // iterate thru all ip addresses by shifting bits
            int counter;
            int startIP = (
               startIPBytes[0] << 24 |
               startIPBytes[1] << 16 |
               startIPBytes[2] << 8 |
               startIPBytes[3]);

            int endIP = (
               endIPBytes[0] << 24 |
               endIPBytes[1] << 16 |
               endIPBytes[2] << 8 |
               endIPBytes[3]);
            List<string> allIPInNetwork = new List<string>();
            long firstOctet;
            long secondOctet;
            long thirdOctet;
            long fourthOctet;
            for (counter = startIP; counter <= endIP; counter++)
            {
                          firstOctet = (counter & 0xFF000000) >> 24;
                          secondOctet = (counter & 0x00FF0000) >> 16;
                          thirdOctet = (counter & 0x0000FF00) >> 8;
                          fourthOctet = (counter & 0x000000FF);
                         // allIPInNetwork.Add(firstOctet.ToString() + "." + secondOctet.ToString() + "." + thirdOctet.ToString() + "." + fourthOctet.ToString());
                          allIPInNetwork.Add(""+firstOctet + "." + secondOctet + "." + thirdOctet + "." +fourthOctet);// consumes a lot of time!!
                          // todo:
                          // try to convert back to ipAddress. might be faster
            }

            return allIPInNetwork;
        }
    }
}
