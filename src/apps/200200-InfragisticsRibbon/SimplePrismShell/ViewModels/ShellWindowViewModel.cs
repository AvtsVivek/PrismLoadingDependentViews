using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace SimplePrismShell.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {

        private string _windowTitle = default!;
        public string WindowTitle
        {
            get { return _windowTitle; }
            set { SetProperty(ref _windowTitle, value); }
        }
        public DelegateCommand<string> NavigateCommand { get; set; } = default!;
        private readonly IRegionManager _regionManager;

        public ShellWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            WindowTitle = "Main Shell Window";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        private void Navigate(string navigationPath)
        {
            _regionManager.RequestNavigate("ContentRegion", navigationPath);
        }
    }
}
