using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;

namespace Bijcorp.Base
{          
    public static class Utilities
    {
        public static int? NullInt32 = null;
        public static short? NullInt16 = null;
        public static long? NullInt64 = null;
        public static decimal? NullDecimal = null;
        public static double? NullDouble = null;
        public static bool? NullBool = null;
        public static DateTime? NullDatetime = null;        


        #region extension methods

        public static string GetDescription(this Enum value)
        {
            var descriptionAttribute = (DescriptionAttribute)value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(false)
                .Where(a => a is DescriptionAttribute)
                .FirstOrDefault();

            return descriptionAttribute != null ? descriptionAttribute.Description : value.ToString();
        }

        public static int ToInt(this Enum value)
        {
            return Convert.ToInt32(value);
        }

        public static char ToChar(this Enum value)
        {
            return Convert.ToChar(value);
        }

        public static bool ToBoolean(this Enum value)
        {
            return Convert.ToBoolean(value);
        }

        public static bool IsEmpty(this object value)
        {
            if (value == null)
                return true;
            if (value is decimal || value is int || value is short || value is double)
            {
                decimal d = Convert.ToDecimal(value);
                if (d <= 0)
                    return true;
            }
            if (value is string)
            {
                string s = value.ToString();
                if (s.Trim().Length == 0)
                    return true;
            }
            return false;
        }

        #endregion                
        
        public static bool isDecimal(object test_number)
        {
            try
            {
                decimal num = Convert.ToDecimal(test_number);
                return true;
            }
            catch
            {
                return false;
            }
        }                               

        public static string EncriptarMD5(string originalPassword)
        {
            //Declarations
            string resultado, resultadoFinal = null;
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            resultado = BitConverter.ToString(encodedBytes);
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] != 45)
                    resultadoFinal += resultado[i];
            }
            return resultadoFinal;
        }

        public static void Save_log(string txt)
        {
            string archive = System.IO.Directory.GetCurrentDirectory() + @"\log.txt";

            System.IO.StreamWriter sw = new System.IO.StreamWriter(archive);
            sw.WriteLine(txt);
            sw.Close();
        }

        public static bool ValidateMail(string mail)
        {
            string email = mail;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }        

        public static DataTable ToDataTable<T>(IList<T> data)// T is any generic type
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, typeof(string));
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
