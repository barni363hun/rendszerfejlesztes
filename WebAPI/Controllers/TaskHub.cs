using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Controllers
{
    public sealed class TaskHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
