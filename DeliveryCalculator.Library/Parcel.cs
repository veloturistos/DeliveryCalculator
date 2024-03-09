namespace DeliveryCalculator.Library
{
    public class Parcel
    {
        public Parcel(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; }

        public double Width { get; }

        public double Height { get; }
    }
}