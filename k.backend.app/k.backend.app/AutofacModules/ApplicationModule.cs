using Autofac;
using k.backend.app.service.Application.Queries;
using k.backend.core.Auth.Jwt.Abstact;
using k.backend.core.Auth.Jwt.Concrete;
using MediatR;

namespace k.backend.app.service.AutofacModules
{
    public class ApplicationModule : Module
    {
        public ApplicationModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
            builder.RegisterType<CampaignCodeQuery>().As<ICampaignCodeQuery>().InstancePerLifetimeScope();
            builder.RegisterType<TokenService>().As<ITokenService>().InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
        }
    }
}