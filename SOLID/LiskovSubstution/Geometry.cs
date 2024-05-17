using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public static class Geometry 
    {
        public static IArea GetRectangle(int x, int? y=null)
        {
            //dikkat!!! Rectangle dönecek fonksiyondan Square döndürürsünüz.
            if (y.HasValue)
            {
                return new Rectangle { Width = x, Height = y.Value };
            }
            return new Square { EdgeLength = x };
        }
    }

    public interface IArea
    {
        int GetArea();
    }
    public class Rectangle : IArea
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea() => Width * Height;
    }
    
    public class Square : IArea
    {
        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        //public override int Height { get => base.Width; set { base.Width = value; base.Height = value; } }
        public int EdgeLength {  get; set; }

        public int GetArea()
        {
            return EdgeLength * EdgeLength;
        }
    }
}
