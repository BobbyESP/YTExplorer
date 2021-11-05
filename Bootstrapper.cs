using Stylet;
using StyletIoC;
using System.Net;
using YTExplorer.Services;
using YTExplorer.ViewModels;
using YTExplorer.ViewModels.Framework;

#if !DEBUG
using System.Windows;
using System.Windows.Threading;
#endif

namespace YTExplorer
{
    public class Bootstrapper : Bootstrapper<RootViewModel>
    {
        protected override void OnStart()
        {
            base.OnStart();

            App.SetLightTheme();

            ServicePointManager.DefaultConnectionLimit = 20;
        }

        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            base.ConfigureIoC(builder);

            builder.Bind<DownloadService>().ToSelf().InSingletonScope();
            builder.Bind<SettingsService>().ToSelf().InSingletonScope();
            builder.Bind<TaggingService>().ToSelf().InSingletonScope();

            builder.Bind<IViewModelFactory>().ToAbstractFactory();
        }

#if !DEBUG
        protected override void OnUnhandledException(DispatcherUnhandledExceptionEventArgs e)
        {
                base.OnUnhandledException(e);

                MessageBox.Show(e.Exception.ToString(), "Ha ocurrido un error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

#endif
    }
}
