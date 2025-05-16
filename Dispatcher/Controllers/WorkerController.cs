using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatcher.Controllers
{
    public static class WorkerController
    {
        public static DispatcherEntities entities = new DispatcherEntities();
        public static Workers currentWorker = new Workers();

        public static Workers GetWorker(int id)
        {
            return entities.Workers.Find(id);
        }
        public static Workers GetWorkerInfo()
        {
            return currentWorker;
        }
        public static List<Workers> GetAllWorkersInfo()
        {
            return entities.Workers.ToList();
        }
        public static List<Posts> GetAllPosts()
        {
            return entities.Posts.ToList();
        }
        public static void AddPost(Posts post)
        {
            entities.Posts.Add(post);  
            entities.SaveChanges();
        }
        public static object GetAllWorkersInfoForCombo()
        {
            return entities.Workers.Select(x => new
            {
                x.ID,
                Имя = x.Surname + " " + x.Name + " " + x.Patronymic
            }).ToList();
        }
        public static object GetAllWorkersInfoForDataGrid()
        {
            return entities.Workers.Select(x => new
            {
                x.ID,
                Имя = x.Name,
                Фамилия = x.Surname,
                Отчество = x.Patronymic,
                Должность = entities.Posts.Where(n=>x.Post_ID == n.ID).Select(n=>n.Name).FirstOrDefault()
            }).ToList();
        }

        public static void InsertWorkerInfo(Workers worker)
        {
            entities.Workers.Add(worker);
            entities.SaveChanges();
        }
        public static void DeleteWorkerInfo(int workerId) 
        {
            entities.Workers.Remove(entities.Workers.Find(workerId));
            entities.SaveChanges();
        } 
    }
}
