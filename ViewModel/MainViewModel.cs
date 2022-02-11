namespace GreenGrad.ViewModel;

internal class MainViewModel: Base.ViewModelBase
{
    private string _title;

    public string Title
    {
        get => _title = "GreenGrad";
        set => Set(ref _title, value);
    }
    
}