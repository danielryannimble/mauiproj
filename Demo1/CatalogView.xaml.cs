using CommunityToolkit.Mvvm.Messaging;
using Demo1.ViewModels;
namespace Demo1;

public partial class CatalogView : ContentPage
{

	public CatalogView(CatalogViewModel catalogViewModel)
	{
		Console.WriteLine("CatalogView");
		InitializeComponent();
	}

}