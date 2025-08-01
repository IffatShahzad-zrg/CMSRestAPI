using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CMSRestAPI.Data;

public partial class SmsContext : DbContext
{
    public SmsContext()
    {
    }

    public SmsContext(DbContextOptions<SmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Smsin> Smsins { get; set; }

    public virtual DbSet<SmsinLog> SmsinLogs { get; set; }

    public virtual DbSet<Smslog> Smslogs { get; set; }

    public virtual DbSet<Smsout> Smsouts { get; set; }

    public virtual DbSet<Smsout20211104> Smsout20211104s { get; set; }

    public virtual DbSet<SmsoutZrg> SmsoutZrgs { get; set; }

    public virtual DbSet<VuAckDateCorrection> VuAckDateCorrections { get; set; }

    public virtual DbSet<VuAcknowledgeSm> VuAcknowledgeSms { get; set; }

    public virtual DbSet<VuInterimDateCorrection> VuInterimDateCorrections { get; set; }

    public virtual DbSet<VuInterimSm> VuInterimSms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.105;Database=SMS;User Id=sa;Password=zrg;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Smsin>(entity =>
        {
            entity.HasKey(e => e.Smsid);

            entity.ToTable("SMSIn");

            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.Opted).HasColumnName("opted");
            entity.Property(e => e.Phoneno).HasMaxLength(20);
            entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReferenceNo).HasMaxLength(20);
            entity.Property(e => e.SmsdateTime)
                .HasColumnType("datetime")
                .HasColumnName("SMSDateTime");
            entity.Property(e => e.Text).HasMaxLength(1000);
            entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");
        });

        modelBuilder.Entity<SmsinLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSInLog");

            entity.Property(e => e.Opted).HasColumnName("opted");
            entity.Property(e => e.Phoneno).HasMaxLength(20);
            entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReferenceNo).HasMaxLength(20);
            entity.Property(e => e.SmsdateTime)
                .HasColumnType("datetime")
                .HasColumnName("SMSDateTime");
            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.Text).HasMaxLength(1000);
            entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");
        });

        modelBuilder.Entity<Smslog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSLog");

            entity.Property(e => e.ComId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ComID");
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Opted).HasColumnName("opted");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.StationId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("StationID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasMaxLength(500);
            entity.Property(e => e.ToCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Smsout>(entity =>
        {
            entity.HasKey(e => e.Smsid).HasName("PK_SMSOut2");

            entity.ToTable("SMSOut");

            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.ComId)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Opted).HasColumnName("opted");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SmsserviceResponse)
                .HasMaxLength(500)
                .HasColumnName("SMSServiceResponse");
            entity.Property(e => e.Smstype)
                .HasMaxLength(50)
                .HasColumnName("SMSType");
            entity.Property(e => e.StationId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("StationID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasMaxLength(4000);
            entity.Property(e => e.ToCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Smsout20211104>(entity =>
        {
            entity.HasKey(e => e.Smsid).HasName("PK_SMSOut1");

            entity.ToTable("SMSOut20211104");

            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.ComId)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Opted).HasColumnName("opted");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Smstype)
                .HasMaxLength(50)
                .HasColumnName("SMSType");
            entity.Property(e => e.StationId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("StationID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasMaxLength(4000);
            entity.Property(e => e.ToCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmsoutZrg>(entity =>
        {
            entity.HasKey(e => e.Smsid).HasName("PK_SMSOut");

            entity.ToTable("SMSOutZRG");

            entity.Property(e => e.Smsid).HasColumnName("SMSID");
            entity.Property(e => e.ComId)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Opted).HasColumnName("opted");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Smstype)
                .HasMaxLength(50)
                .HasColumnName("SMSType");
            entity.Property(e => e.StationId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("StationID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasMaxLength(500);
            entity.Property(e => e.ToCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VuAckDateCorrection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuAckDateCorrection");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Sent)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Smsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SMSID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VuAcknowledgeSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuAcknowledgeSMS");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Sent)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Smsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SMSID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VuInterimDateCorrection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuInterimDateCorrection");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastTried)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Sent)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SentDate)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SentTime)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Smsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SMSID");
            entity.Property(e => e.SubmissionDate)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VuInterimSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuInterimSMS");

            entity.Property(e => e.Date)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Phoneno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Smstype)
                .HasMaxLength(2)
                .HasColumnName("SMSType");
            entity.Property(e => e.SubmissionTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
