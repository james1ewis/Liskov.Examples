namespace Liskov.Examples.Shapes.Model
{
	public abstract class Shape
	{
		public virtual int Height { get; set; }
		public virtual int Width { get; set; }

		public void Draw()
		{
			
		}
	}
}
