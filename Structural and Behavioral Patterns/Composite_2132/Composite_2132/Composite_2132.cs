using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2132
{
    internal class Composite_2132 : IComposite_2132
    {
        private List<IComposite_2132> _composite = new List<IComposite_2132>();

        public void Add(IComposite_2132 component)
        {
            _composite.Add(component);
        }

        public void Remove(IComposite_2132 component)
        {
            _composite.Remove(component);
        }

        public void DisplayInfo()
        {
            foreach (var component in _composite)
            {
                component.DisplayInfo();
            }
        }
    }
}

