using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAPI.Models
{
    public partial class symportalContext : DbContext
    {
        public symportalContext()
        {
        }

        public symportalContext(DbContextOptions<symportalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<F42005> F42005 { get; set; }
        public virtual DbSet<F42005Detail> F42005Detail { get; set; }
        public virtual DbSet<F4211> F4211 { get; set; }
        public virtual DbSet<F42119> F42119 { get; set; }
        public virtual DbSet<F42119Detail> F42119Detail { get; set; }
        public virtual DbSet<F4211Detail> F4211Detail { get; set; }
        public virtual DbSet<F42160> F42160 { get; set; }
        public virtual DbSet<F42160Detail> F42160Detail { get; set; }
        public virtual DbSet<SymPortalUserData> SymPortalUserData { get; set; }
        public virtual DbSet<SymPortalUserRoles> SymPortalUserRoles { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<F42005>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Scdlij)
                    .HasName("Last Invoice Date Index");

                entity.HasIndex(e => e.Scslsp)
                    .HasName("Sales Rep Index");

                entity.HasIndex(e => new { e.Scdoco, e.Scdcto, e.Sclnid })
                    .HasName("IX_F42005")
                    .IsClustered();

                entity.Property(e => e.Scac01)
                    .HasColumnName("SCAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac02)
                    .HasColumnName("SCAC02")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac03)
                    .HasColumnName("SCAC03")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac04)
                    .HasColumnName("SCAC04")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac05)
                    .HasColumnName("SCAC05")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scafxc)
                    .HasColumnName("SCAFXC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scan8)
                    .HasColumnName("SCAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scapun)
                    .HasColumnName("SCAPUN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scccty)
                    .HasColumnName("SCCCTY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sccloj)
                    .HasColumnName("SCCLOJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sccmdj)
                    .HasColumnName("SCCMDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sccmln)
                    .HasColumnName("SCCMLN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sccoma)
                    .HasColumnName("SCCOMA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sccomr)
                    .HasColumnName("SCCOMR")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sccpcr)
                    .HasColumnName("SCCPCR")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sccpct)
                    .HasColumnName("SCCPCT")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Scctyr)
                    .HasColumnName("SCCTYR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scdcto)
                    .HasColumnName("SCDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scdlij)
                    .HasColumnName("SCDLIJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Scdocm)
                    .HasColumnName("SCDOCM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scdoco)
                    .HasColumnName("SCDOCO")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scelig)
                    .HasColumnName("SCELIG")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scelil)
                    .HasColumnName("SCELIL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scfca)
                    .HasColumnName("SCFCA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scfrth)
                    .HasColumnName("SCFRTH")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scitm)
                    .HasColumnName("SCITM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sckcoo)
                    .HasColumnName("SCKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sclfac)
                    .HasColumnName("SCLFAC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sclnid)
                    .HasColumnName("SCLNID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sclrcs)
                    .HasColumnName("SCLRCS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scmcu)
                    .HasColumnName("SCMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scmgm)
                    .HasColumnName("SCMGM")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scmrgl)
                    .HasColumnName("SCMRGL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scmrgn)
                    .HasColumnName("SCMRGN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scorcs)
                    .HasColumnName("SCORCS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scpdcd)
                    .HasColumnName("SCPDCD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scran8)
                    .HasColumnName("SCRAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Screbl)
                    .HasColumnName("SCREBL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Screbt)
                    .HasColumnName("SCREBT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scrpmb)
                    .HasColumnName("SCRPMB")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsfxo)
                    .HasColumnName("SCSFXO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scslsp)
                    .HasColumnName("SCSLSP")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scsplt)
                    .HasColumnName("SCSPLT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp1)
                    .HasColumnName("SCSRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp2)
                    .HasColumnName("SCSRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp3)
                    .HasColumnName("SCSRP3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp4)
                    .HasColumnName("SCSRP4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp5)
                    .HasColumnName("SCSRP5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sctday)
                    .HasColumnName("SCTDAY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sctotl)
                    .HasColumnName("SCTOTL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sctoto)
                    .HasColumnName("SCTOTO")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scupmj)
                    .HasColumnName("SCUPMJ")
                    .HasColumnType("decimal(6, 0)");
            });

            modelBuilder.Entity<F42005Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F42005__Detail");

                entity.HasIndex(e => e.Scdlij)
                    .HasName("Last Invoice Date Index");

                entity.HasIndex(e => e.Scslsp)
                    .HasName("Sales Rep Index");

                entity.HasIndex(e => new { e.Scdoco, e.Scdcto, e.Sclnid })
                    .HasName("Order Number, Type, Line Index")
                    .IsClustered();

                entity.Property(e => e.Salesman)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanAbac01)
                    .HasColumnName("Salesman_ABAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesmanAbac02)
                    .HasColumnName("Salesman_ABAC02")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac01)
                    .HasColumnName("SCAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac02)
                    .HasColumnName("SCAC02")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac03)
                    .HasColumnName("SCAC03")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac04)
                    .HasColumnName("SCAC04")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scac05)
                    .HasColumnName("SCAC05")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scafxc)
                    .HasColumnName("SCAFXC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scan8)
                    .HasColumnName("SCAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scapun)
                    .HasColumnName("SCAPUN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scccty)
                    .HasColumnName("SCCCTY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sccloj)
                    .HasColumnName("SCCLOJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sccmdj)
                    .HasColumnName("SCCMDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sccmln)
                    .HasColumnName("SCCMLN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sccoma)
                    .HasColumnName("SCCOMA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sccomr)
                    .HasColumnName("SCCOMR")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sccpcr)
                    .HasColumnName("SCCPCR")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sccpct)
                    .HasColumnName("SCCPCT")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Scctyr)
                    .HasColumnName("SCCTYR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scdcto)
                    .HasColumnName("SCDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scdlij)
                    .HasColumnName("SCDLIJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Scdocm)
                    .HasColumnName("SCDOCM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scdoco)
                    .HasColumnName("SCDOCO")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scelig)
                    .HasColumnName("SCELIG")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scelil)
                    .HasColumnName("SCELIL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scfca)
                    .HasColumnName("SCFCA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scfrth)
                    .HasColumnName("SCFRTH")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scitm)
                    .HasColumnName("SCITM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sckcoo)
                    .HasColumnName("SCKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sclfac)
                    .HasColumnName("SCLFAC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sclnid)
                    .HasColumnName("SCLNID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sclrcs)
                    .HasColumnName("SCLRCS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scmcu)
                    .HasColumnName("SCMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scmgm)
                    .HasColumnName("SCMGM")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scmrgl)
                    .HasColumnName("SCMRGL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scmrgn)
                    .HasColumnName("SCMRGN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scorcs)
                    .HasColumnName("SCORCS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scpdcd)
                    .HasColumnName("SCPDCD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scran8)
                    .HasColumnName("SCRAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Screbl)
                    .HasColumnName("SCREBL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Screbt)
                    .HasColumnName("SCREBT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scrpmb)
                    .HasColumnName("SCRPMB")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsfxo)
                    .HasColumnName("SCSFXO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scslsp)
                    .HasColumnName("SCSLSP")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Scsplt)
                    .HasColumnName("SCSPLT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp1)
                    .HasColumnName("SCSRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp2)
                    .HasColumnName("SCSRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp3)
                    .HasColumnName("SCSRP3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp4)
                    .HasColumnName("SCSRP4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scsrp5)
                    .HasColumnName("SCSRP5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sctday)
                    .HasColumnName("SCTDAY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sctotl)
                    .HasColumnName("SCTOTL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sctoto)
                    .HasColumnName("SCTOTO")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Scupmj)
                    .HasColumnName("SCUPMJ")
                    .HasColumnType("decimal(6, 0)");
            });

            modelBuilder.Entity<F4211>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Sdan8);

                entity.HasIndex(e => e.Sdlitm);

                entity.HasIndex(e => e.Sdshan);

                entity.HasIndex(e => e.SdtrdjGr);

                entity.HasIndex(e => e.Sdvr01);

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid })
                    .IsClustered();

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid, e.Sdvr01 })
                    .HasName("IDX_Open_Orders_PO");

                entity.HasIndex(e => new { e.Sddoco, e.SdrsdjGr, e.Sdlitm, e.Sdnxtr, e.Sddcto, e.Sdlnty })
                    .HasName("IX_SDDCTO_SDLNTY");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdaaid)
                    .HasColumnName("SDAAID")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdacom)
                    .HasColumnName("SDACOM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdaddj)
                    .HasColumnName("SDADDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdaddjGr)
                    .HasColumnName("SDADDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdadtm)
                    .HasColumnName("SDADTM")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdaexp)
                    .HasColumnName("SDAEXP")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdaitm)
                    .HasColumnName("SDAITM")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdan8)
                    .HasColumnName("SDAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdanby)
                    .HasColumnName("SDANBY")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdaopn)
                    .HasColumnName("SDAOPN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdapts)
                    .HasColumnName("SDAPTS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdapum)
                    .HasColumnName("SDAPUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdasn)
                    .HasColumnName("SDASN")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdatxt)
                    .HasColumnName("SDATXT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdback)
                    .HasColumnName("SDBACK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdbcrc)
                    .HasColumnName("SDBCRC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdbsc)
                    .HasColumnName("SDBSC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcadc)
                    .HasColumnName("SDCADC")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdcars)
                    .HasColumnName("SDCARS")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdcatnm)
                    .HasColumnName("SDCATNM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcbsc)
                    .HasColumnName("SDCBSC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdccidln)
                    .HasColumnName("SDCCIDLN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdclvl)
                    .HasColumnName("SDCLVL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcmcg)
                    .HasColumnName("SDCMCG")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcmgp)
                    .HasColumnName("SDCMGP")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcndj)
                    .HasColumnName("SDCNDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdcndjGr)
                    .HasColumnName("SDCNDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdcnid)
                    .HasColumnName("SDCNID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdco)
                    .HasColumnName("SDCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcomm)
                    .HasColumnName("SDCOMM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcord)
                    .HasColumnName("SDCORD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Sdcpnt)
                    .HasColumnName("SDCPNT")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Sdcrcd)
                    .HasColumnName("SDCRCD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcrmd)
                    .HasColumnName("SDCRMD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcrr)
                    .HasColumnName("SDCRR")
                    .HasColumnType("decimal(15, 7)");

                entity.Property(e => e.Sdcsto)
                    .HasColumnName("SDCSTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdctry)
                    .HasColumnName("SDCTRY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sddct)
                    .HasColumnName("SDDCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddeid)
                    .HasColumnName("SDDEID")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sddeln)
                    .HasColumnName("SDDELN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddgl)
                    .HasColumnName("SDDGL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sddmbu)
                    .HasColumnName("SDDMBU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddmcs)
                    .HasColumnName("SDDMCS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Sddmct)
                    .HasColumnName("SDDMCT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddoc)
                    .HasColumnName("SDDOC")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddrqj)
                    .HasColumnName("SDDRQJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SddrqjGr)
                    .HasColumnName("SDDRQJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sddrqt)
                    .HasColumnName("SDDRQT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sddsc1)
                    .HasColumnName("SDDSC1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddsc2)
                    .HasColumnName("SDDSC2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddtbs)
                    .HasColumnName("SDDTBS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddtys)
                    .HasColumnName("SDDTYS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddual)
                    .HasColumnName("SDDUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddvan)
                    .HasColumnName("SDDVAN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdecst)
                    .HasColumnName("SDECST")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdemcu)
                    .HasColumnName("SDEMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdeuse)
                    .HasColumnName("SDEUSE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdexdp)
                    .HasColumnName("SDEXDP")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdexr1)
                    .HasColumnName("SDEXR1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdfea)
                    .HasColumnName("SDFEA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfec)
                    .HasColumnName("SDFEC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfprc)
                    .HasColumnName("SDFPRC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfrgd)
                    .HasColumnName("SDFRGD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdfrmp)
                    .HasColumnName("SDFRMP")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdfrth)
                    .HasColumnName("SDFRTH")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdfuc)
                    .HasColumnName("SDFUC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfun2)
                    .HasColumnName("SDFUN2")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfup)
                    .HasColumnName("SDFUP")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfy)
                    .HasColumnName("SDFY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sdglc)
                    .HasColumnName("SDGLC")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdgrwt)
                    .HasColumnName("SDGRWT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdgwum)
                    .HasColumnName("SDGWUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdhdbu)
                    .HasColumnName("SDHDBU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdhold)
                    .HasColumnName("SDHOLD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdinmg)
                    .HasColumnName("SDINMG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir01)
                    .HasColumnName("SDIR01")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir02)
                    .HasColumnName("SDIR02")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir03)
                    .HasColumnName("SDIR03")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir04)
                    .HasColumnName("SDIR04")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir05)
                    .HasColumnName("SDIR05")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sditm)
                    .HasColumnName("SDITM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sditvl)
                    .HasColumnName("SDITVL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sditwt)
                    .HasColumnName("SDITWT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdivd)
                    .HasColumnName("SDIVD")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdivdGr)
                    .HasColumnName("SDIVD_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdjobn)
                    .HasColumnName("SDJOBN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdkco)
                    .HasColumnName("SDKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdkcoo)
                    .HasColumnName("SDKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdktln)
                    .HasColumnName("SDKTLN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdktp)
                    .HasColumnName("SDKTP")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdlcod)
                    .HasColumnName("SDLCOD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlitm)
                    .HasColumnName("SDLITM")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdlnty)
                    .HasColumnName("SDLNTY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlob)
                    .HasColumnName("SDLOB")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlocn)
                    .HasColumnName("SDLOCN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlotn)
                    .HasColumnName("SDLOTN")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlprc)
                    .HasColumnName("SDLPRC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdlttr)
                    .HasColumnName("SDLTTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdlttrTxt)
                    .HasColumnName("SDLTTR_TXT")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdmcln)
                    .HasColumnName("SDMCLN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdmcu)
                    .HasColumnName("SDMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdmerl)
                    .HasColumnName("SDMERL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdmot)
                    .HasColumnName("SDMOT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdntr)
                    .HasColumnName("SDNTR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdnumb)
                    .HasColumnName("SDNUMB")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdnxtr)
                    .HasColumnName("SDNXTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdnxtrTxt)
                    .HasColumnName("SDNXTR_TXT")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdocto)
                    .HasColumnName("SDOCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdodct)
                    .HasColumnName("SDODCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdodln)
                    .HasColumnName("SDODLN")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdodoc)
                    .HasColumnName("SDODOC")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdogno)
                    .HasColumnName("SDOGNO")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdokc)
                    .HasColumnName("SDOKC")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdokco)
                    .HasColumnName("SDOKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdoorn)
                    .HasColumnName("SDOORN")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdopdj)
                    .HasColumnName("SDOPDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdopdjGr)
                    .HasColumnName("SDOPDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdoppid)
                    .HasColumnName("SDOPPID")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdoptt)
                    .HasColumnName("SDOPTT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdorp)
                    .HasColumnName("SDORP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdorpr)
                    .HasColumnName("SDORPR")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdoseq)
                    .HasColumnName("SDOSEQ")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Sdostp)
                    .HasColumnName("SDOSTP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdotqy)
                    .HasColumnName("SDOTQY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpa8)
                    .HasColumnName("SDPA8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdpddj)
                    .HasColumnName("SDPDDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdpddjGr)
                    .HasColumnName("SDPDDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdpdtt)
                    .HasColumnName("SDPDTT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdpefj)
                    .HasColumnName("SDPEFJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdpefjGr)
                    .HasColumnName("SDPEFJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdpend)
                    .HasColumnName("SDPEND")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpid)
                    .HasColumnName("SDPID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpmdt)
                    .HasColumnName("SDPMDT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdpmtn)
                    .HasColumnName("SDPMTN")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpmto)
                    .HasColumnName("SDPMTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpoe)
                    .HasColumnName("SDPOE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdppdj)
                    .HasColumnName("SDPPDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdppdjGr)
                    .HasColumnName("SDPPDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdpqor)
                    .HasColumnName("SDPQOR")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdpran8)
                    .HasColumnName("SDPRAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdprcidln)
                    .HasColumnName("SDPRCIDLN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdprgr)
                    .HasColumnName("SDPRGR")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprio)
                    .HasColumnName("SDPRIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprjm)
                    .HasColumnName("SDPRJM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdprov)
                    .HasColumnName("SDPROV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp1)
                    .HasColumnName("SDPRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp2)
                    .HasColumnName("SDPRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp3)
                    .HasColumnName("SDPRP3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp4)
                    .HasColumnName("SDPRP4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp5)
                    .HasColumnName("SDPRP5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpsig)
                    .HasColumnName("SDPSIG")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpsn)
                    .HasColumnName("SDPSN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdpstm)
                    .HasColumnName("SDPSTM")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdptc)
                    .HasColumnName("SDPTC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdqrlv)
                    .HasColumnName("SDQRLV")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdqtyt)
                    .HasColumnName("SDQTYT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdrcd)
                    .HasColumnName("SDRCD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrcto)
                    .HasColumnName("SDRCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdresl)
                    .HasColumnName("SDRESL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrfrv)
                    .HasColumnName("SDRFRV")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrkco)
                    .HasColumnName("SDRKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrkit)
                    .HasColumnName("SDRKIT")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdrldj)
                    .HasColumnName("SDRLDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdrlit)
                    .HasColumnName("SDRLIT")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrlln)
                    .HasColumnName("SDRLLN")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdrlnu)
                    .HasColumnName("SDRLNU")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrltm)
                    .HasColumnName("SDRLTM")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdrorn)
                    .HasColumnName("SDRORN")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrout)
                    .HasColumnName("SDROUT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrprc)
                    .HasColumnName("SDRPRC")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrsdj)
                    .HasColumnName("SDRSDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdrsdjGr)
                    .HasColumnName("SDRSDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdrsdt)
                    .HasColumnName("SDRSDT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdryin)
                    .HasColumnName("SDRYIN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsbal)
                    .HasColumnName("SDSBAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsbl)
                    .HasColumnName("SDSBL")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsblt)
                    .HasColumnName("SDSBLT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsern)
                    .HasColumnName("SDSERN")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsfxo)
                    .HasColumnName("SDSFXO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshan)
                    .HasColumnName("SDSHAN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdshccidln)
                    .HasColumnName("SDSHCCIDLN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdshcm)
                    .HasColumnName("SDSHCM")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshcn)
                    .HasColumnName("SDSHCN")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshpn)
                    .HasColumnName("SDSHPN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdso01)
                    .HasColumnName("SDSO01")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso02)
                    .HasColumnName("SDSO02")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso03)
                    .HasColumnName("SDSO03")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso04)
                    .HasColumnName("SDSO04")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso05)
                    .HasColumnName("SDSO05")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso06)
                    .HasColumnName("SDSO06")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso07)
                    .HasColumnName("SDSO07")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso08)
                    .HasColumnName("SDSO08")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso09)
                    .HasColumnName("SDSO09")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso10)
                    .HasColumnName("SDSO10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso11)
                    .HasColumnName("SDSO11")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso12)
                    .HasColumnName("SDSO12")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso13)
                    .HasColumnName("SDSO13")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso14)
                    .HasColumnName("SDSO14")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso15)
                    .HasColumnName("SDSO15")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso16)
                    .HasColumnName("SDSO16")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso17)
                    .HasColumnName("SDSO17")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso18)
                    .HasColumnName("SDSO18")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso19)
                    .HasColumnName("SDSO19")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso20)
                    .HasColumnName("SDSO20")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsobk)
                    .HasColumnName("SDSOBK")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsocn)
                    .HasColumnName("SDSOCN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsone)
                    .HasColumnName("SDSONE")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsoor)
                    .HasColumnName("SDSOOR")
                    .HasColumnType("decimal(31, 0)");

                entity.Property(e => e.Sdsoqs)
                    .HasColumnName("SDSOQS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdspattn)
                    .HasColumnName("SDSPATTN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsqor)
                    .HasColumnName("SDSQOR")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsrp1)
                    .HasColumnName("SDSRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp2)
                    .HasColumnName("SDSRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp3)
                    .HasColumnName("SDSRP3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp4)
                    .HasColumnName("SDSRP4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp5)
                    .HasColumnName("SDSRP5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdstop)
                    .HasColumnName("SDSTOP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdswms)
                    .HasColumnName("SDSWMS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtax1)
                    .HasColumnName("SDTAX1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtcst)
                    .HasColumnName("SDTCST")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdtday)
                    .HasColumnName("SDTDAY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdthgd)
                    .HasColumnName("SDTHGD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdthrp)
                    .HasColumnName("SDTHRP")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdtorg)
                    .HasColumnName("SDTORG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtpc)
                    .HasColumnName("SDTPC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtrdc)
                    .HasColumnName("SDTRDC")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdtrdj)
                    .HasColumnName("SDTRDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdtrdjGr)
                    .HasColumnName("SDTRDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdtxa1)
                    .HasColumnName("SDTXA1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdukid)
                    .HasColumnName("SDUKID")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sduncd)
                    .HasColumnName("SDUNCD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduncs)
                    .HasColumnName("SDUNCS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sduom)
                    .HasColumnName("SDUOM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduom1)
                    .HasColumnName("SDUOM1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduom2)
                    .HasColumnName("SDUOM2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduom4)
                    .HasColumnName("SDUOM4")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduopn)
                    .HasColumnName("SDUOPN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sduorg)
                    .HasColumnName("SDUORG")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdupc1)
                    .HasColumnName("SDUPC1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdupc2)
                    .HasColumnName("SDUPC2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdupc3)
                    .HasColumnName("SDUPC3")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdupmj)
                    .HasColumnName("SDUPMJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdupmjGr)
                    .HasColumnName("SDUPMJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sduprc)
                    .HasColumnName("SDUPRC")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdurab)
                    .HasColumnName("SDURAB")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdurat)
                    .HasColumnName("SDURAT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdurcd)
                    .HasColumnName("SDURCD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdurdt)
                    .HasColumnName("SDURDT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdurdtGr)
                    .HasColumnName("SDURDT_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdurrf)
                    .HasColumnName("SDURRF")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduser)
                    .HasColumnName("SDUSER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdvend)
                    .HasColumnName("SDVEND")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdvlum)
                    .HasColumnName("SDVLUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdvr01)
                    .HasColumnName("SDVR01")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sdvr02)
                    .HasColumnName("SDVR02")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdvr03)
                    .HasColumnName("SDVR03")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdwtum)
                    .HasColumnName("SDWTUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxcto)
                    .HasColumnName("SDXCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxdck)
                    .HasColumnName("SDXDCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxkco)
                    .HasColumnName("SDXKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxlln)
                    .HasColumnName("SDXLLN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdxorn)
                    .HasColumnName("SDXORN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdxpty)
                    .HasColumnName("SDXPTY")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdxsfx)
                    .HasColumnName("SDXSFX")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdzon)
                    .HasColumnName("SDZON")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<F42119>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Sdan8);

                entity.HasIndex(e => e.Sdshan);

                entity.HasIndex(e => e.Sdvr01)
                    .HasName("IDX_PO_Nbr");

                entity.HasIndex(e => new { e.Sddoc, e.Sdlnty });

                entity.HasIndex(e => new { e.Sdivd, e.SdivdGr });

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid })
                    .IsClustered();

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid, e.Sdvr01 })
                    .HasName("IDX_Closed_Orders_PO");

                entity.HasIndex(e => new { e.Sddoco, e.Sdivd, e.Sdvr01, e.Sddsc1, e.Sdlnty, e.Sdcars })
                    .HasName("IX_SDLNTY_SDCARS");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdaaid)
                    .HasColumnName("SDAAID")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdacom)
                    .HasColumnName("SDACOM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdaddj)
                    .HasColumnName("SDADDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdaddjGr)
                    .HasColumnName("SDADDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdadtm)
                    .HasColumnName("SDADTM")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdaexp)
                    .HasColumnName("SDAEXP")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdaitm)
                    .HasColumnName("SDAITM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdan8)
                    .HasColumnName("SDAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdanby)
                    .HasColumnName("SDANBY")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdaopn)
                    .HasColumnName("SDAOPN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdapts)
                    .HasColumnName("SDAPTS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdapum)
                    .HasColumnName("SDAPUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdasn)
                    .HasColumnName("SDASN")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdatxt)
                    .HasColumnName("SDATXT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdback)
                    .HasColumnName("SDBACK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdbcrc)
                    .HasColumnName("SDBCRC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdbsc)
                    .HasColumnName("SDBSC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcadc)
                    .HasColumnName("SDCADC")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdcars)
                    .HasColumnName("SDCARS")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdcatnm)
                    .HasColumnName("SDCATNM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcbsc)
                    .HasColumnName("SDCBSC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdccidln)
                    .HasColumnName("SDCCIDLN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdclvl)
                    .HasColumnName("SDCLVL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcmcg)
                    .HasColumnName("SDCMCG")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcmgp)
                    .HasColumnName("SDCMGP")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcndj)
                    .HasColumnName("SDCNDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdcndjGr)
                    .HasColumnName("SDCNDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdcnid)
                    .HasColumnName("SDCNID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdco)
                    .HasColumnName("SDCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcomm)
                    .HasColumnName("SDCOMM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcord)
                    .HasColumnName("SDCORD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Sdcpnt)
                    .HasColumnName("SDCPNT")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Sdcrcd)
                    .HasColumnName("SDCRCD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcrmd)
                    .HasColumnName("SDCRMD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcrr)
                    .HasColumnName("SDCRR")
                    .HasColumnType("decimal(15, 7)");

                entity.Property(e => e.Sdcsto)
                    .HasColumnName("SDCSTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdctry)
                    .HasColumnName("SDCTRY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sddct)
                    .HasColumnName("SDDCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddeid)
                    .HasColumnName("SDDEID")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sddeln)
                    .HasColumnName("SDDELN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddgl)
                    .HasColumnName("SDDGL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SddglGr)
                    .HasColumnName("SDDGL_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sddmbu)
                    .HasColumnName("SDDMBU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddmcs)
                    .HasColumnName("SDDMCS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Sddmct)
                    .HasColumnName("SDDMCT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddoc)
                    .HasColumnName("SDDOC")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddrqj)
                    .HasColumnName("SDDRQJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SddrqjGr)
                    .HasColumnName("SDDRQJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sddrqt)
                    .HasColumnName("SDDRQT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sddsc1)
                    .HasColumnName("SDDSC1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddsc2)
                    .HasColumnName("SDDSC2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddtbs)
                    .HasColumnName("SDDTBS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddtys)
                    .HasColumnName("SDDTYS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddual)
                    .HasColumnName("SDDUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddvan)
                    .HasColumnName("SDDVAN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdecst)
                    .HasColumnName("SDECST")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdemcu)
                    .HasColumnName("SDEMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdeuse)
                    .HasColumnName("SDEUSE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdexdp)
                    .HasColumnName("SDEXDP")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdexr1)
                    .HasColumnName("SDEXR1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdfea)
                    .HasColumnName("SDFEA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfec)
                    .HasColumnName("SDFEC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfprc)
                    .HasColumnName("SDFPRC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfrgd)
                    .HasColumnName("SDFRGD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdfrmp)
                    .HasColumnName("SDFRMP")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdfrth)
                    .HasColumnName("SDFRTH")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdfuc)
                    .HasColumnName("SDFUC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfun2)
                    .HasColumnName("SDFUN2")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfup)
                    .HasColumnName("SDFUP")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdfy)
                    .HasColumnName("SDFY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sdglc)
                    .HasColumnName("SDGLC")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdgrwt)
                    .HasColumnName("SDGRWT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdgwum)
                    .HasColumnName("SDGWUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdhdbu)
                    .HasColumnName("SDHDBU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdhold)
                    .HasColumnName("SDHOLD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdinmg)
                    .HasColumnName("SDINMG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir01)
                    .HasColumnName("SDIR01")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir02)
                    .HasColumnName("SDIR02")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir03)
                    .HasColumnName("SDIR03")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir04)
                    .HasColumnName("SDIR04")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdir05)
                    .HasColumnName("SDIR05")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sditm)
                    .HasColumnName("SDITM")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sditvl)
                    .HasColumnName("SDITVL")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sditwt)
                    .HasColumnName("SDITWT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdivd)
                    .HasColumnName("SDIVD")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdivdGr)
                    .HasColumnName("SDIVD_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdjobn)
                    .HasColumnName("SDJOBN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdkco)
                    .HasColumnName("SDKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdkcoo)
                    .HasColumnName("SDKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdktln)
                    .HasColumnName("SDKTLN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdktp)
                    .HasColumnName("SDKTP")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdlcod)
                    .HasColumnName("SDLCOD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlitm)
                    .HasColumnName("SDLITM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdlnty)
                    .HasColumnName("SDLNTY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlob)
                    .HasColumnName("SDLOB")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlocn)
                    .HasColumnName("SDLOCN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlotn)
                    .HasColumnName("SDLOTN")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlprc)
                    .HasColumnName("SDLPRC")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdlttr)
                    .HasColumnName("SDLTTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdlttrTxt)
                    .HasColumnName("SDLTTR_TXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdmcln)
                    .HasColumnName("SDMCLN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdmcu)
                    .HasColumnName("SDMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdmerl)
                    .HasColumnName("SDMERL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdmot)
                    .HasColumnName("SDMOT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdntr)
                    .HasColumnName("SDNTR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdnumb)
                    .HasColumnName("SDNUMB")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdnxtr)
                    .HasColumnName("SDNXTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdnxtrTxt)
                    .HasColumnName("SDNXTR_TXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdocto)
                    .HasColumnName("SDOCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdodct)
                    .HasColumnName("SDODCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdodln)
                    .HasColumnName("SDODLN")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdodoc)
                    .HasColumnName("SDODOC")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdogno)
                    .HasColumnName("SDOGNO")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdokc)
                    .HasColumnName("SDOKC")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdokco)
                    .HasColumnName("SDOKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdoorn)
                    .HasColumnName("SDOORN")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdopdj)
                    .HasColumnName("SDOPDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdopdjGr)
                    .HasColumnName("SDOPDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdoppid)
                    .HasColumnName("SDOPPID")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdoptt)
                    .HasColumnName("SDOPTT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdorp)
                    .HasColumnName("SDORP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdorpr)
                    .HasColumnName("SDORPR")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdoseq)
                    .HasColumnName("SDOSEQ")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Sdostp)
                    .HasColumnName("SDOSTP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdotqy)
                    .HasColumnName("SDOTQY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpa8)
                    .HasColumnName("SDPA8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdpddj)
                    .HasColumnName("SDPDDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdpddjGr)
                    .HasColumnName("SDPDDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdpdtt)
                    .HasColumnName("SDPDTT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdpefj)
                    .HasColumnName("SDPEFJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdpefjGr)
                    .HasColumnName("SDPEFJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdpend)
                    .HasColumnName("SDPEND")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpid)
                    .HasColumnName("SDPID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpmdt)
                    .HasColumnName("SDPMDT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdpmtn)
                    .HasColumnName("SDPMTN")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpmto)
                    .HasColumnName("SDPMTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpoe)
                    .HasColumnName("SDPOE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdppdj)
                    .HasColumnName("SDPPDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdppdjGr)
                    .HasColumnName("SDPPDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdpqor)
                    .HasColumnName("SDPQOR")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdpran8)
                    .HasColumnName("SDPRAN8")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdprcidln)
                    .HasColumnName("SDPRCIDLN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdprgr)
                    .HasColumnName("SDPRGR")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprio)
                    .HasColumnName("SDPRIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprjm)
                    .HasColumnName("SDPRJM")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdprov)
                    .HasColumnName("SDPROV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp1)
                    .HasColumnName("SDPRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp2)
                    .HasColumnName("SDPRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp3)
                    .HasColumnName("SDPRP3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp4)
                    .HasColumnName("SDPRP4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdprp5)
                    .HasColumnName("SDPRP5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpsig)
                    .HasColumnName("SDPSIG")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdpsn)
                    .HasColumnName("SDPSN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdpstm)
                    .HasColumnName("SDPSTM")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdptc)
                    .HasColumnName("SDPTC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdqrlv)
                    .HasColumnName("SDQRLV")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdqtyt)
                    .HasColumnName("SDQTYT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdrcd)
                    .HasColumnName("SDRCD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrcto)
                    .HasColumnName("SDRCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdresl)
                    .HasColumnName("SDRESL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrfrv)
                    .HasColumnName("SDRFRV")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrkco)
                    .HasColumnName("SDRKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrkit)
                    .HasColumnName("SDRKIT")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdrldj)
                    .HasColumnName("SDRLDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdrlit)
                    .HasColumnName("SDRLIT")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrlln)
                    .HasColumnName("SDRLLN")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdrlnu)
                    .HasColumnName("SDRLNU")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrltm)
                    .HasColumnName("SDRLTM")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdrorn)
                    .HasColumnName("SDRORN")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrout)
                    .HasColumnName("SDROUT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrprc)
                    .HasColumnName("SDRPRC")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrsdj)
                    .HasColumnName("SDRSDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdrsdjGr)
                    .HasColumnName("SDRSDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdrsdt)
                    .HasColumnName("SDRSDT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdryin)
                    .HasColumnName("SDRYIN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsbal)
                    .HasColumnName("SDSBAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsbl)
                    .HasColumnName("SDSBL")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsblt)
                    .HasColumnName("SDSBLT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsern)
                    .HasColumnName("SDSERN")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsfxo)
                    .HasColumnName("SDSFXO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshan)
                    .HasColumnName("SDSHAN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdshccidln)
                    .HasColumnName("SDSHCCIDLN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Sdshcm)
                    .HasColumnName("SDSHCM")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshcn)
                    .HasColumnName("SDSHCN")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshpn)
                    .HasColumnName("SDSHPN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdso01)
                    .HasColumnName("SDSO01")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso02)
                    .HasColumnName("SDSO02")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso03)
                    .HasColumnName("SDSO03")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso04)
                    .HasColumnName("SDSO04")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso05)
                    .HasColumnName("SDSO05")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso06)
                    .HasColumnName("SDSO06")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso07)
                    .HasColumnName("SDSO07")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso08)
                    .HasColumnName("SDSO08")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso09)
                    .HasColumnName("SDSO09")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso10)
                    .HasColumnName("SDSO10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso11)
                    .HasColumnName("SDSO11")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso12)
                    .HasColumnName("SDSO12")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso13)
                    .HasColumnName("SDSO13")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso14)
                    .HasColumnName("SDSO14")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso15)
                    .HasColumnName("SDSO15")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso16)
                    .HasColumnName("SDSO16")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso17)
                    .HasColumnName("SDSO17")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso18)
                    .HasColumnName("SDSO18")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso19)
                    .HasColumnName("SDSO19")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdso20)
                    .HasColumnName("SDSO20")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsobk)
                    .HasColumnName("SDSOBK")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsocn)
                    .HasColumnName("SDSOCN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsone)
                    .HasColumnName("SDSONE")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsoor)
                    .HasColumnName("SDSOOR")
                    .HasColumnType("decimal(31, 0)");

                entity.Property(e => e.Sdsoqs)
                    .HasColumnName("SDSOQS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdspattn)
                    .HasColumnName("SDSPATTN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsqor)
                    .HasColumnName("SDSQOR")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdsrp1)
                    .HasColumnName("SDSRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp2)
                    .HasColumnName("SDSRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp3)
                    .HasColumnName("SDSRP3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp4)
                    .HasColumnName("SDSRP4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp5)
                    .HasColumnName("SDSRP5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdstop)
                    .HasColumnName("SDSTOP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdswms)
                    .HasColumnName("SDSWMS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtax1)
                    .HasColumnName("SDTAX1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtcst)
                    .HasColumnName("SDTCST")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdtday)
                    .HasColumnName("SDTDAY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdthgd)
                    .HasColumnName("SDTHGD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdthrp)
                    .HasColumnName("SDTHRP")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdtorg)
                    .HasColumnName("SDTORG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtpc)
                    .HasColumnName("SDTPC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtrdc)
                    .HasColumnName("SDTRDC")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdtrdj)
                    .HasColumnName("SDTRDJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdtrdjGr)
                    .HasColumnName("SDTRDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdtxa1)
                    .HasColumnName("SDTXA1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdukid)
                    .HasColumnName("SDUKID")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sduncd)
                    .HasColumnName("SDUNCD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduncs)
                    .HasColumnName("SDUNCS")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sduom)
                    .HasColumnName("SDUOM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduom1)
                    .HasColumnName("SDUOM1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduom2)
                    .HasColumnName("SDUOM2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduom4)
                    .HasColumnName("SDUOM4")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduopn)
                    .HasColumnName("SDUOPN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sduorg)
                    .HasColumnName("SDUORG")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdupc1)
                    .HasColumnName("SDUPC1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdupc2)
                    .HasColumnName("SDUPC2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdupc3)
                    .HasColumnName("SDUPC3")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdupmj)
                    .HasColumnName("SDUPMJ")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdupmjGr)
                    .HasColumnName("SDUPMJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sduprc)
                    .HasColumnName("SDUPRC")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdurab)
                    .HasColumnName("SDURAB")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdurat)
                    .HasColumnName("SDURAT")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdurcd)
                    .HasColumnName("SDURCD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdurdt)
                    .HasColumnName("SDURDT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SdurdtGr)
                    .HasColumnName("SDURDT_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdurrf)
                    .HasColumnName("SDURRF")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sduser)
                    .HasColumnName("SDUSER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdvend)
                    .HasColumnName("SDVEND")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdvlum)
                    .HasColumnName("SDVLUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdvr01)
                    .HasColumnName("SDVR01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdvr02)
                    .HasColumnName("SDVR02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdvr03)
                    .HasColumnName("SDVR03")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdwtum)
                    .HasColumnName("SDWTUM")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxcto)
                    .HasColumnName("SDXCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxdck)
                    .HasColumnName("SDXDCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxkco)
                    .HasColumnName("SDXKCO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdxlln)
                    .HasColumnName("SDXLLN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdxorn)
                    .HasColumnName("SDXORN")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdxpty)
                    .HasColumnName("SDXPTY")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdxsfx)
                    .HasColumnName("SDXSFX")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdzon)
                    .HasColumnName("SDZON")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<F42119Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F42119__Detail");

                entity.HasIndex(e => e.SalesmanAbac01)
                    .HasName("IX_Salesman_ABAC01");

                entity.HasIndex(e => e.SalesmanAbac02)
                    .HasName("IX_Salesman_ABAC02");

                entity.HasIndex(e => e.Sdan8)
                    .HasName("IX_SDAN8");

                entity.HasIndex(e => e.Sddoc)
                    .HasName("IX_SDDOC");

                entity.HasIndex(e => e.SdivdGr)
                    .HasName("IX_SDIVD_GR");

                entity.HasIndex(e => e.Sdlitm)
                    .HasName("IX_SDLITM");

                entity.HasIndex(e => e.Sdshan)
                    .HasName("IX_SDSHAN");

                entity.HasIndex(e => e.Sdslsm)
                    .HasName("IX_SDSLSM");

                entity.HasIndex(e => e.Sdvr01)
                    .HasName("IX_SDVR01");

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid })
                    .HasName("IX_SDDOCO,SDDCTO,SDLNID")
                    .IsClustered();

                entity.Property(e => e.Salesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanAbac01)
                    .HasColumnName("Salesman_ABAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesmanAbac02)
                    .HasColumnName("Salesman_ABAC02")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdaddjGr)
                    .HasColumnName("SDADDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdaexp)
                    .HasColumnName("SDAEXP")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdan8)
                    .HasColumnName("SDAN8")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddoc)
                    .HasColumnName("SDDOC")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sddsc1)
                    .HasColumnName("SDDSC1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdivdGr)
                    .HasColumnName("SDIVD_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdktp)
                    .HasColumnName("SDKTP")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Sdlitm)
                    .HasColumnName("SDLITM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Sdlnty)
                    .HasColumnName("SDLNTY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlttr)
                    .HasColumnName("SDLTTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdlttrTxt)
                    .HasColumnName("SDLTTR_TXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdmcu)
                    .HasColumnName("SDMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdpddjGr)
                    .HasColumnName("SDPDDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdqtyt)
                    .HasColumnName("SDQTYT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sdrlit)
                    .HasColumnName("SDRLIT")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshan)
                    .HasColumnName("SDSHAN")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sdslsm)
                    .HasColumnName("SDSLSM")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sdsoqs)
                    .HasColumnName("SDSOQS")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Sdsrp1)
                    .HasColumnName("SDSRP1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdsrp2)
                    .HasColumnName("SDSRP2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdtorg)
                    .HasColumnName("SDTORG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdtrdjGr)
                    .HasColumnName("SDTRDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sduorg)
                    .HasColumnName("SDUORG")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Sduprc)
                    .HasColumnName("SDUPRC")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdvr01)
                    .HasColumnName("SDVR01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAbac01)
                    .HasColumnName("ShipTo_ABAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<F4211Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F4211__Detail");

                entity.HasIndex(e => e.SalesmanAbac01);

                entity.HasIndex(e => e.SalesmanAbac02);

                entity.HasIndex(e => e.Sdan8);

                entity.HasIndex(e => e.Sdlitm);

                entity.HasIndex(e => e.Sdshan);

                entity.HasIndex(e => e.Sdslsm);

                entity.HasIndex(e => e.SdtrdjGr);

                entity.HasIndex(e => e.Sdvr01);

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid })
                    .IsClustered();

                entity.Property(e => e.Salesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanAbac01)
                    .HasColumnName("Salesman_ABAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesmanAbac02)
                    .HasColumnName("Salesman_ABAC02")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdaddjGr)
                    .HasColumnName("SDADDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdaexp)
                    .HasColumnName("SDAEXP")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdan8)
                    .HasColumnName("SDAN8")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sddsc1)
                    .HasColumnName("SDDSC1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlitm)
                    .HasColumnName("SDLITM")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Sdlnty)
                    .HasColumnName("SDLNTY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlttr)
                    .HasColumnName("SDLTTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdlttrTxt)
                    .HasColumnName("SDLTTR_TXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdmcu)
                    .HasColumnName("SDMCU")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdnxtr)
                    .HasColumnName("SDNXTR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdnxtrTxt)
                    .HasColumnName("SDNXTR_TXT")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdpddjGr)
                    .HasColumnName("SDPDDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SdppdjGr)
                    .HasColumnName("SDPPDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sdrlit)
                    .HasColumnName("SDRLIT")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdrout)
                    .HasColumnName("SDROUT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdshan)
                    .HasColumnName("SDSHAN")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sdslsm)
                    .HasColumnName("SDSLSM")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Sdsoqs)
                    .HasColumnName("SDSOQS")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Sdtday)
                    .HasColumnName("SDTDAY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdtorg)
                    .HasColumnName("SDTORG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdtrdjGr)
                    .HasColumnName("SDTRDJ_GR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sduorg)
                    .HasColumnName("SDUORG")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Sduprc)
                    .HasColumnName("SDUPRC")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sdvr01)
                    .HasColumnName("SDVR01")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAbac01)
                    .HasColumnName("ShipTo_ABAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldTo)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<F42160>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Sdslsm)
                    .HasName("Sales Rep Index");

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid })
                    .HasName("Order Number, Type, Line Index")
                    .IsClustered();

                entity.Property(e => e.Sdapun)
                    .HasColumnName("SDAPUN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdccty)
                    .HasColumnName("SDCCTY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcmln)
                    .HasColumnName("SDCMLN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdfca)
                    .HasColumnName("SDFCA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdkcoo)
                    .HasColumnName("SDKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdsfxo)
                    .HasColumnName("SDSFXO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdslcm)
                    .HasColumnName("SDSLCM")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdslsm)
                    .HasColumnName("SDSLSM")
                    .HasColumnType("decimal(8, 0)");
            });

            modelBuilder.Entity<F42160Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F42160__Detail");

                entity.HasIndex(e => e.Sdslsm)
                    .HasName("Sales Rep Index");

                entity.HasIndex(e => new { e.Sddoco, e.Sddcto, e.Sdlnid })
                    .HasName("Order Number, Type, Line Index")
                    .IsClustered();

                entity.Property(e => e.Salesman)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanAbac01)
                    .HasColumnName("Salesman_ABAC01")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesmanAbac02)
                    .HasColumnName("Salesman_ABAC02")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdapun)
                    .HasColumnName("SDAPUN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdccty)
                    .HasColumnName("SDCCTY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdcmln)
                    .HasColumnName("SDCMLN")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Sdfca)
                    .HasColumnName("SDFCA")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Sdkcoo)
                    .HasColumnName("SDKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sdsfxo)
                    .HasColumnName("SDSFXO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdslcm)
                    .HasColumnName("SDSLCM")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Sdslsm)
                    .HasColumnName("SDSLSM")
                    .HasColumnType("decimal(8, 0)");
            });

            modelBuilder.Entity<SymPortalUserData>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("SymPortal_UserData");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_UserName")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.Agency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rep)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trained)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserDomain)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRole_ID");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.SymPortalUserData)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_SymPortal_UserData_SymPortal_UserRoles");
            });

            modelBuilder.Entity<SymPortalUserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("SymPortal_UserRoles");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRole_ID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLeadToolManager).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSigToolManager).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartUrl)
                    .HasColumnName("StartURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
