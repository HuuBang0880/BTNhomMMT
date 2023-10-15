# BTNhomMMT

## Tổ chức thư mục:

- Client_CLI: Client bản dòng lệnh
  - Đã hoàn thành các chức năng:
    - Đăng nhập
    - Gửi tin nhắn nhập từ dòng lệnh
    - Hiển thị json nhận lại từ server
  - Cần làm: ~
- Server:
  - Bật ở cổng 9050
  - Có file txt ghi các người dùng để đăng nhập
  - Đã xong các chức năng:
    - Đăng nhập
    - Nhiều người dùng vào cùng lúc, không treo
    - Broadcast: ``broadcast "câu nói"`` để gửi câu nói tới mọi user đang online
    - Quản lý danh sách client: gõ ``show`` để hiển thị các user đang online
  - Cần làm:
    - In danh sách các người dùng đã đăng ký (Trịnh)
    - Gửi client-server-client (Trịnh/Hiếu, cần GUI test thử chức năng này, có thể đã chạy được rồi)
    - Gửi offline (Trịnh, dự tính sẽ làm hàng đợi dạng file tĩnh, khi người dùng đăng nhập thì sẽ đầu tiên lấy về hết mọi tin nhắn từ file tĩnh đó rồi xóa file)
    - Nhóm chat (Trịnh/Bằng, Bằng nghĩ thử giải pháp nào hay thử, ưu tiên làm mấy cái dễ kia cho xong trước đã)
- Client_GUI: Client bản giao diện
  - Mới bắt đầu tạo form đầu tiên
  - Chưa có chức năng
  - Cần làm:
    - Bấm nút đăng nhập hiện form có multiline textbox các tin nhắn nhận được (Hiếu)
    - Lưu trữ tin nhắn trong bộ nhớ tạm thời/trong file tĩnh khi nhận được để hiển thị tin nhắn theo phòng (Hiếu, Bằng)
    - ListView để chọn các người dùng/phòng để gửi tin nhắn, xem tin nhắn (Hiếu)
    - Textbox để nhập tin nhắn rồi button để gửi (Hiếu)

## Lưu ý

- Thêm người dùng bằng cách thêm trong file txt ở ServerTCP
- Messages.cs phải y chang nhau ở cả 3 project, lưu ý khi cóp qua Server thì đổi namespace
- Các lớp ClientSender và Messages ở bản dòng lệnh phải giống y chang bên bản giao diện, cần thì kế thừa rồi đổi 3 phương thức đã đánh dấu Virtual để ko bị dòng lệnh nữa
- Thắc mắc về ý nghĩa của code thì cứ hỏi trong Zalo
