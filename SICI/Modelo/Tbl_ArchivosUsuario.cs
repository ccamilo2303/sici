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
    
    public partial class Tbl_ArchivosUsuario
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public int idRegistro { get; set; }
    
        public virtual Tbl_InformacionBasicaUsuario Tbl_InformacionBasicaUsuario { get; set; }
    }
}
