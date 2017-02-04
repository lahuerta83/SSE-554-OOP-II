using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LicenseData
{
    class LicenseInfo
    {
        public string Software { get; set; }
        public int Total { get; set; }
        public int Usedlicense { get; set; }

        public LicenseInfo (string software, int total, int userlic)
        {
            this.Software = software;
            this.Total = total;
            this.Usedlicense = userlic;
        }
    }
}
