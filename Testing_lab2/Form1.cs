namespace Testing_lab2
{
	public partial class Form1 : Form
	{
		private readonly ImageManager _imageManager;

		public Form1()
		{
			_imageManager = new ImageManager();
			InitializeComponent();
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new()
			{
				Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
			};
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					
					_imageManager.OriginalImage = new Bitmap(ofd.FileName);
					originalImage.Image = _imageManager.OriginalImage;
				}
				catch
				{
					MessageBox.Show("Unable to open the selected file", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void filterButton_Click(object sender, EventArgs e)
		{
			if(_imageManager.OriginalImage != null)
			{
				_imageManager.ApplyFilters();
				filteredImage.Image = _imageManager.FilteredImage;
				timeValue.Text = _imageManager.GetRuntime().TotalMilliseconds.ToString();
				operationValue.Text = _imageManager.GetOperations().ToString();
			}
		}
	}
}