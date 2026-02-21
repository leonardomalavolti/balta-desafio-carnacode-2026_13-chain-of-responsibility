using DesignPatternChallenge.Domain;

namespace DesignPatternChallenge.Handlers;

public abstract class ExpenseHandlerBase : IExpenseHandler
{
    private IExpenseHandler _next;

    public IExpenseHandler SetNext(IExpenseHandler next)
    {
        _next = next;
        return next;
    }

    public virtual void Handle(ExpenseRequest request)
    {
        if (_next != null)
            _next.Handle(request);
        else
            Console.WriteLine("❌ Nenhum aprovador disponível para essa despesa.");
    }

    protected void RegisterApproval(string approver, ExpenseRequest request)
    {
        Console.WriteLine($"  → Registrando aprovação por {approver}");
    }

    protected bool ValidateReceipt()
    {
        Console.WriteLine("  → Validando nota fiscal...");
        return true;
    }

    protected bool CheckBudget(string department)
    {
        Console.WriteLine($"  → Verificando orçamento do departamento {department}...");
        return true;
    }

    protected bool CheckPolicy()
    {
        Console.WriteLine("  → Verificando conformidade com política...");
        return true;
    }

    protected bool CheckStrategicAlignment()
    {
        Console.WriteLine("  → Verificando alinhamento estratégico...");
        return true;
    }

    protected bool CheckBoardApproval()
    {
        Console.WriteLine("  → Verificando aprovação do conselho...");
        return true;
    }
}
