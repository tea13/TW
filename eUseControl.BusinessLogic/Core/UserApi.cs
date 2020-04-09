using eUseControl.Domain;
using eUseControl.Domain.Entities.User;
using System.Data.Entity.Validation;
using System.Linq;



namespace eUseControl.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UserDbTable result;



            using (var db = new UserContext())
            {
                result = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
            }
            if (result == null)
            {
                return new ULoginResp
                {
                    Status = false,
                    StatusMsg = "The username or password is incorrect"
                };
            }
            return new ULoginResp { Status = true };
        }



        internal ULoginResp UserRegisterAction(UserRegisterData data)
        {
            UserDbTable result;
            var user = new UserDbTable();
            user.Username = data.Credential;
            user.Password = data.Password;
            user.Email = data.Email;
            user.Info = data.Informatie;
            user.RegisterDate = data.RegisterDateTime;
            try
            {
                using (var db = new UserContext())
                {
                    result = db.Users.FirstOrDefault(u => u.Username == data.Credential);
                    if (result == null)
                    {
                        db.Users.Add(user);
                        db.SaveChanges();
                        return new ULoginResp { Status = true };
                    }
                    else
                    {
                        return new ULoginResp
                        {
                            Status = false,
                            StatusMsg = "This username already exists."
                        };
                    }
                }
            }

            catch (DbEntityValidationException e)
            {
                throw;
            }



        }
    }
}