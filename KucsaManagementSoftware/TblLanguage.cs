//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KucsaManagementSoftware
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblLanguage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblLanguage()
        {
            this.TblProjects = new HashSet<TblProject>();
        }
    
        public int LanguageId { get; set; }
        public string Language { get; set; }
        public string LanguageAuthor { get; set; }
        public string LanguageWebsite { get; set; }
        public string LanguageTuitorial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblProject> TblProjects { get; set; }
    }
}