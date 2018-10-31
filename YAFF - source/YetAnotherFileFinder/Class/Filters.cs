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
        YetAnotherFileFinder yaffFilter;
        string keyWord;


        public void Load(YetAnotherFileFinder yaffParentForm)
        {
            yaffFilter = yaffParentForm;
            CheckFilter();
        }

        public void CheckFilter(){
            if (!string.IsNullOrEmpty(yaffFilter.txtKeyWord.Text))
            {
                keyWord = yaffFilter.txtKeyWord.Text;

            }
        }

        public void SetFilter(){

        } 
    }
}
