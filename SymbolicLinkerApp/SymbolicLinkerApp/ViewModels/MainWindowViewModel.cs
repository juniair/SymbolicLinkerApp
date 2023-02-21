using Prism.Mvvm;

namespace SymbolicLinkerApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Symbolic Linker";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
