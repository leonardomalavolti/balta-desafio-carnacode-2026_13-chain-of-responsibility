using DesignPatternChallenge.Domain;

namespace DesignPatternChallenge.Handlers;

public class ManagerHandler : ExpenseHandlerBase
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 500)
        {
            Console.WriteLine("[Gerente] Analisando pedido...");

            if (ValidateReceipt() &&
                CheckBudget(request.Department) &&
                CheckPolicy())
            {
                Console.WriteLine($"✅ Despesa de R$ {request.Amount:N2} APROVADA pelo Gerente");
                RegisterApproval("Gerente", request);
            }
        }
        else
        {
            Console.WriteLine("[Gerente] Encaminhando para próximo nível...");
            base.Handle(request);
        }
    }
}
