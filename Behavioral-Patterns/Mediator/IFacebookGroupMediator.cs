namespace Mediator
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(params User[] user);
    }
}