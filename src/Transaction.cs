﻿using ADALottoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class Transaction
    {
        public long? Id { get; set; }
        public long? BlockId { get; set; }
        public Block Block { get; set; } = new Block();
        public IEnumerable<TransactionMeta>? TxMetadata { get; set; }
        public IEnumerable<TransactionIn>? InTxIns { get; set; }
        public int[]? Hash { get; set; }
    }
}
