

using System.Collections.ObjectModel;
using Demo1.Services.Navigation;
using Demo1.Models.Catalog;

namespace Demo1.ViewModels;


public partial class CatalogViewModel : ViewModelBase
{

    private readonly ObservableCollectionEx<CatalogItem> _products = new ();


    public IReadOnlyList<CatalogItem> Products => _products;
    public CatalogViewModel(INavigationService navigationService) : base(navigationService)
    {
    }
}