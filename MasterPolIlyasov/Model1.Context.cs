﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPolIlyasov
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IlyasovmasterpolEntities : DbContext
    {
        public IlyasovmasterpolEntities()
            : base("name=IlyasovmasterpolEntities")
        {
        }
        private static IlyasovmasterpolEntities _context;
        public static IlyasovmasterpolEntities GetContext()
        {
            if (_context == null)
                _context = new IlyasovmasterpolEntities();
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Material_Type> Material_Type { get; set; }
        public virtual DbSet<MaterialCountHistory> MaterialCountHistory { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Partner_Product> Partner_Product { get; set; }
        public virtual DbSet<Partner_type> Partner_type { get; set; }
        public virtual DbSet<PartnerSaleHistory> PartnerSaleHistory { get; set; }
        public virtual DbSet<PointSale> PointSale { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCountHistory> ProductCountHistory { get; set; }
        public virtual DbSet<ProductMinCostHistory> ProductMinCostHistory { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Supllier> Supllier { get; set; }
        public virtual DbSet<Suplly> Suplly { get; set; }
    }
}
