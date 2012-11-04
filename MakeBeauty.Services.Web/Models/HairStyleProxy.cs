// -----------------------------------------------------------------------
// <copyright file="HairStyleProxy.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace MakeBeauty.Services.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    using MakeBeauty.Data.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class HairStyleProxy
    {
        public HairStyleProxy()
        {
            Id = 0;

            Name = string.Empty;
        }

        public HairStyleProxy(HairStyle hairStyle)
        {
            Id = hairStyle.id;

            Name = hairStyle.name;
        }

        [Key()]
        public int Id { get; set; }

        public string Name { get; set; }

        public HairStyle ToHairStyle()
        {
            var hairStyle = new HairStyle();

            hairStyle.id = Id;

            hairStyle.name = Name;

            return hairStyle;
        }
    }
}
