using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAndMAUI.WebAssemblyWebAPI
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message)
        {
            Console.WriteLine(message);
            await Clients.All.SendAsync("MessageReceived", message);
        }
    }
}
