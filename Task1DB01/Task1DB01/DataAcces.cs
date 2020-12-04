using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Task1DB01
{   public class DataAcces
    {
		// Aqui pots crear querys en forma de metodes (A vuelto, en FORMA DE CHAPA)
        public List<ProductModel> GetShowAll(string leng)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                var output = connection.Query < ProductModel >("SELECT Production.ProductModel.Name AS ProductMOdel, " +
                    "Production.Product.Name, Production.Product.ProductNumber, Production.Product.MakeFlag, Production.Product.FinishedGoodsFlag,  Production.Product.Color, " +
                    "Production.Product.SafetyStockLevel, Production.Product.ReorderPoint, Production.Product.StandardCost, Production.Product.ListPrice, Production.Product.Size," +
                    "Production.Product.SizeUnitMeasureCode, Production.Product.WeightUnitMeasureCode, Production.Product.Weight, Production.Product.DaysToManufacture, " +
                    "Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.Product.ProductSubcategoryID, Production.Product.ProductModelID," +
                    "Production.Product.SellStartDate, Production.Product.SellEndDate, Production.Product.DiscontinuedDate, Production.Product.ModifiedDate " +
                "FROM " +
                    "Production.Product " +
                    "INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID " +
                    "INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID " +
                    "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                    "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                    "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                $"WHERE ProductModelProductDescriptionCulture.CultureID = '{ leng }' AND Product.ProductModelID IS NOT NULL").ToList();

                return output;
            }
        }

		public List<ProductModel> GetAviabel(string leng)
        {
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
			{
				var output = connection.Query<ProductModel>("SELECT Production.ProductModel.Name AS ProductMOdel, " +
                    "Production.Product.Name, Production.Product.ProductNumber, Production.Product.MakeFlag, Production.Product.FinishedGoodsFlag,  Production.Product.Color, " +
                    "Production.Product.SafetyStockLevel, Production.Product.ReorderPoint, Production.Product.StandardCost, Production.Product.ListPrice, Production.Product.Size," +
                    "Production.Product.SizeUnitMeasureCode, Production.Product.WeightUnitMeasureCode, Production.Product.Weight, Production.Product.DaysToManufacture, " +
                    "Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.Product.ProductSubcategoryID, Production.Product.ProductModelID," +
                    "Production.Product.SellStartDate, Production.Product.SellEndDate, Production.Product.DiscontinuedDate, Production.Product.ModifiedDate " +
                "FROM " +
                    "Production.Product " +
                    "INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID " +
                    "INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID " +
                    "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                    "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                    "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                $"WHERE ProductModelProductDescriptionCulture.CultureID = '{ leng }' AND Product.ProductModelID IS NOT NULL AND Product.SellEndDate IS NOT NULL ").ToList();
				return output;
			}
		}

        public List<ProductModel> UpdateViewRowsPage(string leng, int inici, int cantidad)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string sql = "SELECT Production.ProductModel.Name AS ProductMOdel, Production.ProductDescription.Description " +
                                "FROM " +
                                    "Production.Product " +
                                    "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                                    "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                                    "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                $"WHERE ProductModelProductDescriptionCulture.CultureID = '{ leng }' " +
                                $"ORDER BY Production.ProductModel.Name OFFSET {inici } ROWS FETCH NEXT 10 ROWS ONLY";
                var output = connection.Query<ProductModel>(sql).ToList();
                return output;
            }
    }
    }
}
