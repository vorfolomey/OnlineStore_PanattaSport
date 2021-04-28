﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Data.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        public IProductRepository Product { get; }

        public int Complete();
    }
}