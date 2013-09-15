// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HairStyleCollectionViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HairStyleCollectionViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.ViewModels
{
    using System;
    using System.Linq;

    using System.Collections.Generic;

    public class Grid<T>
    {
        private IEnumerable<T> _items;

        public Grid(IEnumerable<T> items)
        {
            _items = items;
        }

        public int Rows 
        { 
            get
            {
                return _items.Count() / Columns;
            }
        }

        public int Columns { get; set; }

        public bool Exist(int row, int column)
        {
            return row * Columns + column < _items.Count();
        }

        public T this [int row, int column]
        {
            get
            {
                var index = row * Columns + column;

                if (_items.Count() > index)
                {
                    return _items.ElementAt(index);
                }

                throw new NullReferenceException();
            }
        }
    }
}