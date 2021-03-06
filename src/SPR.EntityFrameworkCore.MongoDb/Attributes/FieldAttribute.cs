﻿using System;

namespace SPR.EntityFrameworkCore.MongoDb.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldAttribute : Attribute
    {
        public FieldAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string TypeName { get; set; }
    }
}
