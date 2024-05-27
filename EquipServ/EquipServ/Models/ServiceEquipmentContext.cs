using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EquipServ.Models;

public partial class ServiceEquipmentContext : DbContext
{
    public ServiceEquipmentContext()
    {
    }

    public ServiceEquipmentContext(DbContextOptions<ServiceEquipmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Announce> Announces { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<DetailEquipment> DetailEquipments { get; set; }

    public virtual DbSet<DetailName> DetailNames { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<ExecutorRequest> ExecutorRequests { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestAnnounce> RequestAnnounces { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<TypeClient> TypeClients { get; set; }

    public virtual DbSet<TypeOfFault> TypeOfFaults { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = ServiceEquipment; Integrated Security = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announce>(entity =>
        {
            entity.ToTable("Announce");

            entity.Property(e => e.AnnounceName).HasMaxLength(100);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.ClientLastName).HasMaxLength(50);
            entity.Property(e => e.ClientName).HasMaxLength(50);
            entity.Property(e => e.ClientSurName).HasMaxLength(50);

            entity.HasOne(d => d.TypeOfClientNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.TypeOfClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_TypeClient");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("Comment");

            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<DetailEquipment>(entity =>
        {
            entity.ToTable("DetailEquipment");

            entity.HasOne(d => d.DetailNavigation).WithMany(p => p.DetailEquipments)
                .HasForeignKey(d => d.Detail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailEquipment_DetailName");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.DetailEquipments)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailEquipment_Equipment");
        });

        modelBuilder.Entity<DetailName>(entity =>
        {
            entity.HasKey(e => e.DetailId);

            entity.ToTable("DetailName");

            entity.Property(e => e.DetailName1)
                .HasMaxLength(50)
                .HasColumnName("DetailName");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.Property(e => e.EquipmentName).HasMaxLength(100);
        });

        modelBuilder.Entity<ExecutorRequest>(entity =>
        {
            entity.HasKey(e => e.ExecutorReqId);

            entity.ToTable("ExecutorRequest");

            entity.HasOne(d => d.RequestNavigation).WithMany(p => p.ExecutorRequests)
                .HasForeignKey(d => d.Request)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExecutorRequest_Request");

            entity.HasOne(d => d.UserExecutorNavigation).WithMany(p => p.ExecutorRequests)
                .HasForeignKey(d => d.UserExecutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExecutorRequest_User");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.ToTable("Request");

            entity.Property(e => e.SerialNumber).HasMaxLength(50);

            entity.HasOne(d => d.ClientNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Client)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Client");

            entity.HasOne(d => d.CommentNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Comment)
                .HasConstraintName("FK_Request_Comment");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Equipment");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Status");

            entity.HasOne(d => d.TypeOfFaultNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.TypeOfFault)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_TypeOfFault");
        });

        modelBuilder.Entity<RequestAnnounce>(entity =>
        {
            entity.HasKey(e => e.ReqAnnounceId);

            entity.ToTable("RequestAnnounce");

            entity.Property(e => e.ReqAnnounceId).ValueGeneratedNever();

            entity.HasOne(d => d.AnnounceNavigation).WithMany(p => p.RequestAnnounces)
                .HasForeignKey(d => d.Announce)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestAnnounce_Announce");

            entity.HasOne(d => d.RequestNavigation).WithMany(p => p.RequestAnnounces)
                .HasForeignKey(d => d.Request)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestAnnounce_Request");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.StatusName).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeClient>(entity =>
        {
            entity.ToTable("TypeClient");
        });

        modelBuilder.Entity<TypeOfFault>(entity =>
        {
            entity.ToTable("TypeOfFault");

            entity.Property(e => e.TypeOfFaultName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(11);

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
