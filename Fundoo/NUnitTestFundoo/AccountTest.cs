using Model.UserModel;
using NUnit.Framework;
using Repository.Repository;

namespace NUnitTestFundoo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Login()
        {
            UserLogin loginobj = new UserLogin();
            LoginModel logmodel = new LoginModel
            {
                Emailid = "bandivenu89@gmail.com",
                Password = "132154"
            };
           
            Assert.IsNotNull(loginobj.Login(logmodel));
        }
        [Test]
        public void RegistrationModel()
        {
            UserLogin user = new UserLogin();
            RegistrationModel registrationobj = new RegistrationModel()
            {
                FirtsName = "Venu",
                LastName = "Bandi",
                Emailid = "bandivenu89@gmail.com",
                Password = "321546"
            };
              Assert.Null(user.Registration(registrationobj));
        }
        [Test]
        public void ForgotPassword()
        {
            UserLogin user = new UserLogin();
            ForgotPasswordModel forgot = new ForgotPasswordModel
            {
                Emailid= "bandivenu89@gmail.com",
            };
            Assert.IsNotNull(user.ForgotPassword(forgot));
        }
        [Test]
        public void ResetPassword()
        {
            UserLogin user = new UserLogin();
            ResetPassword reset = new ResetPassword()
            {
                Emailid= "bandivenu89@gmail.com",
                Password="lasdh12"
            };
            Assert.IsNotNull(user.ResetPassword(reset));
        }
    }
}