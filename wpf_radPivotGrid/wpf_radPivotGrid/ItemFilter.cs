using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Pivot.Core.Filtering;

namespace wpf_radPivotGrid
{
    public class FilterItem
    {
        public string DisplayName { get; set; }

        public GroupFilter GroupFilter { get; set; }
    }

    public class FiltersCollection : Collection<FilterItem>
    {
        public FiltersCollection() { }
    }
}
