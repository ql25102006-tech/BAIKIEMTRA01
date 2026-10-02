# PHẦN I: LÝ THUYẾT & CÂU HỎI NGẮN (BÀI 01)

### Thông tin sinh viên:
- Họ và tên: Lê Ngọc Quyền
- Mã sinh viên: 24810310259
- Tiêu đề: BÀI KIỂM TRA 01 - PHẦN LÝ THUYẾT

---

### Câu 1: Trình bày sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types (Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).

Bảng so sánh:

1. Bản chất dữ liệu:
- Value Types: Lưu trữ trực tiếp giá trị thực tế của biến.
- Reference Types: Lưu trữ địa chỉ tham chiếu (con trỏ) trỏ tới vùng nhớ thực tế chứa đối tượng.

2. Vùng nhớ lưu trữ:
- Value Types: Lưu trên bộ nhớ Stack (hoặc nằm trong Heap nếu là thành phần của một đối tượng).
- Reference Types: Địa chỉ tham chiếu nằm trên Stack, đối tượng thực tế nằm trên Heap.

3. Kiểu dữ liệu tiêu biểu:
- Value Types: int, double, float, decimal, bool, char, struct, enum.
- Reference Types: class, interface, delegate, string, array, object.

4. Cơ chế gán và sao chép:
- Value Types: Sao chép trực tiếp toàn bộ giá trị. Thay đổi biến này không làm ảnh hưởng biến kia.
- Reference Types: Sao chép địa chỉ tham chiếu. Hai biến cùng trỏ về một vùng nhớ trên Heap, thay đổi qua biến này thì biến kia cũng thay đổi theo.

5. Quản lý bộ nhớ và thu gom rác:
- Value Types: Tự động giải phóng khi ra khỏi phạm vi (scope) của hàm.
- Reference Types: Được dọn dẹp bởi bộ thu gom rác tự động Garbage Collector (GC) khi không còn tham chiếu nào trỏ tới.

---

### Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.

1. Sự khác biệt:
- Thuộc tính có 'set' thông thường: Cho phép thay đổi giá trị của thuộc tính ở bất kỳ lúc nào trong suốt vòng đời của đối tượng.
- Thuộc tính có 'init': Chỉ cho phép gán giá trị một lần duy nhất khi khởi tạo đối tượng (qua Constructor hoặc Object Initializer). Sau khi đã khởi tạo xong, thuộc tính sẽ chỉ đọc và không thể thay đổi giá trị được nữa.

2. Trường hợp sử dụng thực tế:
- Dùng cho các trường định danh hoặc các giá trị không được phép thay đổi sau khi tạo như: Id, MaSinhVien, MaSanPham, SoTaiKhoan, NgayTao.
- Giúp bảo đảm tính bất biến (Immutability) và tránh việc vô tình ghi đè sửa đổi dữ liệu trong quá trình chạy chương trình.

---

### Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).

1. Phương thức 'virtual' (ở lớp cha):
- Định nghĩa một phương thức ảo, cho phép các lớp con có thể ghi đè lại hành vi nếu cần thiết.
- Lớp cha vẫn có phần thân cài đặt mặc định. Nếu lớp con không ghi đè thì khi gọi sẽ chạy code của lớp cha.

2. Phương thức 'override' (ở lớp con):
- Định nghĩa lại cách thực hiện của phương thức virtual (hoặc abstract) từ lớp cha.
- Phải giữ nguyên chữ ký hàm (tên hàm, kiểu trả về, danh sách tham số).
- Khi gọi phương thức thông qua biến kiểu lớp cha trỏ tới đối tượng lớp con, chương trình sẽ tự động gọi đúng phương thức override của lớp con tại thời điểm chạy (Runtime Polymorphism).

---

### Câu 4: Tại sao một thành phần được khai báo là static trong Lớp (Class) lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new?

1. Cấp độ sở hữu:
- Thành phần 'static' thuộc về cấp độ Lớp (Class level), không thuộc về riêng một thể hiện/đối tượng cụ thể nào (Instance level).
- Thành phần static chỉ được cấp phát một vùng nhớ duy nhất dùng chung cho toàn bộ chương trình.

2. Lý do quy định của C#:
- Tránh gây hiểu nhầm: Nếu cho phép gọi qua thể hiện (instance.StaticMember), lập trình viên dễ nhầm rằng mỗi đối tượng có một giá trị riêng.
- Quy chuẩn thiết kế rõ ràng: Bắt buộc gọi trực tiếp qua tên Lớp (ClassName.StaticMember) để thể hiện rõ đây là dữ liệu dùng chung.
