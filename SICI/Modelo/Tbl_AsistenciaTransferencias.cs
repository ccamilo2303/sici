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
    
    public partial class Tbl_AsistenciaTransferencias
    {
        public int IdAsistenciaTransferencia { get; set; }
        public int IdTransferencia { get; set; }
        public string Id { get; set; }
        public Nullable<int> IdSede { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual Tbl_Sedes Tbl_Sedes { get; set; }
        public virtual Tbl_Transferencias Tbl_Transferencias { get; set; }
        public virtual Tbl_InformacionBasicaUsuario Tbl_InformacionBasicaUsuario { get; set; }
    }
}