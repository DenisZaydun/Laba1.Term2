﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Term2
{
    class PairClass<TKey, TValue> where TKey : IEquatable<TKey>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public PairClass(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
