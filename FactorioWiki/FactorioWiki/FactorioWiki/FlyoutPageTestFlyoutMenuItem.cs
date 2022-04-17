using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioWiki
{
    public class FlyoutPageTestFlyoutMenuItem
    {
        public FlyoutPageTestFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPageTestFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}