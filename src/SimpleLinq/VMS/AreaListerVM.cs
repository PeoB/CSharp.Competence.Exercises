using System;
using System.Collections.Generic;

namespace SimpleLinq
{
    public class AreaListerVM
    {
        public IEnumerable<Area> Areas { get; set; }

        //This is the currently selected part
        public int Index { get; set; }

        public IEnumerable<Part> Parts
        {
            get { throw new NotImplementedException(); }
        }

        public Area CurrentArea
        {
            get { throw new NotImplementedException(); }
        }

        public void JumpToArea(int areaIndex){

        }
    }
}