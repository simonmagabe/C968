using System;
using System.ComponentModel;

namespace WGU.SoftwareOne.Project.Model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        internal int Min { get; set; }
        internal int Max { get; set; }

        public Product(int id, string name, int instock, decimal price, int max, int min)
        {
            ProductID = id;
            Name = name;
            InStock = instock;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product()
        {
            
        }

        #region // Helper Methods
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int selectedPartId)
        {
            bool isRemoved = false;

            for (int part = 0; part < AssociatedParts.Count; part++)
            {
                if (AssociatedParts[part].ID == selectedPartId)
                {
                    AssociatedParts.Remove(AssociatedParts[part]);
                    isRemoved = true;
                }
                else
                {
                    Console.WriteLine($"Failed! The part was not removed.");
                    isRemoved = false;
                }
            }

            return isRemoved;
        }

        public Part LookupAssociatedPart(int partId)
        {
            for (int part = 0; part < AssociatedParts.Count; part++)
            {
                if (AssociatedParts[part].ID == partId)
                {
                    return AssociatedParts[part];
                }
            }

            Outsourced voidPart = new Outsourced();
            return voidPart;
        }
        #endregion
    }
}
