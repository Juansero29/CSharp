﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceptor
{
    public class Selector
    {
        private Acceptor acceptor;

        public Selector(Acceptor a)
        {
            acceptor = a;
        }

        public void SelectProduct(float price)
        {
            acceptor.SelectProduct((int)(price * 100f));
        }

        public void Buy()
        {
            acceptor.Confirm();
        }
    }
}
