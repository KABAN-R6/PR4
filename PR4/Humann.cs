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
    
    public partial class Humann
    {
        
        public Humann()
        {
            this.Permit = new HashSet<Permit>();
        }
    
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string age { get; set; }
    
        
        public virtual ICollection<Permit> Permit { get; set; }
    }
}
