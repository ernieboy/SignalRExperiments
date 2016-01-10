using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace SignalRExperiments.Hubs
{
    public class RealtimeDataHub : Hub
    {

        public RealtimeDataHub()
        {
            SendSystemTimeToAllClients();
        }

        private void SendSystemTimeToAllClients()
        {
            var task = Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    string time = DateTime.Now.ToString();
                    NewServerTime(time);
                   await  Task.Delay(1000);
                }
            }, TaskCreationOptions.LongRunning);
        }

        public void SendMessage(string msg)
        {
            Clients.All.newMessage(msg);
        }

        public void NewServerTime(string msg)
        {
            Clients.All.newServerTime(msg);
        }
    }
}