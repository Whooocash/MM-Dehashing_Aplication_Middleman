using Microsoft.AspNetCore.SignalR;

namespace BlazorChat.Hubs
{
    public class ChatHub : Hub
    {
        // Metoda do wysyłania wiadomości do wszystkich połączonych użytkowników
        public async Task SendMessage(string user, string message)
        {
            // Przesyła wiadomość do wszystkich połączonych użytkowników
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
