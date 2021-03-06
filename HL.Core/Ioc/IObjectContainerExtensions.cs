﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Core.Ioc
{
    public static class IObjectContainerExtensions
    {
        public static T Reslove<T>(this IObjectContainer container)
        {
           return (T)container.Reslove(typeof(T));
        }

        public static T Reslove<T>(this IObjectContainer container,string name)
        {
            return (T)container.Reslove(typeof(T), name);
        }


        public static IObjectContainer RegisterType<T,F>(this IObjectContainer container,LifeStyle lifestyle)
        {
            return container.RegisterType(typeof(F), typeof(T), null,lifestyle);
        }

        public static IObjectContainer RegisterType<T, F>(this IObjectContainer container, string name,LifeStyle lifestyle)
        {
            return container.RegisterType(typeof(F), typeof(T), name, lifestyle);
        }




    }
}
