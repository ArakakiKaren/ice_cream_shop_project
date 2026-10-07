using ice_cream_shop_project.Domain;
using ice_cream_shop_project.Domain.DTOs;
using ice_cream_shop_project.Domain.Enum;
using ice_cream_shop_project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Api.Applications
{
    public class ProductApp
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public ProductApp(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateProduct(RequestProductDTO request) 
        {
            Product product;

            if (request.SaleMethod == ESaleMethod.Unit)
            {
                product = new UnitProduct();
            }
            else
            {
                product = new WeighedProduct();
            }
            product.Id = Guid.NewGuid();
            product.Name = request.Name;
            product.Type = request.Type;
            product.Description = request.Description;
            product.Active = true;

            _unitOfWork.ProductRepository.Add(product);
            _unitOfWork.Commit();
        }
    }
}
