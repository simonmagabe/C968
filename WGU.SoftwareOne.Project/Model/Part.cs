namespace WGU.SoftwareOne.Project.Model
{
    public abstract class Part
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        internal int Max { get; set; }
        internal int Min { get; set; }

        public Part(int id, string name, int instock, decimal cost, int max, int min)
        {
            ID = id;
            Name = name;
            InStock = instock;
            Price = cost;
            Max = max;
            Min = min;
        }

        public Part()
        {
            
        }
    }
}
