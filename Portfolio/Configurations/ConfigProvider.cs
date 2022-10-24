namespace Portfolio.Configurations;

public static class ConfigProvider
{
    public static IConfiguration Configuration { get; set; } = null!;

    public static string ConnectionStringSqlServer => Get("ConnectionStrings:SqlServer");

    public static string OpenApiInfoTitle => Get("Swagger:OpenApiInfo:Title");
    public static string OpenApiInfoVersion => Get("Swagger:OpenApiInfo:Version");
    public static string OpenApiInfoDescription => Get("Swagger:OpenApiInfo:Description");

    public static string OpenApiSecuritySchemeName => Get("Swagger:OpenApiSecurityScheme:Name");
    public static string OpenApiSecuritySchemeScheme => Get("Swagger:OpenApiSecurityScheme:Scheme");
    public static string OpenApiSecuritySchemeDescription => Get("Swagger:OpenApiSecurityScheme:Description");
    public static string OpenApiSecuritySchemeBearerFormat => Get("Swagger:OpenApiSecurityScheme:BearerFormat");
    
    public static string SmtpClientGmailHost => Get("SmtpClient:Gmail:Host");
    public static int SmtpClientGmailPort => Get<int>("SmtpClient:Gmail:Port");
    public static bool SmtpClientGmailEnableSsl => Get<bool>("SmtpClient:Gmail:EnableSsl");
    public static string SmtpClientGmailCredentialsUserName => Get("SmtpClient:Gmail:Credentials:UserName");
    public static string SmtpClientGmailCredentialsPassword => Get("SmtpClient:Gmail:Credentials:Password");
    
    public static string MailMessageSubject => Get("MailMessage:Subject");
    public static string MailMessageConfirmEmailEndpoint => Get("MailMessage:ConfirmEmailEndpoint");

    private static string Get(string name) => Get<string>(name);
    private static T Get<T>(string name) =>
        Configuration.GetValue<T>(name) ?? throw new Exception("Configuration for " + name + " not found.");
}