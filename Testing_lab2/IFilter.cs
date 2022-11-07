using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_lab2
{
	public interface IFilter
	{
		(Bitmap, ulong) Apply(Bitmap image);
	}
}
