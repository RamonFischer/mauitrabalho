using LiteDB;
using Projeto_Curso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Curso.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase _liteDatabase;
        private readonly string _connectionName = "transaction";

        public TransactionRepository(LiteDatabase liteDatabase) {
            _liteDatabase = liteDatabase;
        }

        public List<Transaction> getAll()
        {
            return _liteDatabase.GetCollection<Transaction>(_connectionName).Query().OrderByDescending(a => a.Date).ToList();
        }

        public void Add(Transaction transactions)
        {
            var crudDatase = _liteDatabase.GetCollection<Transaction>();
            crudDatase.Insert(transactions);
            crudDatase.EnsureIndex(a => a.Date);
        }

        public void eraseAll()
        {
            var crudDatase = _liteDatabase.GetCollection<Transaction>();
            crudDatase.DeleteAll();
        }

        public void Update(Transaction transactions) {
            var crudDatase = _liteDatabase.GetCollection<Transaction>();
             crudDatase.Update(transactions);
        }

        public void Delete(Transaction transactions) {
            var crudDatase = _liteDatabase.GetCollection<Transaction>();
            crudDatase.Delete(transactions.ID);
        }
    }
}
