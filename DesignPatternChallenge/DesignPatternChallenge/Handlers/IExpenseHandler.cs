using DesignPatternChallenge.Domain;

namespace DesignPatternChallenge.Handlers;

public interface IExpenseHandler
{
    IExpenseHandler SetNext(IExpenseHandler next);
    void Handle(ExpenseRequest request);
}
