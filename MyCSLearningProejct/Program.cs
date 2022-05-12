namespace MyCSLearningProejct
{
    class Program
    {
        static void Main(string[] args)
        {
            //int SoBatKi;

            //SoBatKi = int.Parse(Console.ReadLine());
            //string? input = Console.ReadLine();
            //char[] charArr = input.ToCharArray();
            //Console.WriteLine(InHoaMotChuCai('a'));
            Console.WriteLine(InHoaChuoi(NhapMangChar()));
        }

        static int[] NhapMang(int soLuongPhanTu)
        {
            int[] mang = new int[soLuongPhanTu];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}:");
                mang[i] = int.Parse(Console.ReadLine());
            }
            return mang;
        }
        static char[] NhapMangChar()
        {
            string input = Console.ReadLine();

            char[] mang = new char[input.Length];
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] = input[i];
            }
            return mang;
        }

        static int PhanTuNhoNhatTrongMang(int[] mang)
        {
            int min = mang[0];
            for (int i = 0; i < mang.Length; i++)
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
                    viTriCuaMax = i;
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

        static void XuatRaGiaTriCuaCacSoTrongMang(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine($"Phan tu thu {i}: {mang[i]}");
            }
        }

        static int TraVeSoMinDuong(int[] mang)
        {
            int min = mang[0];
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] < min && mang[i] > 0)
                {
                    min = mang[i];
                }
            }
            return min;
        }

        static bool KiemTraSoNguyenTo(int soNguyen)
        {
            if (soNguyen == 1)
                return true;
            for (int i = 2; i < soNguyen; i++)
            {
                if (soNguyen % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        static char[] InHoaChuoi(char[] charArr)
        {
            for(int i = 0; i < charArr.Length; i++)
                charArr[i] = InHoaMotChuCai(charArr[i]);

            return charArr;
        }

        static char InHoaMotChuCai(char moChuCai)
        {
            if (!CoPhaiLaChuThuong(moChuCai))
                return moChuCai;

            int giatriIntCuaC = (int)moChuCai;
            giatriIntCuaC -= 32;
            moChuCai = (char)giatriIntCuaC;
            return moChuCai;
        }

        static bool CoPhaiLaSo(char chuCaiCanKiemTra)
        {
            if ((int)chuCaiCanKiemTra >= 48 && (int)chuCaiCanKiemTra <= 57)
                return true;
            else
                return false;
        }
        static bool CoPhaiLaChuInHoa(char chuCaiCanKiemTra)
        {
            if ((int)chuCaiCanKiemTra >= 65 && (int)chuCaiCanKiemTra <= 90)
                return true;
            else
                return false;
        }

        static bool CoPhaiLaChuThuong(char chuCaiCanKiemTra)
        {
            if ((int)chuCaiCanKiemTra >= 97 && (int)chuCaiCanKiemTra <= 122)
                return true;
            else
                return false;
        }
    }
}