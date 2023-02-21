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

        public ObservableCollection<TargetFile> TargetFiles { get; set; } = new ObservableCollection<TargetFile>();

        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand RemoveCommand { get; private set; }

        public DelegateCommand<object[]> SelectedCommand { get; private set; }

        public FileListViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage();
            TargetFiles.Add(new TargetFile { Name = "1" });
            TargetFiles.Add(new TargetFile { Name = "2" });
            TargetFiles.Add(new TargetFile { Name = "3" });
            TargetFiles.Add(new TargetFile { Name = "4" });

            AddCommand = new DelegateCommand(AddFileOrDirectory);

            RemoveCommand = new DelegateCommand(RemoveFileOrDirectory)

            SelectedCommand = new DelegateCommand<object[]>(OnItemSelected);
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }

        private void OnItemSelected(object[] selectedItems)
        {
            if (selectedItems != null && selectedItems.Count() > 0)
            {
                string SelectedItemText = selectedItems.FirstOrDefault().ToString();
            }
        }

        private void AddFileOrDirectory()
        {

        }

        private void RemoveFileOrDirectory()
        {

        }
    }
}
