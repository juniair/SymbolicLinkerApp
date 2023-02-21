using Prism.Ioc;
using Prism.Modularity;
using SymbolicLinkerApp.Modules.FileList;
using SymbolicLinkerApp.Services;
using SymbolicLinkerApp.Services.Interfaces;
using SymbolicLinkerApp.Views;
using System.Windows;

namespace SymbolicLinkerApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<FileListModule>();
        }
    }
}
