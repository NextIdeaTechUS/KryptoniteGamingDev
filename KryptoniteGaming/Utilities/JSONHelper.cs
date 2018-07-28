using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Data;

namespace KryptoniteGaming.Utilities
{
    public static class JSONHelper
    {
        public static string ToJSON(this object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            return serializer.Serialize(obj);
        }

        public static string ToJSON(this object obj, int recursionDepth)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }

        public static Object ObjectFromJSON(String JSONString)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Object>(JSONString);
        }

        //public static Objects.Library ResponseFromJSON(String JSONString)
        //{
        //    JavaScriptSerializer json_serializer = new JavaScriptSerializer();
        //    return json_serializer.Deserialize<Objects.Library>(JSONString);
        //}
        
    }
}