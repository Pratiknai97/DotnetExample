using WebApp2.Interface;

namespace WebApp2.Services
{
    public class Circle1 :IShape, ISize
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
