using DesignPatternChallenge.Domain;

namespace DesignPatternChallenge.Handlers;

public class SupervisorHandler : ExpenseHandlerBase
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 100)
        {
            Console.WriteLine("[Supervisor] Analisando pedido...");

            if (ValidateReceipt() && CheckBudget(request.Department))
            {
                Console.WriteLine($"✅ Despesa de R$ {request.Amount:N2} APROVADA pelo Supervisor");
                RegisterApproval("Supervisor", request);
            }
        }
        else
        {
            Console.WriteLine("[Supervisor] Encaminhando para próximo nível...");
            base.Handle(request);
        }
    }
}
