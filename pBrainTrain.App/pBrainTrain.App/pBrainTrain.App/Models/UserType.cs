﻿namespace pBrainTrain.App.Models
{
    using System.Collections.Generic;
    using SQLite.Net.Attributes;
    using SQLiteNetExtensions.Attributes;

    public class UserType
    {
        [PrimaryKey]
        public int UserTypeId { get; set; }

        public string Name { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
        public List<User> Users { get; set; }

        public override int GetHashCode()
        {
            return UserTypeId;
        }
    }
}
