//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenLight
{
    using System;
    using System.Collections.Generic;
    
    public partial class OptionType
    {
        public OptionType()
        {
            this.Options = new HashSet<Option>();
        }
    
        public int OptionTypeID { get; set; }
        public string OptionTypeName { get; set; }
    
        public virtual ICollection<Option> Options { get; set; }
    }
}