//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dispatcher
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requests
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateExecution { get; set; }
        public Nullable<int> Status_ID { get; set; }
        public Nullable<int> Responsible_ID { get; set; }
        public Nullable<int> Dispatcher_ID { get; set; }
    
        public virtual Workers Workers { get; set; }
        public virtual Workers Workers1 { get; set; }
        public virtual StatusRequests StatusRequests { get; set; }
    }
}
