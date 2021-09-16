using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrukturer
{
    class Mqueue
    {
        const int size = 6;
        int indexer = 0;
        string[] sQueue = new string[size];

        public void EnQueue(string input)
        {
            sQueue[indexer] = input;
            indexer++;
        }

        public string DeQueue()
        {
            string temp = sQueue[0];
            for (int i = 0; i < sQueue.Length - 1; i++)
            {
                sQueue[i] = sQueue[i+1];
            }
            return temp;
        }
    }
}
