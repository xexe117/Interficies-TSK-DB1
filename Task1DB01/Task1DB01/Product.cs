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
        public string MakeFlag { get; set; }
        public string ProductID { get; set; }
        public string Color { get; set; }
        public string ListPrice { get; set; }
        public string Size { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string ProductSubcategoryID { get; set; }
        public string ProductSubcategory { get; set; }
        public string ProductMOdel { get; set; }
        public string Description { get; set; }
        public string SellStartDate { get; set; }
        public string SellEndDate { get; set; }
        public string ProductNumber { get; set; }
        public string ProductCategory { get; set; }


        public string FullInfo
        {
            get
            {
                return $" { ProductMOdel }  ||  { Description }  ||  { Name }  ||  { ProductNumber }  ||" +
                    $"{ Color }  ||  { ListPrice }  ||  { Size }  ||  { ProductLine }  ||  { Class }  ||" +
                    $"  { Style }  ||  { ProductCategory }  ||  { ProductSubcategory }";
            }
        }

        public string PNamDes
        {
            get
            {
                return $"{ Name }||  {ProductMOdel}||  {Description}";
            }
        }

        public string PshowAll
        {
            get
            {
                return $"{ Name }||  {ProductMOdel}  ||  {Description} || { SellStartDate } || { SellEndDate }";
            }
        }

        public string PNamFiltro
        {
            get
            {
                return $"{ Name }||  {ProductMOdel}  ||  {Description}  || { Size } { ProductID } { Name } { ProductSubcategoryID } { ProductLine } { Class } { Style } { ListPrice } { Color } { MakeFlag }";
            }
        }
    }
}
