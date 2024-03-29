﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domain
{
    public class ClassifiedAdId
    {
        private readonly Guid _value;

        public ClassifiedAdId(Guid value)
        {
            if (value == default(Guid))
                throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty");

            _value = value;
        }

    }
}
