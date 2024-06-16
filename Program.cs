using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước.
            Console.Write("Nhap vao so phan tu cua mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap vao phan tu thu {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            // Bước 2: Nhập X là phần tử cần xoá
            Console.Write("Nhap phan tu can xoa: ");
            int X = int.Parse(Console.ReadLine());

            // Bước 3: Tìm X xem có xuất hiện trong mảng không. Nếu xuất hiện chỉ ra vị trí của X.
            int index_del = Array.IndexOf(array, X);
            if (index_del == -1)
            {
                Console.WriteLine("Phan tu {0} khong ton tai trong mang.", X);
            }
            else
            {
                // Bước 4: Thực hiện xoá phần tử X khỏi mảng
                for (int i = index_del; i < N - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                // Giảm kích thước mảng đi 1
                Array.Resize(ref array, N - 1);

                // Bước 5: Kết thúc duyệt mảng. In ra mảng.
                Console.WriteLine("Mang sau khi xoa phan tử {0}:", X);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
