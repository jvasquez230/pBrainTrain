﻿namespace pBrainTrain.App.Models
{
    using System;
    using SQLite.Net.Attributes;
    using SQLiteNetExtensions.Attributes;

    public class User
    {
        [PrimaryKey]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int UserTypeId { get; set; }

        public string Picture { get; set; }

        public string Email { get; set; }

        public int? CountryId { get; set; }

        public int StatusId { get; set; }

        [ManyToOne]
        public UserType UserType { get; set; }

        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        public DateTime TokenExpires { get; set; }

        public string Password { get; set; }

        public bool IsRemembered { get; set; }

        public string FullName => string.Format("{0} {1}", FirstName, LastName);

        public string FullPicture
        {
            get {
                if (string.IsNullOrEmpty(Picture))
                {
                    return "avatar_user.png";
                }
                return UserTypeId == 1 ? string.Format("http://psbraintrainapis2.azurewebsites.net/{0}", Picture.Substring(1)) : Picture;
            }
        }
        public byte[] ImageArray { get; internal set; }

        public override int GetHashCode()
        {
            return UserId;
        }
    }
}
