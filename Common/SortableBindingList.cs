using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Common
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor propertyDescriptor;
        private bool isSorted;

        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }
        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return propertyDescriptor;
            }
        }
        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return sortDirection;
            }
        }
        protected override bool IsSortedCore
        {
            get
            {
                return isSorted;
            }
        }

        public SortableBindingList() : base() { }
        public SortableBindingList(IList<T> t) : base(t) { }

        private PropertyDescriptor GetPropertyDescriptor(string propertyName)
        {
            bool findName = false;
            PropertyDescriptorCollection propertyCollection = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor item in propertyCollection)
            {
                if (item.Name == propertyName)
                {
                    findName = true;
                    return item;
                }
            }
            if (!findName)
            {
                throw (new Exception("排序字段名不存在!"));
            }
            else
                return null;
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            propertyDescriptor = prop;
            sortDirection = direction;
            InnerSort();
            isSorted = true;
        }

        private void InnerSort()
        {
            List<T> list = (this.Items as List<T>);
            list.Sort(Compare);
            ResetBindings();
        }

        private int Compare(T x, T y)
        {
            if (sortDirection == ListSortDirection.Descending)
                return CompareValue(propertyDescriptor.GetValue(y), propertyDescriptor.GetValue(x));
            else
                return CompareValue(propertyDescriptor.GetValue(x), propertyDescriptor.GetValue(y));
        }

        public void Sort(string sortPropertyName, bool isAscending)
        {
            if (isAscending)
                sortDirection = ListSortDirection.Ascending;
            else
                sortDirection = ListSortDirection.Descending;
            propertyDescriptor = GetPropertyDescriptor(sortPropertyName);
            ApplySortCore(propertyDescriptor, sortDirection);
        }

        static int CompareValue(object o1, object o2)
        {
            if (o1 == null) return o2 == null ? 0 : -1;
            else if (o2 == null) return 1;
            else if (o1 is IComparable) return ((IComparable)o1).CompareTo(o2);
            else if (o2 is IComparable) return ((IComparable)o2).CompareTo(o1);
            else return o1.ToString().CompareTo(o2.ToString());
        }
    }
}
