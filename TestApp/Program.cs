﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cluster_Analysis.CommonClasses;
using Cluster_Analysis.AlgoritmesOfClusterAnalysis.DistanceMetrics;
using Cluster_Analysis;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clustered_Data> datanew = new List<Clustered_Data>();
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            datanew.Add(new Clustered_Data(1,1));
            datanew.Add(new Clustered_Data(1, 20));
            datanew.Add(new Clustered_Data(20, 1));
            datanew.Add(new Clustered_Data(20, 20));

            Euclidian_Distance.GetValueOfEuclidianDistance(datanew[0], datanew[1]);

            List<K_Means<double>> k_meansList = new List<K_Means<double>>();
            List<List<Cluster>> clustersList = new List<List<Cluster>>();
            myStopwatch.Start(); //запуск
            for (var i = 0; i < 1000; i++)
            {
                K_Means<double> k_means = new K_Means<double>(2, 0.1);
                clustersList.Add(k_means.Clustering(datanew));
                k_meansList.Add(k_means);
            }
            myStopwatch.Stop();

            var fulltime = myStopwatch.ElapsedMilliseconds;
            double Onetime = myStopwatch.ElapsedMilliseconds/1000.0;

            //clustersList.Count(a => a.Min(b => b.Data.Count));
            int a = 0;
            int b = 0;
            int c = 0;
            foreach (var list in clustersList)
            {
                a+=list.Count(q => q.Data.Count == 3);
                b += list.Count(q => q.Data.Count == 2);
                c += list.Count(q => q.Data.Count == 1);
            }
            b = b / 2;

            var clusters = new List<Cluster>();

            clusters.Add(new Cluster (1,new Centroid (10,10)));
            clusters.Add(new Cluster(2, new Centroid(10, 10)));
            clusters.Add(new Cluster(3, new Centroid(9, 10)));

            bool flag = true;

            //while (flag)
            //{
            //    flag = k_means.UpdateClustering(datanew, clusters);
            //}

            



        }
    }
}