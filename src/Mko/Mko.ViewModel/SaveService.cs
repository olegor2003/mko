using Mko.Infra;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public class SaveService : ISaveService
    {
        private readonly Func<ISaveView> _viewFactory;
        private readonly MainDbContext _mainDbContext;

        public SaveService(Func<ISaveView> viewFactory, MainDbContext mainDbContext)
        {
            _viewFactory = viewFactory;
            _mainDbContext = mainDbContext;
        }


        public void SaveChanges<T>(T[] values) where T : BaseEntity
        {
            using (var view = _viewFactory())
            {
                if (view.SaveConfirmed)
                {
                    foreach (var m in values)
                    {
                        _mainDbContext.Set<T>().AddOrUpdate(values);
                    }
                    _mainDbContext.SaveChanges();
                }
            }
        }
    }
}