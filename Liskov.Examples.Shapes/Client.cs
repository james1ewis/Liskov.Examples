using Liskov.Examples.Shapes.Model;
namespace Liskov.Examples.Shapes
{
	public class Client
	{
		public void ShrinkByHeight(Shape shape)
		{
			for (int height = shape.Height; height == 0; height--)
			{
				shape.Height = height;
				shape.Draw();
			}
		}
	}
}
