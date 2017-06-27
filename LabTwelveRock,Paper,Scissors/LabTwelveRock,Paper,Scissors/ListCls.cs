using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelveRock_Paper_Scissors
{
    public class ListCls
    {
        private string player;
        //private int group;

        public string Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        //public int Group
        //{
        //    get
        //    {
        //        return group;
        //    }

        //    set
        //    {
        //        group = value;
        //    }
        //}
        //public ListCls()
        //{
        //    //group = 0;
        //    player = "";
              
        //}

        public ListCls(string playerInput)
        {
            //group = groupInput;
            
            player = playerInput;

        }
    }
}
