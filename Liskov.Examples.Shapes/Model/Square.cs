namespace Liskov.Examples.Shapes.Model
{
	public class Square : Shape
	{
		public override int Height
		{
			get
			{
				return base.Height;
			}
			set
			{
				base.Width = value;
				base.Height = value;
			}
		}

		public override int Width
		{
			get
			{
				return base.Width;
			}
			set
			{
				base.Height = value;
				base.Width = value;
			}
		}
	}
}
