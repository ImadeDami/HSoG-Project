using Clearwox;
using HSoG.Portal.Data;
using HSoG.Portal.Services;

namespace HSoG.Portal
{
    public class Service
    {
        public Service(AppDB db)
        {
            Data = new DataService(db);
            Email = new EmailService();
        }

        public DataService Data { get; }
        public EmailService Email { get; }
    }
}