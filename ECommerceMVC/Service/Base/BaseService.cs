using Core.CoreEntity;
using Core.CoreService;
using Model.Context;
using Model.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.CoreEnum;

namespace Service.Base
{
    public abstract class BaseService<T> : ICoreService<T> where T : BaseEntity
    {
        AppDbContext db = Singleton.Context;

        public string Add(T model)
        {
            try
            {
                model.ID = Guid.NewGuid();
                db.Set<T>().Add(model);
                db.SaveChanges();
                return $"veri kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Add(List<T> models)
        {



            try
            {
                foreach (T item in models)
                {
                    item.ID = Guid.NewGuid();
                    db.Set<T>().Add(item);
                    db.SaveChanges();
                }
                //db.Set<T>().AddRange(models);
                //db.SaveChanges();
                return "Liste kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T GetById(Guid id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

        public void RemoveForce(T model)
        {
            try
            {
                if (model.ID != null)
                {
                    T deleted = GetById(model.ID);
                    db.Set<T>().Remove(deleted);
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
                
               
            }
            catch (Exception ex)
            {

                return;

            }
        }

        public string Update(T model)
        {
            try
            {
                T entity = GetById(model.ID);
                switch (model.Status)
                {
                    case Core.CoreEnum.Status.None:
                        entity.Status = Core.CoreEnum.Status.None;
                        db.SaveChanges();
                        break;
                    case Core.CoreEnum.Status.Active:
                        entity.Status = Core.CoreEnum.Status.Active;
                        db.SaveChanges();
                        break;
                    case Core.CoreEnum.Status.Deleted:
                        entity.Status = Core.CoreEnum.Status.Deleted;
                        db.SaveChanges();
                        break;
                    case Core.CoreEnum.Status.Updated:
                        entity.Status = Core.CoreEnum.Status.Updated;
                        var entry = db.Entry(entity);
                        entry.CurrentValues.SetValues(model);
                        db.SaveChanges();
                        break;
                }
                return "veri güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
