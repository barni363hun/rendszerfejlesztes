using System.Net.WebSockets;
using ClassLibrary.WebSocket;
using System.Text;

namespace ClassLibrary.WebSocket.Handlers
{
    public class TaskHandler : WebSocketHandler
    {
        public TaskHandler(ConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {

        }

        public override async Task ReceiveAsync(System.Net.WebSockets.WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            var message = $"Ezt küldte a kliens: {Encoding.UTF8.GetString(buffer, 0, result.Count)}";

            await SendMessageToAllAsync(message);//A kliens által küldött üzenetet visszaküldjük az összes csatlakozott kliensnek
        }
    }
}
