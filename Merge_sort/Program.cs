using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list= new List<int>(){ 4, 5, 2, 8, 1, 6 };
            //int l = list.Count/2;
            //var left = list.Take(l).ToList();
            //var rigth = list.TakeLast(l).ToList();
            //var res = new List<int>();
            //var leftPoint = 0;
            //var rigthPoint = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (leftPoint < left.Count && rigthPoint < rigth.Count)
            //    {
            //        if (left[leftPoint] < rigth[rigthPoint])
            //        {
            //            res.Add(left[leftPoint]);
            //            leftPoint++;
            //        }
            //        else
            //        {
            //            res.Add(rigth[rigthPoint]);
            //            rigthPoint++;
            //        }
            //    }
            //    else
            //    {
            //        if (rigthPoint < rigth.Count)
            //        {
            //            res.Add(rigth[rigthPoint]);
            //            rigthPoint++;
            //        }
            //        else
            //        {
            //            res.Add(left[leftPoint]);
            //            leftPoint++;
            //        }
            //    }
            //}

            #region
            //for (int i = 0; i < rese.Count; i++)
            //{
            //    if (leftpoint <= key && rigthpoint <= key)
            //    {
            //        if (left[leftpoint] > rigth[rigthpoint])
            //        {
            //            newlist.Add(rigth[rigthpoint]);
            //            rigthpoint++;
            //        }
            //        else
            //        {
            //            newlist.Add(left[leftpoint]);
            //            leftpoint++;
            //        }
            //    }
            //     else
            //    {
            //        if (leftpoint!=a)
            //        {
            //            newlist.Add(left[leftpoint]);
            //            leftpoint++;
            //        }
            //        if (rigthpoint != a)
            //        {
            //            newlist.Add(rigth[rigthpoint]);
            //          rigthpoint++;
            //        }
            //    }
            //}
            #endregion
            List<int> list1 = new List<int>() { 8, 5, 4, 3 };
            list1.Sort();
            

        }
        static public List<int> Sort(List<int> list)
        {
            if (list.Count == 1)
            {
                return list;
            }
            var m = list.Count / 2;
            var left = list.Take(m).ToList();
            var rigth = list.TakeLast(m).ToList();
            return Merge(Sort(left), Sort(rigth));
        }
        static public List<int> Merge(List<int> left,List<int> right)
        {
            var length = left.Count + right.Count;
            var leftpoint = 0;
            var rigthpoint = 0;
            var newlist = new List<int>();
            for (int i = 0; i < length; i++)
            {
                if (leftpoint <= left.Count && rigthpoint <= right.Count)
                {
                    if (left[leftpoint] > right[rigthpoint])
                    {
                        newlist.Add(right[rigthpoint]);
                        rigthpoint++;
                    }
                    else
                    {
                        newlist.Add(left[leftpoint]);
                        leftpoint++;
                    }
                }
                else
                {
                    if (leftpoint != left.Count)
                    {
                        newlist.Add(left[leftpoint]);
                        leftpoint++;
                    }
                    if (rigthpoint != left.Count)
                    {
                        newlist.Add(right[rigthpoint]);
                        rigthpoint++;
                    }
                }
            }
            return newlist;
        }

    }
}
