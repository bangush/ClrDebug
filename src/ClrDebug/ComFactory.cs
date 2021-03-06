using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using ClrDebug.Native;

namespace ClrDebug
{
    internal static class ComFactory
    {
        private static readonly ConstructorInfo s_missingMethodExceptionCtor;

        static ComFactory()
        {
            s_missingMethodExceptionCtor = typeof(MissingMethodException)
                .GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    types: new[] { typeof(string) },
                    modifiers: null);
        }

        public unsafe static void Create<T>(void* ptr, int hResult, out T value)
            where T : Unknown
        {
            value = Create<T>(ptr, hResult);
        }

        public unsafe static void Create<T>(void* ptr, out T value)
            where T : Unknown
        {
            value = Create<T>(ptr);
        }

        public unsafe static T Create<T>(void* ptr, int hResult)
            where T : Unknown
        {
            if (hResult != HResult.S_OK)
            {
                return default;
            }

            return Create<T>(ptr);
        }

        public unsafe static T Create<T>(void* ptr)
            where T : Unknown
        {
            if (ptr == null)
            {
                return default;
            }

            var comObject = ConstructorCache<T>.Ctor();
            comObject.SetPointer((void**)ptr);
            return comObject;
        }

        private static class ConstructorCache<TUnknown> where TUnknown : Unknown
        {
            public static readonly Func<TUnknown> Ctor;

            static ConstructorCache()
            {
                Ctor = CreateConstructor();
            }

            private static Func<TUnknown> CreateConstructor()
            {
                if (typeof(TUnknown).IsAbstract)
                {
                    return ThrowMissingMemberException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            @"Cannot construct an instance of the static class ""{0}"".",
                            typeof(TUnknown).FullName));
                }

                ConstructorInfo ctor = typeof(TUnknown)
                    .GetConstructor(
                        BindingFlags.Instance | BindingFlags.NonPublic,
                        binder: null,
                        types: Type.EmptyTypes,
                        modifiers: null);

                if (ctor == null)
                {
                    return ThrowMissingMemberException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            @"No parameterless constructor defined for the type ""{0}"".",
                            typeof(TUnknown).FullName));
                }

                return Expression.Lambda<Func<TUnknown>>(Expression.New(ctor)).Compile();
            }

            private static Func<TUnknown> ThrowMissingMemberException(string message)
            {
                return Expression.Lambda<Func<TUnknown>>(
                    Expression.Block(
                        Expression.Throw(
                            Expression.New(
                                s_missingMethodExceptionCtor,
                                Expression.Constant(
                                    message,
                                    typeof(string)))),
                        Expression.Default(typeof(TUnknown))))
                    .Compile();
            }
        }
    }
}
