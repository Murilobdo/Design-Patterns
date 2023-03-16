namespace Mediator
{
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        public List<User> userList = new();

        public void RegisterUser(params User[] users)
        {
            userList.AddRange(users);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in userList)
            {
                if(u != user)
                    u.Receive(message);
            }
        }
    }
}