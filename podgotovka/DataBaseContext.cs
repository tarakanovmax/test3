using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka
{
    internal class DataBaseContext
    {
        private static TradeEntities _context;
        public static TradeEntities GetContext()
        {
            if(_context == null)

                _context = new TradeEntities();
            return _context;
        }
    }
}
