// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ButtonSize.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ButtonSize type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BootStrapFramework.Extensions
{
    using System.Xml.Serialization;

    /// <summary>
    /// Возможные размеры кнопок
    /// </summary>
    public enum ButtonSize
    {
        [XmlEnum("btn-large")]
        Large,

        [XmlEnum("btn-small")]
        Small,

        [XmlEnum("btn-mini")]
        Mini
    }
}