namespace DeliveryCalculator.Library
{
    public class Parcel
    {
        public Parcel(double length, double width, double height, double weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }



        public double Length { get; }

        public double Width { get; }

        public double Height { get; }

        public double Weight { get; }
    }
}