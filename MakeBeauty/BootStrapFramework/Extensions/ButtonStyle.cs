namespace BootStrapFramework.Extensions
{
    using System.Xml.Serialization;

    public enum ButtonStyle
    {
        /// <summary>
        /// btn Standard gray button with gradient
        /// </summary>
        [XmlEnum("")]
        Standart,

        /// <summary>
        /// btn btn-primary Provides extra visual weight and identifies the primary action in a set of buttons
        /// </summary>
        [XmlEnum("btn-primary")]
        Primary,

        /// <summary>
        /// btn btn-info Used as an alternative to the default styles
        /// </summary>
        [XmlEnum("btn-info")]
        Info,

        /// <summary>
        /// btn btn-success Indicates a successful or positive action
        /// </summary>
        [XmlEnum("btn-success")]
        Success,

        /// <summary>
        /// btn btn-warning Indicates caution should be taken with this action
        /// </summary>
        [XmlEnum("btn-warning")]
        Warning,

        /// <summary>
        /// btn btn-danger Indicates a dangerous or potentially negative action
        /// </summary>
        [XmlEnum("btn-danger")]
        Danger,

        /// <summary>
        /// btn btn-inverse Alternate dark gray button, not tied to a semantic action or use
        /// </summary>
        [XmlEnum("btn-inverse")]
        Inverse,

        /// <summary>
        /// btn btn-link Deemphasize a button by making it look like a link while maintaining button behavior
        /// </summary>
        [XmlEnum("btn-link")]
        Link
    }
}