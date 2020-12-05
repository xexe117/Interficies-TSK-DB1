using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1DB01
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int MakeFlag { get; set; }
        public int FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public int StandardCost { get; set; }
        public int ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public int Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int ProductSubcategoryID { get; set; }
        public int ProductModelID { get; set; }
        public string SellStartDate { get; set; }
        public string SellEndDate { get; set; }
        public string DiscontinuedDate { get; set; }
        public string rowguid { get; set; }
        public string ModifiedDate { get; set; }
        public string ProductMOdel { get; set; }
        public string Description { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ Name }  ||  { ProductNumber }  ||  { MakeFlag }  ||  { FinishedGoodsFlag }  ||  " +
                    $"{ Color }  ||  { SafetyStockLevel }  ||  { ReorderPoint }  ||  { StandardCost }  ||  { ListPrice }  ||  " +
                    $"{ Size }  ||  { SizeUnitMeasureCode }  ||  { WeightUnitMeasureCode }  ||  { Weight }  ||  { DaysToManufacture }  ||  " +
                    $"{ ProductLine }  ||  { Class }  ||  { Style }  ||  { ProductSubcategoryID }  ||  { ProductModelID }  ||  { SellStartDate }  ||  " +
                    $"{ SellEndDate }  ||  { DiscontinuedDate }  ||  { rowguid }  ||  { ModifiedDate } ";
            }
        }

        public string NamDes
        {
            get
            {
                return $"{ProductMOdel}  ||  {Description}";
            }
        }

        public string NamFiltro
        {
            get
            {
                return $"{ProductMOdel}  ||  {Description}  || { Size }";
            }
        }
    }
}
