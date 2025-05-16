using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher.Controllers
{
    public static class AuthorizationController
    {
        public static DispatcherEntities entities = new DispatcherEntities();
        public static int workerId = -1;
        public static bool admin = false;
        public static Workers worker = new Workers();

        public static void DeleteUserInfo()
        {
            workerId = -1;
            admin = false;
            worker = new Workers();
            WorkerController.currentWorker = new Workers();
        }

        public static bool Auth(string user, string password)
        {
            var usrPos = entities.Users.Where(x => x.Login == user && x.Password == password).Select(x => x.Worker_ID).ToList();
            if (usrPos.Count > 0)
            {
                workerId = (int)usrPos[0];
                admin = AuthAdmin(user, password);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AuthAdmin(string user, string password)
        {
            if(workerId != -1)
            { 
                var curWorker = entities.Workers.Find(workerId);
                worker = curWorker;
                WorkerController.currentWorker = worker;
                if (worker.Post_ID == 2) return true;
                admin = true;
            }
            else
            {
                var usrPos = entities.Users.Where(x => x.Login == user && x.Password == password).Select(x => x.Worker_ID).ToList();
                if (usrPos.Count > 0)
                {
                    var worker = entities.Workers.Find((int)usrPos[0].Value);
                    if (worker.Post_ID == 2)
                    {
                        admin = true;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static bool UserAdd(Users user)
        {
             entities.Users.Add(user);
             entities.SaveChanges();
             return true;
            
        }

        public static List<Users> GetAllUsers()
        {
            return entities.Users.ToList();
        }

    }
}
