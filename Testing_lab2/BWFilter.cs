using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_lab2
{
	public class BWFilter : IFilter
	{
		public (Bitmap, ulong) Apply(Bitmap image)
		{
			Bitmap output = new(image.Width, image.Height);
			ulong operations = 0;
			for (int j = 0; j < output.Height; j++)
			{
				for (int i = 0; i < output.Width; i++)
				{
					UInt32 pixel = (UInt32)(image.GetPixel(i, j).ToArgb());
					float R = (float)((pixel & 0x00FF0000) >> 16); // красный
					float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
					float B = (float)(pixel & 0x000000FF); // синий
					operations += 3;
					R = G = B = (R + G + B) / 3.0f;
					operations += 3;
					UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
					operations += 5;
					output.SetPixel(i, j, Color.FromArgb((int)newPixel));
				}
			}

			return (output, operations);
		}
	}
}
