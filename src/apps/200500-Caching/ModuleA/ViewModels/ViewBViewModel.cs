using Prism.Commands;
using Prism.Mvvm;
using System;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _title = "View B";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand UpdateCommand { get; set; }

        public ViewBViewModel()
        {
            UpdateCommand = new DelegateCommand(UpdateTitle);
        }

        private void UpdateTitle()
        {
            Title = String.Format("View B Updated {0}", DateTime.Now);
        }
    }
}
