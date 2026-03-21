// See https://aka.ms/new-console-template for more information
using MVC_Example;

Console.WriteLine("Hello, World!");

User user = new() { Id = 1, Name = "John Doe" };
UserView view = new();
UserController controller = new UserController(user, view);

controller.DisplayUser();
controller.UpdateUserName();