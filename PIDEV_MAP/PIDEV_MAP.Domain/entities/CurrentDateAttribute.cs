﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PIDEV_MAP.Domain.entities
{
    internal class CurrentDateAttribute : ValidationAttribute
    {
        public CurrentDateAttribute()
        {
        }

        public override bool IsValid(object value)
        {
            var dt = (DateTime)value;
            if (dt >= DateTime.Now)
            {
                return true;
            }
            return false;
        }




    }
}