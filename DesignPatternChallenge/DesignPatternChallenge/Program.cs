using DesignPatternChallenge.Domain;
using DesignPatternChallenge.Handlers;

Console.WriteLine("=== Sistema de Aprovação de Despesas ===");

var supervisor = new SupervisorHandler();
var manager = new ManagerHandler();
var director = new DirectorHandler();
var ceo = new CEOHandler();

supervisor
    .SetNext(manager)
    .SetNext(director)
    .SetNext(ceo);

var expense1 = new ExpenseRequest("João Silva", 50m, "Material de escritório", "TI");
var expense2 = new ExpenseRequest("Maria Santos", 350m, "Curso de capacitação", "RH");
var expense3 = new ExpenseRequest("Pedro Oliveira", 2500m, "Notebook", "TI");
var expense4 = new ExpenseRequest("Ana Costa", 15000m, "Servidor", "TI");

supervisor.Handle(expense1);
supervisor.Handle(expense2);
supervisor.Handle(expense3);
supervisor.Handle(expense4);

Console.ReadLine();