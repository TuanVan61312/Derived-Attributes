//một ứng dụng quản lý nhân viên, và bạn có một lớp Employee 
//để lưu thông tin về mỗi nhân viên. Thay vì lưu trữ trường "tuổi" 
//trong lớp Employee, bạn có thể lưu trữ trường "ngày sinh" 
//và tính toán tuổi dựa trên ngày sinh này.

public class Employee {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int Age {
        get {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (today < DateOfBirth.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}

//Trong ví dụ này, thuộc tính Age được tính toán từ ngày sinh và không cần lưu trữ trực tiếp.
//dụ trên đều minh họa cách sử dụng derived attributes để tính toán và truy xuất 
//dữ liệu dựa trên các thuộc tính gốc, giúp giảm thiểu lưu trữ và cải thiện tính nhất quán của dữ liệu.