using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SymbolicLinkerApp.Core.Models;
using SymbolicLinkerApp.Core.Mvvm;
using SymbolicLinkerApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolicLinkerApp.Modules.FileList.ViewModels
{
    public class FileListViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ObservableCollection<TargetFile> targetFiles { get; set; } = new ObservableCollection<TargetFile>();

        public DelegateCommand AddedCommand { get; set; }

        public FileListViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
