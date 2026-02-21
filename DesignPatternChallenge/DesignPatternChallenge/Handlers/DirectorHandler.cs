using DesignPatternChallenge.Domain;

namespace DesignPatternChallenge.Handlers;

public class DirectorHandler : ExpenseHandlerBase
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine("[Diretor] Analisando pedido...");

            if (ValidateReceipt() &&
                CheckBudget(request.Department) &&
                CheckPolicy() &&
                CheckStrategicAlignment())
            {
                Console.WriteLine($"✅ Despesa de R$ {request.Amount:N2} APROVADA pelo Diretor");
                RegisterApproval("Diretor", request);
            }
        }
        else
        {
            Console.WriteLine("[Diretor] Encaminhando para próximo nível...");
            base.Handle(request);
        }
    }
}
