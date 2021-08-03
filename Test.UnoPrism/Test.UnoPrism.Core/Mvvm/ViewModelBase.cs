using Prism.Mvvm;

namespace Test.UnoPrism.Core.Mvvm
{
  public class ViewModelBase : BindableBase
  {
    private string _title;
    public string Title
    {
      get { return _title; }
      set { SetProperty(ref _title, value); }
    }
  }
}
