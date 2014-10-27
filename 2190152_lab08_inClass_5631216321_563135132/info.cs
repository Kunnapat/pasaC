using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2190152_lab08_inClass_5631216321
{
    class info
    {
        public String name = "";
        public String height = "150";
        public String gender = "female";
        public Boolean tennis = false;
        public Boolean football = false;
        public Boolean basketball = false;
        public Boolean dancing = false;

        public info(String name, String height, String gender, Boolean tennis, Boolean football, Boolean basketball, Boolean dancing)
        {
            this.name = name;
            this.height = height;
            this.gender = gender;
            this.tennis = tennis;
            this.football = football;
            this.basketball = basketball;
            this.dancing = dancing;
        }
    }
}
