//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL55
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doenca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doenca()
        {
            this.DoencaRemedio = new HashSet<DoencaRemedio>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Causa { get; set; }
        public string Sintoma { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoencaRemedio> DoencaRemedio { get; set; }
    }
}
