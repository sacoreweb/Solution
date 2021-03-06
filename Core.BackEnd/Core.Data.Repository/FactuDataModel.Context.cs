﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Data.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Entity;

    public partial class FactuContext : DbContext
    {
        public FactuContext()
            : base("name=FactuContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ASPNetModulos> ASPNetModulos { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<ASPNetRolesPermisos> ASPNetRolesPermisos { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<tbl_CatalogoProductos> tbl_CatalogoProductos { get; set; }
        public virtual DbSet<tbl_CCostosCompradores> tbl_CCostosCompradores { get; set; }
        public virtual DbSet<tbl_Transportadoras> tbl_Transportadoras { get; set; }
        public virtual DbSet<tbl_TrazabilidadPedidos> tbl_TrazabilidadPedidos { get; set; }
        public virtual DbSet<bodegas> bodegas { get; set; }
        public virtual DbSet<vendedor> vendedor { get; set; }
        public virtual DbSet<pedidosc1W_2000> pedidosc1W_2000 { get; set; }
        public virtual DbSet<pedidosc2W_2000> pedidosc2W_2000 { get; set; }
    
        public virtual ObjectResult<GetVendedores_Result> GetVendedores(string nit, string idBodega)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("Nit", nit) :
                new ObjectParameter("Nit", typeof(string));
    
            var idBodegaParameter = idBodega != null ?
                new ObjectParameter("idBodega", idBodega) :
                new ObjectParameter("idBodega", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVendedores_Result>("GetVendedores", nitParameter, idBodegaParameter);
        }
    
        public virtual ObjectResult<Get_ProductosByReferencia_Result> Get_ProductosByReferencia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_ProductosByReferencia_Result>("Get_ProductosByReferencia");
        }
    }
}
