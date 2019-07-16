using Microsoft.AspNetCore.SignalR;

namespace WebApi.Hubs
{
    public class ChatHub : Hub
    {
        public void SendToChannel(string name, string message)
        {
            Clients.All.SendAsync("SendToChannel", name, message);
        }
        public void SendToUser(string userId, string name, string message)
        {
            Clients.User(userId).SendAsync("SendToChannel", name, message);
        }

    }

}