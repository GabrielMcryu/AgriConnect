using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace agri_connect_remoting_server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register the TCP channel for remoting communication.
            TcpChannel channel = new TcpChannel(12345);
            ChannelServices.RegisterChannel(channel, false);

            // Register the remote object.
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Supplier.SupplierProduct), "SupplierProduct", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Supplier.SupplierTransaction), "SupplierTransaction", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Vendor.VendorProduct), "VendorProduct", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server is running. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
