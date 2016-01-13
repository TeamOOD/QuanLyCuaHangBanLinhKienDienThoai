using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKienDienThoai
{
    public class Encryptor
    {
        //Hàm tạo mã MD5
        public static string encryptionPassword(string password)
        {
            MD5 md5hash = MD5.Create();
            //chuyển chuỗi input thành mảng kiểu byte và tính toán để băm.
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            //Tạo một chuỗi string kiểu StringBuilder để chứa các byte và tạo chuyển thành chuỗi
            StringBuilder strBuilder = new StringBuilder();
            //Duyệt qua từng byte trong mảng băm và chuyển mỗi phần tử sang hệ thập lục
            for (int i = 0; i < data.Length; ++i)
                strBuilder.Append(data[i].ToString("x2"));
            // trả về một chuỗi hệ thập lục
            return strBuilder.ToString();
        }
    }
}
