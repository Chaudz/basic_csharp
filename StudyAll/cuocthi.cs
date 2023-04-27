using System;
using System.Collections;

public class ChallengeClass
{
    public string FindSubstring(string s)
    {
        string maxSubstring = ""; // chuỗi con lớn nhất
        string tempSubstring = ""; // chuỗi con tạm thời

        for (int i = 0; i < s.Length - 1; i++)
        {
            tempSubstring += s[i]; // thêm số hiện tại vào chuỗi con tạm thời

            // Nếu số tiếp theo không lớn hơn số hiện tại, so sánh độ dài của chuỗi con tạm thời với chuỗi con lớn nhất
            if (s[i + 1] <= s[i] || i == s.Length - 2)
            {
                if (tempSubstring.Length > maxSubstring.Length)
                {
                    maxSubstring = tempSubstring;
                }
                tempSubstring = ""; // đặt chuỗi con tạm thời về rỗng
            }
        }

        return maxSubstring;
    }

}

class Program
{
    static void Main(string[] args)
    {
        
        string s = "06789123456789540123456";
        string str = "";
        ArrayList arr = new ArrayList();
        ArrayList newArr = new ArrayList();
        for (int i = 0; i < s.Length; i++) // Điều kiện dừng vòng lặp không cần trừ đi 1
        {
            int item;
            if (Int32.TryParse(s[i].ToString(), out item)) // Chuyển đổi ký tự sang chuỗi số
            {
                arr.Add(item);
            }
        }
        // 06754
        for (int i =0; i < arr.Count -1; i++)
        {
            if ((int)arr[i] == ((int)arr[i+1] -1)) {
                if(str.Length == 0)
                {
                    str += (string)arr[i].ToString();
                }
                str += (string)arr[i + 1].ToString();
                newArr.Add(str);
            }
            else
            {
                str = "";
            }
            
           
        }
        string max = "";
        foreach (var item in newArr)
        {
            if(item.ToString().Length > max.Length) {
                max = item.ToString();
            }
        }
        Console.WriteLine(max);
    }
       

    
}
