//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace REST.ModelORM.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int id { get; set; }
        public int DoctorId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
