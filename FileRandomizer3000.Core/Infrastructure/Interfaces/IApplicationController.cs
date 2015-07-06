﻿using FileRandomizer3000.Core.Presenters;
using FileRandomizer3000.Core.Views;

namespace FileRandomizer3000.Core.Infrastructure.Interfaces
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;
        IApplicationController RegisterSingletonView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;
        IApplicationController RegisterInstance<TInstance>(TInstance instance);
        IApplicationController RegisterSingletonInstance<TInstance>(TInstance instance);
        IApplicationController RegisterService<TService, TInstance>() where TInstance : class, TService;
        IApplicationController RegisterSingletonService<TService, TInstance>() where TInstance : class, TService;
        void Run<TPresenter>() where TPresenter : class, IPresenter;
        void Run<TPresenter, TArgument>(TArgument argument) where TPresenter : class, IPresenter<TArgument>;
        void RunSingleton<TPresenter>() where TPresenter : class, IPresenter;
        void RunSingleton<TPresenter, TArgument>(TArgument argument) where TPresenter : class, IPresenter<TArgument>;
    }
}