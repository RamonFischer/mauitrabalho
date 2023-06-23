﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Curso.Models
{
    public class Transaction
    {
        [BsonId]
        public int ID { get; set; }
        public  TransactionType Type { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}

public enum TransactionType { 
    Profit,
    Expenses
}



