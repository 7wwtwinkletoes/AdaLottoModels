﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class QueryResponse
    {
        public BlockChainInfo? BlockChainInfo { get; set; }
        public AdaLottoGameInfo? AdaLottoGameInfo { get; set; }
    }
}
