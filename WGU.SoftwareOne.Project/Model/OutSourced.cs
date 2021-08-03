namespace WGU.SoftwareOne.Project.Model
{
    public class Outsourced : Part
    {
        internal string CompanyName { get; set; }

        public Outsourced(int id, string name, int instock, decimal price, int max, int min, string companyName)
            : base(id, name, instock, price, max, min)
        {
            CompanyName = companyName;
        }

        public Outsourced()
        {
            
        }
    }
}
