using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using ContactServiceLibrary.MsSQLService;
using ContactServiceLibrary.Interfaces;

namespace MsSQLContactServiceHost
{
    public partial class MsSQLService : ServiceBase
    {
        private ServiceHost _serviceHost = null;

        public MsSQLService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_serviceHost != null) {
                _serviceHost.Close();
            }

            //string HTTPAddress = @"http://localhost:39001/MsSQLContactService";
            //string TCPAddress = @"net.tcp://localhost:39002/MsSQLContactService";

            //_serviceHost = new ServiceHost(typeof(MsSQLContactService), new Uri[] { new Uri(HTTPAddress), new Uri(TCPAddress) });

            //ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            //_serviceHost.Description.Behaviors.Add(behavior);

            //BasicHttpBinding HTTPBinding = new BasicHttpBinding();
            //_serviceHost.AddServiceEndpoint(typeof(IContactService<MsSQLContactType, long>), HTTPBinding, HTTPAddress);
            //_serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            //NetTcpBinding TCPBinding = new NetTcpBinding();
            //TCPBinding.Security.Mode = SecurityMode.Transport;
            //TCPBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            //TCPBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            //TCPBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            //_serviceHost.AddServiceEndpoint(typeof(IContactService<MsSQLContactType, long>), TCPBinding, TCPAddress);
            //_serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

            _serviceHost = new ServiceHost(typeof(MsSQLContactService));
            _serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
                _serviceHost = null;
            }
        }
    }
}
