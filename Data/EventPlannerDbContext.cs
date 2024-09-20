using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using swanapi.Models;

namespace swanapi.Data;

public partial class EventPlannerDbContext : DbContext
{
    public EventPlannerDbContext()
    {
    }

    public EventPlannerDbContext(DbContextOptions<EventPlannerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutU> AboutUs { get; set; }

    public virtual DbSet<AddressMst> AddressMsts { get; set; }

    public virtual DbSet<AppUpdateVersion> AppUpdateVersions { get; set; }

    public virtual DbSet<Association> Associations { get; set; }

    public virtual DbSet<AssociationAdminAllocation> AssociationAdminAllocations { get; set; }

    public virtual DbSet<AssociationAllocation> AssociationAllocations { get; set; }

    public virtual DbSet<AssociationInvoice> AssociationInvoices { get; set; }

    public virtual DbSet<AssociationMember> AssociationMembers { get; set; }

    public virtual DbSet<AssociationMembersAdminAllocation> AssociationMembersAdminAllocations { get; set; }

    public virtual DbSet<AssociationMembersTypeAllocation> AssociationMembersTypeAllocations { get; set; }

    public virtual DbSet<AssociationMembershipsType> AssociationMembershipsTypes { get; set; }

    public virtual DbSet<AssociationPayment> AssociationPayments { get; set; }

    public virtual DbSet<AssociationPaymentCompanyAllocation> AssociationPaymentCompanyAllocations { get; set; }

    public virtual DbSet<AssociationPaymentUserAllocation> AssociationPaymentUserAllocations { get; set; }

    public virtual DbSet<AssociationProduct> AssociationProducts { get; set; }

    public virtual DbSet<AssociationProductBenefit> AssociationProductBenefits { get; set; }

    public virtual DbSet<AssociationProductDocument> AssociationProductDocuments { get; set; }

    public virtual DbSet<AssociationProductImage> AssociationProductImages { get; set; }

    public virtual DbSet<AssociationProductInvoice> AssociationProductInvoices { get; set; }

    public virtual DbSet<AssociationProductPayment> AssociationProductPayments { get; set; }

    public virtual DbSet<AssociationProductRating> AssociationProductRatings { get; set; }

    public virtual DbSet<AssociationProductUserAllocation> AssociationProductUserAllocations { get; set; }

    public virtual DbSet<AssociationProductUserInteraction> AssociationProductUserInteractions { get; set; }

    public virtual DbSet<AssociationProductUserPromoCodeAllocation> AssociationProductUserPromoCodeAllocations { get; set; }

    public virtual DbSet<AssociationStore> AssociationStores { get; set; }

    public virtual DbSet<AttendeeEventSessionAllocation> AttendeeEventSessionAllocations { get; set; }

    public virtual DbSet<AttendeeFavoriteProduct> AttendeeFavoriteProducts { get; set; }

    public virtual DbSet<AttendeePayment> AttendeePayments { get; set; }

    public virtual DbSet<AttendeePurchaseStoreItemsAllocation> AttendeePurchaseStoreItemsAllocations { get; set; }

    public virtual DbSet<AttendeeReport> AttendeeReports { get; set; }

    public virtual DbSet<AttendeeSchedule> AttendeeSchedules { get; set; }

    public virtual DbSet<Benefit> Benefits { get; set; }

    public virtual DbSet<BlockPostCategory> BlockPostCategories { get; set; }

    public virtual DbSet<BlockReportPost> BlockReportPosts { get; set; }

    public virtual DbSet<BoothAllocation> BoothAllocations { get; set; }

    public virtual DbSet<BoothBookingPayment> BoothBookingPayments { get; set; }

    public virtual DbSet<BoothBookingPaymentBak> BoothBookingPaymentBaks { get; set; }

    public virtual DbSet<BoothSalesUserAllocation> BoothSalesUserAllocations { get; set; }

    public virtual DbSet<CategoryType> CategoryTypes { get; set; }

    public virtual DbSet<ChatMst> ChatMsts { get; set; }

    public virtual DbSet<ChatTransaction> ChatTransactions { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassCategoryRelation> ClassCategoryRelations { get; set; }

    public virtual DbSet<ClassesDocument> ClassesDocuments { get; set; }

    public virtual DbSet<CommunityComment> CommunityComments { get; set; }

    public virtual DbSet<CommunityLikeMst> CommunityLikeMsts { get; set; }

    public virtual DbSet<CommunityPost> CommunityPosts { get; set; }

    public virtual DbSet<CommunityPostTransation> CommunityPostTransations { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyUserAllocation> CompanyUserAllocations { get; set; }

    public virtual DbSet<CompanyUserAllocationOld> CompanyUserAllocationOlds { get; set; }

    public virtual DbSet<Conference> Conferences { get; set; }

    public virtual DbSet<ConferenceAssociationAllocation> ConferenceAssociationAllocations { get; set; }

    public virtual DbSet<ConferenceAttendeePriceType> ConferenceAttendeePriceTypes { get; set; }

    public virtual DbSet<ConferenceBooth> ConferenceBooths { get; set; }

    public virtual DbSet<ConferenceBoothsOld> ConferenceBoothsOlds { get; set; }

    public virtual DbSet<ConferenceFeedbackQuestionAllocation> ConferenceFeedbackQuestionAllocations { get; set; }

    public virtual DbSet<ConferenceFloorPlan> ConferenceFloorPlans { get; set; }

    public virtual DbSet<ConferenceStoreItem> ConferenceStoreItems { get; set; }

    public virtual DbSet<ConferenceTestimonialVideoOrAudio> ConferenceTestimonialVideoOrAudios { get; set; }

    public virtual DbSet<ConferenceTestimonialVideoOrAudioAllocation> ConferenceTestimonialVideoOrAudioAllocations { get; set; }

    public virtual DbSet<CourseCategory> CourseCategories { get; set; }

    public virtual DbSet<CrmActivityMst> CrmActivityMsts { get; set; }

    public virtual DbSet<CrmAttachment> CrmAttachments { get; set; }

    public virtual DbSet<CrmContact> CrmContacts { get; set; }

    public virtual DbSet<CrmCustomerMst> CrmCustomerMsts { get; set; }

    public virtual DbSet<CrmDealMst> CrmDealMsts { get; set; }

    public virtual DbSet<CrmTaskMst> CrmTaskMsts { get; set; }

    public virtual DbSet<EmailPreference> EmailPreferences { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventBooking> EventBookings { get; set; }

    public virtual DbSet<EventBooth> EventBooths { get; set; }

    public virtual DbSet<EventOrganizerAllocation> EventOrganizerAllocations { get; set; }

    public virtual DbSet<EventPromotion> EventPromotions { get; set; }

    public virtual DbSet<EventsLog> EventsLogs { get; set; }

    public virtual DbSet<ExhibitorAssociationProductAllocation> ExhibitorAssociationProductAllocations { get; set; }

    public virtual DbSet<ExhibitorAttendeeInvoice> ExhibitorAttendeeInvoices { get; set; }

    public virtual DbSet<ExhibitorBoothAllocation> ExhibitorBoothAllocations { get; set; }

    public virtual DbSet<ExhibitorBoothAllocationBak> ExhibitorBoothAllocationBaks { get; set; }

    public virtual DbSet<ExhibitorBoothCompanyAllocation> ExhibitorBoothCompanyAllocations { get; set; }

    public virtual DbSet<ExhibitorBoothImport> ExhibitorBoothImports { get; set; }

    public virtual DbSet<ExhibitorPlatformFeesPayment> ExhibitorPlatformFeesPayments { get; set; }

    public virtual DbSet<ExhibitorProduct> ExhibitorProducts { get; set; }

    public virtual DbSet<ExhibitorProductDocument> ExhibitorProductDocuments { get; set; }

    public virtual DbSet<ExhibitorProductImage> ExhibitorProductImages { get; set; }

    public virtual DbSet<ExhibitorProfileView> ExhibitorProfileViews { get; set; }

    public virtual DbSet<ExhibitorSubscriptionAllocation> ExhibitorSubscriptionAllocations { get; set; }

    public virtual DbSet<ExhibitorSubscriptionPayment> ExhibitorSubscriptionPayments { get; set; }

    public virtual DbSet<FavouriteConference> FavouriteConferences { get; set; }

    public virtual DbSet<FsnasipMember> FsnasipMembers { get; set; }

    public virtual DbSet<Gallery> Galleries { get; set; }

    public virtual DbSet<Inquiry> Inquiries { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<MemberManagement> MemberManagements { get; set; }

    public virtual DbSet<MemberManagementAttendeeAllocation> MemberManagementAttendeeAllocations { get; set; }

    public virtual DbSet<MemberManagementAttendeeAllocationOld> MemberManagementAttendeeAllocationOlds { get; set; }

    public virtual DbSet<MemberManagementEventAllocation> MemberManagementEventAllocations { get; set; }

    public virtual DbSet<MemberManagementInvoice> MemberManagementInvoices { get; set; }

    public virtual DbSet<MemberManagementOld> MemberManagementOlds { get; set; }

    public virtual DbSet<MemberManagementPayment> MemberManagementPayments { get; set; }

    public virtual DbSet<MemberManagementUserEventAllocation> MemberManagementUserEventAllocations { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<NewAttendeeEventSessionAllocation> NewAttendeeEventSessionAllocations { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OneWorldSyncProduct> OneWorldSyncProducts { get; set; }

    public virtual DbSet<OneWorldSyncProductImage> OneWorldSyncProductImages { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PostType> PostTypes { get; set; }

    public virtual DbSet<PrivacyType> PrivacyTypes { get; set; }

    public virtual DbSet<ProductPrice> ProductPrices { get; set; }

    public virtual DbSet<ProductPromoCode> ProductPromoCodes { get; set; }

    public virtual DbSet<ProductRating> ProductRatings { get; set; }

    public virtual DbSet<ProductUserInteraction> ProductUserInteractions { get; set; }

    public virtual DbSet<PromoCode> PromoCodes { get; set; }

    public virtual DbSet<PromoCodeUserAllocation> PromoCodeUserAllocations { get; set; }

    public virtual DbSet<PublicNotification> PublicNotifications { get; set; }

    public virtual DbSet<PushToken> PushTokens { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionOption> QuestionOptions { get; set; }

    public virtual DbSet<ReceiveRequest> ReceiveRequests { get; set; }

    public virtual DbSet<RequestAcallUserInformation> RequestAcallUserInformations { get; set; }

    public virtual DbSet<RoleMenuAllocation> RoleMenuAllocations { get; set; }

    public virtual DbSet<RoleMst> RoleMsts { get; set; }

    public virtual DbSet<SalesRepresentative> SalesRepresentatives { get; set; }

    public virtual DbSet<SalesRepresentativesOld> SalesRepresentativesOlds { get; set; }

    public virtual DbSet<SalesRepresentativesOld1> SalesRepresentativesOlds1 { get; set; }

    public virtual DbSet<SchoolDistrict> SchoolDistricts { get; set; }

    public virtual DbSet<SchoolMst> SchoolMsts { get; set; }

    public virtual DbSet<SentRequest> SentRequests { get; set; }

    public virtual DbSet<SessionAttendance> SessionAttendances { get; set; }

    public virtual DbSet<SessionSpeakerAllocation> SessionSpeakerAllocations { get; set; }

    public virtual DbSet<Snamembership> Snamemberships { get; set; }

    public virtual DbSet<Speaker> Speakers { get; set; }

    public virtual DbSet<SpeakerRating> SpeakerRatings { get; set; }

    public virtual DbSet<SpeakerSpeechesAndTopicsAllocation> SpeakerSpeechesAndTopicsAllocations { get; set; }

    public virtual DbSet<SpeakerUploadedAttachment> SpeakerUploadedAttachments { get; set; }

    public virtual DbSet<StateInfo> StateInfos { get; set; }

    public virtual DbSet<StripeReview> StripeReviews { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SubscriptionConferenceAllocation> SubscriptionConferenceAllocations { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TemplateRequiredParameterMst> TemplateRequiredParameterMsts { get; set; }

    public virtual DbSet<TestUserMst> TestUserMsts { get; set; }

    public virtual DbSet<UsDistrictMst> UsDistrictMsts { get; set; }

    public virtual DbSet<UsSchoolsMst> UsSchoolsMsts { get; set; }

    public virtual DbSet<UserAdaallocation> UserAdaallocations { get; set; }

    public virtual DbSet<UserConferenceFeedback> UserConferenceFeedbacks { get; set; }

    public virtual DbSet<UserConferenceFeedbackQuestionAnswer> UserConferenceFeedbackQuestionAnswers { get; set; }

    public virtual DbSet<UserFollower> UserFollowers { get; set; }

    public virtual DbSet<UserMealAllocation> UserMealAllocations { get; set; }

    public virtual DbSet<UserMst> UserMsts { get; set; }

    public virtual DbSet<UserQuestionAnswer> UserQuestionAnswers { get; set; }

    public virtual DbSet<UserRoleAllocation> UserRoleAllocations { get; set; }

    public virtual DbSet<VwAttendeeReport> VwAttendeeReports { get; set; }

    public virtual DbSet<VwBoothsforOhio> VwBoothsforOhios { get; set; }

    public virtual DbSet<VwClassDetailWithSummary> VwClassDetailWithSummaries { get; set; }

    public virtual DbSet<VwSessionAttendeesWithSpecialNeed> VwSessionAttendeesWithSpecialNeeds { get; set; }

    public virtual DbSet<VwStripeReviewEmail> VwStripeReviewEmails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=dbswanprod.database.windows.net;Database=EventPlannerProduction;User Id=loadmin;Password=CMswan@dm1n;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutU>(entity =>
        {
            entity.HasKey(e => e.AboutUsId);

            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<AddressMst>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__AddressM__091C2AFBE5EC5BDB");

            entity.ToTable("AddressMst");

            entity.Property(e => e.AddressId).ValueGeneratedNever();
            entity.Property(e => e.AddressType).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Zip).HasMaxLength(200);
        });

        modelBuilder.Entity<AppUpdateVersion>(entity =>
        {
            entity.HasKey(e => e.VersionId).HasName("PK__AppUpdat__16C6400F08E608AD");

            entity.ToTable("AppUpdateVersion");

            entity.Property(e => e.VersionId).ValueGeneratedNever();
            entity.Property(e => e.AndroidPlayStoreUrl).HasMaxLength(150);
            entity.Property(e => e.AndroidUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.AndroidVersionCode).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IosappStoreUrl)
                .HasMaxLength(150)
                .HasColumnName("IOSAppStoreUrl");
            entity.Property(e => e.IosupdateDate)
                .HasColumnType("datetime")
                .HasColumnName("IOSUpdateDate");
            entity.Property(e => e.IosversionCode)
                .HasMaxLength(150)
                .HasColumnName("IOSVersionCode");
        });

        modelBuilder.Entity<Association>(entity =>
        {
            entity.ToTable("Association");

            entity.Property(e => e.AssociationId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(250);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PaymentCity).HasMaxLength(100);
            entity.Property(e => e.PaymentRemittanceAddress).HasMaxLength(1000);
            entity.Property(e => e.PaymentState).HasMaxLength(100);
            entity.Property(e => e.PaymentZip).HasMaxLength(20);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PublicKey).HasMaxLength(250);
            entity.Property(e => e.SecretKey).HasMaxLength(250);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Website).HasMaxLength(100);
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<AssociationAdminAllocation>(entity =>
        {
            entity.ToTable("AssociationAdminAllocation");

            entity.Property(e => e.AssociationAdminAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationAllocation>(entity =>
        {
            entity.ToTable("AssociationAllocation");

            entity.HasIndex(e => new { e.IsActive, e.AssociationId }, "nci_msft_1_AssociationAllocation_641791C9FF8BA4D1677445AB38C3FE10");

            entity.Property(e => e.AssociationAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationInvoice>(entity =>
        {
            entity.ToTable("AssociationInvoice");

            entity.Property(e => e.AssociationInvoiceId).ValueGeneratedNever();
            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.CheckNumber).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CompleteDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.InvoiceInstructions).HasMaxLength(1000);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(100);
            entity.Property(e => e.ReceivedPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ZipCode).HasMaxLength(10);
        });

        modelBuilder.Entity<AssociationMember>(entity =>
        {
            entity.HasKey(e => e.AssociationMembersId);

            entity.Property(e => e.AssociationMembersId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Leaid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEAID");
            entity.Property(e => e.MealRequirements).HasMaxLength(100);
            entity.Property(e => e.MemberNumber).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.TshirtSize)
                .HasMaxLength(50)
                .HasColumnName("TShirtSize");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<AssociationMembersAdminAllocation>(entity =>
        {
            entity.ToTable("AssociationMembersAdminAllocation");

            entity.Property(e => e.AssociationMembersAdminAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationMembersTypeAllocation>(entity =>
        {
            entity.ToTable("AssociationMembersTypeAllocation");

            entity.HasIndex(e => new { e.IsActive, e.UserId }, "nci_msft_1_AssociationMembersTypeAllocation_998F2AE23637DFD23585D074240EDC26");

            entity.HasIndex(e => new { e.AssociationMembersId, e.IsActive }, "nci_msft_1_AssociationMembersTypeAllocation_C4E72DA1DF3B7D00F595A4AEBD70B655");

            entity.Property(e => e.AssociationMembersTypeAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationMembershipsType>(entity =>
        {
            entity.HasKey(e => e.AssociationMembershipsTypesId);

            entity.Property(e => e.AssociationMembershipsTypesId).ValueGeneratedNever();
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Frequency).HasMaxLength(100);
            entity.Property(e => e.MembershipType).HasMaxLength(25);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationPayment>(entity =>
        {
            entity.ToTable("AssociationPayment");

            entity.Property(e => e.AssociationPaymentId).ValueGeneratedNever();
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMode).HasMaxLength(10);
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.RegisterType).HasMaxLength(25);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationPaymentCompanyAllocation>(entity =>
        {
            entity.ToTable("AssociationPaymentCompanyAllocation");

            entity.Property(e => e.AssociationPaymentCompanyAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationPaymentUserAllocation>(entity =>
        {
            entity.ToTable("AssociationPaymentUserAllocation");

            entity.Property(e => e.AssociationPaymentUserAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProduct>(entity =>
        {
            entity.ToTable("AssociationProduct");

            entity.Property(e => e.AssociationProductId).ValueGeneratedNever();
            entity.Property(e => e.BrandName).HasMaxLength(200);
            entity.Property(e => e.CategoryName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountedType).HasMaxLength(20);
            entity.Property(e => e.DiscountedValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Glnnumber)
                .HasMaxLength(200)
                .HasColumnName("GLNNumber");
            entity.Property(e => e.Gtin)
                .HasMaxLength(200)
                .HasColumnName("GTIN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProductName).HasMaxLength(500);
            entity.Property(e => e.SubCategoryName).HasMaxLength(100);
            entity.Property(e => e.TotalProductPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Upc)
                .HasMaxLength(200)
                .HasColumnName("UPC");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductBenefit>(entity =>
        {
            entity.ToTable("AssociationProductBenefit");

            entity.Property(e => e.AssociationProductBenefitId).ValueGeneratedNever();
            entity.Property(e => e.BenefitTitle).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductDocument>(entity =>
        {
            entity.HasKey(e => e.AssociationaProductDocumentsId);

            entity.Property(e => e.AssociationaProductDocumentsId).ValueGeneratedNever();
            entity.Property(e => e.AttachmentExtension).HasMaxLength(50);
            entity.Property(e => e.AttachmentType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductImage>(entity =>
        {
            entity.HasKey(e => e.AssociationProductImageId).HasName("PK__Associat__4ED8583D9609EC1B");

            entity.ToTable("AssociationProductImage");

            entity.Property(e => e.AssociationProductImageId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductInvoice>(entity =>
        {
            entity.ToTable("AssociationProductInvoice");

            entity.Property(e => e.AssociationProductInvoiceId).ValueGeneratedNever();
            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.CheckNumber).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CompleteDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.InvoiceInstructions).HasMaxLength(1000);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(100);
            entity.Property(e => e.ReceivedPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ZipCode).HasMaxLength(10);
        });

        modelBuilder.Entity<AssociationProductPayment>(entity =>
        {
            entity.ToTable("AssociationProductPayment");

            entity.Property(e => e.AssociationProductPaymentId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderNumber).HasMaxLength(20);
            entity.Property(e => e.PaymentMode).HasMaxLength(10);
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.ShippingAddress).HasMaxLength(15);
            entity.Property(e => e.ShippingAddressType).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<AssociationProductRating>(entity =>
        {
            entity.HasKey(e => e.AssociationProductRatingId).HasName("PK__Associat__F2BB910CEA25E471");

            entity.ToTable("AssociationProductRating");

            entity.Property(e => e.AssociationProductRatingId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductUserAllocation>(entity =>
        {
            entity.ToTable("AssociationProductUserAllocation");

            entity.Property(e => e.AssociationProductUserAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductUserInteraction>(entity =>
        {
            entity.HasKey(e => e.AssociationProductUserInteractionId).HasName("PK__Associat__9CED665EAD31E457");

            entity.ToTable("AssociationProductUserInteraction");

            entity.Property(e => e.AssociationProductUserInteractionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(25);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationProductUserPromoCodeAllocation>(entity =>
        {
            entity.ToTable("AssociationProductUserPromoCodeAllocation");

            entity.Property(e => e.AssociationProductUserPromoCodeAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssociationStore>(entity =>
        {
            entity.ToTable("AssociationStore");

            entity.Property(e => e.AssociationStoreId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.StoreName).HasMaxLength(200);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AttendeeEventSessionAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttendeeEventSessionAllocation");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.SessionFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<AttendeeFavoriteProduct>(entity =>
        {
            entity.ToTable("AttendeeFavoriteProduct");

            entity.Property(e => e.AttendeeFavoriteProductId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LeadStatus).HasMaxLength(30);
            entity.Property(e => e.OtherAssociationMembersName).HasMaxLength(250);
            entity.Property(e => e.RequestAcallUserInformationId).HasColumnName("RequestACallUserInformationId");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AttendeePayment>(entity =>
        {
            entity.HasKey(e => e.AttendeePaymentId).HasName("PK_AttendeeEventsPayment");

            entity.Property(e => e.AttendeePaymentId).ValueGeneratedNever();
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber).HasMaxLength(20);
            entity.Property(e => e.ChequeStatus).HasMaxLength(10);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(10);
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserType).HasMaxLength(20);
        });

        modelBuilder.Entity<AttendeePurchaseStoreItemsAllocation>(entity =>
        {
            entity.ToTable("AttendeePurchaseStoreItemsAllocation");

            entity.Property(e => e.AttendeePurchaseStoreItemsAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AttendeeReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AttendeeReport");

            entity.Property(e => e.AdaDietaryRestrictions).HasMaxLength(1002);
            entity.Property(e => e.CheckNumber).HasMaxLength(30);
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CustomerEmail).HasMaxLength(150);
            entity.Property(e => e.CustomerName).HasMaxLength(91);
            entity.Property(e => e.DatePaid).HasColumnType("datetime");
            entity.Property(e => e.DateRegistered).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("PONumber");
            entity.Property(e => e.PurchaseType).HasMaxLength(1000);
            entity.Property(e => e.RefundStatus)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RegisteredBy).HasMaxLength(91);
            entity.Property(e => e.SessionEndDate).HasMaxLength(20);
            entity.Property(e => e.SessionLocation).HasMaxLength(50);
            entity.Property(e => e.SessionStartDate).HasColumnType("datetime");
            entity.Property(e => e.SessionTitle).HasMaxLength(150);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AttendeeSchedule>(entity =>
        {
            entity.ToTable("AttendeeSchedule");

            entity.Property(e => e.AttendeeScheduleId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(20);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Benefit>(entity =>
        {
            entity.ToTable("Benefit");

            entity.Property(e => e.BenefitId).ValueGeneratedNever();
            entity.Property(e => e.BenefitTitle).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlockPostCategory>(entity =>
        {
            entity.HasKey(e => e.BlockPostCategoryId).HasName("PK__BlockPos__4427A7165F1F3691");

            entity.ToTable("BlockPostCategory");

            entity.Property(e => e.BlockPostCategoryId).ValueGeneratedNever();
            entity.Property(e => e.BlockPostCategoryName).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlockReportPost>(entity =>
        {
            entity.HasKey(e => e.PostBlockReportId).HasName("PK__BlockRep__F3E8156AB407FDF5");

            entity.ToTable("BlockReportPost");

            entity.Property(e => e.PostBlockReportId).ValueGeneratedNever();
            entity.Property(e => e.PostType).HasMaxLength(150);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BoothAllocation>(entity =>
        {
            entity.ToTable("BoothAllocation");

            entity.Property(e => e.BoothAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BoothBookingPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BoothBookingPayment");

            entity.Property(e => e.BoothAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber).HasMaxLength(20);
            entity.Property(e => e.ChequeStatus).HasMaxLength(10);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EventAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentFees).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(10);
            entity.Property(e => e.PaymentPlatfom).HasMaxLength(50);
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(50);
            entity.Property(e => e.ProductAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserType).HasMaxLength(20);
        });

        modelBuilder.Entity<BoothBookingPaymentBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BoothBookingPaymentBAK");

            entity.Property(e => e.BoothAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChequeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EventAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<BoothSalesUserAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BoothSalesUserAllocation");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SalesRepresentativeType).HasMaxLength(20);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoryType>(entity =>
        {
            entity.HasKey(e => e.CategoryTypeId).HasName("PK_CategoryTypes_1");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ChatMst>(entity =>
        {
            entity.HasKey(e => e.ChatId).HasName("PK__ChatMst__A9FBE7C6841E91E1");

            entity.ToTable("ChatMst");

            entity.Property(e => e.ChatId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.StartedOnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChatTransaction>(entity =>
        {
            entity.ToTable("ChatTransaction");

            entity.Property(e => e.ChatTransactionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.MessageType).HasMaxLength(50);
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassesId);

            entity.Property(e => e.ClassesId).ValueGeneratedNever();
            entity.Property(e => e.Ceus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClassesStartdate).HasColumnType("datetime");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasMaxLength(20);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Learningobjective).HasMaxLength(50);
            entity.Property(e => e.MeetingRoomNumber).HasMaxLength(50);
            entity.Property(e => e.QrcodeImageUrl).HasColumnName("QRCodeImageURL");
            entity.Property(e => e.StartTime).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceCode).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.TrainingTopic).HasMaxLength(50);
        });

        modelBuilder.Entity<ClassCategoryRelation>(entity =>
        {
            entity.ToTable("ClassCategoryRelation");

            entity.Property(e => e.ClassCategoryRelationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClassesDocument>(entity =>
        {
            entity.HasKey(e => e.ClassesDocumnetId);

            entity.ToTable("ClassesDocument");

            entity.Property(e => e.ClassesDocumnetId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentType).HasMaxLength(500);
            entity.Property(e => e.FileLength).HasMaxLength(500);
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.FileType).HasMaxLength(500);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CommunityComment>(entity =>
        {
            entity.ToTable("CommunityComment");

            entity.Property(e => e.CommunityCommentId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CommunityLikeMst>(entity =>
        {
            entity.HasKey(e => e.CommunityLikeId).HasName("PK__Communit__82AC6552CCE845D2");

            entity.ToTable("CommunityLikeMst");

            entity.Property(e => e.CommunityLikeId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CommunityPost>(entity =>
        {
            entity.ToTable("CommunityPost");

            entity.Property(e => e.CommunityPostId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CommunityPostTransation>(entity =>
        {
            entity.HasKey(e => e.CommunityPostTransactionId).HasName("PK__Communit__4BC8BA1472E9802B");

            entity.Property(e => e.CommunityPostTransactionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.HasIndex(e => new { e.CreatedBy, e.IsActive, e.CompanyType }, "nci_msft_1_Company_BD0373D604CC04DE9C2280C75F4436B9");

            entity.Property(e => e.CompanyId).ValueGeneratedNever();
            entity.Property(e => e.AlternateContactName).HasMaxLength(100);
            entity.Property(e => e.AlternateEmailId).HasMaxLength(150);
            entity.Property(e => e.AlternatePhoneNumber).HasMaxLength(20);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(300);
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CompanyProductCategory).HasMaxLength(50);
            entity.Property(e => e.CompanyType).HasMaxLength(30);
            entity.Property(e => e.ContactName).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Glnnumber)
                .HasMaxLength(30)
                .HasColumnName("GLNNumber");
            entity.Property(e => e.IsApproved).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(300);
            entity.Property(e => e.Website).HasMaxLength(100);
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<CompanyUserAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyUserAllocation");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CompanyUserAllocationOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyUserAllocationOld");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Conference>(entity =>
        {
            entity.ToTable("Conference");

            entity.Property(e => e.ConferenceId).ValueGeneratedNever();
            entity.Property(e => e.AccountNumber).HasMaxLength(20);
            entity.Property(e => e.AttendeeFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankRoutingNumber).HasMaxLength(20);
            entity.Property(e => e.BookingStartDate).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(250);
            entity.Property(e => e.ConferenceAddress).HasMaxLength(50);
            entity.Property(e => e.ConferenceEnddate).HasColumnType("datetime");
            entity.Property(e => e.ConferenceName).HasMaxLength(50);
            entity.Property(e => e.ConferenceStartdate).HasColumnType("datetime");
            entity.Property(e => e.ConferenceWebsite).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(45);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.ExhibitorFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PriceType).HasMaxLength(15);
            entity.Property(e => e.PublicKey).HasMaxLength(250);
            entity.Property(e => e.SecretKey).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VideoAudioDescription).HasMaxLength(2000);
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.Zip).HasMaxLength(150);
        });

        modelBuilder.Entity<ConferenceAssociationAllocation>(entity =>
        {
            entity.ToTable("ConferenceAssociationAllocation");

            entity.Property(e => e.ConferenceAssociationAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ConferenceAttendeePriceType>(entity =>
        {
            entity.HasKey(e => e.ConferenceAttendeePriceTypeId).HasName("PK__Conferen__E4ED74F881D4A481");

            entity.ToTable("ConferenceAttendeePriceType");

            entity.Property(e => e.ConferenceAttendeePriceTypeId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ConferenceBooth>(entity =>
        {
            entity.HasKey(e => e.ConferenceBoothsId);

            entity.Property(e => e.ConferenceBoothsId).ValueGeneratedNever();
            entity.Property(e => e.BoothStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Hight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PositionX).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PositionY).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SeatEventNumber).HasMaxLength(20);
            entity.Property(e => e.SeatTextNumber).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(10);
            entity.Property(e => e.Width)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("width");
        });

        modelBuilder.Entity<ConferenceBoothsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConferenceBoothsOld");

            entity.Property(e => e.BoothStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Hight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PositionX).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PositionY).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SeatEventNumber).HasMaxLength(20);
            entity.Property(e => e.SeatTextNumber).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(10);
            entity.Property(e => e.Width)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("width");
        });

        modelBuilder.Entity<ConferenceFeedbackQuestionAllocation>(entity =>
        {
            entity.ToTable("ConferenceFeedbackQuestionAllocation");

            entity.Property(e => e.ConferenceFeedbackQuestionAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SendUserType).HasMaxLength(20);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ConferenceFloorPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConferenceFloorPlan");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.FloorPlanTitle).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ConferenceStoreItem>(entity =>
        {
            entity.HasKey(e => e.ConferenceStoreItemsId);

            entity.Property(e => e.ConferenceStoreItemsId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ConferenceTestimonialVideoOrAudio>(entity =>
        {
            entity.ToTable("ConferenceTestimonialVideoOrAudio");

            entity.Property(e => e.ConferenceTestimonialVideoOrAudioId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.SchoolDistrictOrOrganization).HasMaxLength(200);
        });

        modelBuilder.Entity<ConferenceTestimonialVideoOrAudioAllocation>(entity =>
        {
            entity.ToTable("ConferenceTestimonialVideoOrAudioAllocation");

            entity.Property(e => e.ConferenceTestimonialVideoOrAudioAllocationId).ValueGeneratedNever();
            entity.Property(e => e.AttachmentExtension).HasMaxLength(50);
            entity.Property(e => e.AttachmentTitle).HasMaxLength(250);
            entity.Property(e => e.AttachmentType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CourseCategory>(entity =>
        {
            entity.ToTable("CourseCategory");

            entity.HasIndex(e => e.CategoryTypeId, "IX_CourseCategory_CategoryTypeId");

            entity.Property(e => e.CourseCategoryId).ValueGeneratedNever();
            entity.Property(e => e.CourseCategoryCode).HasMaxLength(50);
            entity.Property(e => e.CourseCategoryName).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CategoryType).WithMany(p => p.CourseCategories)
                .HasForeignKey(d => d.CategoryTypeId)
                .HasConstraintName("FK_CourseCategory_CategoryTypes");
        });

        modelBuilder.Entity<CrmActivityMst>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK__CRM_Acti__45F4A7910349B3C7");

            entity.ToTable("CRM_ActivityMst");

            entity.Property(e => e.ActivityId).ValueGeneratedNever();
            entity.Property(e => e.ActivityDate).HasColumnType("datetime");
            entity.Property(e => e.ActivityTime).HasColumnType("datetime");
            entity.Property(e => e.ActivityType).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CrmAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PK__CRM_Atta__442C64BE36D5BD19");

            entity.ToTable("CRM_Attachment");

            entity.Property(e => e.AttachmentId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageName).HasMaxLength(500);
            entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CrmContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__CRM_Cont__5C66259BF55655CB");

            entity.ToTable("CRM_Contact");

            entity.Property(e => e.ContactId).ValueGeneratedNever();
            entity.Property(e => e.ContactOwner).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.IsAllowYourTeamMarketContact).HasColumnName("IsAllowYourTeamMArketContact");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.PhoneNo).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CrmCustomerMst>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__CRM_Cust__A4AE64D8B017369D");

            entity.ToTable("CRM_CustomerMst");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.Addess).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.ContactNo).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.MainContactEmail).HasMaxLength(200);
            entity.Property(e => e.MainContactMobileNo).HasMaxLength(200);
            entity.Property(e => e.MainContactName).HasMaxLength(200);
            entity.Property(e => e.MainContactOfficeNo).HasMaxLength(200);
            entity.Property(e => e.MainContactOtherNo).HasMaxLength(200);
            entity.Property(e => e.MainContactTitle).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.WebSite).HasMaxLength(200);
            entity.Property(e => e.ZipCode).HasMaxLength(200);
        });

        modelBuilder.Entity<CrmDealMst>(entity =>
        {
            entity.HasKey(e => e.DealId).HasName("PK__CRM_Deal__E5B281667ACD6D51");

            entity.ToTable("CRM_DealMst");

            entity.Property(e => e.DealId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealName).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CrmTaskMst>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__CRM_Task__7C6949B10C5A8998");

            entity.ToTable("CRM_TaskMst");

            entity.Property(e => e.TaskId).ValueGeneratedNever();
            entity.Property(e => e.ContactName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeadLineDate).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(200);
            entity.Property(e => e.TaskName).HasMaxLength(200);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmailPreference>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__EmailPre__1788CC4C546EA7AB");

            entity.ToTable("EmailPreference");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorId);

            entity.ToTable("ErrorLog");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Events__7944C81039A5A1D5");

            entity.Property(e => e.EventId).ValueGeneratedNever();
            entity.Property(e => e.AttendeeFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ContactName).HasMaxLength(45);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.EndTime).HasMaxLength(20);
            entity.Property(e => e.EventEnddate).HasColumnType("datetime");
            entity.Property(e => e.EventName).HasMaxLength(50);
            entity.Property(e => e.EventStartdate).HasColumnType("datetime");
            entity.Property(e => e.EventWebsite).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PriceType).HasMaxLength(15);
            entity.Property(e => e.QrcodeImageUrl).HasColumnName("QRCodeImageURL");
            entity.Property(e => e.StartTime).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EventBooking>(entity =>
        {
            entity.ToTable("EventBooking");

            entity.Property(e => e.EventBookingId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserType).HasMaxLength(20);
        });

        modelBuilder.Entity<EventBooth>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BoothStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Hight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PositionX).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PositionY).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SeatEventNumber).HasMaxLength(20);
            entity.Property(e => e.SeatTextNumber).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(10);
            entity.Property(e => e.Width).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<EventOrganizerAllocation>(entity =>
        {
            entity.ToTable("EventOrganizerAllocation");

            entity.Property(e => e.EventOrganizerAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EventPromotion>(entity =>
        {
            entity.HasKey(e => e.EventPromotionId).HasName("PK_EventPromotiona");

            entity.Property(e => e.EventPromotionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.Type).HasMaxLength(20);
        });

        modelBuilder.Entity<EventsLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EventsLog");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LogId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("LogID");
            entity.Property(e => e.SentOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(500);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ExhibitorAssociationProductAllocation>(entity =>
        {
            entity.ToTable("ExhibitorAssociationProductAllocation");

            entity.Property(e => e.ExhibitorAssociationProductAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorAttendeeInvoice>(entity =>
        {
            entity.ToTable("ExhibitorAttendeeInvoice");

            entity.Property(e => e.ExhibitorAttendeeInvoiceId).ValueGeneratedNever();
            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.ApproveOrRejecteDate).HasColumnType("datetime");
            entity.Property(e => e.CheckNumber).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.InvoiceInstructions).HasMaxLength(1000);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(100);
            entity.Property(e => e.ReceivedPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserType).HasMaxLength(20);
            entity.Property(e => e.ZipCode).HasMaxLength(10);
        });

        modelBuilder.Entity<ExhibitorBoothAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExhibitorBoothAllocation");

            entity.Property(e => e.BoothStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorBoothAllocationBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExhibitorBoothAllocationBAK");

            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ExhibitorBoothCompanyAllocation>(entity =>
        {
            entity.ToTable("ExhibitorBoothCompanyAllocation");

            entity.Property(e => e.ExhibitorBoothCompanyAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorBoothImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExhibitorBoothImport");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.BoothBookingPaymentId).HasColumnName("BoothBookingPaymentID");
            entity.Property(e => e.BoothCount).HasMaxLength(150);
            entity.Property(e => e.BoothFee).HasColumnType("money");
            entity.Property(e => e.BoothNumber).HasMaxLength(150);
            entity.Property(e => e.BrokerCompany).HasMaxLength(150);
            entity.Property(e => e.BrokerContactName)
                .HasMaxLength(150)
                .HasColumnName("Broker_Contact_Name");
            entity.Property(e => e.BrokerEmail).HasMaxLength(250);
            entity.Property(e => e.BrokerUserId).HasColumnName("BrokerUserID");
            entity.Property(e => e.CompanyContactAtExpo).HasMaxLength(150);
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.ConferenceId).HasColumnName("ConferenceID");
            entity.Property(e => e.ContactName).HasMaxLength(150);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FigboothGuidid).HasColumnName("FIGBoothGUIDId");
            entity.Property(e => e.LogoFile)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(150);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ExhibitorPlatformFeesPayment>(entity =>
        {
            entity.ToTable("ExhibitorPlatformFeesPayment");

            entity.Property(e => e.ExhibitorPlatformFeesPaymentId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorProduct>(entity =>
        {
            entity.ToTable("ExhibitorProduct");

            entity.Property(e => e.ExhibitorProductId).ValueGeneratedNever();
            entity.Property(e => e.BrandName).HasMaxLength(200);
            entity.Property(e => e.CategoryName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Glnnumber)
                .HasMaxLength(200)
                .HasColumnName("GLNNumber");
            entity.Property(e => e.Gtin)
                .HasMaxLength(200)
                .HasColumnName("GTIN");
            entity.Property(e => e.ProductName).HasMaxLength(500);
            entity.Property(e => e.Upc)
                .HasMaxLength(200)
                .HasColumnName("UPC");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorProductDocument>(entity =>
        {
            entity.HasKey(e => e.ExhibitorProductDocumentsId);

            entity.Property(e => e.ExhibitorProductDocumentsId).ValueGeneratedNever();
            entity.Property(e => e.AttachmentExtension).HasMaxLength(50);
            entity.Property(e => e.AttachmentType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorProductImage>(entity =>
        {
            entity.ToTable("ExhibitorProductImage");

            entity.Property(e => e.ExhibitorProductImageId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorProfileView>(entity =>
        {
            entity.ToTable("ExhibitorProfileView");

            entity.Property(e => e.ExhibitorProfileViewId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserType).HasMaxLength(15);
        });

        modelBuilder.Entity<ExhibitorSubscriptionAllocation>(entity =>
        {
            entity.ToTable("ExhibitorSubscriptionAllocation");

            entity.Property(e => e.ExhibitorSubscriptionAllocationId).ValueGeneratedNever();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExhibitorSubscriptionPayment>(entity =>
        {
            entity.ToTable("ExhibitorSubscriptionPayment");

            entity.Property(e => e.ExhibitorSubscriptionPaymentId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FavouriteConference>(entity =>
        {
            entity.ToTable("FavouriteConference");

            entity.Property(e => e.FavouriteConferenceId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<FsnasipMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FSNASipMember");

            entity.Property(e => e.BrokerCompany)
                .HasMaxLength(150)
                .HasColumnName("Broker_Company");
            entity.Property(e => e.BrokerContact)
                .HasMaxLength(150)
                .HasColumnName("Broker_Contact");
            entity.Property(e => e.BrokerEmail)
                .HasMaxLength(100)
                .HasColumnName("Broker_Email");
            entity.Property(e => e.BrokerPhone)
                .HasMaxLength(100)
                .HasColumnName("Broker_Phone");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SipContact)
                .HasMaxLength(100)
                .HasColumnName("SIP_Contact");
            entity.Property(e => e.SipMember)
                .HasMaxLength(100)
                .HasColumnName("SIP_Member");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<Gallery>(entity =>
        {
            entity.ToTable("Gallery");

            entity.Property(e => e.GalleryId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Inquiry>(entity =>
        {
            entity.HasKey(e => e.InquiryId).HasName("PK__Inquiry__05E6E7CF7806CA09");

            entity.ToTable("Inquiry");

            entity.Property(e => e.InquiryId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolDistrictName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoicesId).HasName("PK__Invoices__88AF57379E8D3AA6");

            entity.Property(e => e.InvoicesId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(100);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatesOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagement>(entity =>
        {
            entity.ToTable("MemberManagement");

            entity.Property(e => e.MemberManagementId).ValueGeneratedNever();
            entity.Property(e => e.ConferenceMembersPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.OrganizationOrAttendeeType).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(120);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagementAttendeeAllocation>(entity =>
        {
            entity.HasKey(e => e.MemberManagementAttendeeAllocationId).HasName("PK__MemberMa__ECBBE0575DE15F78");

            entity.ToTable("MemberManagementAttendeeAllocation");

            entity.Property(e => e.MemberManagementAttendeeAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagementAttendeeAllocationOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberManagementAttendeeAllocation_Old");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagementEventAllocation>(entity =>
        {
            entity.ToTable("MemberManagementEventAllocation");

            entity.Property(e => e.MemberManagementEventAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EventPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type).HasMaxLength(10);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagementInvoice>(entity =>
        {
            entity.ToTable("MemberManagementInvoice");

            entity.Property(e => e.MemberManagementInvoiceId).ValueGeneratedNever();
            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.CheckNumber).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CompleteDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.InvoiceInstructions).HasMaxLength(1000);
            entity.Property(e => e.InvoiceStatus).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(100);
            entity.Property(e => e.ReceivedPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ZipCode).HasMaxLength(10);
        });

        modelBuilder.Entity<MemberManagementOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberManagement_Old");

            entity.Property(e => e.ConferenceMembersPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.OrganizationOrAttendeeType).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(120);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagementPayment>(entity =>
        {
            entity.ToTable("MemberManagementPayment");

            entity.Property(e => e.MemberManagementPaymentId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMode).HasMaxLength(10);
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemberManagementUserEventAllocation>(entity =>
        {
            entity.ToTable("MemberManagementUserEventAllocation");

            entity.Property(e => e.MemberManagementUserEventAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.MenuDescription).HasMaxLength(50);
            entity.Property(e => e.MenuIcon).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<NewAttendeeEventSessionAllocation>(entity =>
        {
            entity.HasKey(e => e.SessionAllocationId);

            entity.ToTable("NewAttendeeEventSessionAllocation");

            entity.Property(e => e.SessionAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.SessionFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.Property(e => e.NotificationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.NotificationType).HasMaxLength(150);
        });

        modelBuilder.Entity<OneWorldSyncProduct>(entity =>
        {
            entity.ToTable("OneWorldSyncProduct");

            entity.Property(e => e.BrandName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CategoryName).HasMaxLength(200);
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.Glnnumber)
                .HasMaxLength(200)
                .HasColumnName("GLNNumber");
            entity.Property(e => e.Gtin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GTIN");
            entity.Property(e => e.Modifiedon).HasColumnType("datetime");
            entity.Property(e => e.SubCategory1Name).HasMaxLength(200);
            entity.Property(e => e.SubCategory2Name).HasMaxLength(200);
            entity.Property(e => e.Upc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UPC");
            entity.Property(e => e.Vendor).HasMaxLength(200);
        });

        modelBuilder.Entity<OneWorldSyncProductImage>(entity =>
        {
            entity.ToTable("OneWorldSyncProductImage");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(200)
                .HasColumnName("ImageURL");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentFees).HasMaxLength(50);
            entity.Property(e => e.PaymentPlatfom).HasMaxLength(50);
            entity.Property(e => e.PaymentReference).HasMaxLength(1000);
            entity.Property(e => e.PaymentStatus).HasMaxLength(50);
            entity.Property(e => e.UserType).HasMaxLength(25);
        });

        modelBuilder.Entity<PostType>(entity =>
        {
            entity.HasKey(e => e.PostTypeId).HasName("PK__PostType__AB2125F027CE7B34");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PostType1)
                .HasMaxLength(250)
                .HasColumnName("PostType");
        });

        modelBuilder.Entity<PrivacyType>(entity =>
        {
            entity.ToTable("PrivacyType");

            entity.Property(e => e.PrivacyTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductPrice>(entity =>
        {
            entity.ToTable("ProductPrice");

            entity.Property(e => e.ProductPriceId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SubscriptionBase).HasMaxLength(100);
            entity.Property(e => e.SubscriptionType).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductPromoCode>(entity =>
        {
            entity.ToTable("ProductPromoCode");

            entity.Property(e => e.ProductPromoCodeId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.MinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductPromoCode1)
                .HasMaxLength(30)
                .HasColumnName("ProductPromoCode");
            entity.Property(e => e.PromoTitle).HasMaxLength(100);
            entity.Property(e => e.PromoType).HasMaxLength(15);
            entity.Property(e => e.PromoValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductRating>(entity =>
        {
            entity.ToTable("ProductRating");

            entity.Property(e => e.ProductRatingId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductUserInteraction>(entity =>
        {
            entity.ToTable("ProductUserInteraction");

            entity.Property(e => e.ProductUserInteractionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(25);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PromoCode>(entity =>
        {
            entity.ToTable("PromoCode");

            entity.Property(e => e.PromoCodeId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.MinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PromoCode1)
                .HasMaxLength(30)
                .HasColumnName("PromoCode");
            entity.Property(e => e.PromoTitle).HasMaxLength(100);
            entity.Property(e => e.PromoType).HasMaxLength(15);
            entity.Property(e => e.PromoValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(30);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PromoCodeUserAllocation>(entity =>
        {
            entity.ToTable("PromoCodeUserAllocation");

            entity.Property(e => e.PromoCodeUserAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PublicNotification>(entity =>
        {
            entity.HasKey(e => e.PublicNotificationId).HasName("PK__PublicNo__6B6C2FB8737D1032");

            entity.ToTable("PublicNotification");

            entity.Property(e => e.PublicNotificationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EventName).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PushToken>(entity =>
        {
            entity.HasKey(e => e.PushToeknId).HasName("PK__PushToke__68D4868D2EEF2FC1");

            entity.Property(e => e.PushToeknId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasMaxLength(100);
            entity.Property(e => e.PushToken1).HasColumnName("PushToken");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06FACAB118CBE");

            entity.ToTable("Question");

            entity.Property(e => e.QuestionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.QuestionCategory).HasMaxLength(50);
            entity.Property(e => e.QuestionTitle).HasMaxLength(300);
            entity.Property(e => e.QuestionType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<QuestionOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PK__Question__92C7A1FFBF4B7099");

            entity.ToTable("QuestionOption");

            entity.Property(e => e.OptionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Option)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiveRequest>(entity =>
        {
            entity.HasKey(e => e.ReceivedRequestId).HasName("PK__ReceiveR__27B84E5BFFA701F9");

            entity.ToTable("ReceiveRequest");

            entity.Property(e => e.ReceivedRequestId)
                .ValueGeneratedNever()
                .HasColumnName("ReceivedRequestID");
            entity.Property(e => e.CancelReceiveRequestOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<RequestAcallUserInformation>(entity =>
        {
            entity.HasKey(e => e.RequestAcallUserInformationId).HasName("PK__RequestA__BC905E081E4DDB80");

            entity.ToTable("RequestACallUserInformation");

            entity.Property(e => e.RequestAcallUserInformationId)
                .ValueGeneratedNever()
                .HasColumnName("RequestACallUserInformationId");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.OtherAssociationMemberName).HasMaxLength(250);
            entity.Property(e => e.OtherConferenceName).HasMaxLength(250);
            entity.Property(e => e.Phone).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RoleMenuAllocation>(entity =>
        {
            entity.ToTable("RoleMenuAllocation");

            entity.Property(e => e.RoleMenuAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RoleMst>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_Event_Role");

            entity.ToTable("RoleMst");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesRepresentative>(entity =>
        {
            entity.HasKey(e => e.SalesRepresentativesId);

            entity.Property(e => e.SalesRepresentativesId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SalesRepresentativesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesRepresentatives_Old");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SalesRepresentativesOld1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesRepresentativesOld");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SchoolDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SchoolDistrict");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictName).HasMaxLength(150);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.SiteCode).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(100);
        });

        modelBuilder.Entity<SchoolMst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SchoolMst");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.SchoolName).HasMaxLength(250);
        });

        modelBuilder.Entity<SentRequest>(entity =>
        {
            entity.ToTable("SentRequest");

            entity.Property(e => e.SentRequestId)
                .ValueGeneratedNever()
                .HasColumnName("SentRequestID");
            entity.Property(e => e.AcceptedSentRequestOn).HasColumnType("datetime");
            entity.Property(e => e.CancelSentRequestOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<SessionAttendance>(entity =>
        {
            entity.ToTable("SessionAttendance");

            entity.Property(e => e.SessionAttendanceId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasMaxLength(200);
            entity.Property(e => e.DeviceName).HasMaxLength(200);
            entity.Property(e => e.SessionDate).HasColumnType("datetime");
            entity.Property(e => e.SessionEventType).HasMaxLength(15);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TypeOfUser).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SessionSpeakerAllocation>(entity =>
        {
            entity.ToTable("SessionSpeakerAllocation");

            entity.Property(e => e.SessionSpeakerAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Snamembership>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SNAMembership");

            entity.Property(e => e.CertExpDate).HasColumnName("Cert_Exp_Date");
            entity.Property(e => e.CertLevel)
                .HasMaxLength(150)
                .HasColumnName("Cert_Level");
            entity.Property(e => e.Chapter).HasMaxLength(150);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(150);
            entity.Property(e => e.DistrictSchool)
                .HasMaxLength(150)
                .HasColumnName("District_School");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FiguserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIGUserID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(150)
                .HasColumnName("Home_Address");
            entity.Property(e => e.HomeCity)
                .HasMaxLength(150)
                .HasColumnName("Home_City");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(150)
                .HasColumnName("Home_Phone");
            entity.Property(e => e.HomeState)
                .HasMaxLength(150)
                .HasColumnName("Home_State");
            entity.Property(e => e.HomeZip)
                .HasMaxLength(150)
                .HasColumnName("Home_Zip");
            entity.Property(e => e.InfoLastUpdated).HasColumnName("Info_Last_Updated");
            entity.Property(e => e.JoinDate).HasColumnName("Join_Date");
            entity.Property(e => e.LastDuesPaidAmount)
                .HasMaxLength(150)
                .HasColumnName("Last_Dues_Paid_Amount");
            entity.Property(e => e.LastDuesPaymentDate).HasColumnName("Last_Dues_Payment_Date");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.LeaguidId).HasColumnName("LEAGuidId");
            entity.Property(e => e.Leaid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEAID");
            entity.Property(e => e.MemberType)
                .HasMaxLength(50)
                .HasColumnName("Member_Type");
            entity.Property(e => e.PaidThruDate).HasColumnName("Paid_Thru_Date");
            entity.Property(e => e.PreferredAddress)
                .HasMaxLength(150)
                .HasColumnName("Preferred_Address");
            entity.Property(e => e.PreferredCity)
                .HasMaxLength(150)
                .HasColumnName("Preferred_City");
            entity.Property(e => e.PreferredMailingAddress)
                .HasMaxLength(150)
                .HasColumnName("Preferred_Mailing_Address");
            entity.Property(e => e.PreferredState)
                .HasMaxLength(150)
                .HasColumnName("Preferred_State");
            entity.Property(e => e.PreferredZip)
                .HasMaxLength(150)
                .HasColumnName("Preferred_Zip");
            entity.Property(e => e.ReferredBy)
                .HasMaxLength(150)
                .HasColumnName("Referred_By");
            entity.Property(e => e.Sdm)
                .HasMaxLength(50)
                .HasColumnName("SDM");
            entity.Property(e => e.SdmAdministrator)
                .HasMaxLength(150)
                .HasColumnName("SDM_Administrator");
            entity.Property(e => e.SnamemberId).HasColumnName("SNAMemberID");
            entity.Property(e => e.SnamembershipNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNAMembershipNumber");
            entity.Property(e => e.Sns)
                .HasMaxLength(150)
                .HasColumnName("SNS");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.UsCongress)
                .HasMaxLength(150)
                .HasColumnName("US_Congress");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkAddress)
                .HasMaxLength(150)
                .HasColumnName("Work_Address");
            entity.Property(e => e.WorkCity)
                .HasMaxLength(150)
                .HasColumnName("Work_City");
            entity.Property(e => e.WorkPhone)
                .HasMaxLength(150)
                .HasColumnName("Work_Phone");
            entity.Property(e => e.WorkState)
                .HasMaxLength(150)
                .HasColumnName("Work_State");
            entity.Property(e => e.WorkZip)
                .HasMaxLength(150)
                .HasColumnName("Work_Zip");
        });

        modelBuilder.Entity<Speaker>(entity =>
        {
            entity.ToTable("Speaker");

            entity.Property(e => e.SpeakerId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(25);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.Ribbon).HasMaxLength(45);
            entity.Property(e => e.SpeakerName).HasMaxLength(50);
            entity.Property(e => e.Website).HasMaxLength(250);
        });

        modelBuilder.Entity<SpeakerRating>(entity =>
        {
            entity.HasKey(e => e.SpeakerRatingId).HasName("PK__SpeakerR__CB21FD73964217FF");

            entity.ToTable("SpeakerRating");

            entity.Property(e => e.SpeakerRatingId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SpeakerSpeechesAndTopicsAllocation>(entity =>
        {
            entity.ToTable("SpeakerSpeechesAndTopicsAllocation");

            entity.Property(e => e.SpeakerSpeechesAndTopicsAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SpeakerUploadedAttachment>(entity =>
        {
            entity.HasKey(e => e.SpeakerDocumentId);

            entity.Property(e => e.SpeakerDocumentId).ValueGeneratedNever();
            entity.Property(e => e.AttachmentExtension).HasMaxLength(50);
            entity.Property(e => e.AttachmentTitle).HasMaxLength(250);
            entity.Property(e => e.AttachmentType)
                .HasMaxLength(50)
                .HasDefaultValue("classwork documentation or brochures");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<StateInfo>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__StateInf__C3BA3B3A871F6DC0");

            entity.ToTable("StateInfo");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StateName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StripeReview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StripeReview");

            entity.Property(e => e.AmountRefunded).HasColumnName("Amount_Refunded");
            entity.Property(e => e.Captured).HasMaxLength(50);
            entity.Property(e => e.CardId)
                .HasMaxLength(50)
                .HasColumnName("Card_ID");
            entity.Property(e => e.ConvertedAmount).HasColumnName("Converted_Amount");
            entity.Property(e => e.ConvertedAmountRefunded).HasColumnName("Converted_Amount_Refunded");
            entity.Property(e => e.ConvertedCurrency)
                .HasMaxLength(50)
                .HasColumnName("Converted_Currency");
            entity.Property(e => e.CreatedDateUtc).HasColumnName("Created_date_UTC");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription)
                .HasMaxLength(1)
                .HasColumnName("Customer_Description");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(1)
                .HasColumnName("Customer_Email");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(1)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.FormIdMetadata)
                .HasMaxLength(1)
                .HasColumnName("formId_metadata");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(1)
                .HasColumnName("Invoice_ID");
            entity.Property(e => e.SellerMessage)
                .HasMaxLength(50)
                .HasColumnName("Seller_Message");
            entity.Property(e => e.StatementDescriptor)
                .HasMaxLength(50)
                .HasColumnName("Statement_Descriptor");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubmissionIdMetadata)
                .HasMaxLength(1)
                .HasColumnName("submissionId_metadata");
            entity.Property(e => e.TaxesOnFee).HasColumnName("Taxes_On_Fee");
            entity.Property(e => e.TransactionTypeMetadata)
                .HasMaxLength(1)
                .HasColumnName("transactionType_metadata");
            entity.Property(e => e.Transfer).HasMaxLength(50);
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.ToTable("Subscription");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountedType).HasMaxLength(20);
            entity.Property(e => e.DiscountedValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Duration).HasMaxLength(20);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceType).HasMaxLength(20);
            entity.Property(e => e.SubscriptionTitle).HasMaxLength(250);
            entity.Property(e => e.TotalSubscriptionPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SubscriptionConferenceAllocation>(entity =>
        {
            entity.ToTable("SubscriptionConferenceAllocation");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionTitle).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PK__Template__F87ADD27D0BE4B60");

            entity.Property(e => e.TemplateId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.NotificationType).HasMaxLength(100);
            entity.Property(e => e.Subject).HasMaxLength(2000);
            entity.Property(e => e.TemplateLanguage).HasMaxLength(50);
            entity.Property(e => e.TemplateTitle).HasMaxLength(1500);
            entity.Property(e => e.TemplateType).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TemplateRequiredParameterMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Template__3214EC07BD541734");

            entity.ToTable("TemplateRequiredParameterMst");

            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<TestUserMst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TestUserMst");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FigupdateFlag).HasColumnName("FIGUpdateFlag");
            entity.Property(e => e.FirstName).HasMaxLength(45);
            entity.Property(e => e.IsFigCreated).HasColumnName("isFigCreated");
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(45);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(25);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.UserType).HasMaxLength(20);
            entity.Property(e => e.WorkEmail).HasMaxLength(200);
            entity.Property(e => e.WorkPhone).HasMaxLength(200);
        });

        modelBuilder.Entity<UsDistrictMst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("US_DistrictMst");

            entity.Property(e => e.Address1).HasMaxLength(100);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CharterLea)
                .HasMaxLength(50)
                .HasColumnName("CHARTER_LEA");
            entity.Property(e => e.CharterLeaText)
                .HasMaxLength(50)
                .HasColumnName("CHARTER_LEA_TEXT");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyType).HasMaxLength(50);
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(50)
                .HasColumnName("EFFECTIVE_DATE");
            entity.Property(e => e.Fipst)
                .HasMaxLength(50)
                .HasColumnName("FIPST");
            entity.Property(e => e.G10Offered)
                .HasMaxLength(50)
                .HasColumnName("G_10_OFFERED");
            entity.Property(e => e.G11Offered)
                .HasMaxLength(50)
                .HasColumnName("G_11_OFFERED");
            entity.Property(e => e.G12Offered)
                .HasMaxLength(50)
                .HasColumnName("G_12_OFFERED");
            entity.Property(e => e.G13Offered)
                .HasMaxLength(50)
                .HasColumnName("G_13_OFFERED");
            entity.Property(e => e.G1Offered)
                .HasMaxLength(50)
                .HasColumnName("G_1_OFFERED");
            entity.Property(e => e.G2Offered)
                .HasMaxLength(50)
                .HasColumnName("G_2_OFFERED");
            entity.Property(e => e.G3Offered)
                .HasMaxLength(50)
                .HasColumnName("G_3_OFFERED");
            entity.Property(e => e.G4Offered)
                .HasMaxLength(50)
                .HasColumnName("G_4_OFFERED");
            entity.Property(e => e.G5Offered)
                .HasMaxLength(50)
                .HasColumnName("G_5_OFFERED");
            entity.Property(e => e.G6Offered)
                .HasMaxLength(50)
                .HasColumnName("G_6_OFFERED");
            entity.Property(e => e.G7Offered)
                .HasMaxLength(50)
                .HasColumnName("G_7_OFFERED");
            entity.Property(e => e.G8Offered)
                .HasMaxLength(50)
                .HasColumnName("G_8_OFFERED");
            entity.Property(e => e.G9Offered)
                .HasMaxLength(50)
                .HasColumnName("G_9_OFFERED");
            entity.Property(e => e.GAeOffered)
                .HasMaxLength(50)
                .HasColumnName("G_AE_OFFERED");
            entity.Property(e => e.GKgOffered)
                .HasMaxLength(50)
                .HasColumnName("G_KG_OFFERED");
            entity.Property(e => e.GPkOffered)
                .HasMaxLength(50)
                .HasColumnName("G_PK_OFFERED");
            entity.Property(e => e.GUgOffered)
                .HasMaxLength(50)
                .HasColumnName("G_UG_OFFERED");
            entity.Property(e => e.Gshi)
                .HasMaxLength(50)
                .HasColumnName("GSHI");
            entity.Property(e => e.Gslo)
                .HasMaxLength(50)
                .HasColumnName("GSLO");
            entity.Property(e => e.Igoffered)
                .HasMaxLength(50)
                .HasColumnName("IGOFFERED");
            entity.Property(e => e.Lcity)
                .HasMaxLength(50)
                .HasColumnName("LCITY");
            entity.Property(e => e.LeaType)
                .HasMaxLength(50)
                .HasColumnName("LEA_TYPE");
            entity.Property(e => e.LeaTypeText)
                .HasMaxLength(100)
                .HasColumnName("LEA_TYPE_TEXT");
            entity.Property(e => e.Leaid)
                .HasMaxLength(50)
                .HasColumnName("LEAID");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .HasColumnName("LEVEL");
            entity.Property(e => e.Lstate)
                .HasMaxLength(50)
                .HasColumnName("LSTATE");
            entity.Property(e => e.Lstreet1)
                .HasMaxLength(50)
                .HasColumnName("LSTREET1");
            entity.Property(e => e.Lstreet2)
                .HasMaxLength(50)
                .HasColumnName("LSTREET2");
            entity.Property(e => e.Lstreet3)
                .HasMaxLength(50)
                .HasColumnName("LSTREET3");
            entity.Property(e => e.Lzip)
                .HasMaxLength(50)
                .HasColumnName("LZIP");
            entity.Property(e => e.Lzip4)
                .HasMaxLength(50)
                .HasColumnName("LZIP4");
            entity.Property(e => e.Mzip4)
                .HasMaxLength(50)
                .HasColumnName("MZIP4");
            entity.Property(e => e.Nogrades)
                .HasMaxLength(50)
                .HasColumnName("NOGRADES");
            entity.Property(e => e.OperationalSchools)
                .HasMaxLength(50)
                .HasColumnName("OPERATIONAL_SCHOOLS");
            entity.Property(e => e.OutOfStateFlag)
                .HasMaxLength(50)
                .HasColumnName("OUT_OF_STATE_FLAG");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("PHONE");
            entity.Property(e => e.SchoolYear)
                .HasMaxLength(50)
                .HasColumnName("SCHOOL_YEAR");
            entity.Property(e => e.St)
                .HasMaxLength(50)
                .HasColumnName("ST");
            entity.Property(e => e.StLeaid)
                .HasMaxLength(50)
                .HasColumnName("ST_LEAID");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StateAgencyNo)
                .HasMaxLength(50)
                .HasColumnName("STATE_AGENCY_NO");
            entity.Property(e => e.Statename)
                .HasMaxLength(50)
                .HasColumnName("STATENAME");
            entity.Property(e => e.SyStatus)
                .HasMaxLength(50)
                .HasColumnName("SY_STATUS");
            entity.Property(e => e.SyStatusText)
                .HasMaxLength(50)
                .HasColumnName("SY_STATUS_TEXT");
            entity.Property(e => e.Union)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNION");
            entity.Property(e => e.UpdatedStatus)
                .HasMaxLength(50)
                .HasColumnName("UPDATED_STATUS");
            entity.Property(e => e.UpdatedStatusText)
                .HasMaxLength(50)
                .HasColumnName("UPDATED_STATUS_TEXT");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .HasColumnName("WEBSITE");
            entity.Property(e => e.Zip).HasMaxLength(50);
        });

        modelBuilder.Entity<UsSchoolsMst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("US_SchoolsMst");

            entity.Property(e => e.Chartauth1)
                .HasMaxLength(150)
                .HasColumnName("CHARTAUTH1");
            entity.Property(e => e.Chartauth2)
                .HasMaxLength(150)
                .HasColumnName("CHARTAUTH2");
            entity.Property(e => e.Chartauthn1)
                .HasMaxLength(150)
                .HasColumnName("CHARTAUTHN1");
            entity.Property(e => e.Chartauthn2)
                .HasMaxLength(150)
                .HasColumnName("CHARTAUTHN2");
            entity.Property(e => e.CharterText)
                .HasMaxLength(150)
                .HasColumnName("CHARTER_TEXT");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(50)
                .HasColumnName("EFFECTIVE_DATE");
            entity.Property(e => e.Fipst)
                .HasMaxLength(50)
                .HasColumnName("FIPST");
            entity.Property(e => e.G10Offered)
                .HasMaxLength(150)
                .HasColumnName("G_10_OFFERED");
            entity.Property(e => e.G11Offered)
                .HasMaxLength(150)
                .HasColumnName("G_11_OFFERED");
            entity.Property(e => e.G12Offered)
                .HasMaxLength(150)
                .HasColumnName("G_12_OFFERED");
            entity.Property(e => e.G13Offered)
                .HasMaxLength(50)
                .HasColumnName("G_13_OFFERED");
            entity.Property(e => e.G1Offered)
                .HasMaxLength(150)
                .HasColumnName("G_1_OFFERED");
            entity.Property(e => e.G2Offered)
                .HasMaxLength(150)
                .HasColumnName("G_2_OFFERED");
            entity.Property(e => e.G3Offered)
                .HasMaxLength(150)
                .HasColumnName("G_3_OFFERED");
            entity.Property(e => e.G4Offered)
                .HasMaxLength(150)
                .HasColumnName("G_4_OFFERED");
            entity.Property(e => e.G5Offered)
                .HasMaxLength(150)
                .HasColumnName("G_5_OFFERED");
            entity.Property(e => e.G6Offered)
                .HasMaxLength(150)
                .HasColumnName("G_6_OFFERED");
            entity.Property(e => e.G7Offered)
                .HasMaxLength(150)
                .HasColumnName("G_7_OFFERED");
            entity.Property(e => e.G8Offered)
                .HasMaxLength(150)
                .HasColumnName("G_8_OFFERED");
            entity.Property(e => e.G9Offered)
                .HasMaxLength(150)
                .HasColumnName("G_9_OFFERED");
            entity.Property(e => e.GAeOffered)
                .HasMaxLength(50)
                .HasColumnName("G_AE_OFFERED");
            entity.Property(e => e.GKgOffered)
                .HasMaxLength(150)
                .HasColumnName("G_KG_OFFERED");
            entity.Property(e => e.GPkOffered)
                .HasMaxLength(150)
                .HasColumnName("G_PK_OFFERED");
            entity.Property(e => e.GUgOffered)
                .HasMaxLength(50)
                .HasColumnName("G_UG_OFFERED");
            entity.Property(e => e.Gshi)
                .HasMaxLength(150)
                .HasColumnName("GSHI");
            entity.Property(e => e.Gslo)
                .HasMaxLength(50)
                .HasColumnName("GSLO");
            entity.Property(e => e.Igoffered)
                .HasMaxLength(50)
                .HasColumnName("IGOFFERED");
            entity.Property(e => e.Lcity)
                .HasMaxLength(50)
                .HasColumnName("LCITY");
            entity.Property(e => e.LeaName)
                .HasMaxLength(150)
                .HasColumnName("LEA_NAME");
            entity.Property(e => e.Leaid)
                .HasMaxLength(50)
                .HasColumnName("LEAID");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .HasColumnName("LEVEL");
            entity.Property(e => e.Lstate)
                .HasMaxLength(50)
                .HasColumnName("LSTATE");
            entity.Property(e => e.Lstreet1)
                .HasMaxLength(150)
                .HasColumnName("LSTREET1");
            entity.Property(e => e.Lstreet2)
                .HasMaxLength(150)
                .HasColumnName("LSTREET2");
            entity.Property(e => e.Lstreet3)
                .HasMaxLength(150)
                .HasColumnName("LSTREET3");
            entity.Property(e => e.Lzip)
                .HasMaxLength(150)
                .HasColumnName("LZIP");
            entity.Property(e => e.Lzip4)
                .HasMaxLength(150)
                .HasColumnName("LZIP4");
            entity.Property(e => e.Mcity)
                .HasMaxLength(50)
                .HasColumnName("MCITY");
            entity.Property(e => e.Mstate)
                .HasMaxLength(50)
                .HasColumnName("MSTATE");
            entity.Property(e => e.Mstreet1)
                .HasMaxLength(150)
                .HasColumnName("MSTREET1");
            entity.Property(e => e.Mstreet2)
                .HasMaxLength(150)
                .HasColumnName("MSTREET2");
            entity.Property(e => e.Mstreet3)
                .HasMaxLength(150)
                .HasColumnName("MSTREET3");
            entity.Property(e => e.Mzip)
                .HasMaxLength(150)
                .HasColumnName("MZIP");
            entity.Property(e => e.Mzip4)
                .HasMaxLength(150)
                .HasColumnName("MZIP4");
            entity.Property(e => e.Ncessch)
                .HasMaxLength(50)
                .HasColumnName("NCESSCH");
            entity.Property(e => e.Nogrades)
                .HasMaxLength(50)
                .HasColumnName("NOGRADES");
            entity.Property(e => e.OutOfStateFlag)
                .HasMaxLength(50)
                .HasColumnName("OUT_OF_STATE_FLAG");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("PHONE");
            entity.Property(e => e.ReconStatus)
                .HasMaxLength(50)
                .HasColumnName("RECON_STATUS");
            entity.Property(e => e.SchName)
                .HasMaxLength(100)
                .HasColumnName("SCH_NAME");
            entity.Property(e => e.SchType)
                .HasMaxLength(150)
                .HasColumnName("SCH_TYPE");
            entity.Property(e => e.SchTypeText)
                .HasMaxLength(150)
                .HasColumnName("SCH_TYPE_TEXT");
            entity.Property(e => e.Schid)
                .HasMaxLength(150)
                .HasColumnName("SCHID");
            entity.Property(e => e.SchoolYear)
                .HasMaxLength(50)
                .HasColumnName("SCHOOL_YEAR");
            entity.Property(e => e.St)
                .HasMaxLength(50)
                .HasColumnName("ST");
            entity.Property(e => e.StLeaid)
                .HasMaxLength(50)
                .HasColumnName("ST_LEAID");
            entity.Property(e => e.StSchid)
                .HasMaxLength(50)
                .HasColumnName("ST_SCHID");
            entity.Property(e => e.StateAgencyNo)
                .HasMaxLength(50)
                .HasColumnName("STATE_AGENCY_NO");
            entity.Property(e => e.Statename)
                .HasMaxLength(50)
                .HasColumnName("STATENAME");
            entity.Property(e => e.SyStatus)
                .HasMaxLength(150)
                .HasColumnName("SY_STATUS");
            entity.Property(e => e.SyStatusText)
                .HasMaxLength(50)
                .HasColumnName("SY_STATUS_TEXT");
            entity.Property(e => e.Union)
                .HasMaxLength(150)
                .HasColumnName("UNION");
            entity.Property(e => e.UpdatedStatus)
                .HasMaxLength(150)
                .HasColumnName("UPDATED_STATUS");
            entity.Property(e => e.UpdatedStatusText)
                .HasMaxLength(50)
                .HasColumnName("UPDATED_STATUS_TEXT");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<UserAdaallocation>(entity =>
        {
            entity.ToTable("UserADAAllocation");

            entity.Property(e => e.UserAdaallocationId)
                .ValueGeneratedNever()
                .HasColumnName("UserADAAllocationId");
            entity.Property(e => e.Ada)
                .HasMaxLength(500)
                .HasColumnName("ADA");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherDescription).HasMaxLength(1000);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserConferenceFeedback>(entity =>
        {
            entity.ToTable("UserConferenceFeedback");

            entity.Property(e => e.UserConferenceFeedbackId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(200);
        });

        modelBuilder.Entity<UserConferenceFeedbackQuestionAnswer>(entity =>
        {
            entity.ToTable("UserConferenceFeedbackQuestionAnswer");

            entity.Property(e => e.UserConferenceFeedbackQuestionAnswerId).ValueGeneratedNever();
            entity.Property(e => e.Answer).HasMaxLength(550);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserFollower>(entity =>
        {
            entity.HasKey(e => e.UserFollowersId);

            entity.Property(e => e.UserFollowersId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FollowDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserMealAllocation>(entity =>
        {
            entity.ToTable("UserMealAllocation");

            entity.Property(e => e.UserMealAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Meal).HasMaxLength(500);
            entity.Property(e => e.OtherDescription).HasMaxLength(1000);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserMst>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Event_User");

            entity.ToTable("UserMst");

            entity.HasIndex(e => new { e.IsActive, e.Email, e.Password }, "nci_msft_1_UserMst_B833D2D7FD35BE4AB9959321B6223187");

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FigupdateFlag).HasColumnName("FIGUpdateFlag");
            entity.Property(e => e.FirstName).HasMaxLength(45);
            entity.Property(e => e.IsFigCreated).HasColumnName("isFigCreated");
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(45);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(25);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.UserType).HasMaxLength(20);
            entity.Property(e => e.WorkEmail).HasMaxLength(200);
            entity.Property(e => e.WorkPhone).HasMaxLength(200);
        });

        modelBuilder.Entity<UserQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.UserQuestionAnswerId).HasName("PK__UserQues__0491336FA4222410");

            entity.ToTable("UserQuestionAnswer");

            entity.Property(e => e.UserQuestionAnswerId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherExternalConference).HasMaxLength(250);
            entity.Property(e => e.RequestAcallUserInformationId).HasColumnName("RequestACallUserInformationId");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserRoleAllocation>(entity =>
        {
            entity.HasKey(e => e.UserRoleAllocationId).HasName("PK__UserRole__CCA1F843C4D89C95");

            entity.ToTable("UserRoleAllocation");

            entity.Property(e => e.UserRoleAllocationId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAttendeeReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AttendeeReport");

            entity.Property(e => e.AdaDietaryRestrictions).HasMaxLength(1002);
            entity.Property(e => e.ChargeType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CheckNumber).HasMaxLength(30);
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CustomerEmail).HasMaxLength(150);
            entity.Property(e => e.CustomerName).HasMaxLength(91);
            entity.Property(e => e.DateRegistered).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatus).HasMaxLength(1000);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("PONumber");
            entity.Property(e => e.PurchaseType).HasMaxLength(1000);
            entity.Property(e => e.RegisteredBy).HasMaxLength(91);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwBoothsforOhio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_boothsfor_ohio");

            entity.Property(e => e.BoothNumber).HasMaxLength(20);
            entity.Property(e => e.CompanyEmail).HasMaxLength(150);
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CompanyPhone).HasMaxLength(50);
            entity.Property(e => e.CreatedByEmail).HasMaxLength(150);
            entity.Property(e => e.CreatedByFirstName).HasMaxLength(45);
            entity.Property(e => e.CreatedByLastName).HasMaxLength(45);
            entity.Property(e => e.Height).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PositionX).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PositionY).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Width).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<VwClassDetailWithSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ClassDetailWithSummary");

            entity.Property(e => e.AttendeeName).HasMaxLength(91);
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.Leaname)
                .HasMaxLength(250)
                .HasColumnName("LEAName");
            entity.Property(e => e.NumberOfAttendees).HasMaxLength(30);
            entity.Property(e => e.SessionTitle).HasMaxLength(150);
        });

        modelBuilder.Entity<VwSessionAttendeesWithSpecialNeed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SessionAttendeesWithSpecialNeeds");

            entity.Property(e => e.Adarequirements)
                .HasMaxLength(4000)
                .HasColumnName("ADARequirements");
            entity.Property(e => e.AttendeeName).HasMaxLength(91);
            entity.Property(e => e.MealNeeds).HasMaxLength(4000);
            entity.Property(e => e.NumberOfAttendees).HasMaxLength(30);
            entity.Property(e => e.SessionTitle).HasMaxLength(150);
        });

        modelBuilder.Entity<VwStripeReviewEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StripeReviewEmails");

            entity.Property(e => e.AmountRefunded).HasColumnName("Amount_Refunded");
            entity.Property(e => e.Captured).HasMaxLength(50);
            entity.Property(e => e.CardId)
                .HasMaxLength(50)
                .HasColumnName("Card_ID");
            entity.Property(e => e.ConvertedAmount).HasColumnName("Converted_Amount");
            entity.Property(e => e.ConvertedAmountRefunded).HasColumnName("Converted_Amount_Refunded");
            entity.Property(e => e.ConvertedCurrency)
                .HasMaxLength(50)
                .HasColumnName("Converted_Currency");
            entity.Property(e => e.CreatedDateUtc).HasColumnName("Created_date_UTC");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription)
                .HasMaxLength(1)
                .HasColumnName("Customer_Description");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(1)
                .HasColumnName("Customer_Email");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(1)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.ExtractedEmail)
                .HasMaxLength(100)
                .HasColumnName("Extracted_Email");
            entity.Property(e => e.FormIdMetadata)
                .HasMaxLength(1)
                .HasColumnName("formId_metadata");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(1)
                .HasColumnName("Invoice_ID");
            entity.Property(e => e.SellerMessage)
                .HasMaxLength(50)
                .HasColumnName("Seller_Message");
            entity.Property(e => e.StatementDescriptor)
                .HasMaxLength(50)
                .HasColumnName("Statement_Descriptor");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubmissionIdMetadata)
                .HasMaxLength(1)
                .HasColumnName("submissionId_metadata");
            entity.Property(e => e.TaxesOnFee).HasColumnName("Taxes_On_Fee");
            entity.Property(e => e.TransactionTypeMetadata)
                .HasMaxLength(1)
                .HasColumnName("transactionType_metadata");
            entity.Property(e => e.Transfer).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
