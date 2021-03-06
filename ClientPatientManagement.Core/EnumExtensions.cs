﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public static class EnumExtensions
    {
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        public static string ToDesc(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

    public class EligibilityHandler
    {
        private readonly string _eligibleFox = "ELINGFX";

        public EligibilityHandler(string eligibleFox)
        {
            _eligibleFox = eligibleFox;

        }

        protected void Handle()
        {
            string handleMessage = string.Empty;

            if (handleMessage == null)
                handleMessage = "ad";
            handleMessage = "asd";                
        }

        private void Rest()
        {
            var asd = string.Empty;
        }

        public string ToString => "asd";


    }
}
