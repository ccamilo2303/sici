//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SICI.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_InformacionBasicaUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_InformacionBasicaUsuario()
        {
            this.Tbl_AsistenciaTransferencias = new HashSet<Tbl_AsistenciaTransferencias>();
            this.Tbl_Calificaciones = new HashSet<Tbl_Calificaciones>();
            this.Tbl_EspecializacionesUsuario = new HashSet<Tbl_EspecializacionesUsuario>();
            this.Tbl_Inscripciones = new HashSet<Tbl_Inscripciones>();
            this.Tbl_ArchivosUsuario = new HashSet<Tbl_ArchivosUsuario>();
        }
    
        public string Id { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> Discapacidad { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> IdPerfil { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_AsistenciaTransferencias> Tbl_AsistenciaTransferencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Calificaciones> Tbl_Calificaciones { get; set; }
        public virtual Tbl_Discapacidades Tbl_Discapacidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_EspecializacionesUsuario> Tbl_EspecializacionesUsuario { get; set; }
        public virtual Tbl_Estados Tbl_Estados { get; set; }
        public virtual Tbl_Perfiles Tbl_Perfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Inscripciones> Tbl_Inscripciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ArchivosUsuario> Tbl_ArchivosUsuario { get; set; }
    }
}
