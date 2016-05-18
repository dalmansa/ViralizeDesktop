﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViralizeDesktop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VIRALIZEEntities : DbContext
    {
        public VIRALIZEEntities()
            : base("name=VIRALIZEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LOGRO> LOGROes { get; set; }
        public virtual DbSet<LOGRO_LOG> LOGRO_LOG { get; set; }
        public virtual DbSet<NIVEL> NIVELs { get; set; }
        public virtual DbSet<NIVEL_LOG> NIVEL_LOG { get; set; }
        public virtual DbSet<PLATAFORMA> PLATAFORMAs { get; set; }
        public virtual DbSet<PLATAFORMA_LOG> PLATAFORMA_LOG { get; set; }
        public virtual DbSet<PROPUESTA_RETO> PROPUESTA_RETO { get; set; }
        public virtual DbSet<RETO> RETOes { get; set; }
        public virtual DbSet<RETO_LOG> RETO_LOG { get; set; }
        public virtual DbSet<SHARE> SHAREs { get; set; }
        public virtual DbSet<SHARE_BLOQUEADA> SHARE_BLOQUEADA { get; set; }
        public virtual DbSet<SHARE_BLOQUEADA_LOG> SHARE_BLOQUEADA_LOG { get; set; }
        public virtual DbSet<USUARIO_LOG> USUARIO_LOG { get; set; }
        public virtual DbSet<USUARIO_LOGRO> USUARIO_LOGRO { get; set; }
        public virtual DbSet<USUARIO_LOGRO_LOG> USUARIO_LOGRO_LOG { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
    
        public virtual ObjectResult<spLogroLogDel_Result> spLogroLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLogroLogDel_Result>("spLogroLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spLogroLogIns_Result> spLogroLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLogroLogIns_Result>("spLogroLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spLogroLogUpd_Result> spLogroLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLogroLogUpd_Result>("spLogroLogUpd", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spNivelLogDel_Result> spNivelLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spNivelLogDel_Result>("spNivelLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spNivelLogIns_Result> spNivelLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spNivelLogIns_Result>("spNivelLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spNivelLogUpd_Result> spNivelLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spNivelLogUpd_Result>("spNivelLogUpd", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spPlataformaLogDel_Result> spPlataformaLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPlataformaLogDel_Result>("spPlataformaLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spPlataformaLogIns_Result> spPlataformaLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPlataformaLogIns_Result>("spPlataformaLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spPlataformaLogUpd_Result> spPlataformaLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPlataformaLogUpd_Result>("spPlataformaLogUpd", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spRetoLogDel_Result> spRetoLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRetoLogDel_Result>("spRetoLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spRetoLogIns_Result> spRetoLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRetoLogIns_Result>("spRetoLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spRetoLogUpd_Result> spRetoLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRetoLogUpd_Result>("spRetoLogUpd", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spShareBloqueadaLogDel_Result> spShareBloqueadaLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spShareBloqueadaLogDel_Result>("spShareBloqueadaLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spShareBloqueadaLogIns_Result> spShareBloqueadaLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spShareBloqueadaLogIns_Result>("spShareBloqueadaLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spShareBloqueadaLogUpd_Result> spShareBloqueadaLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spShareBloqueadaLogUpd_Result>("spShareBloqueadaLogUpd", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spUsuarioLogDel_Result> spUsuarioLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuarioLogDel_Result>("spUsuarioLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spUsuarioLogIns_Result> spUsuarioLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuarioLogIns_Result>("spUsuarioLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spUsuarioLogroLogDel_Result> spUsuarioLogroLogDel(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuarioLogroLogDel_Result>("spUsuarioLogroLogDel", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spUsuarioLogroLogIns_Result> spUsuarioLogroLogIns(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuarioLogroLogIns_Result>("spUsuarioLogroLogIns", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spUsuarioLogroLogUpd_Result> spUsuarioLogroLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuarioLogroLogUpd_Result>("spUsuarioLogroLogUpd", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spUsuarioLogUpd_Result> spUsuarioLogUpd(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUsuarioLogUpd_Result>("spUsuarioLogUpd", firstParameter, lastParameter);
        }
    }
}
