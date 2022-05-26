using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearningProejct
{
    public struct Human
    {
        public string hoTen;
        public int tuoi;
        public int namSinh;
    }

    public struct Date
    {
        public int day;
        public int month;
        public int year;
    }
    public struct Subject
    {
        public string subjectName;
        public int grade;
    }

    public class ConNguoi
    {

    }

    public class IntArray
    {
        public int[] arr;
        public int length;

        public void NhapIntArray()
        {
            Console.WriteLine("Vui long nhap so luong phan tu");
            length = int.Parse(Console.ReadLine());
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void XuatIntArray()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public void ThemMotChuCaiVaoMang(int pos, int value)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (i == pos)
                {
                    arr[count++] = value;
                    continue;
                }

                arr[count++] = arr[i];
            }
        }

        public int TimRaViTriCuaSoNhoNhat()
        {
            int min = arr[0];  // 9 8 7
            int viTriMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    viTriMin = i;
                }
            }
            return viTriMin;
        }

        public void SapXepMangTangDan()
        {
            int count = 0;
            int[] ketQua = new int[arr.Length];

            for (int i = 0; i < ketQua.Length; i++)
            {
                int viTriMin = TimRaViTriCuaSoNhoNhat();
                ketQua[count++] = arr[viTriMin];
                XoaTaiViTri(viTriMin);
            }

            arr = ketQua;
        }

        public bool XoaTaiViTri(int pos)
        {
            if (pos < 0 || pos >= length)
            {
                return false;
            }

            int[] ketQua = new int[arr.Length - 1];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != pos)
                    ketQua[count++] = arr[i];
            }

            length--;
            arr = ketQua;
            return true;
        }
        public bool TimGiaTri(int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }
            return false;
        }

        public void ThemGiaTri(int value)
        {
            int[] ketQua = new int[arr.Length + 1];
            for (int i = 0; i < ketQua.Length; i++)
            {
                if (i == ketQua.Length - 1)
                {
                    ketQua[i] = value;
                    continue;
                }
                ketQua[i] = arr[i];

            }
            length++;
            arr = ketQua;

        }

        public bool ThemGiaTri(int value, int pos)
        {
            if (pos < 0 || pos >= length)
            {
                return false;
            }

            int[] ketQua = new int[arr.Length + 1];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pos)
                {
                    ketQua[count++] = value;
                }
                ketQua[count++] = arr[i];
            }

            length++;
            arr = ketQua;
            return true;
        }

        public bool XoaGiaTri(int value) // 1 2 3   , value = 6
        {
            for (int i = 0; i < length;i++)
            {
                if (arr[i] == value)
                {
                    return XoaTaiViTri(i);
                }
            }
            
            return false;
        }
        public bool SuaGiaTriTaiViTri(int value, int pos)
        {
            if (pos < 0 || pos >= length)
            {
                return false;
            }
            for(int i = 0; i < length; i++)
            {
                if (i == pos)
                    arr[i] = value;
            }
            return true;
        }

        public bool SuaGiaTriABangB(int aValue, int bValue)
        {
            if (TimGiaTri(aValue))
            {
                for (int i = 0; i< length; i++)
                {
                    if (arr[i] == aValue)
                    {
                        arr[i] = bValue;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
