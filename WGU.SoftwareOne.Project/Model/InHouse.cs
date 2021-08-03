namespace WGU.SoftwareOne.Project.Model
{
    public class InHouse : Part
    {
        internal int MachineID { get; set; }

        public InHouse(int id, string name, int instock, decimal price, int max, int min, int machineId)
            : base(id, name, instock, price, max, min)
        {
            MachineID = machineId;
        }

        public InHouse()
        {
            
        }
    }
}
