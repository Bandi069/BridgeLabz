using Model.UserModel;
using NUnit.Framework;
using Repository.Repository;

namespace NUnitTestFundoo
{
    /// <summary>
    /// Test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Logins this instance.
        /// </summary>
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
        /// <summary>
        /// Registrations the model.
        /// </summary>
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
        /// <summary>
        /// Forgots the password.
        /// </summary>
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
        /// <summary>
        /// Resets the password.
        /// </summary>
        [Test]
        public void ResetPassword()
        {
            UserLogin user = new UserLogin();
            ResetPassword reset = new ResetPassword()
            {
                Emailid = "bandivenu89@gmail.com",
                Password = "lasdh12"
            };
            Assert.IsNotNull(user.ResetPassword(reset));
        }
    }
}