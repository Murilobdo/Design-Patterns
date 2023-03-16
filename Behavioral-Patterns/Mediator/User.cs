namespace Mediator
{
    public abstract class User
    {
        protected IFacebookGroupMediator _mediator;
        protected string _name;

        public User(IFacebookGroupMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}