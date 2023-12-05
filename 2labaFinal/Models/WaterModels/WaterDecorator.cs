namespace Models
{
    public abstract class WaterDecorator : Water
    {
        protected Water water;

        public WaterDecorator(Water water)
        {
            this.water = water;
        }
    }
}
