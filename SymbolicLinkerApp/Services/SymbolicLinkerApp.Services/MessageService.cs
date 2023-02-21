using SymbolicLinkerApp.Services.Interfaces;

namespace SymbolicLinkerApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
