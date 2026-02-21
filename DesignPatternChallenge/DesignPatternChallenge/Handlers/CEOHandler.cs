using DesignPatternChallenge.Domain;

namespace DesignPatternChallenge.Handlers;

public class CEOHandler : ExpenseHandlerBase
{
    public override void Handle(ExpenseRequest request)
    {
        Console.WriteLine("[CEO] Analisando pedido...");

        if (ValidateReceipt() &&
            CheckBudget(request.Department) &&
            CheckPolicy() &&
            CheckStrategicAlignment() &&
            CheckBoardApproval())
        {
            Console.WriteLine($"✅ Despesa de R$ {request.Amount:N2} APROVADA pelo CEO");
            RegisterApproval("CEO", request);
        }
    }
}
