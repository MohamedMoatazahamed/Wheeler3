//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moves
{
    using System;
    using System.Collections.Generic;
    
    public partial class Move1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Category { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual User1 User1 { get; set; }
    }
}
