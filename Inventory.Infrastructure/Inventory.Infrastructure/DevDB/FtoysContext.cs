using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PersonalWork.Domain.DBModel;

namespace PersonalWork.Infrastructure.DevDB;

public partial class FtoysContext : DbContext
{
    public FtoysContext()
    {
    }

    public FtoysContext(DbContextOptions<FtoysContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApiAuditErrorLog> ApiAuditErrorLogs { get; set; }

    public virtual DbSet<ApiAuditLog> ApiAuditLogs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Category1> Categories1 { get; set; }

    public virtual DbSet<Classification> Classifications { get; set; }

    public virtual DbSet<ItemNumberGenerater> ItemNumberGeneraters { get; set; }

    public virtual DbSet<MainUrl> MainUrls { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Product1> Products1 { get; set; }

    public virtual DbSet<ProductDetail> ProductDetails { get; set; }

    public virtual DbSet<ProductList> ProductLists { get; set; }

    public virtual DbSet<RecentlyViewed> RecentlyVieweds { get; set; }

    public virtual DbSet<Rfqdetail> Rfqdetails { get; set; }

    public virtual DbSet<Rfqheader> Rfqheaders { get; set; }

    public virtual DbSet<ScrapHistory> ScrapHistories { get; set; }

    public virtual DbSet<ScrapHistory1> ScrapHistories1 { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SyncDetail> SyncDetails { get; set; }

    public virtual DbSet<SyncHeader> SyncHeaders { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<TempProduct> TempProducts { get; set; }

    public virtual DbSet<TempProductList> TempProductLists { get; set; }

    public virtual DbSet<Tempprice> Tempprices { get; set; }

    public virtual DbSet<Tempproductlistbkp> Tempproductlistbkps { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAccessObject> UserAccessObjects { get; set; }

    public virtual DbSet<UserAction> UserActions { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

    public virtual DbSet<UserSession> UserSessions { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserTracking> UserTrackings { get; set; }

    public virtual DbSet<UserWishList> UserWishLists { get; set; }

    public virtual DbSet<Vproduct> Vproducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=96.125.165.205;TrustServerCertificate=True;user id=ftoys;password=agile@5210;Initial Catalog=Ftoys;Integrated Security=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApiAuditErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ApiAuditErrorLog");

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Referrer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApiAuditLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ApiAuditLog");

            entity.Property(e => e.ApiuserId).HasColumnName("APIUserId");
            entity.Property(e => e.BodyContentSizeInBytes).HasMaxLength(55);
            entity.Property(e => e.ContentType).HasMaxLength(55);
            entity.Property(e => e.Header).HasMaxLength(4000);
            entity.Property(e => e.HttpMethod).HasMaxLength(55);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(55)
                .HasColumnName("IPAddress");
            entity.Property(e => e.OriginatedOn).HasColumnType("datetime");
            entity.Property(e => e.ReachedOn).HasColumnType("datetime");
            entity.Property(e => e.Refferer).HasMaxLength(55);
            entity.Property(e => e.StatusCode).HasMaxLength(55);
            entity.Property(e => e.Uri).HasMaxLength(255);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07AFEE103B");

            entity.ToTable("Categories", "Scrap");

            entity.Property(e => e.CatId).HasMaxLength(10);
            entity.Property(e => e.CatName).HasMaxLength(500);
            entity.Property(e => e.CatType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CatUrl)
                .HasMaxLength(100)
                .HasColumnName("CatURL");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MapId).HasMaxLength(10);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ParentCatId).HasMaxLength(10);
        });

        modelBuilder.Entity<Category1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC0743F6AD6B");

            entity.ToTable("Categories", "Store");

            entity.HasIndex(e => new { e.Id, e.ParentId, e.Relation, e.Code }, "ClusteredIndex-20211029-235002").HasFillFactor(90);

            entity.HasIndex(e => new { e.Name, e.CreatedOn, e.ModifiedOn }, "NonClusteredIndex-20211030-000050");

            entity.Property(e => e.Breadcrumb).HasMaxLength(500);
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.ImgUrl).HasMaxLength(500);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Relation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SequenceNo).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Classification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Classifi__3214EC074D8B55B7");

            entity.Property(e => e.ItemModelName).HasMaxLength(200);
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<ItemNumberGenerater>(entity =>
        {
            entity.HasKey(e => e.FtoysItemNumber).HasName("PK__ItemNumb__05DB3BFC3E2BC1F3");

            entity.ToTable("ItemNumberGenerater", "Store");

            entity.Property(e => e.FtoysItemNumber).ValueGeneratedNever();
            entity.Property(e => e.BstitemNumber).HasColumnName("BSTItemNumber");
        });

        modelBuilder.Entity<MainUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MainURL__3214EC076F2E7908");

            entity.ToTable("MainURL", "Scrap");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastRunUrl).HasMaxLength(500);
            entity.Property(e => e.MainUrl1)
                .HasMaxLength(1000)
                .HasColumnName("MainURL");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC07A6505839");

            entity.ToTable("Products", "Scrap");

            entity.Property(e => e.CatId).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImgDownloaded).HasMaxLength(100);
            entity.Property(e => e.IsEdited).HasMaxLength(100);
            entity.Property(e => e.MainImgUrl).HasMaxLength(250);
            entity.Property(e => e.MainUrlid).HasColumnName("MainURLId");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductUrl)
                .HasMaxLength(300)
                .HasColumnName("ProductURL");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("Products_PK")
                .IsClustered(false);

            entity.ToTable("Products", "Store");

            entity.HasIndex(e => new { e.CategoryId, e.ItemNumber, e.Id, e.Price, e.Width, e.Depth, e.Height, e.UpdateDate, e.IsActive }, "ClusteredIndex-20211029-233213")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Battery).HasMaxLength(200);
            entity.Property(e => e.CartonSize).HasMaxLength(100);
            entity.Property(e => e.Cbmcutf)
                .HasMaxLength(100)
                .HasColumnName("CBMCUTF");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Gwnkg)
                .HasMaxLength(100)
                .HasColumnName("GWNKg");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InnerOuter).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PackSize).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypeOfPakcing).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ProductDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductD__3214EC0702E783AF");

            entity.ToTable("ProductDetails", "Scrap");

            entity.HasIndex(e => e.ProductId, "UQ__ProductD__B40CC6CCC34DBE41").IsUnique();

            entity.Property(e => e.Battery).HasMaxLength(200);
            entity.Property(e => e.CartonSize).HasMaxLength(100);
            entity.Property(e => e.CatCode).HasMaxLength(10);
            entity.Property(e => e.Cbmcutf)
                .HasMaxLength(100)
                .HasColumnName("CBMCUTF");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Depth).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Gwnkg)
                .HasMaxLength(100)
                .HasColumnName("GWNKg");
            entity.Property(e => e.Height).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.InnerOuter).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PackSize).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductUrlid).HasColumnName("ProductURLId");
            entity.Property(e => e.Sku)
                .HasMaxLength(300)
                .HasColumnName("SKU");
            entity.Property(e => e.TypeOfPakcing).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Width).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<ProductList>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ProductL__B40CC6CD22F4FD53");

            entity.ToTable("ProductList");

            entity.Property(e => e.AddCount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Bhdes)
                .HasMaxLength(100)
                .HasColumnName("BHDes");
            entity.Property(e => e.BoxCount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BoxSize).HasMaxLength(200);
            entity.Property(e => e.BoxSize01).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BoxSize02).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BoxSize03).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BoxSizeSum).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Ceritficate).HasMaxLength(100);
            entity.Property(e => e.Cntcbm)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CNTCBM");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DetailDescription).HasMaxLength(100);
            entity.Property(e => e.Enname)
                .HasMaxLength(200)
                .HasColumnName("ENName");
            entity.Property(e => e.EsName).HasMaxLength(200);
            entity.Property(e => e.FacCode)
                .HasMaxLength(50)
                .HasColumnName("Fac_Code");
            entity.Property(e => e.FacPno)
                .HasMaxLength(20)
                .HasColumnName("Fac_Pno");
            entity.Property(e => e.FactoryCode).HasMaxLength(50);
            entity.Property(e => e.FactoryName).HasMaxLength(200);
            entity.Property(e => e.Gw)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GW");
            entity.Property(e => e.Imgurl).HasMaxLength(1000);
            entity.Property(e => e.IsEn).HasColumnName("IsEN");
            entity.Property(e => e.IsZh).HasColumnName("IsZH");
            entity.Property(e => e.LastUpdate).HasColumnType("date");
            entity.Property(e => e.MeterialArea).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Nw)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NW");
            entity.Property(e => e.PakingTypeName).HasMaxLength(100);
            entity.Property(e => e.Pcs)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PCS");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductModelName).HasMaxLength(200);
            entity.Property(e => e.ProductState).HasMaxLength(50);
            entity.Property(e => e.ProductTypeName).HasMaxLength(200);
            entity.Property(e => e.ProductVideo).HasMaxLength(50);
            entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RuName).HasMaxLength(200);
            entity.Property(e => e.SampleSize).HasMaxLength(200);
            entity.Property(e => e.SampleSize01).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SampleSize02).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SampleSize03).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SmallImagurl).HasMaxLength(1000);
            entity.Property(e => e.TotalCbm)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TotalCBM");
            entity.Property(e => e.TotalGw)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TotalGW");
            entity.Property(e => e.TotalNw).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalPcs)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TotalPCS");
            entity.Property(e => e.VideoUrl).HasMaxLength(200);
        });

        modelBuilder.Entity<RecentlyViewed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recently__3214EC07FB1BF13C");

            entity.ToTable("RecentlyViewed", "Store");

            entity.Property(e => e.ViewedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Rfqdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RFQDetai__3214EC07D8458D57");

            entity.ToTable("RFQDetails", "Store");

            entity.Property(e => e.Dqty).HasColumnName("DQty");
            entity.Property(e => e.RequestedOn).HasColumnType("datetime");
            entity.Property(e => e.Rqty).HasColumnName("RQty");
            entity.Property(e => e.Scomments)
                .HasMaxLength(500)
                .HasColumnName("SComments");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ucomments)
                .HasMaxLength(500)
                .HasColumnName("UComments");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Rfqheader>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__RFQHeade__5D55CE586E877BEF");

            entity.ToTable("RFQHeader", "Store");

            entity.Property(e => e.RequestedOn).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ScrapHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ScrapHis__3214EC07F23108C0");

            entity.ToTable("ScrapHistory");

            entity.Property(e => e.ScrapDate).HasColumnType("date");
        });

        modelBuilder.Entity<ScrapHistory1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ScrapHis__3214EC0746BB6DE3");

            entity.ToTable("ScrapHistory", "Scrap");

            entity.Property(e => e.ScrapDate).HasColumnType("date");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Supplier", "Scrap");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Domain).HasMaxLength(300);
            entity.Property(e => e.DomainUrl)
                .HasMaxLength(300)
                .HasColumnName("DomainURL");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<SyncDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SyncDeta__3214EC07828E9AD8");

            entity.ToTable("SyncDetails", "Scrap");

            entity.Property(e => e.CompletedOn).HasColumnType("datetime");
            entity.Property(e => e.QueuedOn).HasColumnType("datetime");
            entity.Property(e => e.StaredOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<SyncHeader>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__SyncHead__5D55CE58920FDB4D");

            entity.ToTable("SyncHeader", "Scrap");

            entity.Property(e => e.CompletedOn).HasColumnType("datetime");
            entity.Property(e => e.QueuedOn).HasColumnType("datetime");
            entity.Property(e => e.StaredOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.SyncType).HasMaxLength(50);
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table_1");

            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Val)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TempProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempProducts", "Scrap");

            entity.Property(e => e.CatId).HasMaxLength(100);
            entity.Property(e => e.MainImgUrl).HasMaxLength(250);
            entity.Property(e => e.MainUrlid).HasColumnName("MainURLId");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductUrl)
                .HasMaxLength(300)
                .HasColumnName("ProductURL");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<TempProductList>(entity =>
        {
            entity.HasKey(e => e.Fid).HasName("PK__TempProd__C1BEAA42CB38991B");

            entity.ToTable("TempProductList");

            entity.Property(e => e.Fid).HasColumnName("FId");
            entity.Property(e => e.Bhdes).HasColumnName("BHDes");
            entity.Property(e => e.Cntcbm).HasColumnName("CNTCBM");
            entity.Property(e => e.Enname).HasColumnName("ENName");
            entity.Property(e => e.FacCode).HasColumnName("Fac_Code");
            entity.Property(e => e.FacPno).HasColumnName("Fac_Pno");
            entity.Property(e => e.Gw).HasColumnName("GW");
            entity.Property(e => e.IsEn).HasColumnName("IsEN");
            entity.Property(e => e.IsZh).HasColumnName("IsZH");
            entity.Property(e => e.Nw).HasColumnName("NW");
            entity.Property(e => e.Pcs).HasColumnName("PCS");
            entity.Property(e => e.TotalCbm).HasColumnName("TotalCBM");
            entity.Property(e => e.TotalGw).HasColumnName("TotalGW");
            entity.Property(e => e.TotalPcs).HasColumnName("TotalPCS");
        });

        modelBuilder.Entity<Tempprice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempprice");

            entity.Property(e => e.Sprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sprice");
        });

        modelBuilder.Entity<Tempproductlistbkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempproductlistbkp");

            entity.Property(e => e.Bhdes).HasColumnName("BHDes");
            entity.Property(e => e.Cntcbm).HasColumnName("CNTCBM");
            entity.Property(e => e.Enname).HasColumnName("ENName");
            entity.Property(e => e.FacCode).HasColumnName("Fac_Code");
            entity.Property(e => e.FacPno).HasColumnName("Fac_Pno");
            entity.Property(e => e.Gw).HasColumnName("GW");
            entity.Property(e => e.IsEn).HasColumnName("IsEN");
            entity.Property(e => e.IsZh).HasColumnName("IsZH");
            entity.Property(e => e.Nw).HasColumnName("NW");
            entity.Property(e => e.Pcs).HasColumnName("PCS");
            entity.Property(e => e.ProductId).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalCbm).HasColumnName("TotalCBM");
            entity.Property(e => e.TotalGw).HasColumnName("TotalGW");
            entity.Property(e => e.TotalPcs).HasColumnName("TotalPCS");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC0777902990");

            entity.ToTable("User", "Store");

            entity.HasIndex(e => e.UserName, "UQ__User__C9F28456A626E2EA").IsUnique();

            entity.HasIndex(e => e.UserToken, "UQ__User__FD9E0823F18E7284").IsUnique();

            entity.Property(e => e.AccessToken).HasMaxLength(250);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EMailId");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MarkupAmount).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MarkupPercent).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Passwd).HasMaxLength(250);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RoleId).HasDefaultValueSql("((2))");
            entity.Property(e => e.TokenExpiredOn).HasColumnType("datetime");
            entity.Property(e => e.TokenGeneratedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserToken).HasMaxLength(250);
        });

        modelBuilder.Entity<UserAccessObject>(entity =>
        {
            entity.HasKey(e => e.AccessId).HasName("PK__UserAcce__4130D05FFBB7C095");

            entity.ToTable("UserAccessObject", "Store");

            entity.Property(e => e.AccessLevel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AccessName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Relation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<UserAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserActi__3214EC07E5FEEBB9");

            entity.ToTable("UserAction", "Store");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserProf__3214EC079EB1F704");

            entity.ToTable("UserProfile", "Store");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.BusinessLocation).HasMaxLength(100);
            entity.Property(e => e.BusinessName).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Pincode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(100);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC078CF4E263");

            entity.ToTable("UserRole", "Store");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<UserRoleMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC077C421275");

            entity.ToTable("UserRoleMapping", "Store");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserSess__3214EC07ECB17BE0");

            entity.ToTable("UserSession", "Store");

            entity.Property(e => e.AccessToken).HasMaxLength(100);
            entity.Property(e => e.ExpiredAt).HasColumnType("datetime");
            entity.Property(e => e.LoggedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserSett__3214EC07B53860EE");

            entity.ToTable("UserSettings", "Store");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailNotification).HasColumnName("EMailNotification");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Smsnotification).HasColumnName("SMSNotification");
        });

        modelBuilder.Entity<UserTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserTrac__3214EC07ADA55B15");

            entity.ToTable("UserTracking", "Store");

            entity.Property(e => e.ActionRate).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.CheckOut).HasColumnType("datetime");
            entity.Property(e => e.Checkin).HasColumnType("datetime");
            entity.Property(e => e.PageUrl)
                .HasMaxLength(500)
                .HasColumnName("PageURL");
        });

        modelBuilder.Entity<UserWishList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserWish__3214EC070979E270");

            entity.ToTable("UserWishList", "Store");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemType).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<Vproduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VProducts");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
