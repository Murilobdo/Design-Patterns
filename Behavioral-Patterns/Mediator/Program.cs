
using Mediator;

IFacebookGroupMediator mediator = new ConcreteFacebookGroupMediator();

User murilo = new ConcreteUser(mediator, "Murilo");
User isabel = new ConcreteUser(mediator, "Isabel");
User felipe = new ConcreteUser(mediator, "Felipe");
User julia = new ConcreteUser(mediator, "Julia");
User fabricio = new ConcreteUser(mediator, "Fabricio");

mediator.RegisterUser(murilo, isabel, felipe, julia, fabricio);
murilo.Send("Sejam muito bem vindos ao time corporativo.");

Console.ReadLine();