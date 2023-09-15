using WebApp3.Interface;

namespace WebApp3.Services
{
    public class Cricle : IShape, ISize
    {
        public string Draw()
        {
            return "Circle";
        }
        public int Width()
        {
            return 100;
        }
    }
}
