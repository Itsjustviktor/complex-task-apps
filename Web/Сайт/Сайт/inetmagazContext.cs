using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Сайт
{
    public partial class inetmagazContext : DbContext
    {
        public inetmagazContext()
        {
        }

        public inetmagazContext(DbContextOptions<inetmagazContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderedgood> Orderedgoods { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<Supplygood> Supplygoods { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=inetmagaz;Username=postgres;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.HasKey(e => e.Idbuyer)
                    .HasName("buyer_pkey");

                entity.ToTable("buyer");

                entity.Property(e => e.Idbuyer)
                    .HasColumnName("idbuyer")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(5L, null, null, null, null, null);

                entity.Property(e => e.Emailbuyer).HasColumnName("emailbuyer");

                entity.Property(e => e.First).HasColumnName("first");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Second).HasColumnName("second");

                entity.Property(e => e.Telephonebuyer).HasColumnName("telephonebuyer");

                entity.Property(e => e.Third).HasColumnName("third");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Idemployee)
                    .HasName("employee_pkey");

                entity.ToTable("employee");

                entity.Property(e => e.Idemployee)
                    .HasColumnName("idemployee")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Firstname).HasColumnName("firstname");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Post).HasColumnName("post");

                entity.Property(e => e.Secondname).HasColumnName("secondname");

                entity.Property(e => e.Thirdname).HasColumnName("thirdname");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.Idfeedback)
                    .HasName("feedback_pkey");

                entity.ToTable("feedback");

                entity.Property(e => e.Idfeedback)
                    .HasColumnName("idfeedback")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.Firstname).HasColumnName("firstname");

                entity.Property(e => e.Problem).HasColumnName("problem");

                entity.Property(e => e.Solve).HasColumnName("solve");

                entity.Property(e => e.Telnumber).HasColumnName("telnumber");
            });

            modelBuilder.Entity<Good>(entity =>
            {
                entity.HasKey(e => e.Idgood)
                    .HasName("good_pkey");

                entity.ToTable("good");

                entity.Property(e => e.Idgood)
                    .ValueGeneratedNever()
                    .HasColumnName("idgood");

                entity.Property(e => e.Availability).HasColumnName("availability");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Dimension).HasColumnName("dimension");

                entity.Property(e => e.Firm).HasColumnName("firm");

                entity.Property(e => e.Guarantee).HasColumnName("guarantee");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.P1).HasColumnName("p1");

                entity.Property(e => e.P2).HasColumnName("p2");

                entity.Property(e => e.P3).HasColumnName("p3");

                entity.Property(e => e.Picture).HasColumnName("picture");

                entity.Property(e => e.Picture2).HasColumnName("picture2");

                entity.Property(e => e.Picture3).HasColumnName("picture3");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Provider).HasColumnName("provider");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Subcategory).HasColumnName("subcategory");

                entity.Property(e => e.Subfirm).HasColumnName("subfirm");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Idorder)
                    .HasName("order_pkey");

                entity.ToTable("order");

                entity.Property(e => e.Idorder)
                    .HasColumnName("idorder")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1111L, null, null, null, null, null);

                entity.Property(e => e.Adress).HasColumnName("adress");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Idbuyer).HasColumnName("idbuyer");

                entity.Property(e => e.Paymentmethod).HasColumnName("paymentmethod");

                entity.Property(e => e.Priceoreder).HasColumnName("priceoreder");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Takemethod).HasColumnName("takemethod");

                entity.Property(e => e.Tracknum).HasColumnName("tracknum");
            });

            modelBuilder.Entity<Orderedgood>(entity =>
            {
                entity.HasKey(e => e.Idorderedgoods)
                    .HasName("orderedgoods_pkey");

                entity.ToTable("orderedgoods");

                entity.Property(e => e.Idorderedgoods)
                    .HasColumnName("idorderedgoods")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(null, null, 3L, null, null, null);

                entity.Property(e => e.Idgood).HasColumnName("idgood");

                entity.Property(e => e.Idorder).HasColumnName("idorder");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantityorderedgoods).HasColumnName("quantityorderedgoods");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.Provider1)
                    .HasName("provider_pkey");

                entity.ToTable("provider");

                entity.Property(e => e.Provider1).HasColumnName("provider");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fax).HasColumnName("fax");

                entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");

                entity.Property(e => e.Pricelist).HasColumnName("pricelist");

                entity.Property(e => e.Telephone).HasColumnName("telephone");
            });

            modelBuilder.Entity<Supply>(entity =>
            {
                entity.HasKey(e => e.Idsupply)
                    .HasName("supply_pkey");

                entity.ToTable("supply");

                entity.Property(e => e.Idsupply)
                    .HasColumnName("idsupply")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(null, null, 10L, null, null, null);

                entity.Property(e => e.Idgood).HasColumnName("idgood");

                entity.Property(e => e.Priceposition).HasColumnName("priceposition");

                entity.Property(e => e.Pricesupply).HasColumnName("pricesupply");

                entity.Property(e => e.Provider).HasColumnName("provider");

                entity.Property(e => e.Quantitydeliveredgoods).HasColumnName("quantitydeliveredgoods");
            });

            modelBuilder.Entity<Supplygood>(entity =>
            {
                entity.HasKey(e => e.Idsupplygoods)
                    .HasName("deliveredgoods_pkey");

                entity.ToTable("supplygoods");

                entity.Property(e => e.Idsupplygoods)
                    .HasColumnName("idsupplygoods")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Idgood).HasColumnName("idgood");

                entity.Property(e => e.Idpackagesupply).HasColumnName("idpackagesupply");

                entity.Property(e => e.Priceposition).HasColumnName("priceposition");

                entity.Property(e => e.Quantitydeliveredgoods).HasColumnName("quantitydeliveredgoods");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test");

                entity.Property(e => e.Solve).HasColumnName("solve");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Idtransaction)
                    .HasName("transaction_pkey");

                entity.ToTable("transaction");

                entity.Property(e => e.Idtransaction)
                    .HasColumnName("idtransaction")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Idorder).HasColumnName("idorder");

                entity.Property(e => e.Receipt).HasColumnName("receipt");

                entity.Property(e => e.Transactiontime)
                    .HasColumnType("time without time zone")
                    .HasColumnName("transactiontime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
