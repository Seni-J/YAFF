using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * CHANGER
 * LES
 * TYPES VOIDS
 * MERCI
 */

namespace YetAnotherFileFinder.Class
{
    class Filters
    {
        private YetAnotherFileFinder yaffFilter;

        public void Load(YetAnotherFileFinder yetAnotherParentForm)
        {
            yaffFilter = yetAnotherParentForm;
            CheckFilter();
        }

        public void CheckFilter(){
            if (!string.IsNullOrEmpty(yaffFilter.txtKeyWord.Text))
            {

            }
        }

        public void SetFilter(){

        } 
    }
}
