using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class BusiestServersSolution
    {
        public IList<int> BusiestServers(int k, int[] arrival, int[] load)
        {
            //如果i%k服务器空闲，处理之，否则向后循环第一个空闲者，没有则丢弃
            PriorityQueue<int> idle = new PriorityQueue<int>();//索引优先队列
            for (int i = 0; i < k; i++) idle.Enqueue(i);
            PriorityQueue<int[]> busy = new PriorityQueue<int[]>((a, b) => a[0] - b[0]);//当前繁忙优先队列
            int[] requests = new int[k];//总处理数量统计
            for (int i = 0; i < arrival.Length; i++)
            {
                while (busy.Count > 0 && busy.Peek[0] <= arrival[i])//如果发现有空闲的服务器，全部弹出
                {
                    int id = busy.Peek[1];//获取空闲索引
                    busy.Dequeue();//出队  注意: 一定会优先用掉较小的索引,因为i只会越来越大
                    idle.Enqueue(i + ((id - i) % k + k) % k); //保证得到的是一个不小于 i 的且与 id 同余的数
                }
                if (idle.Count <= 0) continue;//如果空闲队列为空，丢弃这项任务
                int server = idle.Dequeue() % k;//使用最前接近的索引服务器
                requests[server]++;//计入服务器工作项
                busy.Enqueue(new int[] { arrival[i] + load[i], server });//将繁忙时间，索引 入队
            }
            int max = requests.Max();//最大处理任务数
            IList<int> res = new List<int>();//答案
            for (int i = 0; i < k; i++) if (requests[i] == max) res.Add(i);
            return res;
        }

        private sealed class PriorityQueue<T>
        {
            public int Count { get { return a.Count; } }
            public T Peek { get { if (Count < 1) throw new Exception("试图读取队首,但队列已空！"); return a[0]; } }
            readonly List<T> a = new List<T>();
            readonly Comparison<T> cp;
            public PriorityQueue()
            {
                cp = Comparer<T>.Default.Compare;
            }
            public PriorityQueue(Comparison<T> _cp)
            {
                cp = _cp;
            }
            public void Enqueue(T _v)
            {
                a.Add(_v); Raise(Count - 1);
            }
            public T Dequeue()
            {
                if (Count < 1) throw new Exception("试图出队,但队列已空！");
                T vi = a[0];
                int e = Count - 1;
                a[0] = a[e];
                a.RemoveAt(e);
                Drop(0);
                return vi;
            }
            void Raise(int i)
            {
                if (Count < 2) return;
                T cv = a[i];
                for (int pa = i - 1 >> 1; pa >= 0; i = pa, pa = i - 1 >> 1)
                {
                    if (cp(a[pa], cv) <= 0) break;
                    a[i] = a[pa];
                }
                a[i] = cv;
            }
            void Drop(int i)
            {
                if (Count < 2) return;
                T pv = a[i];
                for (int ch = i << 1 | 1; ch < Count; i = ch, ch = i << 1 | 1)
                {
                    if (ch + 1 < Count && cp(a[ch + 1], a[ch]) < 0) ch++;
                    if (cp(pv, a[ch]) <= 0) break;
                    a[i] = a[ch];
                }
                a[i] = pv;
            }
        }
    }
}
