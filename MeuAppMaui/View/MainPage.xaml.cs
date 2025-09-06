using MeuAppMaui.ViewModel;

namespace MeuAppMaui;

public partial class MainPage : ContentPage
{
	//NAO PODE LOGICA DE NEGOCIO!!!!!!
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}
