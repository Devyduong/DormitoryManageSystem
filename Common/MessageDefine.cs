using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManageSystem.Common
{
    public class MessageDefine
    {
        public static string ExceptionMessage = "ERROR: Đã có lỗi xảy ra - ";
        public const string CAPTION = "Hệ thống quản lý kí túc xá";
        // Quản lý sinh viên
        public static string StudentIdNull = "Phải nhập Mã sinh viên";
        public static string UploadAvatarFailed = "Opps!! Có lỗi xảy ra khi upload ảnh";
        public static string LoadDataFailed = "Xảy ra lỗi khi tải dữ liệu";
        public static string ConfirmDeleteStudent = "Bạn có chắc chắn muốn xóa bản ghi này không?";
        public static string RecordRequestedNoExist = "Bản ghi vừa yêu cầu không tồn tại";
        public static string DeleteRecordSuccessful = "Đã xóa thành công";


        // Dashboard 
        public const string ConfirmLogout = "Bạn có chắc chắn muốn thoát khỏi hệ thống?";
    }
}
