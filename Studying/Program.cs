// See https://aka.ms/new-console-template for more information
using SOLID;
using SOLID.Implemented_classes;

Console.WriteLine("Hello, World!");
//demonistrate SOLID principles
var PaymentProcessor = new PaymentProcessor(new VisaPayment());
PaymentProcessor.ProcessPayment(new Order());

