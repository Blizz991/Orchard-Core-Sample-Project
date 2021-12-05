using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orchard_Core.ViewModels
{
    public class BlogPost : ContentItem
    {
        public string Teaser { get; set; }
    }
}
