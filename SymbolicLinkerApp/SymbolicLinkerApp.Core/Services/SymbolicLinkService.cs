using SymbolicLinkerApp.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolicLinkerApp.Core.Services
{
    public class SymbolicLinkService
    {
        public bool IsHardLink { get; set; } = false;

        public bool IsOnlySelectedItems { get; set; } = false;

        public SymbolicLinkType LinkType { get; set; } = SymbolicLinkType.Relative;




        public void makeSymbolicLink(IList selectedItems, string targetPath)
        {

        }

        
    }
}
