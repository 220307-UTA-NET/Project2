using Microsoft.AspNetCore.SignalR;

//The ChatHub class inherits from the SignalR Hub class.
//The Hub class manages connections, groups, and messaging.


namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

