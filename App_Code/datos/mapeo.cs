using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class mapeo : DbContext
{
    static mapeo()
    {
        Database.SetInitializer<mapeo>(null);
    }
    private readonly string schema;

    public mapeo()
        : base("name=postgres")
    {

    }
    protected override void OnModelCreating(DbModelBuilder builder)
    {
        builder.HasDefaultSchema(this.schema);

        base.OnModelCreating(builder);
    }
    public virtual DbSet<Edatos> Db_datos { get; set; }


}