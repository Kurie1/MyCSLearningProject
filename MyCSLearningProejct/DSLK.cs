using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearningProejct
{
    public class Node
    {
        public int value;
        public Node nextNode;

        public void XuatNode()
        {
            Console.WriteLine($"{value} ");
        }

        public static Node TaoNode(int Value)
        {
            Node newNode = new Node();
            newNode.value = Value;
            newNode.nextNode = null;

            return newNode;

        }
    }
    public class DSLK
    {
        public Node nodeDau;

        public DSLK()
        {
            nodeDau = null;
        }

        public void NhapDanhSach()
        {
            int soLuong = 0;
            Console.WriteLine($"vui long nhap so luong node:");

            soLuong = int.Parse(Console.ReadLine());

            for(int i=0; i < soLuong; i++)
            {
                int input = int.Parse(Console.ReadLine());
                ThemCuoi(input);
            }

        }
        public void NhapDanhSachKhongTrung()
        {
            int soLuong = 0;
            Console.WriteLine($"vui long nhap so luong node:");

            soLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                int input = int.Parse(Console.ReadLine());

                while (TimNode(input) != null)
                {
                    Console.WriteLine($"vui long nhap lai:");
                    input = int.Parse(Console.ReadLine());
                }

                ThemCuoi(input);
            }
        }
        public void XuatDanhSach()
        {
            Node counter = nodeDau;
            while (counter != null)
            {
                Console.Write($"{counter.value} ");

                counter = counter.nextNode;
            }
        }
        public void ThemCuoi(int value)
        {
            Node newNode = Node.TaoNode(value);
            if (nodeDau == null)
            {
                nodeDau = newNode;
            }
            else
            {
                Node counter = nodeDau;
                while (counter.nextNode != null)
                {
                    counter = counter.nextNode;
                }
                counter.nextNode = newNode;
            }

        }
        public Node TimNode(int value)
        {
            Node counter = nodeDau;
            while (counter != null)
            {
                if (counter.value == value)
                {
                    return counter;
                }
                counter = counter.nextNode;
            }
            return null;
        }
        public void ThemDau(int value)
        {
            Node newNode = Node.TaoNode(value);
            newNode.nextNode = nodeDau;
            nodeDau = newNode;

        }
        public void ThemSauNodeA(Node nodeA, int giaTriCanThem)
        {
            Node newNode = Node.TaoNode(giaTriCanThem);
            newNode.nextNode = nodeA.nextNode;
            nodeA.nextNode = newNode;
        }
        public void ThemTruocNodeA(Node nodeA, int giaTriCanThem)
        {
            Node nodeDungTruocNodeA=TimNodeDungTruocNodeA(nodeA);
            if (nodeDungTruocNodeA == null)
            {
                ThemDau(giaTriCanThem);
            }
            else
            {
                Node newNode = Node.TaoNode(giaTriCanThem);
                newNode.nextNode = nodeDungTruocNodeA.nextNode;
                nodeDungTruocNodeA.nextNode = newNode;
            }
        }

        public Node TimNodeDungTruocNodeA(Node nodeA)
        {
            Node counter = nodeDau;
            if (nodeA == nodeDau) {
                return null;
            }
            while (counter != null)
            {
                if (counter.nextNode.value == nodeA.value)
                {
                    return counter;
                }
                counter = counter.nextNode;
            }
            return null;

        }
        public Node TimNodeCuoi()
        {
            Node counter = nodeDau;
            if (nodeDau == null)
            {
                return null;
            }

            while (counter.nextNode != null)
            {
                counter = counter.nextNode;
            }

            return counter;
        }

        public void XoaDau()
        {
            nodeDau = nodeDau.nextNode;
        }

        public void XoaCuoi()
        {
            Node nodeCuoi = TimNodeCuoi();
            if(nodeCuoi != nodeDau)
                TimNodeDungTruocNodeA(nodeCuoi).nextNode = null;
            else
                nodeDau = null;
        }

        public void XoaNodeSauNodeA(Node nodeA)
        {
            Node nodeSauNodeA = nodeA.nextNode;

            if(nodeSauNodeA != null)
                nodeA.nextNode = nodeSauNodeA.nextNode;
        }

        public void XoaNodeTruocNodeA(Node nodeA)
        {
            Node dungTruocNodeA=TimNodeDungTruocNodeA(nodeA);
            Node dungTruocCuaTruocNodeA = TimNodeDungTruocNodeA(dungTruocNodeA);
            dungTruocCuaTruocNodeA.nextNode = nodeA;
        }
        public int SoLuongPhanTu() // B C 
        {
            Node counter = nodeDau;
            int c = 0;
            while (counter != null)
            {
                c++;
                counter = counter.nextNode;
            }
            return c;
        }
        public void Swap(Node a,Node b)
        {
            int c = a.value;
            a.value = b.value;
            b.value = c;
        }

        public void SapXepTangDan() // 6 5 4 3 2 -> 2 3 4 5 6
        {
            for (Node counter = nodeDau; counter != null; counter = counter.nextNode)
            {
                for (Node counter2 = counter.nextNode; counter2 != null; counter2 = counter2.nextNode)
                {
                    if (counter.value > counter2.value)
                    {
                        Swap(counter, counter2);
                    }
                }
            }
        }
    }

}
   