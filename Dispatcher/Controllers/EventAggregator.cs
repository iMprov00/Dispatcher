using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatcher.Controllers
{
    public class EventAggregator
    {
        public static event Action RequestDataChanged;
        public static void NotifyDataChanged() => RequestDataChanged?.Invoke();
    }
}
