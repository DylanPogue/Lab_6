using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class VolumeInfoBase
    {
        public VolumeInfo Volume { get; set; }

        public VolumeInfoBase(VolumeInfo volume)
        {
            Volume = volume;
        }
    }
}
