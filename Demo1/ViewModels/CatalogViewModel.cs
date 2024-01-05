

using System.Collections.ObjectModel;
using Demo1.Services.Navigation;
using Demo1.Models.Catalog;
using System.ComponentModel;


namespace Demo1.ViewModels;


public partial class CatalogViewModel : ViewModelBase
{

    private readonly ObservableCollectionEx<CatalogItem> _products = new ();


    public IReadOnlyList<CatalogItem> Products => _products;
    public CatalogViewModel(INavigationService navigationService) : base(navigationService)
    {
        _products = new ObservableCollectionEx<CatalogItem>();
        AddCatalogItem();
    }

    private void AddCatalogItem(){
        var catalogItem = new CatalogItem("123", "coat", "description");
        var products = new List<CatalogItem>();
        products.Add(catalogItem);
        // products.Append(catalogItem);
        _products.ReloadData(products);
        Console.WriteLine("_products.Count: " + _products.Count);
        Console.WriteLine("products.Count: " + products.Count);
    }
}