using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SymbolicLinkerApp.Core;
using SymbolicLinkerApp.Modules.FileList.Views;

namespace SymbolicLinkerApp.Modules.FileList
{
    public class FileListModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public FileListModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.FileListRegion, "FileListView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<FileListView>();
        }
    }
}