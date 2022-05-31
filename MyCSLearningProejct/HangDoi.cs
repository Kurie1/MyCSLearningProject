using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearningProejct
{
    public class HangDoi
    {
        public DSLK dslk;

        public HangDoi() //Constructor
        {
            dslk = new DSLK();
        }

        public void Enqueue(int value)
        {
            dslk.ThemCuoi(value);
        }

        public int Dequeue()
        {
            int value = dslk.nodeDau.value;
            dslk.XoaDau();
            return value;
        }

      public class stack1
        {
            public DSLK dslk;

            public void Push(int value)
            {
                dslk.ThemDau(value);
            }

            public int Pop()
            {
                
                int value = dslk.TimNodeCuoi().value;
                dslk.XoaCuoi();
                return value;
            }

            public int Peek()
            {
                return dslk.nodeDau.value;
            }

            public int SoLuongPhanTu()
            {
                return dslk.SoLuongPhanTu();
            }
        }
    }
}
