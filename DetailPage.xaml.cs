using Keep_Notes_Android.ViewModel;
namespace Keep_Notes_Android;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}
