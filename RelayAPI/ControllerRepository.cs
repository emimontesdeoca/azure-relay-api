using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RelayAPI
{
    public class ControllerRepository
    {
        public static object Call(string controllername, string methodname, object[] paramenters)
        {
            try
            {
                Type type = Assembly.GetExecutingAssembly().GetType($"RelayAPI.Controllers.{controllername}Controller");
                object instance = Activator.CreateInstance(type);
                MethodInfo method = type.GetMethod(methodname);
                var result = method.Invoke(instance, paramenters);

                return result;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
