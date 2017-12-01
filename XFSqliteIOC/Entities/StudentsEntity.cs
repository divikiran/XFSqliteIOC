﻿using SQLite.Net.Attributes;

namespace XFSqliteIOC
{
    public class StudentsEntity : IEntity
    {
        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }
    }
}