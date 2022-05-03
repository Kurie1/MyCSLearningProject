namespace MyCSLearningProejct
{
    class Program
    {
        static void Main(string[] args)
        {
            int SoBatKi;
            
            SoBatKi = int.Parse(Console.ReadLine());
            int[] mang = NhapMang(SoBatKi);
            Console.WriteLine($"so nho nhat trong mang la:{PhanTuNhoNhatTrongMang(mang)}");
            Console.WriteLine($"vi tri cua max:{ViTriCuaSoLonNhatTrongMang(mang)}");
            bool ketQua = KiemTraSoAm(mang);
            if (ketQua)
                Console.WriteLine($"co so am");
            else
                Console.WriteLine($"khong co so am");

        }

        static int[] NhapMang(int soLuongPhanTu)
        {
            int[] mang = new int[soLuongPhanTu];
            for (int i = 0; i < mang.Length; i++)
                mang[i] = int.Parse(Console.ReadLine());
            return mang;
        }

        static int PhanTuNhoNhatTrongMang(int[] mang)
        {
            int min = mang[0];
            for(int i = 0; i < mang.Length; i++)
            {
                if (mang[i] < min)
                    min = mang[i];
                    
            }
            return min;
        }
        static int ViTriCuaSoLonNhatTrongMang(int[] mang)
        {
            int max = mang[0];
            int viTriCuaMax = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                    viTriCuaMax = i ;
                }

            }
            return viTriCuaMax;
        }
        static bool KiemTraSoAm(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] < 0)
                {
                    return true;
                }

            }
            return false;
        }
        

    }
}