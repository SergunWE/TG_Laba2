using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_lab2
{
	public class ImageManager
	{
		public Bitmap? OriginalImage { get; set; }
		public Bitmap? FilteredImage { get; set; }

		private IFilter[] _filters = { new BWFilter() };
		private Stopwatch _stopwatch = new Stopwatch();
		private ulong _operations;

		public void ApplyFilters()
		{
			if(OriginalImage != null)
			{
				if(FilteredImage != null)
				{
					FilteredImage.Dispose();
				}
				FilteredImage = OriginalImage;
				_stopwatch = Stopwatch.StartNew();
				for(int i = 0; i < _filters.Length; i++)
				{
					var res = _filters[i].Apply(FilteredImage);
					FilteredImage = res.Item1;
					_operations = res.Item2;
				}
				_stopwatch.Stop();
			}
		}

		public TimeSpan GetRuntime()
		{
			if(_stopwatch != null)
			{
				return _stopwatch.Elapsed;
			}
			return TimeSpan.Zero;
		}

		public ulong GetOperations()
		{
			return _operations;
		}
	}

}
