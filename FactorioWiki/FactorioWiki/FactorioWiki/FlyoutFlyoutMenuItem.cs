using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FactorioWiki
{
    public class FlyoutFlyoutMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Page TargetPage { get; set; }
    }
}