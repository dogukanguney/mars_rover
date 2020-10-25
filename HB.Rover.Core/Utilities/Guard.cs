using System;
using System.Globalization;

namespace HB.Rover.Infrastructure.Utilities
{
    public static class Guard
    {
        public static void AgainstNullArgument<TArgument>(string parameterName, TArgument argument) where TArgument : class
        {
            AgainstNullArgument(parameterName, argument == null);
        }

        public static void AgainstNullArgument(string parameterName, Func<bool> argumentNullCheckFunc)
        {
            if (argumentNullCheckFunc == null)
            {
                throw new ArgumentNullException(nameof(argumentNullCheckFunc));
            }

            if (parameterName == null)
            {
                throw new ArgumentNullException(nameof(parameterName));
            }

            bool isNull = argumentNullCheckFunc();

            AgainstNullArgument(parameterName, isNull);
        }

        public static void AgainstNullArgumentIfNullable<TArgument>(string parameterName, TArgument argument)
        {
            if (typeof(TArgument).IsNullableType() && argument == null)
            {
                throw new ArgumentNullException(parameterName, string.Format(CultureInfo.InvariantCulture, "{0} is null.", parameterName));
            }
        }

        public static void AgainstNullArgumentProperty<TProperty>(string parameterName, string propertyName, TProperty argumentProperty)
            where TProperty : class
        {
            if (argumentProperty == null)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "{0}.{1} is null.", parameterName, propertyName), parameterName);
            }
        }

        public static void AgainstNullArgumentPropertyIfNullable<TProperty>(
            string parameterName, string propertyName, TProperty argumentProperty)
        {
            if (typeof(TProperty).IsNullableType() && argumentProperty == null)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "{0}.{1} is null.", parameterName, propertyName), parameterName);
            }
        }

        private static bool IsNullableType(this Type type)
        {
            return !type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        private static void AgainstNullArgument(string parameterName, bool isNull)
        {
            if (isNull)
            {
                throw new ArgumentNullException(parameterName, string.Format(CultureInfo.InvariantCulture, "{0} is null.", parameterName));
            }
        }
    }
}
