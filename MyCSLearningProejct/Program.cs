namespace MyCSLearningProejct
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Input();
            int ketQua=bst.GetTreeHeight(bst.root);
            Console.WriteLine(ketQua);

        }


        static void OutputSubject(Subject subject)
        {
            Console.WriteLine($"{subject.subjectName}:{subject.grade}");
        }
        
        static Date InputDate()
        {
            Console.WriteLine($"Input DD/MM/YY");
            Date inputDate;
            int day = int.Parse(Console.ReadLine());
            //while (day < 1 || day > 31)
            //{
            //    Console.WriteLine($"Input DD/MM/YY");
            //    day = int.Parse(Console.ReadLine());
            //}
            int month = int.Parse(Console.ReadLine());
            //while (month < 1 || month > 12)
            //{
            //    Console.WriteLine($"Input DD/MM/YY");
            //    month = int.Parse(Console.ReadLine());
            //}
            int year = int.Parse(Console.ReadLine());
            //while (year < 0)
            //{
            //    Console.WriteLine($"Input DD/MM/YY");
            //    year = int.Parse(Console.ReadLine());
            //}
            inputDate.day = day;
            inputDate.month = month;
            inputDate.year = year;
            return inputDate;
        }
        static void OutputDate(Date dateToOutput)
        {
            Console.WriteLine($"{dateToOutput.day}/{dateToOutput.month}/{dateToOutput.year}");
        }

        static void IsValidDate(Date dateToCheck)
        {
            if (CheckDate(dateToCheck))
                Console.WriteLine($"hop le!");
            else
                Console.WriteLine($"khong hop le!");
        }

        static bool CheckDate(Date dateToCheck)
        {
            if (dateToCheck.day < 1 || dateToCheck.day > 31)
                return false;
            if (dateToCheck.month < 1 || dateToCheck.month > 12)
                return false;

            if (dateToCheck.year < 0)
                return false;

            return true;
        }


        static void XuatRaDog(Human dog)
        {
            Console.WriteLine(dog.hoTen);
            Console.WriteLine(dog.tuoi);
            Console.WriteLine(dog.namSinh);
        }
        static Human conNguoi()
        {
            string hoTen = Console.ReadLine();
            int tuoi = int.Parse(Console.ReadLine());
            int namSinh = int.Parse(Console.ReadLine());
            Human dog;
            dog.hoTen = hoTen;
            dog.tuoi = tuoi;
            dog.namSinh = namSinh;
            return dog;

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
        static void XuatMang(int[] mangCanXuat)
        {
            for(int i = 0; i < mangCanXuat.Length; i++)
            {
                Console.Write($"{mangCanXuat[i]} ");
            }
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

        static char NhapMotChuCai()
        {
            string input = Console.ReadLine();

            return input[0];
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

        static char[] TraVeMangXoaMotChuCaiChiDinh(char[] charArr,char chuCanXoa)
        {
            char[] ketQua = new char[charArr.Length];
            int counter = 0;
            for(int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == chuCanXoa)
                    continue;
                else
                {
                    ketQua[counter] = charArr[i];
                    counter++;
                }
            }

            return ketQua;
        }

        static char[] ThemMotChuCaiVaoMang(char[] charArr, int pos, char chuCaiCanThem)
        {
            char[] mangDaThemChuCai = new char[charArr.Length+1];
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (i == pos)
                {
                    mangDaThemChuCai[count++] = chuCaiCanThem;
                }

                mangDaThemChuCai[count++] = charArr[i];
            }
            return mangDaThemChuCai;
        }

        static int TinhSoTho(int ngay   )
        {
            int soThorNgay1 = 0;
            int soThorNgay2 = 1;
            int ngayHomNay = soThorNgay2;
            int ngayHomTruoc = soThorNgay1;
            int tongSoTho = 0;
            for(int i = 2; i <= ngay; i++)
            {
                tongSoTho = ngayHomNay + ngayHomTruoc;
                ngayHomTruoc = ngayHomNay;
                ngayHomNay = tongSoTho;
            }
            return tongSoTho;
        }
        static void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
            
        }
        
        static void SapXepMangTangDan(ref int[] mangA) 
        {
            for(int i = 0; i < mangA.Length; i++)
            {
                for(int j = i+1; j < mangA.Length; j++)
                {
                    if (mangA[i] > mangA[j])
                    {
                        Swap(ref mangA[i],ref mangA[j]);
                    }
                }
            }
        }
        // 6 7 5 3 4 (10)
        public static bool CoTonTai2SoTrongMangCongLaiBangX(int[] mangA, int soX)
        {
            for (int i = 0; i < mangA.Length; i++)
            {
                for (int j = i + 1; j < mangA.Length; j++)
                {
                    if (mangA[i] + mangA[j]==soX)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}