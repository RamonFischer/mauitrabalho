using Projeto_Curso.Models;
namespace Projeto_Curso.Repositories
{
    public interface ITransactionRepository
    {
        void Add(Transaction transactions);
        void Delete(Transaction transactions);
        void Update(Transaction transactions);

        void eraseAll();
        List<Transaction> getAll();
    }
}