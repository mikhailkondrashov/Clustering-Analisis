﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster_Analysis.CommonClasses
{
    public class Cluster<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Clustered_Data<T>> Data { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Centroid<T> Cendroid { get; private set; }

        public 


    }
}
