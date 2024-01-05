using CommunityToolkit.Mvvm.Input;
using Demo1.Services;
using Demo1.Services.Navigation;

namespace Demo1.ViewModels.Base;


public interface IViewModelBase : IQueryAttributable
{

    public INavigationService NavigationService { get; }

    public IAsyncRelayCommand InitializeAsyncCommand { get; }

    public bool IsBusy{ get; }
    public bool IsInitialized { get; }

    Task InitializeAsync();

}