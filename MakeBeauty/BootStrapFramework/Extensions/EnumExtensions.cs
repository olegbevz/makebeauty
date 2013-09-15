namespace BootStrapFramework.Extensions
{
    using System;

    public static class EnumExtensions
    {
        public static T GetAttribute<T>(this Enum owner) where T : Attribute
        {
            var field = owner.GetType().GetField(owner.ToString());

            return (T)Attribute.GetCustomAttribute(field, typeof(T));
        }
    }
}
