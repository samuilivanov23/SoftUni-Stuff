namespace StorageMaster.Products
{
    public class HardDrive : Product
    {
        private const double HardDriveWeight = 1;

        public HardDrive(double price)
            : base(price, HardDriveWeight) { }
    }
}