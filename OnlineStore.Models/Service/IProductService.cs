﻿using OnlineStore.Data.DTO_ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Service
{
    public interface IProductService
    {
        List<AdminProductViewDTO> GetAllProducts();
        List<ProductViewDTO> GetAllActiveProducts();

        List<ProductViewDTO> GetActiveProductCategorized(List<int> muscleLoadIds);

        public void DeactivateProduct(int id);
        public void ActivateProduct(int id);
        ProductDetailsDTO GetProductDetailsById(int id);
    }
}
