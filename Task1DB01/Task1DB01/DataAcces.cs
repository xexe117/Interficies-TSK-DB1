﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Task1DB01
{   public class DataAcces
    {
        public List<ProductModel> GetProduct(string tipo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
				var output = connection.Query<ProductModel>($"SELECT " +
					$"Production.ProductModel.Name AS ProductMOdel, Production.ProductDescription.Description, " +
					$"Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size, " +
					$"Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, " +
					$"Production.ProductCategory.Name AS [Product Category], " +
					$"Production.ProductSubcategory.Name AS [Product Subcategory] " +
			$"FROM " +
					$"Production.Product " +
					$"INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID " +
					$"INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID " +
					$"INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
					$"INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
					$"INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
			$"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL ").ToList();
				return output;
            }
        }
    }
}
