using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatcher.Controllers
{
    public static class RequestsController
    {
        public static DispatcherEntities entities = new DispatcherEntities();

        public static object GetRequests()
        {
            return entities.Requests.Select(x => new 
            { 
                x.ID,
                Дата_создания = x.DateCreated,
                Дата_выполнения = x.DateExecution,
                Наименование = x.Title,
                Описание = x.Description,
                Статус = entities.StatusRequests.Where(n => x.Status_ID == n.ID).FirstOrDefault().Name,
                Диспетчер = entities.Workers.Where(n => x.Dispatcher_ID == n.ID).FirstOrDefault().Name + 
                    entities.Workers.Where(n => x.Dispatcher_ID == n.ID).FirstOrDefault().Surname + 
                    entities.Workers.Where(n => x.Dispatcher_ID == n.ID).FirstOrDefault().Patronymic,
                Ответственный = entities.Workers.Where(n => x.Responsible_ID == n.ID).FirstOrDefault().Name +
                    entities.Workers.Where(n => x.Responsible_ID == n.ID).FirstOrDefault().Surname +
                    entities.Workers.Where(n => x.Responsible_ID == n.ID).FirstOrDefault().Patronymic
            }).ToList();
        }

        public static object GetRequestsForStatus(int idStatus)
        {
            var requests = entities.Requests.Select(x => new
            {
                x.ID,
                Дата_создания = x.DateCreated,
                Дата_выполнения = x.DateExecution,
                Наименование = x.Title,
                Описание = x.Description,
                Статус = entities.StatusRequests.Where(n => x.Status_ID == n.ID).FirstOrDefault().Name,
                Диспетчер = entities.Workers.Where(n => x.Dispatcher_ID == n.ID).FirstOrDefault().Name + " " +
                    entities.Workers.Where(n => x.Dispatcher_ID == n.ID).FirstOrDefault().Surname + " " +
                    entities.Workers.Where(n => x.Dispatcher_ID == n.ID).FirstOrDefault().Patronymic,
                Ответственный = entities.Workers.Where(n => x.Responsible_ID == n.ID).FirstOrDefault().Name + " " +
                    entities.Workers.Where(n => x.Responsible_ID == n.ID).FirstOrDefault().Surname + " " +
                    entities.Workers.Where(n => x.Responsible_ID == n.ID).FirstOrDefault().Patronymic,
                x.Status_ID
            }).ToList();
            var result = requests.Where(x => x.Status_ID == idStatus).ToList();
            return result;
        }

        public static Requests GetRequest(int id)
        {
            return entities.Requests.Find(id);
        }

        public static void InsertRequestInfo(Requests request)
        {
            entities.Requests.Add(request);
            entities.SaveChanges();
        }
        public static void DeleteRequestInfo(Requests request)
        {
            entities.Requests.Remove(request);
            entities.SaveChanges();
        }


        public static object GetAllStatus()
        {
            return entities.StatusRequests.ToList();
        }
        public static void AddStatus(StatusRequests status)
        {
            entities.StatusRequests.Add(status);
            entities.SaveChanges();
        }
    }
}
