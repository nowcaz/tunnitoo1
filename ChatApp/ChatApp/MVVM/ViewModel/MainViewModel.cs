using ChatClient.MVVM.Core;
using ChatClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.MVVM.ViewModel
{
    class MainViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }

        private Server server;
        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(0 => _server.ConnectToServer());
        }
    }
}
