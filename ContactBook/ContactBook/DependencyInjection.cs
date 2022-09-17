using ContactBook.Configuration;
using ContactBook.Repositories;
using ContactBook.Repositories.Interfaces;
using ContactBook.Repositories.Repositories;
using ContactBook.Services.Interfaces;
using ContactBook.Services.Services;

namespace ContactBook
{
    public class DependencyInjection
    {
        private readonly ApplicationSettings _applicationSettings;
        private readonly IServiceCollection _container;
        public DependencyInjection(ApplicationSettings applicationSetting, IServiceCollection container)
        {
            _applicationSettings = applicationSetting;
            _container = container;
        }

        internal void Init()
        {
            _container.AddSingleton(typeof(IRepositoryContext), new RepositoryContext(_applicationSettings.ConnectionString));
            _container.AddSingleton(typeof(IContactsRepository), typeof(ContactsRepository));
            _container.AddSingleton(typeof(IContactsService), typeof(ContactsService));
        }
    }
}
