﻿namespace Gu.Wpf.Validation.Internals
{
    using System;
    using System.Linq;

    public static class TypeExt
    {
        /// <summary>
        /// Returns nicely formatted type names for generic types.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static string PrettyName(this Type type)
        {
            if (type == typeof(long))
            {
                return "long";
            }

            if (type == typeof(ulong))
            {
                return "ulong";
            }

            if (type == typeof(double))
            {
                return "double";
            }

            if (type == typeof(float))
            {
                return "float";
            }

            if (type == typeof(decimal))
            {
                return "decimal";
            }

            if (type == typeof(int))
            {
                return "int";
            }

            if (type == typeof(short))
            {
                return "short";
            }

            if (type == typeof(ushort))
            {
                return "short";
            }

            if (type == typeof(byte))
            {
                return "byte";
            }

            if (type == typeof(sbyte))
            {
                return "sbyte";
            }

            if (type == typeof(uint))
            {
                return "uint";
            }

            if (type == typeof(string))
            {
                return "string";
            }

            if (type == typeof(bool))
            {
                return "bool";
            }

            if (type.IsGenericType)
            {
                var arguments = string.Join(", ", type.GenericTypeArguments.Select(PrettyName));
                return string.Format("{0}<{1}>", type.Name.Split('`').First(), arguments);
            }

            return type.Name;
        }

        /// <summary>
        /// Check if a type is Nullable`1
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static bool IsNullable(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
