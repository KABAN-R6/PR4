//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hotell
    {
        
        public Hotell()
        {
            this.Permit = new HashSet<Permit>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string service { get; set; }
        public string Prise { get; set; }
    
       
        public virtual ICollection<Permit> Permit { get; set; }
        public virtual Servicce Servicce { get; set; }
    }
}