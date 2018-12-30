using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Packages
    {
        private int packagesId;
        private string pkgName;
        private decimal pkgBasePrice;
        private decimal pkgAgencyCommission;

        public Packages() { } //Empty Constructor

        //Constructor
        public Packages(int packagesId, string pkgName, decimal pkgBasePrice, decimal pkgAgencyCommission)
        {
            this.PackagesId = packagesId;
            this.PkgName = pkgName;
            this.PkgBasePrice = pkgBasePrice;
            this.PkgAgencyCommission = pkgAgencyCommission;
        }

        public int PackagesId
        {
            get
            {
                return packagesId;
            }
            set
            {
                packagesId = value;
            }
        }

        public string PkgName
        {
            get
            {
                return pkgName;
            }
            set
            {
                pkgName = value;
            }
        }

        public decimal PkgBasePrice
        {
            get
            {
                return pkgBasePrice;
            }
            set
            {
                pkgBasePrice = value;
            }
        }

        public decimal PkgAgencyCommission
        {
            get
            {
                return pkgAgencyCommission;
            }
            set
            {
                pkgAgencyCommission = value;
            }
        }


    }
}
    

