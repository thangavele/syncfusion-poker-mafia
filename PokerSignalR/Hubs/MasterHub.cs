using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace PokerSignalR.Hubs
{
    public class MasterHub : Hub
    {
        public static List<string> masterConnectionID = new List<string>();
        public static string CardList;
        public void Send(string name, string message)
        {
            CardList = message;
            // Call the addNewMessageToPage method to update clients.
          //  Clients.All.addNewMessageToPage(name, message);
        }
        public void get()
        {
            Clients.All.addNewMessageToPage(CardList);
            // Call the addNewMessageToPage method to update clients.
            //  Clients.All.addNewMessageToPage(name, message);
        }
        public override Task OnReconnected()
        {
            masterConnectionID = new List<string>();
            return base.OnReconnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            masterConnectionID = new List<string>();
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnConnected()
        {
            if (masterConnectionID.Count == 0)
            {
                masterConnectionID.Add(Context.ConnectionId);
            }
            return base.OnConnected();
        }
    }
}