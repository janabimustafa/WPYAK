using System;
using System.Collections.Generic;
using System.Text;

namespace WPYAK.Model.Data
{
    public class User
    {
        private Guid _userID;
        public Guid UserID
        {
            get
            {
                if (_userID == Guid.Empty)
                    _userID = Guid.NewGuid();
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        private static User _currentUser;
        public static User CurrentUser 
        {
            get
            {
                if (_currentUser == null)
                    _currentUser = new User();
                return _currentUser;
            }
            set
            {
                _currentUser = value;
            }
        }

        public override string ToString()
        {
            return UserID.ToString().ToUpper();
        }

    }
}
