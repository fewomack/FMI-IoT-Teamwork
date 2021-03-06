﻿using Ninject.Modules;
using SmartHive.Services;
using SmartHive.Services.Contracts;

namespace SmartHive.Web.App_Start.NinjectModules
{
    public class ServicesNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserService>().To<UserService>();
            this.Bind<IHiveService>().To<HiveService>();
            this.Bind<IEmailService>().To<EmailService>();
            this.Bind<ISMSSenderService>().To<SMSSenderService>();
        }
    }
}