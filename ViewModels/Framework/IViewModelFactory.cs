using YTExplorer.ViewModels.Components;
using YTExplorer.ViewModels.Dialogs;

namespace YTExplorer.ViewModels.Framework
{
    // Used to instantiate new view models while making use of dependency injection
    public interface IViewModelFactory
    {
        DownloadViewModel CreateDownloadViewModel();

        DownloadMultipleSetupViewModel CreateDownloadMultipleSetupViewModel();

        DownloadSingleSetupViewModel CreateDownloadSingleSetupViewModel();

        MessageBoxViewModel CreateMessageBoxViewModel();

        SettingsViewModel CreateSettingsViewModel();
    }
}