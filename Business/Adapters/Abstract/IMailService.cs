using Entity.Concrete;

namespace Business.Adapters.Abstract
{
    public interface IMailService
    {
        void SendMailForPassword(User user);
        void SendMailForEmail(User user);
        void SendMailForQuestion(User user);
    }
}