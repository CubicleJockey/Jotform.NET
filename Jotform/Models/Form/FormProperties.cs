namespace Jotform.Models.Form;

public class FormProperties
{
    [JsonPropertyName("activeRedirect")]
    public string ActiveRedirect { get; set; }

    [JsonPropertyName("alignment")]
    public string Alignment { get; set; }

    [JsonPropertyName("allowSubmissionEdit")]
    public bool AllowSubmissionEdit { get; set; }

    [JsonPropertyName("attachInvoice")]
    public bool AttachInvoice { get; set; }

    [JsonPropertyName("background")]
    public string Background { get; set; }

    [JsonPropertyName("cardThemeID")]
    public string CardThemeID { get; set; }

    [JsonPropertyName("clearFieldOnHide")]
    public string ClearFieldOnHide { get; set; }

    [JsonPropertyName("creationLanguage")]
    public string CreationLanguage { get; set; }

    [JsonPropertyName("datetimeMigrationStatus")]
    public string DatetimeMigrationStatus { get; set; }

    [JsonPropertyName("defaultAutoResponderEmailAssigned")]
    public bool DefaultAutoResponderEmailAssigned { get; set; }

    [JsonPropertyName("defaultEmailAssigned")]
    public bool DefaultEmailAssigned { get; set; }

    [JsonPropertyName("defaultTheme")]
    public string DefaultTheme { get; set; }

    [JsonPropertyName("emailsToAttachInvoice")]
    public string EmailsToAttachInvoice { get; set; }

    [JsonPropertyName("errorNavigation")]
    public bool ErrorNavigation { get; set; }

    [JsonPropertyName("expireDate")]
    public string ExpireDate { get; set; }

    [JsonPropertyName("font")]
    public string Font { get; set; }

    [JsonPropertyName("fontcolor")]
    public string Fontcolor { get; set; }

    [JsonPropertyName("fontsize")]
    public string Fontsize { get; set; }

    [JsonPropertyName("formStringsChanged")]
    public bool FormStringsChanged { get; set; }

    [JsonPropertyName("formType")]
    public string FormType { get; set; }

    [JsonPropertyName("formWidth")]
    public int FormWidth { get; set; }

    [JsonPropertyName("hash")]
    public string Hash { get; set; }

    [JsonPropertyName("hideEmptySubmissionFields")]
    public bool HideEmptySubmissionFields { get; set; }

    [JsonPropertyName("hideMailEmptyFields")]
    public string HideMailEmptyFields { get; set; }

    [JsonPropertyName("hideNonInputSubmissionFields")]
    public bool HideNonInputSubmissionFields { get; set; }

    [JsonPropertyName("hideSubmissionHeader")]
    public bool HideSubmissionHeader { get; set; }

    [JsonPropertyName("highlightLine")]
    public string HighlightLine { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("injectCSS")]
    public string InjectCSS { get; set; }

    [JsonPropertyName("invoiceEnabled")]
    public bool InvoiceEnabled { get; set; }

    [JsonPropertyName("isEncrypted")]
    public bool IsEncrypted { get; set; }

    [JsonPropertyName("isPaymentStoreInBasicFields")]
    public bool IsPaymentStoreInBasicFields { get; set; }

    [JsonPropertyName("labelWidth")]
    public int LabelWidth { get; set; }

    [JsonPropertyName("lastQuestionID")]
    public string LastQuestionID { get; set; }

    [JsonPropertyName("limitSubmission")]
    public string LimitSubmission { get; set; }

    [JsonPropertyName("lineSpacing")]
    public int LineSpacing { get; set; }

    [JsonPropertyName("messageOfLimitedForm")]
    public string MessageOfLimitedForm { get; set; }

    [JsonPropertyName("mobileGoButton")]
    public string MobileGoButton { get; set; }

    [JsonPropertyName("newPaymentUIForNewCreatedForms")]
    public bool NewPaymentUIForNewCreatedForms { get; set; }

    [JsonPropertyName("optioncolor")]
    public string Optioncolor { get; set; }

    [JsonPropertyName("pageColor")]
    public string PageColor { get; set; }

    [JsonPropertyName("pagetitle")]
    public string Pagetitle { get; set; }

    [JsonPropertyName("pageTitleChanged")]
    public bool PageTitleChanged { get; set; }

    [JsonPropertyName("paymentStringsChanged")]
    public bool PaymentStringsChanged { get; set; }

    [JsonPropertyName("preventCloningForm")]
    public bool PreventCloningForm { get; set; }

    [JsonPropertyName("responsive")]
    public bool Responsive { get; set; }

    [JsonPropertyName("sendpostdata")]
    public bool Sendpostdata { get; set; }

    [JsonPropertyName("showJotFormLogo")]
    public bool ShowJotFormLogo { get; set; }

    [JsonPropertyName("showProgressBar")]
    public string ShowProgressBar { get; set; }

    [JsonPropertyName("styleJSON")]
    public string StyleJSON { get; set; }

    [JsonPropertyName("styles")]
    public string Styles { get; set; }

    [JsonPropertyName("submissionHeaders")]
    public string SubmissionHeaders { get; set; }

    [JsonPropertyName("submitError")]
    public string SubmitError { get; set; }

    [JsonPropertyName("thanktext")]
    public string Thanktext { get; set; }

    [JsonPropertyName("thankYouDownloadPDF")]
    public bool ThankYouDownloadPDF { get; set; }

    [JsonPropertyName("thankYouEditSubmission")]
    public bool ThankYouEditSubmission { get; set; }

    [JsonPropertyName("thankYouFillAgain")]
    public bool ThankYouFillAgain { get; set; }

    [JsonPropertyName("thankYouIconSrc")]
    public string ThankYouIconSrc { get; set; }

    [JsonPropertyName("thankYouImageSrc")]
    public string ThankYouImageSrc { get; set; }

    [JsonPropertyName("thankYouPageLayout")]
    public string ThankYouPageLayout { get; set; }

    [JsonPropertyName("thankYouSelectedPDFs")]
    public bool ThankYouSelectedPDFs { get; set; }

    [JsonPropertyName("themeID")]
    public string ThemeID { get; set; }

    [JsonPropertyName("unique")]
    public string Unique { get; set; }

    [JsonPropertyName("uniqueField")]
    public string UniqueField { get; set; }

    [JsonPropertyName("usesNewPDF")]
    public bool UsesNewPDF { get; set; }

    [JsonPropertyName("v4")]
    public bool V4 { get; set; }

    [JsonPropertyName("coupons")]
    public List<Coupon> Coupons { get; } = new List<Coupon>();

    [JsonPropertyName("emails")]
    public List<Email> Emails { get; } = new List<Email>();

    [JsonPropertyName("paymentListSettings")]
    public List<PaymentListSetting> PaymentListSettings { get; } = new List<PaymentListSetting>();

    [JsonPropertyName("paymentStrings")]
    public Dictionary<int, string> PaymentStrings { get; } = new();

    [JsonPropertyName("products")]
    public List<Product> Products { get; } = new List<Product>();

    [JsonPropertyName("submissionSettings")]
    public List<object> SubmissionSettings { get; } = new List<object>();

    [JsonPropertyName("integrations")]
    public List<object> Integrations { get; } = new List<object>();

    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("height")]
    public string Height { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("formOwnerAccountType")]
    public string FormOwnerAccountType { get; set; }

    [JsonPropertyName("formOwnerName")]
    public string FormOwnerName { get; set; }

    [JsonPropertyName("isHIPAA")]
    public string IsHIPAA { get; set; }

    [JsonPropertyName("isEUForm")]
    public string IsEUForm { get; set; }
}